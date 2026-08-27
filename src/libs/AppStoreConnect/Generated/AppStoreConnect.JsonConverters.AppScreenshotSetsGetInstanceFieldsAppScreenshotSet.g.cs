#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppScreenshotSetsGetInstanceFieldsAppScreenshotSetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet Read(
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
                        return global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSetExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSet value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppScreenshotSetsGetInstanceFieldsAppScreenshotSetExtensions.ToValueString(value));
        }
    }
}
