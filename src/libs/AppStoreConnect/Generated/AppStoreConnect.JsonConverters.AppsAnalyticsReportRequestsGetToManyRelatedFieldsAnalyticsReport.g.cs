#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport Read(
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
                        return global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportExtensions.ToValueString(value));
        }
    }
}
