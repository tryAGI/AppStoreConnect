#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase Read(
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
                        return global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseExtensions.ToValueString(value));
        }
    }
}
