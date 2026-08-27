
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiStartConditionFileMatcher
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory")]
        public string? Directory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiStartConditionFileMatcher" /> class.
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileExtension"></param>
        /// <param name="fileName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiStartConditionFileMatcher(
            string? directory,
            string? fileExtension,
            string? fileName)
        {
            this.Directory = directory;
            this.FileExtension = fileExtension;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiStartConditionFileMatcher" /> class.
        /// </summary>
        public CiStartConditionFileMatcher()
        {
        }

    }
}