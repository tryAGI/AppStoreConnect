#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? Read(
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
                        return global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
