// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Output of custom domain validation. </summary>
    public partial class ValidateCustomDomainOutput
    {
        /// <summary> Initializes a new instance of ValidateCustomDomainOutput. </summary>
        internal ValidateCustomDomainOutput()
        {
        }

        /// <summary> Initializes a new instance of ValidateCustomDomainOutput. </summary>
        /// <param name="customDomainValidated"> Indicates whether the custom domain is valid or not. </param>
        /// <param name="reason"> The reason why the custom domain is not valid. </param>
        /// <param name="message"> Error message describing why the custom domain is not valid. </param>
        internal ValidateCustomDomainOutput(bool? customDomainValidated, string reason, string message)
        {
            CustomDomainValidated = customDomainValidated;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicates whether the custom domain is valid or not. </summary>
        public bool? CustomDomainValidated { get; }
        /// <summary> The reason why the custom domain is not valid. </summary>
        public string Reason { get; }
        /// <summary> Error message describing why the custom domain is not valid. </summary>
        public string Message { get; }
    }
}
