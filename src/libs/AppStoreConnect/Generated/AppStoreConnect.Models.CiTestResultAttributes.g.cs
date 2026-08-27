
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiTestResultAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("className")]
        public string? ClassName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiTestStatusJsonConverter))]
        public global::AppStoreConnect.CiTestStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSource")]
        public global::AppStoreConnect.FileLocation? FileSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationTestResults")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestResultAttributesDestinationTestResult>? DestinationTestResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestResultAttributes" /> class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="fileSource"></param>
        /// <param name="message"></param>
        /// <param name="destinationTestResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiTestResultAttributes(
            string? className,
            string? name,
            global::AppStoreConnect.CiTestStatus? status,
            global::AppStoreConnect.FileLocation? fileSource,
            string? message,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestResultAttributesDestinationTestResult>? destinationTestResults)
        {
            this.ClassName = className;
            this.Name = name;
            this.Status = status;
            this.FileSource = fileSource;
            this.Message = message;
            this.DestinationTestResults = destinationTestResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestResultAttributes" /> class.
        /// </summary>
        public CiTestResultAttributes()
        {
        }

    }
}