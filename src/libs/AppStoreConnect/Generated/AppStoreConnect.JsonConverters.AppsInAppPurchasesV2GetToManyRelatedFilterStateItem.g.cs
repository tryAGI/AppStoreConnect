#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsInAppPurchasesV2GetToManyRelatedFilterStateItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem Read(
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
                        return global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItemExtensions.ToValueString(value));
        }
    }
}
