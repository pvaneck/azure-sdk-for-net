// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> IoT Addon. </summary>
    public partial class IoTAddon : AddonData
    {
        /// <summary> Initializes a new instance of IoTAddon. </summary>
        /// <param name="ioTDeviceDetails"> IoT device metadata to which appliance needs to be connected. </param>
        /// <param name="ioTEdgeDeviceDetails"> IoT edge device to which the IoT Addon needs to be configured. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ioTDeviceDetails"/> or <paramref name="ioTEdgeDeviceDetails"/> is null. </exception>
        public IoTAddon(IoTDeviceInfo ioTDeviceDetails, IoTDeviceInfo ioTEdgeDeviceDetails)
        {
            if (ioTDeviceDetails == null)
            {
                throw new ArgumentNullException(nameof(ioTDeviceDetails));
            }
            if (ioTEdgeDeviceDetails == null)
            {
                throw new ArgumentNullException(nameof(ioTEdgeDeviceDetails));
            }

            IoTDeviceDetails = ioTDeviceDetails;
            IoTEdgeDeviceDetails = ioTEdgeDeviceDetails;
            Kind = AddonType.IotEdge;
        }

        /// <summary> Initializes a new instance of IoTAddon. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        /// <param name="ioTDeviceDetails"> IoT device metadata to which appliance needs to be connected. </param>
        /// <param name="ioTEdgeDeviceDetails"> IoT edge device to which the IoT Addon needs to be configured. </param>
        /// <param name="version"> Version of IoT running on the appliance. </param>
        /// <param name="hostPlatform"> Host OS supported by the IoT addon. </param>
        /// <param name="hostPlatformType"> Platform where the runtime is hosted. </param>
        /// <param name="provisioningState"> Addon Provisioning State. </param>
        internal IoTAddon(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind, IoTDeviceInfo ioTDeviceDetails, IoTDeviceInfo ioTEdgeDeviceDetails, string version, PlatformType? hostPlatform, HostPlatformType? hostPlatformType, AddonState? provisioningState) : base(id, name, resourceType, systemData, kind)
        {
            IoTDeviceDetails = ioTDeviceDetails;
            IoTEdgeDeviceDetails = ioTEdgeDeviceDetails;
            Version = version;
            HostPlatform = hostPlatform;
            HostPlatformType = hostPlatformType;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> IoT device metadata to which appliance needs to be connected. </summary>
        public IoTDeviceInfo IoTDeviceDetails { get; set; }
        /// <summary> IoT edge device to which the IoT Addon needs to be configured. </summary>
        public IoTDeviceInfo IoTEdgeDeviceDetails { get; set; }
        /// <summary> Version of IoT running on the appliance. </summary>
        public string Version { get; }
        /// <summary> Host OS supported by the IoT addon. </summary>
        public PlatformType? HostPlatform { get; }
        /// <summary> Platform where the runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Addon Provisioning State. </summary>
        public AddonState? ProvisioningState { get; }
    }
}
