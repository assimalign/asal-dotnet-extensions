﻿using System;

namespace Assimalign.Extensions.FileSystemGlobbing.Internal.PathSegments;

using Assimalign.Extensions.FileSystemGlobbing.Internal.Utilities;

public class LiteralPathSegment : IFilePathSegment
{
    private readonly StringComparison _comparisonType;

    public bool CanProduceStem { get { return false; } }

    public LiteralPathSegment(string value, StringComparison comparisonType)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        Value = value;

        _comparisonType = comparisonType;
    }

    public string Value { get; }

    public bool Match(string value)
    {
        return string.Equals(Value, value, _comparisonType);
    }

    public override bool Equals(object obj)
    {
        var other = obj as LiteralPathSegment;

        return other != null &&
            _comparisonType == other._comparisonType &&
            string.Equals(other.Value, Value, _comparisonType);
    }

    public override int GetHashCode()
    {
        return StringComparisonHelper.GetStringComparer(_comparisonType).GetHashCode(Value);
    }
}