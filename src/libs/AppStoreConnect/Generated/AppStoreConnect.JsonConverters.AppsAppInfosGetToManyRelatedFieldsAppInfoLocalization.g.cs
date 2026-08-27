#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsAppInfosGetToManyRelatedFieldsAppInfoLocalizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization Read(
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
                        return global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalizationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalizationExtensions.ToValueString(value));
        }
    }
}
