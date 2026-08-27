
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewResponseV1CreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1CreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="responseBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewResponseV1CreateRequestDataAttributes(
            string responseBody)
        {
            this.ResponseBody = responseBody ?? throw new global::System.ArgumentNullException(nameof(responseBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1CreateRequestDataAttributes" /> class.
        /// </summary>
        public CustomerReviewResponseV1CreateRequestDataAttributes()
        {
        }

    }
}