
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointCoordinates? Coordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSourceJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint(
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointCoordinates? coordinates,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource? source)
        {
            this.Coordinates = coordinates;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        public AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint()
        {
        }

    }
}