
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BundleIdRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::AppStoreConnect.BundleIdRelationshipsProfiles? Profiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleIdCapabilities")]
        public global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilities? BundleIdCapabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.BundleIdRelationshipsApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdRelationships" /> class.
        /// </summary>
        /// <param name="profiles"></param>
        /// <param name="bundleIdCapabilities"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BundleIdRelationships(
            global::AppStoreConnect.BundleIdRelationshipsProfiles? profiles,
            global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilities? bundleIdCapabilities,
            global::AppStoreConnect.BundleIdRelationshipsApp? app)
        {
            this.Profiles = profiles;
            this.BundleIdCapabilities = bundleIdCapabilities;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdRelationships" /> class.
        /// </summary>
        public BundleIdRelationships()
        {
        }

    }
}