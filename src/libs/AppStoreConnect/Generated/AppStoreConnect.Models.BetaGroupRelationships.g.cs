
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaGroupRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.BetaGroupRelationshipsApp? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.BetaGroupRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaTesters")]
        public global::AppStoreConnect.BetaGroupRelationshipsBetaTesters? BetaTesters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaRecruitmentCriteria")]
        public global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteria? BetaRecruitmentCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaRecruitmentCriterionCompatibleBuildCheck")]
        public global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriterionCompatibleBuildCheck? BetaRecruitmentCriterionCompatibleBuildCheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="builds"></param>
        /// <param name="betaTesters"></param>
        /// <param name="betaRecruitmentCriteria"></param>
        /// <param name="betaRecruitmentCriterionCompatibleBuildCheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupRelationships(
            global::AppStoreConnect.BetaGroupRelationshipsApp? app,
            global::AppStoreConnect.BetaGroupRelationshipsBuilds? builds,
            global::AppStoreConnect.BetaGroupRelationshipsBetaTesters? betaTesters,
            global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteria? betaRecruitmentCriteria,
            global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriterionCompatibleBuildCheck? betaRecruitmentCriterionCompatibleBuildCheck)
        {
            this.App = app;
            this.Builds = builds;
            this.BetaTesters = betaTesters;
            this.BetaRecruitmentCriteria = betaRecruitmentCriteria;
            this.BetaRecruitmentCriterionCompatibleBuildCheck = betaRecruitmentCriterionCompatibleBuildCheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupRelationships" /> class.
        /// </summary>
        public BetaGroupRelationships()
        {
        }

    }
}