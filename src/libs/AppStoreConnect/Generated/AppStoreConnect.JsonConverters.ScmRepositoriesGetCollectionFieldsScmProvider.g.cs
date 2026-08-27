#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScmRepositoriesGetCollectionFieldsScmProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProvider>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProvider Read(
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
                        return global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.ScmRepositoriesGetCollectionFieldsScmProviderExtensions.ToValueString(value));
        }
    }
}
