
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BundleIdCapabilityCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleId BundleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BundleIdCapabilityCreateRequestDataRelationships(
            global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationshipsBundleId bundleId)
        {
            this.BundleId = bundleId ?? throw new global::System.ArgumentNullException(nameof(bundleId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        public BundleIdCapabilityCreateRequestDataRelationships()
        {
        }

    }
}