
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoutingAppCoverageRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutingAppCoverageRelationships(
            global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersion? appStoreVersion)
        {
            this.AppStoreVersion = appStoreVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageRelationships" /> class.
        /// </summary>
        public RoutingAppCoverageRelationships()
        {
        }

    }
}