#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion Read(
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
                        return global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsRetentionMessageVersionExtensions.ToValueString(value));
        }
    }
}
