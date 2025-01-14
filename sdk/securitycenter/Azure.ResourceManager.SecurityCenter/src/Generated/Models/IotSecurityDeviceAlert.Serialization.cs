// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecurityDeviceAlert : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static IotSecurityDeviceAlert DeserializeIotSecurityDeviceAlert(JsonElement element)
        {
            Optional<string> alertDisplayName = default;
            Optional<ReportedSeverity> reportedSeverity = default;
            Optional<long> alertsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertDisplayName"))
                {
                    alertDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportedSeverity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reportedSeverity = new ReportedSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alertsCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new IotSecurityDeviceAlert(alertDisplayName.Value, Optional.ToNullable(reportedSeverity), Optional.ToNullable(alertsCount));
        }
    }
}
