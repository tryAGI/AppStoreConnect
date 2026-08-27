#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePointNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint? Read(
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
                        return global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePointExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePointExtensions.ToValueString(value.Value));
            }
        }
    }
}
