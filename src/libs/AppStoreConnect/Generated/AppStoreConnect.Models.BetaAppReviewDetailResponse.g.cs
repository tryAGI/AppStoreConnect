
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppReviewDetailResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaAppReviewDetail Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.App>? Included { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.DocumentLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewDetailResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppReviewDetailResponse(
            global::AppStoreConnect.BetaAppReviewDetail data,
            global::AppStoreConnect.DocumentLinks links,
            global::System.Collections.Generic.IList<global::AppStoreConnect.App>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewDetailResponse" /> class.
        /// </summary>
        public BetaAppReviewDetailResponse()
        {
        }

    }
}