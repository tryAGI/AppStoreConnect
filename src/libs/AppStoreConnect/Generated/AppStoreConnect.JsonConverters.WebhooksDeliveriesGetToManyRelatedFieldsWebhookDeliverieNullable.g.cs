#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie? Read(
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
                        return global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieExtensions.ToValueString(value.Value));
            }
        }
    }
}
