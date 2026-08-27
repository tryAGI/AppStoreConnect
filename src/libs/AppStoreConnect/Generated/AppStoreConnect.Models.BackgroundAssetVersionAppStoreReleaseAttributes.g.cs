
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetVersionAppStoreReleaseAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseStateJsonConverter))]
        public global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAppStoreReleaseAttributes" /> class.
        /// </summary>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionAppStoreReleaseAttributes(
            global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState? state)
        {
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAppStoreReleaseAttributes" /> class.
        /// </summary>
        public BackgroundAssetVersionAppStoreReleaseAttributes()
        {
        }

    }
}