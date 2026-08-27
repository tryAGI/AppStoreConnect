
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionOfferCodeCustomCodeAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCode")]
        public string? CustomCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfCodes")]
        public int? NumberOfCodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCustomCodeAttributes" /> class.
        /// </summary>
        /// <param name="customCode"></param>
        /// <param name="numberOfCodes"></param>
        /// <param name="createdDate"></param>
        /// <param name="expirationDate"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeCustomCodeAttributes(
            string? customCode,
            int? numberOfCodes,
            global::System.DateTime? createdDate,
            global::System.DateTime? expirationDate,
            bool? active)
        {
            this.CustomCode = customCode;
            this.NumberOfCodes = numberOfCodes;
            this.CreatedDate = createdDate;
            this.ExpirationDate = expirationDate;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCustomCodeAttributes" /> class.
        /// </summary>
        public SubscriptionOfferCodeCustomCodeAttributes()
        {
        }

    }
}