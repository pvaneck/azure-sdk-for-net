// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Port Mirroring Status. </summary>
    public readonly partial struct PortMirroringStatusEnum : IEquatable<PortMirroringStatusEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PortMirroringStatusEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PortMirroringStatusEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "SUCCESS";
        private const string FailureValue = "FAILURE";

        /// <summary> SUCCESS. </summary>
        public static PortMirroringStatusEnum Success { get; } = new PortMirroringStatusEnum(SuccessValue);
        /// <summary> FAILURE. </summary>
        public static PortMirroringStatusEnum Failure { get; } = new PortMirroringStatusEnum(FailureValue);
        /// <summary> Determines if two <see cref="PortMirroringStatusEnum"/> values are the same. </summary>
        public static bool operator ==(PortMirroringStatusEnum left, PortMirroringStatusEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PortMirroringStatusEnum"/> values are not the same. </summary>
        public static bool operator !=(PortMirroringStatusEnum left, PortMirroringStatusEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PortMirroringStatusEnum"/>. </summary>
        public static implicit operator PortMirroringStatusEnum(string value) => new PortMirroringStatusEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PortMirroringStatusEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PortMirroringStatusEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
