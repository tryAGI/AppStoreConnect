#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePriceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice? Read(
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
                        return global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePriceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePriceExtensions.ToValueString(value.Value));
            }
        }
    }
}
