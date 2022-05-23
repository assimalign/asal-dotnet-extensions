﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace  Assimalign.Extensions.ValidationTests;

using  Assimalign.Extensions.Validation;
using  Assimalign.Extensions.Validation.Internal;
using  Assimalign.Extensions.Validation.Internal.Rules;


public class RuleNotStartsWithTests
{
    public IValidationContext RunNotStartsWithTest(string value, string input, StringComparison comparison = StringComparison.InvariantCulture)
    {
        var rule = new MustNotStartWithValidationRule(value, comparison)
        {
            Error = new ValidationError()
            {

            }
        };

        if (rule.TryValidate((object)input, out var context))
        {
            return context;
        }
        else
        {
            throw new Exception("Unable to validate.");
        }
    }

    [Fact]
    public void StringSuccessNotStartsWithCaseInsensitive()
    {
        var context = RunNotStartsWithTest("hase", "Chase Crawford", StringComparison.InvariantCultureIgnoreCase);

        Assert.Empty(context.Errors);
    }

    [Fact]
    public void StringSuccessNotStartsWithCaseSensitive()
    {
        var context = RunNotStartsWithTest("hase", "Chase Crawford");

        Assert.Empty(context.Errors);
    }

    [Fact]
    public void StringFailureNotStartsWithCaseInsensitive()
    {
        var context = RunNotStartsWithTest("chase", "Chase Crawford", StringComparison.InvariantCultureIgnoreCase);

        Assert.Single(context.Errors);
    }

    [Fact]
    public void StringFailureNotStartsWithCaseSensitive()
    {
        var context = RunNotStartsWithTest("Chase", "Chase Crawford");

        Assert.Single(context.Errors);
    }
}