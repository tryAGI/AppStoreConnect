#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization Read(
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
                        return global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalizationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalizationExtensions.ToValueString(value));
        }
    }
}
