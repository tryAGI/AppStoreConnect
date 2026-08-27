
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPricePointV3Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppPricePointV3RelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equalizations")]
        public global::AppStoreConnect.AppPricePointV3RelationshipsEqualizations? Equalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.AppPricePointV3RelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPricePointV3Relationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="equalizations"></param>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPricePointV3Relationships(
            global::AppStoreConnect.AppPricePointV3RelationshipsApp? app,
            global::AppStoreConnect.AppPricePointV3RelationshipsEqualizations? equalizations,
            global::AppStoreConnect.AppPricePointV3RelationshipsTerritory? territory)
        {
            this.App = app;
            this.Equalizations = equalizations;
            this.Territory = territory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPricePointV3Relationships" /> class.
        /// </summary>
        public AppPricePointV3Relationships()
        {
        }

    }
}