
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeVersionInlineCreateRelationshipsChallenge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationshipsChallengeData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreateRelationshipsChallenge" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionInlineCreateRelationshipsChallenge(
            global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationshipsChallengeData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreateRelationshipsChallenge" /> class.
        /// </summary>
        public GameCenterChallengeVersionInlineCreateRelationshipsChallenge()
        {
        }

    }
}