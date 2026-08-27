
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeVersionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterChallengeVersionCreateRequestDataRelationshipsChallenge Challenge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="challenge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterChallengeVersionCreateRequestDataRelationshipsChallenge challenge)
        {
            this.Challenge = challenge ?? throw new global::System.ArgumentNullException(nameof(challenge));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterChallengeVersionCreateRequestDataRelationships()
        {
        }

    }
}