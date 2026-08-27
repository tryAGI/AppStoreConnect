#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion Read(
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
                        return global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionExtensions.ToValueString(value));
        }
    }
}
