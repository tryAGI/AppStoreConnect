
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoutingAppCoverageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RoutingAppCoverageCreateRequestDataRelationshipsAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutingAppCoverageCreateRequestDataRelationships(
            global::AppStoreConnect.RoutingAppCoverageCreateRequestDataRelationshipsAppStoreVersion appStoreVersion)
        {
            this.AppStoreVersion = appStoreVersion ?? throw new global::System.ArgumentNullException(nameof(appStoreVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageCreateRequestDataRelationships" /> class.
        /// </summary>
        public RoutingAppCoverageCreateRequestDataRelationships()
        {
        }

    }
}