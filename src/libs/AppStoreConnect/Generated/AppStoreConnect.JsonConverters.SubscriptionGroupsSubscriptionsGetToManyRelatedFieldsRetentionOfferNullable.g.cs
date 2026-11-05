#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOfferNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer? Read(
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
                        return global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOfferExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOfferExtensions.ToValueString(value.Value));
            }
        }
    }
}
