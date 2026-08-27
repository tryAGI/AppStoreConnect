
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppAvailabilityV2Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryAvailabilities")]
        public global::AppStoreConnect.AppAvailabilityV2RelationshipsTerritoryAvailabilities? TerritoryAvailabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2Relationships" /> class.
        /// </summary>
        /// <param name="territoryAvailabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAvailabilityV2Relationships(
            global::AppStoreConnect.AppAvailabilityV2RelationshipsTerritoryAvailabilities? territoryAvailabilities)
        {
            this.TerritoryAvailabilities = territoryAvailabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2Relationships" /> class.
        /// </summary>
        public AppAvailabilityV2Relationships()
        {
        }

    }
}