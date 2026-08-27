
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEncryptionDeclarationCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containsProprietaryCryptography")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContainsProprietaryCryptography { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containsThirdPartyCryptography")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContainsThirdPartyCryptography { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableOnFrenchStore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AvailableOnFrenchStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="appDescription"></param>
        /// <param name="containsProprietaryCryptography"></param>
        /// <param name="containsThirdPartyCryptography"></param>
        /// <param name="availableOnFrenchStore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEncryptionDeclarationCreateRequestDataAttributes(
            string appDescription,
            bool containsProprietaryCryptography,
            bool containsThirdPartyCryptography,
            bool availableOnFrenchStore)
        {
            this.AppDescription = appDescription ?? throw new global::System.ArgumentNullException(nameof(appDescription));
            this.ContainsProprietaryCryptography = containsProprietaryCryptography;
            this.ContainsThirdPartyCryptography = containsThirdPartyCryptography;
            this.AvailableOnFrenchStore = availableOnFrenchStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppEncryptionDeclarationCreateRequestDataAttributes()
        {
        }

    }
}