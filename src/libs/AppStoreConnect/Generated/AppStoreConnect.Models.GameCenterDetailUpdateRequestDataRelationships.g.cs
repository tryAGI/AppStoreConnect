
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterDetailUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLeaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard? DefaultLeaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLeaderboardV2")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2? DefaultLeaderboardV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultGroupLeaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboard? DefaultGroupLeaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultGroupLeaderboardV2")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2? DefaultGroupLeaderboardV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterGroup"></param>
        /// <param name="defaultLeaderboardV2"></param>
        /// <param name="defaultGroupLeaderboardV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterDetailUpdateRequestDataRelationships(
            global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2? defaultLeaderboardV2,
            global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2? defaultGroupLeaderboardV2)
        {
            this.GameCenterGroup = gameCenterGroup;
            this.DefaultLeaderboardV2 = defaultLeaderboardV2;
            this.DefaultGroupLeaderboardV2 = defaultGroupLeaderboardV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailUpdateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterDetailUpdateRequestDataRelationships()
        {
        }

    }
}