
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnosticLogCallStackNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleCount")]
        public int? SampleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlameFrame")]
        public bool? IsBlameFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symbolName")]
        public string? SymbolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightsCategory")]
        public string? InsightsCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offsetIntoSymbol")]
        public string? OffsetIntoSymbol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binaryName")]
        public string? BinaryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binaryUUID")]
        public string? BinaryUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineNumber")]
        public string? LineNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offsetIntoBinaryTextSegment")]
        public string? OffsetIntoBinaryTextSegment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawFrame")]
        public string? RawFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subFrames")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogCallStackNode>? SubFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogCallStackNode" /> class.
        /// </summary>
        /// <param name="sampleCount"></param>
        /// <param name="isBlameFrame"></param>
        /// <param name="symbolName"></param>
        /// <param name="insightsCategory"></param>
        /// <param name="offsetIntoSymbol"></param>
        /// <param name="binaryName"></param>
        /// <param name="fileName"></param>
        /// <param name="binaryUUID"></param>
        /// <param name="lineNumber"></param>
        /// <param name="address"></param>
        /// <param name="offsetIntoBinaryTextSegment"></param>
        /// <param name="rawFrame"></param>
        /// <param name="subFrames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogCallStackNode(
            int? sampleCount,
            bool? isBlameFrame,
            string? symbolName,
            string? insightsCategory,
            string? offsetIntoSymbol,
            string? binaryName,
            string? fileName,
            string? binaryUUID,
            string? lineNumber,
            string? address,
            string? offsetIntoBinaryTextSegment,
            string? rawFrame,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogCallStackNode>? subFrames)
        {
            this.SampleCount = sampleCount;
            this.IsBlameFrame = isBlameFrame;
            this.SymbolName = symbolName;
            this.InsightsCategory = insightsCategory;
            this.OffsetIntoSymbol = offsetIntoSymbol;
            this.BinaryName = binaryName;
            this.FileName = fileName;
            this.BinaryUUID = binaryUUID;
            this.LineNumber = lineNumber;
            this.Address = address;
            this.OffsetIntoBinaryTextSegment = offsetIntoBinaryTextSegment;
            this.RawFrame = rawFrame;
            this.SubFrames = subFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogCallStackNode" /> class.
        /// </summary>
        public DiagnosticLogCallStackNode()
        {
        }

    }
}