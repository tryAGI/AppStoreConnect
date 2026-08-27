
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization(
            global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization" /> class.
        /// </summary>
        public AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization()
        {
        }

    }
}