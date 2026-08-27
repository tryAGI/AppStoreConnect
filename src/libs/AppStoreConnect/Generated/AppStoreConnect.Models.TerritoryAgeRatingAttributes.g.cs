
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TerritoryAgeRatingAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreAgeRatingJsonConverter))]
        public global::AppStoreConnect.AppStoreAgeRating? AppStoreAgeRating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAgeRatingAttributes" /> class.
        /// </summary>
        /// <param name="appStoreAgeRating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerritoryAgeRatingAttributes(
            global::AppStoreConnect.AppStoreAgeRating? appStoreAgeRating)
        {
            this.AppStoreAgeRating = appStoreAgeRating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAgeRatingAttributes" /> class.
        /// </summary>
        public TerritoryAgeRatingAttributes()
        {
        }

    }
}