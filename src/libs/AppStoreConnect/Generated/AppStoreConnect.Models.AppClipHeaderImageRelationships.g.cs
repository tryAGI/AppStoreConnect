
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipHeaderImageRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperienceLocalization")]
        public global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalization? AppClipDefaultExperienceLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipHeaderImageRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperienceLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipHeaderImageRelationships(
            global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalization? appClipDefaultExperienceLocalization)
        {
            this.AppClipDefaultExperienceLocalization = appClipDefaultExperienceLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipHeaderImageRelationships" /> class.
        /// </summary>
        public AppClipHeaderImageRelationships()
        {
        }

    }
}