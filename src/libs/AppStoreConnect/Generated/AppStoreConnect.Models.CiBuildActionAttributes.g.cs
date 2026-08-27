
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildActionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiActionTypeJsonConverter))]
        public global::AppStoreConnect.CiActionType? ActionType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("isRequiredToPass")]
        public bool? IsRequiredToPass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildActionAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="actionType"></param>
        /// <param name="startedDate"></param>
        /// <param name="finishedDate"></param>
        /// <param name="issueCounts"></param>
        /// <param name="executionProgress"></param>
        /// <param name="completionStatus"></param>
        /// <param name="isRequiredToPass"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildActionAttributes(
            string? name,
            global::AppStoreConnect.CiActionType? actionType,
            global::System.DateTime? startedDate,
            global::System.DateTime? finishedDate,
            global::AppStoreConnect.CiIssueCounts? issueCounts,
            global::AppStoreConnect.CiExecutionProgress? executionProgress,
            global::AppStoreConnect.CiCompletionStatus? completionStatus,
            bool? isRequiredToPass)
        {
            this.Name = name;
            this.ActionType = actionType;
            this.StartedDate = startedDate;
            this.FinishedDate = finishedDate;
            this.IssueCounts = issueCounts;
            this.ExecutionProgress = executionProgress;
            this.CompletionStatus = completionStatus;
            this.IsRequiredToPass = isRequiredToPass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildActionAttributes" /> class.
        /// </summary>
        public CiBuildActionAttributes()
        {
        }

    }
}