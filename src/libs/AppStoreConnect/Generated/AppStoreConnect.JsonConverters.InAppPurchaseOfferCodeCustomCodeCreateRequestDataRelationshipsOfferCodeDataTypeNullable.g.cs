#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? Read(
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
                        return global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
