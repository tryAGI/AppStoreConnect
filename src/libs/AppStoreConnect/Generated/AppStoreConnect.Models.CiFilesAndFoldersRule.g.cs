
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiFilesAndFoldersRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeJsonConverter))]
        public global::AppStoreConnect.CiFilesAndFoldersRuleMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchers")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiStartConditionFileMatcher>? Matchers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiFilesAndFoldersRule" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="matchers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiFilesAndFoldersRule(
            global::AppStoreConnect.CiFilesAndFoldersRuleMode? mode,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiStartConditionFileMatcher>? matchers)
        {
            this.Mode = mode;
            this.Matchers = matchers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiFilesAndFoldersRule" /> class.
        /// </summary>
        public CiFilesAndFoldersRule()
        {
        }

    }
}