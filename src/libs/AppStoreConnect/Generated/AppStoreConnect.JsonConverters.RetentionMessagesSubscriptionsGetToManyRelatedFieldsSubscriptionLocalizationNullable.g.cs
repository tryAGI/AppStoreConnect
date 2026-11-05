#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization? Read(
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
                        return global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
