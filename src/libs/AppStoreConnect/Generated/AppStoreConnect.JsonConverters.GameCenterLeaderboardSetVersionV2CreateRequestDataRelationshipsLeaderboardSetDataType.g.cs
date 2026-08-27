#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataType Read(
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
                        return global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSetDataTypeExtensions.ToValueString(value));
        }
    }
}
