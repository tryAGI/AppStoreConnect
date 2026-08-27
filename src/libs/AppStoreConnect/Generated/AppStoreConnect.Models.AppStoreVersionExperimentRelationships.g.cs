
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionExperimentRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatments")]
        public global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatments? AppStoreVersionExperimentTreatments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
        /// <param name="appStoreVersionExperimentTreatments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentRelationships(
            global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatments? appStoreVersionExperimentTreatments)
        {
            this.AppStoreVersion = appStoreVersion;
            this.AppStoreVersionExperimentTreatments = appStoreVersionExperimentTreatments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentRelationships" /> class.
        /// </summary>
        public AppStoreVersionExperimentRelationships()
        {
        }

    }
}