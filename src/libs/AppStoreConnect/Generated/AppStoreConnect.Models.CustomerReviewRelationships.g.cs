
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::AppStoreConnect.CustomerReviewRelationshipsResponse? Response { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewTerritory")]
        public global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritory? ReviewTerritory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewRelationships" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="reviewTerritory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewRelationships(
            global::AppStoreConnect.CustomerReviewRelationshipsResponse? response,
            global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritory? reviewTerritory)
        {
            this.Response = response;
            this.ReviewTerritory = reviewTerritory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewRelationships" /> class.
        /// </summary>
        public CustomerReviewRelationships()
        {
        }

    }
}