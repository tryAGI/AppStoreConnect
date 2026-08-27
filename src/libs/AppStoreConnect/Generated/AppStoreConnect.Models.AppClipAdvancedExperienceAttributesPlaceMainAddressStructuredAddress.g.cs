
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streetAddress")]
        public global::System.Collections.Generic.IList<string>? StreetAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("floor")]
        public string? Floor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neighborhood")]
        public string? Neighborhood { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stateProvince")]
        public string? StateProvince { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress" /> class.
        /// </summary>
        /// <param name="streetAddress"></param>
        /// <param name="floor"></param>
        /// <param name="neighborhood"></param>
        /// <param name="locality"></param>
        /// <param name="stateProvince"></param>
        /// <param name="postalCode"></param>
        /// <param name="countryCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress(
            global::System.Collections.Generic.IList<string>? streetAddress,
            string? floor,
            string? neighborhood,
            string? locality,
            string? stateProvince,
            string? postalCode,
            string? countryCode)
        {
            this.StreetAddress = streetAddress;
            this.Floor = floor;
            this.Neighborhood = neighborhood;
            this.Locality = locality;
            this.StateProvince = stateProvince;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress" /> class.
        /// </summary>
        public AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress()
        {
        }

    }
}