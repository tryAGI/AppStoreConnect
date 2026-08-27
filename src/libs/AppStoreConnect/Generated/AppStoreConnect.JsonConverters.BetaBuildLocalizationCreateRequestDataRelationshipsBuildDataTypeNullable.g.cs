#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType? Read(
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
                        return global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
