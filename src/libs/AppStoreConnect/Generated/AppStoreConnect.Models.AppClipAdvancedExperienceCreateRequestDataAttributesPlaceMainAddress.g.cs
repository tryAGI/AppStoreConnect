
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress
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
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddressStructuredAddress? StructuredAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress" /> class.
        /// </summary>
        /// <param name="fullAddress"></param>
        /// <param name="structuredAddress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress(
            string? fullAddress,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddressStructuredAddress? structuredAddress)
        {
            this.FullAddress = fullAddress;
            this.StructuredAddress = structuredAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress()
        {
        }

    }
}