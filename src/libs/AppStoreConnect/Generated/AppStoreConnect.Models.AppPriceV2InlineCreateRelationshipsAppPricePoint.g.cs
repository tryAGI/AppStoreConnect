
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceV2InlineCreateRelationshipsAppPricePoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2InlineCreateRelationshipsAppPricePoint" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPriceV2InlineCreateRelationshipsAppPricePoint(
            global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2InlineCreateRelationshipsAppPricePoint" /> class.
        /// </summary>
        public AppPriceV2InlineCreateRelationshipsAppPricePoint()
        {
        }

    }
}