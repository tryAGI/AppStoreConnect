
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeLocalizationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersion? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeLocalizationRelationships(
            global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersion? version,
            global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImage? image)
        {
            this.Version = version;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeLocalizationRelationships" /> class.
        /// </summary>
        public GameCenterChallengeLocalizationRelationships()
        {
        }

    }
}