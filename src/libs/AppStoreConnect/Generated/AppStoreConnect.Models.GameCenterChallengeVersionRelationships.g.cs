
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge")]
        public global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallenge? Challenge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleases? Releases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultImage")]
        public global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImage? DefaultImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionRelationships" /> class.
        /// </summary>
        /// <param name="challenge"></param>
        /// <param name="localizations"></param>
        /// <param name="releases"></param>
        /// <param name="defaultImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionRelationships(
            global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallenge? challenge,
            global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizations? localizations,
            global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleases? releases,
            global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImage? defaultImage)
        {
            this.Challenge = challenge;
            this.Localizations = localizations;
            this.Releases = releases;
            this.DefaultImage = defaultImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionRelationships" /> class.
        /// </summary>
        public GameCenterChallengeVersionRelationships()
        {
        }

    }
}