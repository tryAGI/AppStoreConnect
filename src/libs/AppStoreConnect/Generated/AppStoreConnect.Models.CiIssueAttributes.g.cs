
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiIssueAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiIssueAttributesIssueTypeJsonConverter))]
        public global::AppStoreConnect.CiIssueAttributesIssueType? IssueType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSource")]
        public global::AppStoreConnect.FileLocation? FileSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiIssueAttributes" /> class.
        /// </summary>
        /// <param name="issueType"></param>
        /// <param name="message"></param>
        /// <param name="fileSource"></param>
        /// <param name="category"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiIssueAttributes(
            global::AppStoreConnect.CiIssueAttributesIssueType? issueType,
            string? message,
            global::AppStoreConnect.FileLocation? fileSource,
            string? category)
        {
            this.IssueType = issueType;
            this.Message = message;
            this.FileSource = fileSource;
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiIssueAttributes" /> class.
        /// </summary>
        public CiIssueAttributes()
        {
        }

    }
}