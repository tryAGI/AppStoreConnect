#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse Read(
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
                        return global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseExtensions.ToValueString(value));
        }
    }
}
