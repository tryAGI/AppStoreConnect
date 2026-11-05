#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class RetentionOfferPricesLinkagesResponseDataItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemType? Read(
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
                        return global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.RetentionOfferPricesLinkagesResponseDataItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
