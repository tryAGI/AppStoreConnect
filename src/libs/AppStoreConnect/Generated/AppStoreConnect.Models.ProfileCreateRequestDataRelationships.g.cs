
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProfileCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleId BundleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devices")]
        public global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevices? Devices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificates Certificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="certificates"></param>
        /// <param name="devices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileCreateRequestDataRelationships(
            global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleId bundleId,
            global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificates certificates,
            global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevices? devices)
        {
            this.BundleId = bundleId ?? throw new global::System.ArgumentNullException(nameof(bundleId));
            this.Devices = devices;
            this.Certificates = certificates ?? throw new global::System.ArgumentNullException(nameof(certificates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileCreateRequestDataRelationships" /> class.
        /// </summary>
        public ProfileCreateRequestDataRelationships()
        {
        }

    }
}