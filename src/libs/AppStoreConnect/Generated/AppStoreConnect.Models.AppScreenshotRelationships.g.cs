
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppScreenshotRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScreenshotSet")]
        public global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSet? AppScreenshotSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotRelationships" /> class.
        /// </summary>
        /// <param name="appScreenshotSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppScreenshotRelationships(
            global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSet? appScreenshotSet)
        {
            this.AppScreenshotSet = appScreenshotSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotRelationships" /> class.
        /// </summary>
        public AppScreenshotRelationships()
        {
        }

    }
}