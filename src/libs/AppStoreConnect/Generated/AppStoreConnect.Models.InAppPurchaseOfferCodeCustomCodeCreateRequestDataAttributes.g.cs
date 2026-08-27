
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeCustomCodeCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfCodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="customCode"></param>
        /// <param name="numberOfCodes"></param>
        /// <param name="expirationDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeCustomCodeCreateRequestDataAttributes(
            string customCode,
            int numberOfCodes,
            global::System.DateTime? expirationDate)
        {
            this.CustomCode = customCode ?? throw new global::System.ArgumentNullException(nameof(customCode));
            this.NumberOfCodes = numberOfCodes;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeCustomCodeCreateRequestDataAttributes()
        {
        }

    }
}