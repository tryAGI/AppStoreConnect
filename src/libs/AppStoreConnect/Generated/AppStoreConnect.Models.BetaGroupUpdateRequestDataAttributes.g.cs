
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaGroupUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iosBuildsAvailableForAppleSiliconMac")]
        public bool? IosBuildsAvailableForAppleSiliconMac { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iosBuildsAvailableForAppleVision")]
        public bool? IosBuildsAvailableForAppleVision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="publicLinkEnabled"></param>
        /// <param name="publicLinkLimitEnabled"></param>
        /// <param name="publicLinkLimit"></param>
        /// <param name="feedbackEnabled"></param>
        /// <param name="iosBuildsAvailableForAppleSiliconMac"></param>
        /// <param name="iosBuildsAvailableForAppleVision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupUpdateRequestDataAttributes(
            string? name,
            bool? publicLinkEnabled,
            bool? publicLinkLimitEnabled,
            int? publicLinkLimit,
            bool? feedbackEnabled,
            bool? iosBuildsAvailableForAppleSiliconMac,
            bool? iosBuildsAvailableForAppleVision)
        {
            this.Name = name;
            this.PublicLinkEnabled = publicLinkEnabled;
            this.PublicLinkLimitEnabled = publicLinkLimitEnabled;
            this.PublicLinkLimit = publicLinkLimit;
            this.FeedbackEnabled = feedbackEnabled;
            this.IosBuildsAvailableForAppleSiliconMac = iosBuildsAvailableForAppleSiliconMac;
            this.IosBuildsAvailableForAppleVision = iosBuildsAvailableForAppleVision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BetaGroupUpdateRequestDataAttributes()
        {
        }

    }
}