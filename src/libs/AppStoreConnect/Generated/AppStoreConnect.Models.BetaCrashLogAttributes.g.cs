
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCrashLogAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logText")]
        public string? LogText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCrashLogAttributes" /> class.
        /// </summary>
        /// <param name="logText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCrashLogAttributes(
            string? logText)
        {
            this.LogText = logText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCrashLogAttributes" /> class.
        /// </summary>
        public BetaCrashLogAttributes()
        {
        }

    }
}