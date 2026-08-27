#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType? Read(
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
                        return global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
