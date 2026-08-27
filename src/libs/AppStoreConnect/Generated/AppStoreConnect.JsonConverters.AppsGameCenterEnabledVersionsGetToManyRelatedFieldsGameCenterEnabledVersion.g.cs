#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion Read(
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
                        return global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersionExtensions.ToValueString(value));
        }
    }
}
