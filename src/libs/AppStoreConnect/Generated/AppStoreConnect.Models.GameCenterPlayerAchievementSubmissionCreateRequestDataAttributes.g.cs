
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterPlayerAchievementSubmissionCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageAchieved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PercentageAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopedPlayerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopedPlayerId { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterPlayerAchievementSubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="percentageAchieved"></param>
        /// <param name="scopedPlayerId"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="challengeIds"></param>
        /// <param name="submittedDate"></param>
        /// <param name="preReleased"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterPlayerAchievementSubmissionCreateRequestDataAttributes(
            string bundleId,
            int percentageAchieved,
            string scopedPlayerId,
            string vendorIdentifier,
            global::System.Collections.Generic.IList<string>? challengeIds,
            global::System.DateTime? submittedDate,
            bool? preReleased)
        {
            this.BundleId = bundleId ?? throw new global::System.ArgumentNullException(nameof(bundleId));
            this.ChallengeIds = challengeIds;
            this.PercentageAchieved = percentageAchieved;
            this.ScopedPlayerId = scopedPlayerId ?? throw new global::System.ArgumentNullException(nameof(scopedPlayerId));
            this.SubmittedDate = submittedDate;
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.PreReleased = preReleased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterPlayerAchievementSubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterPlayerAchievementSubmissionCreateRequestDataAttributes()
        {
        }

    }
}