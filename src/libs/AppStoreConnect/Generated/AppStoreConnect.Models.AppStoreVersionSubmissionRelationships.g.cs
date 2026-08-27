
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionSubmissionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionSubmissionRelationships(
            global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersion? appStoreVersion)
        {
            this.AppStoreVersion = appStoreVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionSubmissionRelationships" /> class.
        /// </summary>
        public AppStoreVersionSubmissionRelationships()
        {
        }

    }
}