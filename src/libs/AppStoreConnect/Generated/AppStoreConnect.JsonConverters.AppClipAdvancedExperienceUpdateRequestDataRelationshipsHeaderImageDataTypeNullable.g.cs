#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
