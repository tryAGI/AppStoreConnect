
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetReleaseCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetReleaseCreateRequestData" /> class.
        /// </summary>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetReleaseCreateRequestData(
            global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationships relationships,
            global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataType type)
        {
            this.Type = type;
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetReleaseCreateRequestData" /> class.
        /// </summary>
        public GameCenterLeaderboardSetReleaseCreateRequestData()
        {
        }

    }
}