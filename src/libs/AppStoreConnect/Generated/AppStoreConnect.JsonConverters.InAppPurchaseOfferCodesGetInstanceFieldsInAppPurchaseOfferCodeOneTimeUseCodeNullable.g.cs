#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode? Read(
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
                        return global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
