#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType Read(
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
                        return global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataTypeExtensions.ToValueString(value));
        }
    }
}
