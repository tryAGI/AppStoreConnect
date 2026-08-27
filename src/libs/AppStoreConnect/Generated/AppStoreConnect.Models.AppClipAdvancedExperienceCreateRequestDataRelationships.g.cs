
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClip AppClip { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImage HeaderImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizations Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClip"></param>
        /// <param name="headerImage"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequestDataRelationships(
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClip appClip,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImage headerImage,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizations localizations)
        {
            this.AppClip = appClip ?? throw new global::System.ArgumentNullException(nameof(appClip));
            this.HeaderImage = headerImage ?? throw new global::System.ArgumentNullException(nameof(headerImage));
            this.Localizations = localizations ?? throw new global::System.ArgumentNullException(nameof(localizations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequestDataRelationships()
        {
        }

    }
}