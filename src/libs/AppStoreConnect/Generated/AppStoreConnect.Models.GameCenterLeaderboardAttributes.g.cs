
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFormatter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardFormatter? DefaultFormatter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        public string? VendorIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submissionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesSubmissionTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType? SubmissionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreSortType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesScoreSortTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType? ScoreSortType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreRangeStart")]
        public string? ScoreRangeStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreRangeEnd")]
        public string? ScoreRangeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurrenceStartDate")]
        public global::System.DateTime? RecurrenceStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurrenceDuration")]
        public string? RecurrenceDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurrenceRule")]
        public string? RecurrenceRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityProperties")]
        public global::System.Collections.Generic.Dictionary<string, string>? ActivityProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesVisibilityJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardAttributes" /> class.
        /// </summary>
        /// <param name="defaultFormatter"></param>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="submissionType"></param>
        /// <param name="scoreSortType"></param>
        /// <param name="scoreRangeStart"></param>
        /// <param name="scoreRangeEnd"></param>
        /// <param name="recurrenceStartDate"></param>
        /// <param name="recurrenceDuration"></param>
        /// <param name="recurrenceRule"></param>
        /// <param name="archived"></param>
        /// <param name="activityProperties"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardAttributes(
            global::AppStoreConnect.GameCenterLeaderboardFormatter? defaultFormatter,
            string? referenceName,
            string? vendorIdentifier,
            global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType? submissionType,
            global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType? scoreSortType,
            string? scoreRangeStart,
            string? scoreRangeEnd,
            global::System.DateTime? recurrenceStartDate,
            string? recurrenceDuration,
            string? recurrenceRule,
            bool? archived,
            global::System.Collections.Generic.Dictionary<string, string>? activityProperties,
            global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility? visibility)
        {
            this.DefaultFormatter = defaultFormatter;
            this.ReferenceName = referenceName;
            this.VendorIdentifier = vendorIdentifier;
            this.SubmissionType = submissionType;
            this.ScoreSortType = scoreSortType;
            this.ScoreRangeStart = scoreRangeStart;
            this.ScoreRangeEnd = scoreRangeEnd;
            this.RecurrenceStartDate = recurrenceStartDate;
            this.RecurrenceDuration = recurrenceDuration;
            this.RecurrenceRule = recurrenceRule;
            this.Archived = archived;
            this.ActivityProperties = activityProperties;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardAttributes()
        {
        }

    }
}