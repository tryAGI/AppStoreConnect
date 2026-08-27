#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class PassTypeIdsGetCollectionFieldsPassTypeIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId Read(
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
                        return global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeIdExtensions.ToValueString(value));
        }
    }
}
