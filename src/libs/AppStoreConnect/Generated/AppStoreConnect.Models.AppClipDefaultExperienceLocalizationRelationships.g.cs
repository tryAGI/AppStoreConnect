
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipDefaultExperienceLocalizationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        public global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperience? AppClipDefaultExperience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipHeaderImage")]
        public global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage? AppClipHeaderImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperience"></param>
        /// <param name="appClipHeaderImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceLocalizationRelationships(
            global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperience? appClipDefaultExperience,
            global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage? appClipHeaderImage)
        {
            this.AppClipDefaultExperience = appClipDefaultExperience;
            this.AppClipHeaderImage = appClipHeaderImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationRelationships" /> class.
        /// </summary>
        public AppClipDefaultExperienceLocalizationRelationships()
        {
        }

    }
}