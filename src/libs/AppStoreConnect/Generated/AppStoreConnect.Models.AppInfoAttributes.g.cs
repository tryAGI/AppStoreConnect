
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfoAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionStateJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionState? AppStoreState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppInfoAttributesStateJsonConverter))]
        public global::AppStoreConnect.AppInfoAttributesState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreAgeRatingJsonConverter))]
        public global::AppStoreConnect.AppStoreAgeRating? AppStoreAgeRating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("australiaAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating? AustraliaAgeRating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brazilAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BrazilAgeRatingJsonConverter))]
        public global::AppStoreConnect.BrazilAgeRating? BrazilAgeRating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brazilAgeRatingV2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2JsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2? BrazilAgeRatingV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("franceAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppInfoAttributesFranceAgeRating? FranceAgeRating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("koreaAgeRating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppInfoAttributesKoreaAgeRating? KoreaAgeRating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kidsAgeBand")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.KidsAgeBandJsonConverter))]
        public global::AppStoreConnect.KidsAgeBand? KidsAgeBand { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoAttributes" /> class.
        /// </summary>
        /// <param name="appStoreState"></param>
        /// <param name="state"></param>
        /// <param name="appStoreAgeRating"></param>
        /// <param name="brazilAgeRating"></param>
        /// <param name="kidsAgeBand"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoAttributes(
            global::AppStoreConnect.AppStoreVersionState? appStoreState,
            global::AppStoreConnect.AppInfoAttributesState? state,
            global::AppStoreConnect.AppStoreAgeRating? appStoreAgeRating,
            global::AppStoreConnect.BrazilAgeRating? brazilAgeRating,
            global::AppStoreConnect.KidsAgeBand? kidsAgeBand)
        {
            this.AppStoreState = appStoreState;
            this.State = state;
            this.AppStoreAgeRating = appStoreAgeRating;
            this.BrazilAgeRating = brazilAgeRating;
            this.KidsAgeBand = kidsAgeBand;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoAttributes" /> class.
        /// </summary>
        public AppInfoAttributes()
        {
        }

    }
}