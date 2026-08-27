
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeIds")]
        public global::System.Collections.Generic.IList<string>? ChallengeIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopedPlayerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopedPlayerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VendorIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preReleased")]
        public bool? PreReleased { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="scopedPlayerId"></param>
        /// <param name="score"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="challengeIds"></param>
        /// <param name="context"></param>
        /// <param name="submittedDate"></param>
        /// <param name="preReleased"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes(
            string bundleId,
            string scopedPlayerId,
            string score,
            string vendorIdentifier,
            global::System.Collections.Generic.IList<string>? challengeIds,
            string? context,
            global::System.DateTime? submittedDate,
            bool? preReleased)
        {
            this.BundleId = bundleId ?? throw new global::System.ArgumentNullException(nameof(bundleId));
            this.ChallengeIds = challengeIds;
            this.Context = context;
            this.ScopedPlayerId = scopedPlayerId ?? throw new global::System.ArgumentNullException(nameof(scopedPlayerId));
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
            this.SubmittedDate = submittedDate;
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.PreReleased = preReleased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes()
        {
        }

    }
}