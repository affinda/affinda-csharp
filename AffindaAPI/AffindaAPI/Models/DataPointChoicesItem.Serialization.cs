// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataPointChoicesItem
    {
        internal static DataPointChoicesItem DeserializeDataPointChoicesItem(JsonElement element)
        {
            string label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new DataPointChoicesItem(label);
        }
    }
}
