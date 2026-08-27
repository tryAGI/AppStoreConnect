#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetailNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail? Read(
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
                        return global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetailExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetail? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppsBetaAppReviewDetailGetToOneRelatedFieldsBetaAppReviewDetailExtensions.ToValueString(value.Value));
            }
        }
    }
}
