
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClip")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip? AppClip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerImage")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage? HeaderImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClip"></param>
        /// <param name="headerImage"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceUpdateRequestDataRelationships(
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip? appClip,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage? headerImage,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations? localizations)
        {
            this.AppClip = appClip;
            this.HeaderImage = headerImage;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipAdvancedExperienceUpdateRequestDataRelationships()
        {
        }

    }
}