// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class RoutingPreference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RoutingChoice != null)
            {
                writer.WritePropertyName("routingChoice");
                writer.WriteStringValue(RoutingChoice.Value.ToString());
            }
            if (PublishMicrosoftEndpoints != null)
            {
                writer.WritePropertyName("publishMicrosoftEndpoints");
                writer.WriteBooleanValue(PublishMicrosoftEndpoints.Value);
            }
            if (PublishInternetEndpoints != null)
            {
                writer.WritePropertyName("publishInternetEndpoints");
                writer.WriteBooleanValue(PublishInternetEndpoints.Value);
            }
            writer.WriteEndObject();
        }

        internal static RoutingPreference DeserializeRoutingPreference(JsonElement element)
        {
            RoutingChoice? routingChoice = default;
            bool? publishMicrosoftEndpoints = default;
            bool? publishInternetEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingChoice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingChoice = new RoutingChoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publishMicrosoftEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishMicrosoftEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishInternetEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishInternetEndpoints = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RoutingPreference(routingChoice, publishMicrosoftEndpoints, publishInternetEndpoints);
        }
    }
}
