// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class YearsExperienceAnnotationV2Update : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parsed))
            {
                writer.WritePropertyName("parsed");
                writer.WriteObjectValue(Parsed);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Rectangle))
            {
                if (Rectangle != null)
                {
                    writer.WritePropertyName("rectangle");
                    writer.WriteObjectValue(Rectangle);
                }
                else
                {
                    writer.WriteNull("rectangle");
                }
            }
            if (Optional.IsDefined(PageIndex))
            {
                if (PageIndex != null)
                {
                    writer.WritePropertyName("pageIndex");
                    writer.WriteNumberValue(PageIndex.Value);
                }
                else
                {
                    writer.WriteNull("pageIndex");
                }
            }
            if (Optional.IsDefined(Raw))
            {
                if (Raw != null)
                {
                    writer.WritePropertyName("raw");
                    writer.WriteStringValue(Raw);
                }
                else
                {
                    writer.WriteNull("raw");
                }
            }
            if (Optional.IsDefined(Confidence))
            {
                if (Confidence != null)
                {
                    writer.WritePropertyName("confidence");
                    writer.WriteNumberValue(Confidence.Value);
                }
                else
                {
                    writer.WriteNull("confidence");
                }
            }
            if (Optional.IsDefined(ClassificationConfidence))
            {
                if (ClassificationConfidence != null)
                {
                    writer.WritePropertyName("classificationConfidence");
                    writer.WriteNumberValue(ClassificationConfidence.Value);
                }
                else
                {
                    writer.WriteNull("classificationConfidence");
                }
            }
            if (Optional.IsDefined(TextExtractionConfidence))
            {
                if (TextExtractionConfidence != null)
                {
                    writer.WritePropertyName("textExtractionConfidence");
                    writer.WriteNumberValue(TextExtractionConfidence.Value);
                }
                else
                {
                    writer.WriteNull("textExtractionConfidence");
                }
            }
            if (Optional.IsDefined(IsVerified))
            {
                writer.WritePropertyName("isVerified");
                writer.WriteBooleanValue(IsVerified.Value);
            }
            if (Optional.IsDefined(IsClientVerified))
            {
                writer.WritePropertyName("isClientVerified");
                writer.WriteBooleanValue(IsClientVerified.Value);
            }
            if (Optional.IsDefined(IsAutoVerified))
            {
                writer.WritePropertyName("isAutoVerified");
                writer.WriteBooleanValue(IsAutoVerified.Value);
            }
            if (Optional.IsDefined(DataPoint))
            {
                writer.WritePropertyName("dataPoint");
                writer.WriteStringValue(DataPoint);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType");
                writer.WriteStringValue(ContentType);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static YearsExperienceAnnotationV2Update DeserializeYearsExperienceAnnotationV2Update(JsonElement element)
        {
            Optional<YearsExperienceAnnotationV2UpdateParsed> parsed = default;
            Optional<int> id = default;
            Optional<Rectangle> rectangle = default;
            Optional<IReadOnlyList<Rectangle>> rectangles = default;
            Optional<int?> pageIndex = default;
            Optional<string> raw = default;
            Optional<float?> confidence = default;
            Optional<float?> classificationConfidence = default;
            Optional<float?> textExtractionConfidence = default;
            Optional<bool> isVerified = default;
            Optional<bool> isClientVerified = default;
            Optional<bool> isAutoVerified = default;
            Optional<string> dataPoint = default;
            Optional<string> contentType = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parsed = YearsExperienceAnnotationV2UpdateParsed.DeserializeYearsExperienceAnnotationV2UpdateParsed(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rectangle"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rectangle = null;
                        continue;
                    }
                    rectangle = Rectangle.DeserializeRectangle(property.Value);
                    continue;
                }
                if (property.NameEquals("rectangles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rectangles = null;
                        continue;
                    }
                    List<Rectangle> array = new List<Rectangle>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Rectangle.DeserializeRectangle(item));
                    }
                    rectangles = array;
                    continue;
                }
                if (property.NameEquals("pageIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pageIndex = null;
                        continue;
                    }
                    pageIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("raw"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        raw = null;
                        continue;
                    }
                    raw = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        confidence = null;
                        continue;
                    }
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("classificationConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        classificationConfidence = null;
                        continue;
                    }
                    classificationConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("textExtractionConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        textExtractionConfidence = null;
                        continue;
                    }
                    textExtractionConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("isVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isClientVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isClientVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new YearsExperienceAnnotationV2Update(Optional.ToNullable(id), rectangle.Value, Optional.ToList(rectangles), Optional.ToNullable(pageIndex), raw.Value, Optional.ToNullable(confidence), Optional.ToNullable(classificationConfidence), Optional.ToNullable(textExtractionConfidence), Optional.ToNullable(isVerified), Optional.ToNullable(isClientVerified), Optional.ToNullable(isAutoVerified), dataPoint.Value, contentType.Value, additionalProperties, parsed.Value);
        }
    }
}
