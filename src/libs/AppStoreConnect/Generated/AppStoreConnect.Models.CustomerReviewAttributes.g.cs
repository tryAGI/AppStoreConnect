
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewerNickname")]
        public string? ReviewerNickname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter))]
        public global::AppStoreConnect.TerritoryCode? Territory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewAttributes" /> class.
        /// </summary>
        /// <param name="rating"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="reviewerNickname"></param>
        /// <param name="createdDate"></param>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewAttributes(
            int? rating,
            string? title,
            string? body,
            string? reviewerNickname,
            global::System.DateTime? createdDate,
            global::AppStoreConnect.TerritoryCode? territory)
        {
            this.Rating = rating;
            this.Title = title;
            this.Body = body;
            this.ReviewerNickname = reviewerNickname;
            this.CreatedDate = createdDate;
            this.Territory = territory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewAttributes" /> class.
        /// </summary>
        public CustomerReviewAttributes()
        {
        }

    }
}