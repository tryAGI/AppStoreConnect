
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiBranchPatterns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAllMatch")]
        public bool? IsAllMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>? Patterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBranchPatterns" /> class.
        /// </summary>
        /// <param name="isAllMatch"></param>
        /// <param name="patterns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBranchPatterns(
            bool? isAllMatch,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>? patterns)
        {
            this.IsAllMatch = isAllMatch;
            this.Patterns = patterns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBranchPatterns" /> class.
        /// </summary>
        public CiBranchPatterns()
        {
        }

    }
}