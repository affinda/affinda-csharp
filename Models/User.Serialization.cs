// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace affinda.Models
{
    public partial class User
    {
        internal static User DeserializeUser(JsonElement element)
        {
            Optional<int> documentCount = default;
            Optional<int> redactedDocumentCount = default;
            Optional<int> reformattedResumeCount = default;
            Optional<int> parsingCredits = default;
            Optional<int> redactionCredits = default;
            Optional<int> reformattingCredits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    documentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("redactedDocumentCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    redactedDocumentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reformattedResumeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reformattedResumeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("parsingCredits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parsingCredits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("redactionCredits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    redactionCredits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reformattingCredits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reformattingCredits = property.Value.GetInt32();
                    continue;
                }
            }
            return new User(Optional.ToNullable(documentCount), Optional.ToNullable(redactedDocumentCount), Optional.ToNullable(reformattedResumeCount), Optional.ToNullable(parsingCredits), Optional.ToNullable(redactionCredits), Optional.ToNullable(reformattingCredits));
        }
    }
}
