
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FileLocation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileLocation" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lineNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileLocation(
            string? path,
            int? lineNumber)
        {
            this.Path = path;
            this.LineNumber = lineNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileLocation" /> class.
        /// </summary>
        public FileLocation()
        {
        }

    }
}