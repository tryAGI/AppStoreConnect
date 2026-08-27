
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndAppAvailabilityPreOrderCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryAvailabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilities TerritoryAvailabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndAppAvailabilityPreOrderCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="territoryAvailabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndAppAvailabilityPreOrderCreateRequestDataRelationships(
            global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilities territoryAvailabilities)
        {
            this.TerritoryAvailabilities = territoryAvailabilities ?? throw new global::System.ArgumentNullException(nameof(territoryAvailabilities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndAppAvailabilityPreOrderCreateRequestDataRelationships" /> class.
        /// </summary>
        public EndAppAvailabilityPreOrderCreateRequestDataRelationships()
        {
        }

    }
}