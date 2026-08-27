
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeVersionReleaseRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionReleaseRelationships" /> class.
        /// </summary>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionReleaseRelationships(
            global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersion? version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionReleaseRelationships" /> class.
        /// </summary>
        public GameCenterChallengeVersionReleaseRelationships()
        {
        }

    }
}