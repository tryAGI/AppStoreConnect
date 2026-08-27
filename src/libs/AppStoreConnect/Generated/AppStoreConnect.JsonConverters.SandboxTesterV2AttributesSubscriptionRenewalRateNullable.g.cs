#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SandboxTesterV2AttributesSubscriptionRenewalRateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate? Read(
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
                        return global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRateExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRateExtensions.ToValueString(value.Value));
            }
        }
    }
}
