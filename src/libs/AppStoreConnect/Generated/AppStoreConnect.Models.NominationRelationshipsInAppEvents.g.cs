
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NominationRelationshipsInAppEvents
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::AppStoreConnect.PagingInformation? Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationRelationshipsInAppEvents" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NominationRelationshipsInAppEvents(
            global::AppStoreConnect.PagingInformation? meta,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>? data)
        {
            this.Meta = meta;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationRelationshipsInAppEvents" /> class.
        /// </summary>
        public NominationRelationshipsInAppEvents()
        {
        }

    }
}