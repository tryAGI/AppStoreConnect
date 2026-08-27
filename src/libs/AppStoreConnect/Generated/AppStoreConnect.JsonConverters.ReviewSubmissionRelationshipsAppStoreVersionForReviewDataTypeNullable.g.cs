#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType? Read(
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
                        return global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
