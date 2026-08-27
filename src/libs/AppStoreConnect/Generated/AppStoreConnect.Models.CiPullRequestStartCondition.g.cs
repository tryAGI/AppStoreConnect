
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiPullRequestStartCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::AppStoreConnect.CiBranchPatterns? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public global::AppStoreConnect.CiBranchPatterns? Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesAndFoldersRule")]
        public global::AppStoreConnect.CiFilesAndFoldersRule? FilesAndFoldersRule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoCancel")]
        public bool? AutoCancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiPullRequestStartCondition" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="filesAndFoldersRule"></param>
        /// <param name="autoCancel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiPullRequestStartCondition(
            global::AppStoreConnect.CiBranchPatterns? source,
            global::AppStoreConnect.CiBranchPatterns? destination,
            global::AppStoreConnect.CiFilesAndFoldersRule? filesAndFoldersRule,
            bool? autoCancel)
        {
            this.Source = source;
            this.Destination = destination;
            this.FilesAndFoldersRule = filesAndFoldersRule;
            this.AutoCancel = autoCancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiPullRequestStartCondition" /> class.
        /// </summary>
        public CiPullRequestStartCondition()
        {
        }

    }
}