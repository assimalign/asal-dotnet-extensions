﻿using System;
using System.Collections;
using Xunit;

namespace  Assimalign.Extensions.ValidationTests;

using  Assimalign.Extensions.Validation;
using  Assimalign.Extensions.Validation.Internal;
using  Assimalign.Extensions.Validation.Internal.Rules;


public class RuleEmptyTests
{

    public IValidationContext RunEmptyTest<TValue>(TValue testValue)
        where TValue : IEnumerable
    {
        var rule = new EmptyValidationRule<TValue>()
        {
            Error = new ValidationError()
            {

            }
        };

        if (rule.TryValidate((object)testValue, out var context))
        {

            return context;
        }
        else
        {
            throw new Exception("Unable to validate.");
        }
    }


    [Fact]
    public void ArrayFailureTest()
    {
        var array = new int[] { 1 };
        var context = this.RunEmptyTest(array);

        Assert.Single(context.Errors);
    }


    [Fact]
    public void ArraySuccessTest()
    {
        var array = new int[] {  };
        var context = this.RunEmptyTest(array);

        Assert.Empty(context.Errors);
    }


    [Fact]
    public void StringFailureTest()
    {
        var str = "test";
        var context = this.RunEmptyTest(str);

        Assert.Single(context.Errors);
    }


    [Fact]
    public void StringSuccessTest()
    {
        var str = "";
        var context = this.RunEmptyTest(str);

        Assert.Empty(context.Errors);
    }
}
