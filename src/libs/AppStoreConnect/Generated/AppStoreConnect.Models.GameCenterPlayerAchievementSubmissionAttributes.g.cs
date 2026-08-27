
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterPlayerAchievementSubmissionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeIds")]
        public global::System.Collections.Generic.IList<string>? ChallengeIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageAchieved")]
        public int? PercentageAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopedPlayerId")]
        public string? ScopedPlayerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        public string? VendorIdentifier { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterPlayerAchievementSubmissionAttributes" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="challengeIds"></param>
        /// <param name="percentageAchieved"></param>
        /// <param name="scopedPlayerId"></param>
        /// <param name="submittedDate"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="preReleased"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterPlayerAchievementSubmissionAttributes(
            string? bundleId,
            global::System.Collections.Generic.IList<string>? challengeIds,
            int? percentageAchieved,
            string? scopedPlayerId,
            global::System.DateTime? submittedDate,
            string? vendorIdentifier,
            bool? preReleased)
        {
            this.BundleId = bundleId;
            this.ChallengeIds = challengeIds;
            this.PercentageAchieved = percentageAchieved;
            this.ScopedPlayerId = scopedPlayerId;
            this.SubmittedDate = submittedDate;
            this.VendorIdentifier = vendorIdentifier;
            this.PreReleased = preReleased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterPlayerAchievementSubmissionAttributes" /> class.
        /// </summary>
        public GameCenterPlayerAchievementSubmissionAttributes()
        {
        }

    }
}