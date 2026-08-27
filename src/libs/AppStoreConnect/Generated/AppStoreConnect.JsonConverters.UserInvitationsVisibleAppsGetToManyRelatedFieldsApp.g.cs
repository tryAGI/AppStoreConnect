#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserInvitationsVisibleAppsGetToManyRelatedFieldsAppJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsApp>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsApp Read(
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
                        return global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsAppExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsApp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsApp);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsApp value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.UserInvitationsVisibleAppsGetToManyRelatedFieldsAppExtensions.ToValueString(value));
        }
    }
}
