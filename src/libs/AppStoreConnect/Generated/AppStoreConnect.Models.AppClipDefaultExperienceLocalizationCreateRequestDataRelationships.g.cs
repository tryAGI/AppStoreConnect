
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipDefaultExperienceLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperience AppClipDefaultExperience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperience appClipDefaultExperience)
        {
            this.AppClipDefaultExperience = appClipDefaultExperience ?? throw new global::System.ArgumentNullException(nameof(appClipDefaultExperience));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipDefaultExperienceLocalizationCreateRequestDataRelationships()
        {
        }

    }
}