#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase? Read(
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
                        return global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
