
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetLocalizationCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetLocalizationCreateRequestData(
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataAttributes attributes,
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataRelationships relationships,
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationCreateRequestData" /> class.
        /// </summary>
        public GameCenterLeaderboardSetLocalizationCreateRequestData()
        {
        }

    }
}