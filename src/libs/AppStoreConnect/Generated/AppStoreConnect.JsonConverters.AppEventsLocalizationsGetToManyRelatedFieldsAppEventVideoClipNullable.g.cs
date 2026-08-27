#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClipNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip? Read(
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
                        return global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClipExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClipExtensions.ToValueString(value.Value));
            }
        }
    }
}
