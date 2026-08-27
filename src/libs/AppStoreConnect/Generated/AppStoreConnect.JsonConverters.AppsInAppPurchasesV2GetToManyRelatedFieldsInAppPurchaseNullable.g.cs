#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase? Read(
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
                        return global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
