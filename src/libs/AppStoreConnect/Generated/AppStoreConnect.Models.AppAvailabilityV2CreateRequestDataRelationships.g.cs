
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAvailabilityV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryAvailabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities TerritoryAvailabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="territoryAvailabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAvailabilityV2CreateRequestDataRelationships(
            global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities territoryAvailabilities)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.TerritoryAvailabilities = territoryAvailabilities ?? throw new global::System.ArgumentNullException(nameof(territoryAvailabilities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public AppAvailabilityV2CreateRequestDataRelationships()
        {
        }

    }
}