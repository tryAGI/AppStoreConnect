#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease? Read(
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
                        return global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
