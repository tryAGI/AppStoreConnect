
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRecruitmentCriterionCompatibleBuildCheckAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasCompatibleBuild")]
        public bool? HasCompatibleBuild { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionCompatibleBuildCheckAttributes" /> class.
        /// </summary>
        /// <param name="hasCompatibleBuild"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRecruitmentCriterionCompatibleBuildCheckAttributes(
            bool? hasCompatibleBuild)
        {
            this.HasCompatibleBuild = hasCompatibleBuild;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionCompatibleBuildCheckAttributes" /> class.
        /// </summary>
        public BetaRecruitmentCriterionCompatibleBuildCheckAttributes()
        {
        }

    }
}