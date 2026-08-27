
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificateType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CertificateType2JsonConverter))]
        public global::AppStoreConnect.CertificateType2? CertificateType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialNumber")]
        public string? SerialNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter))]
        public global::AppStoreConnect.BundleIdPlatform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificateContent")]
        public string? CertificateContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activated")]
        public bool? Activated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="certificateType"></param>
        /// <param name="displayName"></param>
        /// <param name="serialNumber"></param>
        /// <param name="platform"></param>
        /// <param name="expirationDate"></param>
        /// <param name="certificateContent"></param>
        /// <param name="activated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateAttributes(
            string? name,
            global::AppStoreConnect.CertificateType2? certificateType,
            string? displayName,
            string? serialNumber,
            global::AppStoreConnect.BundleIdPlatform? platform,
            global::System.DateTime? expirationDate,
            string? certificateContent,
            bool? activated)
        {
            this.Name = name;
            this.CertificateType = certificateType;
            this.DisplayName = displayName;
            this.SerialNumber = serialNumber;
            this.Platform = platform;
            this.ExpirationDate = expirationDate;
            this.CertificateContent = certificateContent;
            this.Activated = activated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateAttributes" /> class.
        /// </summary>
        public CertificateAttributes()
        {
        }

    }
}