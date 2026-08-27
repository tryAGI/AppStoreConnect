
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiWorkflowCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchStartCondition")]
        public global::AppStoreConnect.CiBranchStartCondition? BranchStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagStartCondition")]
        public global::AppStoreConnect.CiTagStartCondition? TagStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequestStartCondition")]
        public global::AppStoreConnect.CiPullRequestStartCondition? PullRequestStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledStartCondition")]
        public global::AppStoreConnect.CiScheduledStartCondition? ScheduledStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualBranchStartCondition")]
        public global::AppStoreConnect.CiManualBranchStartCondition? ManualBranchStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualTagStartCondition")]
        public global::AppStoreConnect.CiManualTagStartCondition? ManualTagStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualPullRequestStartCondition")]
        public global::AppStoreConnect.CiManualPullRequestStartCondition? ManualPullRequestStartCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLockedForEditing")]
        public bool? IsLockedForEditing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Clean { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerFilePath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="actions"></param>
        /// <param name="isEnabled"></param>
        /// <param name="clean"></param>
        /// <param name="containerFilePath"></param>
        /// <param name="branchStartCondition"></param>
        /// <param name="tagStartCondition"></param>
        /// <param name="pullRequestStartCondition"></param>
        /// <param name="scheduledStartCondition"></param>
        /// <param name="manualBranchStartCondition"></param>
        /// <param name="manualTagStartCondition"></param>
        /// <param name="manualPullRequestStartCondition"></param>
        /// <param name="isLockedForEditing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowCreateRequestDataAttributes(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction> actions,
            bool isEnabled,
            bool clean,
            string containerFilePath,
            global::AppStoreConnect.CiBranchStartCondition? branchStartCondition,
            global::AppStoreConnect.CiTagStartCondition? tagStartCondition,
            global::AppStoreConnect.CiPullRequestStartCondition? pullRequestStartCondition,
            global::AppStoreConnect.CiScheduledStartCondition? scheduledStartCondition,
            global::AppStoreConnect.CiManualBranchStartCondition? manualBranchStartCondition,
            global::AppStoreConnect.CiManualTagStartCondition? manualTagStartCondition,
            global::AppStoreConnect.CiManualPullRequestStartCondition? manualPullRequestStartCondition,
            bool? isLockedForEditing)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.BranchStartCondition = branchStartCondition;
            this.TagStartCondition = tagStartCondition;
            this.PullRequestStartCondition = pullRequestStartCondition;
            this.ScheduledStartCondition = scheduledStartCondition;
            this.ManualBranchStartCondition = manualBranchStartCondition;
            this.ManualTagStartCondition = manualTagStartCondition;
            this.ManualPullRequestStartCondition = manualPullRequestStartCondition;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.IsEnabled = isEnabled;
            this.IsLockedForEditing = isLockedForEditing;
            this.Clean = clean;
            this.ContainerFilePath = containerFilePath ?? throw new global::System.ArgumentNullException(nameof(containerFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataAttributes" /> class.
        /// </summary>
        public CiWorkflowCreateRequestDataAttributes()
        {
        }

    }
}