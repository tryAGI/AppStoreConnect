
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointCoordinates? Coordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSourceJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint(
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointCoordinates? coordinates,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource? source)
        {
            this.Coordinates = coordinates;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint()
        {
        }

    }
}