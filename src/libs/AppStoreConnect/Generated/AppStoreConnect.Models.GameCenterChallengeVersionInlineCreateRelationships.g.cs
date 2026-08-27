
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeVersionInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge")]
        public global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationshipsChallenge? Challenge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="challenge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionInlineCreateRelationships(
            global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationshipsChallenge? challenge)
        {
            this.Challenge = challenge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreateRelationships" /> class.
        /// </summary>
        public GameCenterChallengeVersionInlineCreateRelationships()
        {
        }

    }
}