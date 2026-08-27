
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedDate")]
        public global::System.DateTime? UploadedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minOsVersion")]
        public string? MinOsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsMinimumSystemVersion")]
        public string? LsMinimumSystemVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computedMinMacOsVersion")]
        public string? ComputedMinMacOsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computedMinVisionOsVersion")]
        public string? ComputedMinVisionOsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconAssetToken")]
        public global::AppStoreConnect.ImageAsset? IconAssetToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateJsonConverter))]
        public global::AppStoreConnect.BuildAttributesProcessingState? ProcessingState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildAudienceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter))]
        public global::AppStoreConnect.BuildAudienceType? BuildAudienceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesNonExemptEncryption")]
        public bool? UsesNonExemptEncryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildAttributes" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="uploadedDate"></param>
        /// <param name="expirationDate"></param>
        /// <param name="expired"></param>
        /// <param name="minOsVersion"></param>
        /// <param name="lsMinimumSystemVersion"></param>
        /// <param name="computedMinMacOsVersion"></param>
        /// <param name="computedMinVisionOsVersion"></param>
        /// <param name="iconAssetToken"></param>
        /// <param name="processingState"></param>
        /// <param name="buildAudienceType"></param>
        /// <param name="usesNonExemptEncryption"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildAttributes(
            string? version,
            global::System.DateTime? uploadedDate,
            global::System.DateTime? expirationDate,
            bool? expired,
            string? minOsVersion,
            string? lsMinimumSystemVersion,
            string? computedMinMacOsVersion,
            string? computedMinVisionOsVersion,
            global::AppStoreConnect.ImageAsset? iconAssetToken,
            global::AppStoreConnect.BuildAttributesProcessingState? processingState,
            global::AppStoreConnect.BuildAudienceType? buildAudienceType,
            bool? usesNonExemptEncryption)
        {
            this.Version = version;
            this.UploadedDate = uploadedDate;
            this.ExpirationDate = expirationDate;
            this.Expired = expired;
            this.MinOsVersion = minOsVersion;
            this.LsMinimumSystemVersion = lsMinimumSystemVersion;
            this.ComputedMinMacOsVersion = computedMinMacOsVersion;
            this.ComputedMinVisionOsVersion = computedMinVisionOsVersion;
            this.IconAssetToken = iconAssetToken;
            this.ProcessingState = processingState;
            this.BuildAudienceType = buildAudienceType;
            this.UsesNonExemptEncryption = usesNonExemptEncryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildAttributes" /> class.
        /// </summary>
        public BuildAttributes()
        {
        }

    }
}