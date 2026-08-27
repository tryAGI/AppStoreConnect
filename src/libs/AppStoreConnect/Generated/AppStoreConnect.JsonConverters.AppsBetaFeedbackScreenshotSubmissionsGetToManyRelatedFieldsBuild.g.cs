#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuildJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild Read(
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
                        return global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuildExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuildExtensions.ToValueString(value));
        }
    }
}
