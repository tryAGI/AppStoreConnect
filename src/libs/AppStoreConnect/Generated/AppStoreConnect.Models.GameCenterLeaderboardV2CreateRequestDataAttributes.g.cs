
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardV2CreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultFormatter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardFormatter DefaultFormatter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VendorIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submissionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType SubmissionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreSortType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType ScoreSortType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("activityProperties")]
        public global::System.Collections.Generic.Dictionary<string, string>? ActivityProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2CreateRequestDataAttributesVisibilityJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2CreateRequestDataAttributes" /> class.
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
        /// <param name="activityProperties"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardV2CreateRequestDataAttributes(
            global::AppStoreConnect.GameCenterLeaderboardFormatter defaultFormatter,
            string referenceName,
            string vendorIdentifier,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType submissionType,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType scoreSortType,
            string? scoreRangeStart,
            string? scoreRangeEnd,
            global::System.DateTime? recurrenceStartDate,
            string? recurrenceDuration,
            string? recurrenceRule,
            global::System.Collections.Generic.Dictionary<string, string>? activityProperties,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataAttributesVisibility? visibility)
        {
            this.DefaultFormatter = defaultFormatter;
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.SubmissionType = submissionType;
            this.ScoreSortType = scoreSortType;
            this.ScoreRangeStart = scoreRangeStart;
            this.ScoreRangeEnd = scoreRangeEnd;
            this.RecurrenceStartDate = recurrenceStartDate;
            this.RecurrenceDuration = recurrenceDuration;
            this.RecurrenceRule = recurrenceRule;
            this.ActivityProperties = activityProperties;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2CreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardV2CreateRequestDataAttributes()
        {
        }

    }
}