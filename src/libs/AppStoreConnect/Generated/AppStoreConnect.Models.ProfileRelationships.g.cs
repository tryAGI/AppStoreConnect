
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProfileRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public global::AppStoreConnect.ProfileRelationshipsBundleId? BundleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devices")]
        public global::AppStoreConnect.ProfileRelationshipsDevices? Devices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificates")]
        public global::AppStoreConnect.ProfileRelationshipsCertificates? Certificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRelationships" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="devices"></param>
        /// <param name="certificates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileRelationships(
            global::AppStoreConnect.ProfileRelationshipsBundleId? bundleId,
            global::AppStoreConnect.ProfileRelationshipsDevices? devices,
            global::AppStoreConnect.ProfileRelationshipsCertificates? certificates)
        {
            this.BundleId = bundleId;
            this.Devices = devices;
            this.Certificates = certificates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRelationships" /> class.
        /// </summary>
        public ProfileRelationships()
        {
        }

    }
}