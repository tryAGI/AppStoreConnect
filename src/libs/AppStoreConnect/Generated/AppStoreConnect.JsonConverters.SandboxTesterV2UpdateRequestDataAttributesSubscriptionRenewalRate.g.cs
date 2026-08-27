#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate Read(
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
                        return global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateExtensions.ToValueString(value));
        }
    }
}
