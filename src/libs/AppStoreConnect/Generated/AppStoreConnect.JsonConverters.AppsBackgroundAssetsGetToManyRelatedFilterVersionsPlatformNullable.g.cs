#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatformNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform? Read(
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
                        return global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatformExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatformExtensions.ToValueString(value.Value));
            }
        }
    }
}
