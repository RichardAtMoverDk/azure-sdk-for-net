// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// Identifier that indicates how the meter is priced.
    /// Serialized Name: PricingModelType
    /// </summary>
    public readonly partial struct ConsumptionPricingModelType : IEquatable<ConsumptionPricingModelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsumptionPricingModelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsumptionPricingModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnDemandValue = "On Demand";
        private const string ReservationValue = "Reservation";
        private const string SpotValue = "Spot";

        /// <summary>
        /// On Demand
        /// Serialized Name: PricingModelType.On Demand
        /// </summary>
        public static ConsumptionPricingModelType OnDemand { get; } = new ConsumptionPricingModelType(OnDemandValue);
        /// <summary>
        /// Reservation
        /// Serialized Name: PricingModelType.Reservation
        /// </summary>
        public static ConsumptionPricingModelType Reservation { get; } = new ConsumptionPricingModelType(ReservationValue);
        /// <summary>
        /// Spot
        /// Serialized Name: PricingModelType.Spot
        /// </summary>
        public static ConsumptionPricingModelType Spot { get; } = new ConsumptionPricingModelType(SpotValue);
        /// <summary> Determines if two <see cref="ConsumptionPricingModelType"/> values are the same. </summary>
        public static bool operator ==(ConsumptionPricingModelType left, ConsumptionPricingModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsumptionPricingModelType"/> values are not the same. </summary>
        public static bool operator !=(ConsumptionPricingModelType left, ConsumptionPricingModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConsumptionPricingModelType"/>. </summary>
        public static implicit operator ConsumptionPricingModelType(string value) => new ConsumptionPricingModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsumptionPricingModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsumptionPricingModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
