
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetVersionInternalBetaReleaseAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseAttributesStateJsonConverter))]
        public global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionInternalBetaReleaseAttributes" /> class.
        /// </summary>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionInternalBetaReleaseAttributes(
            global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState? state)
        {
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionInternalBetaReleaseAttributes" /> class.
        /// </summary>
        public BackgroundAssetVersionInternalBetaReleaseAttributes()
        {
        }

    }
}