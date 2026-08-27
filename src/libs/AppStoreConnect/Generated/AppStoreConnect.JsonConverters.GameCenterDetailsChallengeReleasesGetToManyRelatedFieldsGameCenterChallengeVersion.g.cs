#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion Read(
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
                        return global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionExtensions.ToValueString(value));
        }
    }
}
