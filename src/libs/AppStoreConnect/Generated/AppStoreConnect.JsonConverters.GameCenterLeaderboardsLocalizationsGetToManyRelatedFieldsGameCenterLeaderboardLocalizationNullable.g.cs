#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? Read(
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
                        return global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
