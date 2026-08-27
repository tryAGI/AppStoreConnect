#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity? Read(
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
                        return global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityExtensions.ToValueString(value.Value));
            }
        }
    }
}
