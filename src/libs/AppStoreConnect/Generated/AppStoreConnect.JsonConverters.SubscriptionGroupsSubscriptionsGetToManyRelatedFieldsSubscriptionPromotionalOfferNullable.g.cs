#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer? Read(
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
                        return global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferExtensions.ToValueString(value.Value));
            }
        }
    }
}
