
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewSummarizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewSummarizationRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewSummarizationRelationships(
            global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritory? territory)
        {
            this.Territory = territory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewSummarizationRelationships" /> class.
        /// </summary>
        public CustomerReviewSummarizationRelationships()
        {
        }

    }
}