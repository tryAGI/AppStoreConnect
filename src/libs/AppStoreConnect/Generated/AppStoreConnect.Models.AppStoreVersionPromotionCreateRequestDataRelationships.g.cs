
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionPromotionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment AppStoreVersionExperimentTreatment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPromotionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
        /// <param name="appStoreVersionExperimentTreatment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionPromotionCreateRequestDataRelationships(
            global::AppStoreConnect.AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersion appStoreVersion,
            global::AppStoreConnect.AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment appStoreVersionExperimentTreatment)
        {
            this.AppStoreVersion = appStoreVersion ?? throw new global::System.ArgumentNullException(nameof(appStoreVersion));
            this.AppStoreVersionExperimentTreatment = appStoreVersionExperimentTreatment ?? throw new global::System.ArgumentNullException(nameof(appStoreVersionExperimentTreatment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPromotionCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreVersionPromotionCreateRequestDataRelationships()
        {
        }

    }
}