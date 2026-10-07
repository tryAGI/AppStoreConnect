#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType Read(
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
                        return global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemTypeExtensions.ToValueString(value));
        }
    }
}
