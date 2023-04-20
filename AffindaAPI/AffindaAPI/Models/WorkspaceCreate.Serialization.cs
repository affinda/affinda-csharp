// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class WorkspaceCreate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("organization");
            writer.WriteStringValue(Organization);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility");
                writer.WriteStringValue(Visibility.Value.ToString());
            }
            if (Optional.IsDefined(RejectInvalidDocuments))
            {
                writer.WritePropertyName("rejectInvalidDocuments");
                writer.WriteBooleanValue(RejectInvalidDocuments.Value);
            }
            if (Optional.IsDefined(RejectDuplicates))
            {
                if (RejectDuplicates != null)
                {
                    writer.WritePropertyName("rejectDuplicates");
                    writer.WriteStringValue(RejectDuplicates);
                }
                else
                {
                    writer.WriteNull("rejectDuplicates");
                }
            }
            if (Optional.IsCollectionDefined(WhitelistIngestAddresses))
            {
                if (WhitelistIngestAddresses != null)
                {
                    writer.WritePropertyName("whitelistIngestAddresses");
                    writer.WriteStartArray();
                    foreach (var item in WhitelistIngestAddresses)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("whitelistIngestAddresses");
                }
            }
            writer.WriteEndObject();
        }
    }
}
