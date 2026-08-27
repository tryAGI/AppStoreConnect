#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetailJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail Read(
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
                        return global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetailExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetailExtensions.ToValueString(value));
        }
    }
}
