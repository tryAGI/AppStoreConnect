
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppPriceV2InlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPricePoint")]
        public global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePoint? AppPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2InlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="appPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPriceV2InlineCreateRelationships(
            global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePoint? appPricePoint)
        {
            this.AppPricePoint = appPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2InlineCreateRelationships" /> class.
        /// </summary>
        public AppPriceV2InlineCreateRelationships()
        {
        }

    }
}