// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal static partial class DayOfWeekExtensions
    {
        public static string ToSerialString(this DayOfWeek value) => value switch
        {
            DayOfWeek.Sunday => "Sunday",
            DayOfWeek.Monday => "Monday",
            DayOfWeek.Tuesday => "Tuesday",
            DayOfWeek.Wednesday => "Wednesday",
            DayOfWeek.Thursday => "Thursday",
            DayOfWeek.Friday => "Friday",
            DayOfWeek.Saturday => "Saturday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DayOfWeek value.")
        };

        public static DayOfWeek ToDayOfWeek(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sunday")) return DayOfWeek.Sunday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Monday")) return DayOfWeek.Monday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tuesday")) return DayOfWeek.Tuesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wednesday")) return DayOfWeek.Wednesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Thursday")) return DayOfWeek.Thursday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Friday")) return DayOfWeek.Friday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Saturday")) return DayOfWeek.Saturday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DayOfWeek value.");
        }
    }
}
