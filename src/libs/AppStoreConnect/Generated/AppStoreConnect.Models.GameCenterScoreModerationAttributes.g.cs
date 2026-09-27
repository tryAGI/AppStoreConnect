
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterScoreModerationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public string? Rank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public string? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preReleased")]
        public bool? PreReleased { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeIds")]
        public global::System.Collections.Generic.IList<string>? ChallengeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationAttributes" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="score"></param>
        /// <param name="submittedDate"></param>
        /// <param name="blocked"></param>
        /// <param name="preReleased"></param>
        /// <param name="context"></param>
        /// <param name="challengeIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterScoreModerationAttributes(
            string? rank,
            string? score,
            global::System.DateTime? submittedDate,
            bool? blocked,
            bool? preReleased,
            string? context,
            global::System.Collections.Generic.IList<string>? challengeIds)
        {
            this.Rank = rank;
            this.Score = score;
            this.SubmittedDate = submittedDate;
            this.Blocked = blocked;
            this.PreReleased = preReleased;
            this.Context = context;
            this.ChallengeIds = challengeIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationAttributes" /> class.
        /// </summary>
        public GameCenterScoreModerationAttributes()
        {
        }

    }
}