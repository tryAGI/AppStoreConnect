#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage Read(
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
                        return global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImageExtensions.ToValueString(value));
        }
    }
}
