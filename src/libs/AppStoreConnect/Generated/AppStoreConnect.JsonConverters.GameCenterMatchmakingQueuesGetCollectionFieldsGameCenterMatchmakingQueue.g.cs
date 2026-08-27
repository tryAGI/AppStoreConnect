#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue Read(
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
                        return global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueExtensions.ToValueString(value));
        }
    }
}
