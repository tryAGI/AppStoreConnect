
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppScreenshotCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScreenshotSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSet AppScreenshotSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appScreenshotSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppScreenshotCreateRequestDataRelationships(
            global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSet appScreenshotSet)
        {
            this.AppScreenshotSet = appScreenshotSet ?? throw new global::System.ArgumentNullException(nameof(appScreenshotSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppScreenshotCreateRequestDataRelationships()
        {
        }

    }
}