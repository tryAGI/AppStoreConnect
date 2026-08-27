
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEncryptionDeclarationAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appDescription")]
        public string? AppDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesEncryption")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UsesEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exempt")]
        public bool? Exempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containsProprietaryCryptography")]
        public bool? ContainsProprietaryCryptography { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containsThirdPartyCryptography")]
        public bool? ContainsThirdPartyCryptography { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableOnFrenchStore")]
        public bool? AvailableOnFrenchStore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedDate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? UploadedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DocumentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentName")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentType")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEncryptionDeclarationState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter))]
        public global::AppStoreConnect.AppEncryptionDeclarationState? AppEncryptionDeclarationState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeValue")]
        public string? CodeValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationAttributes" /> class.
        /// </summary>
        /// <param name="appDescription"></param>
        /// <param name="createdDate"></param>
        /// <param name="exempt"></param>
        /// <param name="containsProprietaryCryptography"></param>
        /// <param name="containsThirdPartyCryptography"></param>
        /// <param name="availableOnFrenchStore"></param>
        /// <param name="platform"></param>
        /// <param name="appEncryptionDeclarationState"></param>
        /// <param name="codeValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEncryptionDeclarationAttributes(
            string? appDescription,
            global::System.DateTime? createdDate,
            bool? exempt,
            bool? containsProprietaryCryptography,
            bool? containsThirdPartyCryptography,
            bool? availableOnFrenchStore,
            global::AppStoreConnect.Platform? platform,
            global::AppStoreConnect.AppEncryptionDeclarationState? appEncryptionDeclarationState,
            string? codeValue)
        {
            this.AppDescription = appDescription;
            this.CreatedDate = createdDate;
            this.Exempt = exempt;
            this.ContainsProprietaryCryptography = containsProprietaryCryptography;
            this.ContainsThirdPartyCryptography = containsThirdPartyCryptography;
            this.AvailableOnFrenchStore = availableOnFrenchStore;
            this.Platform = platform;
            this.AppEncryptionDeclarationState = appEncryptionDeclarationState;
            this.CodeValue = codeValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationAttributes" /> class.
        /// </summary>
        public AppEncryptionDeclarationAttributes()
        {
        }

    }
}