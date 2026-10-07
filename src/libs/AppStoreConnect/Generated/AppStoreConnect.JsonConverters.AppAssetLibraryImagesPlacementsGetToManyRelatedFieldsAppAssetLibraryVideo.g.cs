#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo Read(
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
                        return global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions.ToValueString(value));
        }
    }
}
