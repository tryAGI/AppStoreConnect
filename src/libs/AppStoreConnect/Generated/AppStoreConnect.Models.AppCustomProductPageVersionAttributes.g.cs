
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageVersionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionAttributesStateJsonConverter))]
        public global::AppStoreConnect.AppCustomProductPageVersionAttributesState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepLink")]
        public string? DeepLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionAttributes" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="state"></param>
        /// <param name="deepLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageVersionAttributes(
            string? version,
            global::AppStoreConnect.AppCustomProductPageVersionAttributesState? state,
            string? deepLink)
        {
            this.Version = version;
            this.State = state;
            this.DeepLink = deepLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionAttributes" /> class.
        /// </summary>
        public AppCustomProductPageVersionAttributes()
        {
        }

    }
}