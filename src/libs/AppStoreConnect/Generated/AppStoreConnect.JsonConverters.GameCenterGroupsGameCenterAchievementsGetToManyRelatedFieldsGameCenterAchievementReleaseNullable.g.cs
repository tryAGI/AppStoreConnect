#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease? Read(
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
                        return global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
