
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreReviewDetailUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactFirstName")]
        public string? ContactFirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactLastName")]
        public string? ContactLastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactPhone")]
        public string? ContactPhone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactEmail")]
        public string? ContactEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demoAccountName")]
        public string? DemoAccountName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demoAccountPassword")]
        public string? DemoAccountPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demoAccountRequired")]
        public bool? DemoAccountRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="contactFirstName"></param>
        /// <param name="contactLastName"></param>
        /// <param name="contactPhone"></param>
        /// <param name="contactEmail"></param>
        /// <param name="demoAccountName"></param>
        /// <param name="demoAccountPassword"></param>
        /// <param name="demoAccountRequired"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreReviewDetailUpdateRequestDataAttributes(
            string? contactFirstName,
            string? contactLastName,
            string? contactPhone,
            string? contactEmail,
            string? demoAccountName,
            string? demoAccountPassword,
            bool? demoAccountRequired,
            string? notes)
        {
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactPhone = contactPhone;
            this.ContactEmail = contactEmail;
            this.DemoAccountName = demoAccountName;
            this.DemoAccountPassword = demoAccountPassword;
            this.DemoAccountRequired = demoAccountRequired;
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreReviewDetailUpdateRequestDataAttributes()
        {
        }

    }
}