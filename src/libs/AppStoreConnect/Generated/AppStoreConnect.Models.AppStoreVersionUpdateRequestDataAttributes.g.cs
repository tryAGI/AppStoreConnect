
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionString")]
        public string? VersionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReviewTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType? ReviewType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReleaseTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType? ReleaseType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="versionString"></param>
        /// <param name="copyright"></param>
        /// <param name="reviewType"></param>
        /// <param name="releaseType"></param>
        /// <param name="earliestReleaseDate"></param>
        /// <param name="downloadable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionUpdateRequestDataAttributes(
            string? versionString,
            string? copyright,
            global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType? reviewType,
            global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType? releaseType,
            global::System.DateTime? earliestReleaseDate,
            bool? downloadable)
        {
            this.VersionString = versionString;
            this.Copyright = copyright;
            this.ReviewType = reviewType;
            this.ReleaseType = releaseType;
            this.EarliestReleaseDate = earliestReleaseDate;
            this.Downloadable = downloadable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionUpdateRequestDataAttributes()
        {
        }

    }
}