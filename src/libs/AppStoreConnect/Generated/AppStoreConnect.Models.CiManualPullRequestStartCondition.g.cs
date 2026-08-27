
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiManualPullRequestStartCondition
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiManualPullRequestStartCondition" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiManualPullRequestStartCondition(
            global::AppStoreConnect.CiBranchPatterns? source,
            global::AppStoreConnect.CiBranchPatterns? destination)
        {
            this.Source = source;
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiManualPullRequestStartCondition" /> class.
        /// </summary>
        public CiManualPullRequestStartCondition()
        {
        }

    }
}