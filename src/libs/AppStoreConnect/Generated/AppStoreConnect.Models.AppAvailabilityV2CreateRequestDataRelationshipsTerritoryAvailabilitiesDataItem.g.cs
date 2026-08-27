
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemTypeJsonConverter))]
        public global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem(
            string id,
            global::AppStoreConnect.AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem" /> class.
        /// </summary>
        public AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem()
        {
        }

    }
}