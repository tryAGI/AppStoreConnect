#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType? Read(
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
                        return global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
