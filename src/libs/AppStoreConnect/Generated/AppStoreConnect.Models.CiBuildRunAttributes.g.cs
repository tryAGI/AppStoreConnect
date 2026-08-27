
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedDate")]
        public global::System.DateTime? StartedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedDate")]
        public global::System.DateTime? FinishedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceCommit")]
        public global::AppStoreConnect.CiBuildRunAttributesSourceCommit? SourceCommit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationCommit")]
        public global::AppStoreConnect.CiBuildRunAttributesDestinationCommit? DestinationCommit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequestBuild")]
        public bool? IsPullRequestBuild { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueCounts")]
        public global::AppStoreConnect.CiIssueCounts? IssueCounts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionProgress")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiExecutionProgressJsonConverter))]
        public global::AppStoreConnect.CiExecutionProgress? ExecutionProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiCompletionStatusJsonConverter))]
        public global::AppStoreConnect.CiCompletionStatus? CompletionStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiBuildRunAttributesStartReasonJsonConverter))]
        public global::AppStoreConnect.CiBuildRunAttributesStartReason? StartReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiBuildRunAttributesCancelReasonJsonConverter))]
        public global::AppStoreConnect.CiBuildRunAttributesCancelReason? CancelReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunAttributes" /> class.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="createdDate"></param>
        /// <param name="startedDate"></param>
        /// <param name="finishedDate"></param>
        /// <param name="sourceCommit"></param>
        /// <param name="destinationCommit"></param>
        /// <param name="isPullRequestBuild"></param>
        /// <param name="issueCounts"></param>
        /// <param name="executionProgress"></param>
        /// <param name="completionStatus"></param>
        /// <param name="startReason"></param>
        /// <param name="cancelReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildRunAttributes(
            int? number,
            global::System.DateTime? createdDate,
            global::System.DateTime? startedDate,
            global::System.DateTime? finishedDate,
            global::AppStoreConnect.CiBuildRunAttributesSourceCommit? sourceCommit,
            global::AppStoreConnect.CiBuildRunAttributesDestinationCommit? destinationCommit,
            bool? isPullRequestBuild,
            global::AppStoreConnect.CiIssueCounts? issueCounts,
            global::AppStoreConnect.CiExecutionProgress? executionProgress,
            global::AppStoreConnect.CiCompletionStatus? completionStatus,
            global::AppStoreConnect.CiBuildRunAttributesStartReason? startReason,
            global::AppStoreConnect.CiBuildRunAttributesCancelReason? cancelReason)
        {
            this.Number = number;
            this.CreatedDate = createdDate;
            this.StartedDate = startedDate;
            this.FinishedDate = finishedDate;
            this.SourceCommit = sourceCommit;
            this.DestinationCommit = destinationCommit;
            this.IsPullRequestBuild = isPullRequestBuild;
            this.IssueCounts = issueCounts;
            this.ExecutionProgress = executionProgress;
            this.CompletionStatus = completionStatus;
            this.StartReason = startReason;
            this.CancelReason = cancelReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunAttributes" /> class.
        /// </summary>
        public CiBuildRunAttributes()
        {
        }

    }
}