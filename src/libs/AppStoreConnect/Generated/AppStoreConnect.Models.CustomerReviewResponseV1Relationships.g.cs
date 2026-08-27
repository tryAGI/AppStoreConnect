
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerReviewResponseV1Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        public global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReview? Review { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1Relationships" /> class.
        /// </summary>
        /// <param name="review"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewResponseV1Relationships(
            global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReview? review)
        {
            this.Review = review;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1Relationships" /> class.
        /// </summary>
        public CustomerReviewResponseV1Relationships()
        {
        }

    }
}