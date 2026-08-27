
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerReviewResponseV1CreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReview Review { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="review"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewResponseV1CreateRequestDataRelationships(
            global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReview review)
        {
            this.Review = review ?? throw new global::System.ArgumentNullException(nameof(review));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1CreateRequestDataRelationships" /> class.
        /// </summary>
        public CustomerReviewResponseV1CreateRequestDataRelationships()
        {
        }

    }
}