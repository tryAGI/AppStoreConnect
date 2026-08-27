#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization? Read(
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
                        return global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
