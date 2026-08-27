#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider Read(
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
                        return global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderExtensions.ToValueString(value));
        }
    }
}
