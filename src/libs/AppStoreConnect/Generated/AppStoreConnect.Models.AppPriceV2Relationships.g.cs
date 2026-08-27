
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPricePoint")]
        public global::AppStoreConnect.AppPriceV2RelationshipsAppPricePoint? AppPricePoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.AppPriceV2RelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2Relationships" /> class.
        /// </summary>
        /// <param name="appPricePoint"></param>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPriceV2Relationships(
            global::AppStoreConnect.AppPriceV2RelationshipsAppPricePoint? appPricePoint,
            global::AppStoreConnect.AppPriceV2RelationshipsTerritory? territory)
        {
            this.AppPricePoint = appPricePoint;
            this.Territory = territory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceV2Relationships" /> class.
        /// </summary>
        public AppPriceV2Relationships()
        {
        }

    }
}