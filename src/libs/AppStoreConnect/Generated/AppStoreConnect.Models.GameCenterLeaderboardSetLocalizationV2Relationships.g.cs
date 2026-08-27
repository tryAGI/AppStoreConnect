
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetLocalizationV2Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersion? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationV2Relationships" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetLocalizationV2Relationships(
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsVersion? version,
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2RelationshipsImage? image)
        {
            this.Version = version;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationV2Relationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetLocalizationV2Relationships()
        {
        }

    }
}