
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaGroupCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isInternalGroup")]
        public bool? IsInternalGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasAccessToAllBuilds")]
        public bool? HasAccessToAllBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicLinkEnabled")]
        public bool? PublicLinkEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicLinkLimitEnabled")]
        public bool? PublicLinkLimitEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicLinkLimit")]
        public int? PublicLinkLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackEnabled")]
        public bool? FeedbackEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isInternalGroup"></param>
        /// <param name="hasAccessToAllBuilds"></param>
        /// <param name="publicLinkEnabled"></param>
        /// <param name="publicLinkLimitEnabled"></param>
        /// <param name="publicLinkLimit"></param>
        /// <param name="feedbackEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupCreateRequestDataAttributes(
            string name,
            bool? isInternalGroup,
            bool? hasAccessToAllBuilds,
            bool? publicLinkEnabled,
            bool? publicLinkLimitEnabled,
            int? publicLinkLimit,
            bool? feedbackEnabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsInternalGroup = isInternalGroup;
            this.HasAccessToAllBuilds = hasAccessToAllBuilds;
            this.PublicLinkEnabled = publicLinkEnabled;
            this.PublicLinkLimitEnabled = publicLinkLimitEnabled;
            this.PublicLinkLimit = publicLinkLimit;
            this.FeedbackEnabled = feedbackEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataAttributes" /> class.
        /// </summary>
        public BetaGroupCreateRequestDataAttributes()
        {
        }

    }
}