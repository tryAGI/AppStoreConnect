#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionReleaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease? Read(
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
                        return global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionReleaseExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionRelease? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeVersionReleaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
