#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType Read(
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
                        return global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeExtensions.ToValueString(value));
        }
    }
}
