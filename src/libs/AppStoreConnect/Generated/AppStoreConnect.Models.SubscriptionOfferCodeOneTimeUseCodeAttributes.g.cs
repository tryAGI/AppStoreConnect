
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionOfferCodeOneTimeUseCodeAttributes
    {
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
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeAttributes" /> class.
        /// </summary>
        /// <param name="numberOfCodes"></param>
        /// <param name="createdDate"></param>
        /// <param name="expirationDate"></param>
        /// <param name="active"></param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeOneTimeUseCodeAttributes(
            int? numberOfCodes,
            global::System.DateTime? createdDate,
            global::System.DateTime? expirationDate,
            bool? active,
            global::AppStoreConnect.OfferCodeEnvironment? environment)
        {
            this.NumberOfCodes = numberOfCodes;
            this.CreatedDate = createdDate;
            this.ExpirationDate = expirationDate;
            this.Active = active;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeAttributes" /> class.
        /// </summary>
        public SubscriptionOfferCodeOneTimeUseCodeAttributes()
        {
        }

    }
}