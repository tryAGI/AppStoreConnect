#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2 Read(
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
                        return global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2Extensions.ToValueString(value));
        }
    }
}
