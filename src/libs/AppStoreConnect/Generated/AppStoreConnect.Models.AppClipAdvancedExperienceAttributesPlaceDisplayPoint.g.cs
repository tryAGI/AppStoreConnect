
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceAttributesPlaceDisplayPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointCoordinates? Coordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceDisplayPointSourceJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceAttributesPlaceDisplayPoint(
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointCoordinates? coordinates,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource? source)
        {
            this.Coordinates = coordinates;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        public AppClipAdvancedExperienceAttributesPlaceDisplayPoint()
        {
        }

    }
}