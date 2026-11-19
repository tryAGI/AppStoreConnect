#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType Read(
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
                        return global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemTypeExtensions.ToValueString(value));
        }
    }
}
