
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceScheduleRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppPriceScheduleRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseTerritory")]
        public global::AppStoreConnect.AppPriceScheduleRelationshipsBaseTerritory? BaseTerritory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualPrices")]
        public global::AppStoreConnect.AppPriceScheduleRelationshipsManualPrices? ManualPrices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticPrices")]
        public global::AppStoreConnect.AppPriceScheduleRelationshipsAutomaticPrices? AutomaticPrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="baseTerritory"></param>
        /// <param name="manualPrices"></param>
        /// <param name="automaticPrices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPriceScheduleRelationships(
            global::AppStoreConnect.AppPriceScheduleRelationshipsApp? app,
            global::AppStoreConnect.AppPriceScheduleRelationshipsBaseTerritory? baseTerritory,
            global::AppStoreConnect.AppPriceScheduleRelationshipsManualPrices? manualPrices,
            global::AppStoreConnect.AppPriceScheduleRelationshipsAutomaticPrices? automaticPrices)
        {
            this.App = app;
            this.BaseTerritory = baseTerritory;
            this.ManualPrices = manualPrices;
            this.AutomaticPrices = automaticPrices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleRelationships" /> class.
        /// </summary>
        public AppPriceScheduleRelationships()
        {
        }

    }
}