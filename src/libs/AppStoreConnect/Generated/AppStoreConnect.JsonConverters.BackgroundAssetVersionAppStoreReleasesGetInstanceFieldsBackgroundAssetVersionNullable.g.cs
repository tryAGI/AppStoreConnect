#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion? Read(
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
                        return global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
