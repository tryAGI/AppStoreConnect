
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceUpdateRequestDataAttributesPlace
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeId")]
        public string? PlaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        public global::System.Collections.Generic.IList<string>? Names { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mainAddress")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddress? MainAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayPoint")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint? DisplayPoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapAction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapActionJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction? MapAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationship")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationshipJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship? Relationship { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homePage")]
        public string? HomePage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributesPlace" /> class.
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="names"></param>
        /// <param name="mainAddress"></param>
        /// <param name="displayPoint"></param>
        /// <param name="mapAction"></param>
        /// <param name="relationship"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="homePage"></param>
        /// <param name="categories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceUpdateRequestDataAttributesPlace(
            string? placeId,
            global::System.Collections.Generic.IList<string>? names,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddress? mainAddress,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint? displayPoint,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction? mapAction,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship? relationship,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumber? phoneNumber,
            string? homePage,
            global::System.Collections.Generic.IList<string>? categories)
        {
            this.PlaceId = placeId;
            this.Names = names;
            this.MainAddress = mainAddress;
            this.DisplayPoint = displayPoint;
            this.MapAction = mapAction;
            this.Relationship = relationship;
            this.PhoneNumber = phoneNumber;
            this.HomePage = homePage;
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributesPlace" /> class.
        /// </summary>
        public AppClipAdvancedExperienceUpdateRequestDataAttributesPlace()
        {
        }

    }
}