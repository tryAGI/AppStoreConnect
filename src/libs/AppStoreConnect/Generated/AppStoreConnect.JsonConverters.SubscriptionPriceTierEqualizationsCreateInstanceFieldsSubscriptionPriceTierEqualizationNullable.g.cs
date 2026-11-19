#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization? Read(
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
                        return global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualizationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
