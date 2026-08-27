
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceScheduleCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseTerritory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory BaseTerritory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualPrices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPrices ManualPrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="baseTerritory"></param>
        /// <param name="manualPrices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPriceScheduleCreateRequestDataRelationships(
            global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory baseTerritory,
            global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPrices manualPrices)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.BaseTerritory = baseTerritory ?? throw new global::System.ArgumentNullException(nameof(baseTerritory));
            this.ManualPrices = manualPrices ?? throw new global::System.ArgumentNullException(nameof(manualPrices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppPriceScheduleCreateRequestDataRelationships()
        {
        }

    }
}