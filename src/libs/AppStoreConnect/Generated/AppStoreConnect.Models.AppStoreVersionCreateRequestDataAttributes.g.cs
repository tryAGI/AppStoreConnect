
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.Platform Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReviewTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType? ReviewType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReleaseTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType? ReleaseType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="versionString"></param>
        /// <param name="copyright"></param>
        /// <param name="reviewType"></param>
        /// <param name="releaseType"></param>
        /// <param name="earliestReleaseDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionCreateRequestDataAttributes(
            global::AppStoreConnect.Platform platform,
            string versionString,
            string? copyright,
            global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType? reviewType,
            global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType? releaseType,
            global::System.DateTime? earliestReleaseDate)
        {
            this.Platform = platform;
            this.VersionString = versionString ?? throw new global::System.ArgumentNullException(nameof(versionString));
            this.Copyright = copyright;
            this.ReviewType = reviewType;
            this.ReleaseType = releaseType;
            this.EarliestReleaseDate = earliestReleaseDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionCreateRequestDataAttributes()
        {
        }

    }
}