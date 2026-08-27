
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionString")]
        public string? VersionString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionStateJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionState? AppStoreState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appVersionState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppVersionStateJsonConverter))]
        public global::AppStoreConnect.AppVersionState? AppVersionState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReviewTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionAttributesReviewType? ReviewType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReleaseTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionAttributesReleaseType? ReleaseType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliestReleaseDate")]
        public global::System.DateTime? EarliestReleaseDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesIdfa")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UsesIdfa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="versionString"></param>
        /// <param name="appStoreState"></param>
        /// <param name="appVersionState"></param>
        /// <param name="copyright"></param>
        /// <param name="reviewType"></param>
        /// <param name="releaseType"></param>
        /// <param name="earliestReleaseDate"></param>
        /// <param name="downloadable"></param>
        /// <param name="createdDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionAttributes(
            global::AppStoreConnect.Platform? platform,
            string? versionString,
            global::AppStoreConnect.AppStoreVersionState? appStoreState,
            global::AppStoreConnect.AppVersionState? appVersionState,
            string? copyright,
            global::AppStoreConnect.AppStoreVersionAttributesReviewType? reviewType,
            global::AppStoreConnect.AppStoreVersionAttributesReleaseType? releaseType,
            global::System.DateTime? earliestReleaseDate,
            bool? downloadable,
            global::System.DateTime? createdDate)
        {
            this.Platform = platform;
            this.VersionString = versionString;
            this.AppStoreState = appStoreState;
            this.AppVersionState = appVersionState;
            this.Copyright = copyright;
            this.ReviewType = reviewType;
            this.ReleaseType = releaseType;
            this.EarliestReleaseDate = earliestReleaseDate;
            this.Downloadable = downloadable;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionAttributes" /> class.
        /// </summary>
        public AppStoreVersionAttributes()
        {
        }

    }
}