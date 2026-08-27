
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceAttributesPlace
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
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddress? MainAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayPoint")]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPoint? DisplayPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapAction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceMapActionJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction? MapAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationship")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceRelationshipJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship? Relationship { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumber? PhoneNumber { get; set; }

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
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlace" /> class.
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
        public AppClipAdvancedExperienceAttributesPlace(
            string? placeId,
            global::System.Collections.Generic.IList<string>? names,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddress? mainAddress,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPoint? displayPoint,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction? mapAction,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship? relationship,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumber? phoneNumber,
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
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlace" /> class.
        /// </summary>
        public AppClipAdvancedExperienceAttributesPlace()
        {
        }

    }
}