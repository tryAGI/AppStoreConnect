#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType Read(
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
                        return global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeExtensions.ToValueString(value));
        }
    }
}
