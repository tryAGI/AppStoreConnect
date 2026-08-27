#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion? Read(
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
                        return global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
