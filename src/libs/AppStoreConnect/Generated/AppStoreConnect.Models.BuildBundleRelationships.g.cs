
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildBundleRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDomainCacheStatus")]
        public global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatus? AppClipDomainCacheStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDomainDebugStatus")]
        public global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatus? AppClipDomainDebugStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppClipInvocations")]
        public global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocations? BetaAppClipInvocations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildBundleFileSizes")]
        public global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizes? BuildBundleFileSizes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleRelationships" /> class.
        /// </summary>
        /// <param name="appClipDomainCacheStatus"></param>
        /// <param name="appClipDomainDebugStatus"></param>
        /// <param name="betaAppClipInvocations"></param>
        /// <param name="buildBundleFileSizes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBundleRelationships(
            global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatus? appClipDomainCacheStatus,
            global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatus? appClipDomainDebugStatus,
            global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocations? betaAppClipInvocations,
            global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizes? buildBundleFileSizes)
        {
            this.AppClipDomainCacheStatus = appClipDomainCacheStatus;
            this.AppClipDomainDebugStatus = appClipDomainDebugStatus;
            this.BetaAppClipInvocations = betaAppClipInvocations;
            this.BuildBundleFileSizes = buildBundleFileSizes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleRelationships" /> class.
        /// </summary>
        public BuildBundleRelationships()
        {
        }

    }
}