
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataAttributes
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.OfferCodeEnvironmentJsonConverter))]
        public global::AppStoreConnect.OfferCodeEnvironment? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="numberOfCodes"></param>
        /// <param name="expirationDate"></param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataAttributes(
            int numberOfCodes,
            global::System.DateTime expirationDate,
            global::AppStoreConnect.OfferCodeEnvironment? environment)
        {
            this.NumberOfCodes = numberOfCodes;
            this.ExpirationDate = expirationDate;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataAttributes()
        {
        }

    }
}