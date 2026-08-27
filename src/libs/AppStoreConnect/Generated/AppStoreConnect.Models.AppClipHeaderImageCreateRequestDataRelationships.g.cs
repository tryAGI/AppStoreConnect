
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipHeaderImageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperienceLocalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalization AppClipDefaultExperienceLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipHeaderImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperienceLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipHeaderImageCreateRequestDataRelationships(
            global::AppStoreConnect.AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalization appClipDefaultExperienceLocalization)
        {
            this.AppClipDefaultExperienceLocalization = appClipDefaultExperienceLocalization ?? throw new global::System.ArgumentNullException(nameof(appClipDefaultExperienceLocalization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipHeaderImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipHeaderImageCreateRequestDataRelationships()
        {
        }

    }
}