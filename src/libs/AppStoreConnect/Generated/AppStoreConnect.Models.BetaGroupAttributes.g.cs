
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGroupAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicLinkId")]
        public string? PublicLinkId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicLink")]
        public string? PublicLink { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaGroupAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdDate"></param>
        /// <param name="isInternalGroup"></param>
        /// <param name="hasAccessToAllBuilds"></param>
        /// <param name="publicLinkEnabled"></param>
        /// <param name="publicLinkId"></param>
        /// <param name="publicLinkLimitEnabled"></param>
        /// <param name="publicLinkLimit"></param>
        /// <param name="publicLink"></param>
        /// <param name="feedbackEnabled"></param>
        /// <param name="iosBuildsAvailableForAppleSiliconMac"></param>
        /// <param name="iosBuildsAvailableForAppleVision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupAttributes(
            string? name,
            global::System.DateTime? createdDate,
            bool? isInternalGroup,
            bool? hasAccessToAllBuilds,
            bool? publicLinkEnabled,
            string? publicLinkId,
            bool? publicLinkLimitEnabled,
            int? publicLinkLimit,
            string? publicLink,
            bool? feedbackEnabled,
            bool? iosBuildsAvailableForAppleSiliconMac,
            bool? iosBuildsAvailableForAppleVision)
        {
            this.Name = name;
            this.CreatedDate = createdDate;
            this.IsInternalGroup = isInternalGroup;
            this.HasAccessToAllBuilds = hasAccessToAllBuilds;
            this.PublicLinkEnabled = publicLinkEnabled;
            this.PublicLinkId = publicLinkId;
            this.PublicLinkLimitEnabled = publicLinkLimitEnabled;
            this.PublicLinkLimit = publicLinkLimit;
            this.PublicLink = publicLink;
            this.FeedbackEnabled = feedbackEnabled;
            this.IosBuildsAvailableForAppleSiliconMac = iosBuildsAvailableForAppleSiliconMac;
            this.IosBuildsAvailableForAppleVision = iosBuildsAvailableForAppleVision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupAttributes" /> class.
        /// </summary>
        public BetaGroupAttributes()
        {
        }

    }
}