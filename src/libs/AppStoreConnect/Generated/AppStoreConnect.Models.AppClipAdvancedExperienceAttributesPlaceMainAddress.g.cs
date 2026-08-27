
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceAttributesPlaceMainAddress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullAddress")]
        public string? FullAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredAddress")]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress? StructuredAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddress" /> class.
        /// </summary>
        /// <param name="fullAddress"></param>
        /// <param name="structuredAddress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceAttributesPlaceMainAddress(
            string? fullAddress,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress? structuredAddress)
        {
            this.FullAddress = fullAddress;
            this.StructuredAddress = structuredAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddress" /> class.
        /// </summary>
        public AppClipAdvancedExperienceAttributesPlaceMainAddress()
        {
        }

    }
}