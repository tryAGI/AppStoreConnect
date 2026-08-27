#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes? Read(
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
                        return global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesExtensions.ToValueString(value.Value));
            }
        }
    }
}
