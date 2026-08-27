
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRecruitmentCriterionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroup BetaGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="betaGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRecruitmentCriterionCreateRequestDataRelationships(
            global::AppStoreConnect.BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroup betaGroup)
        {
            this.BetaGroup = betaGroup ?? throw new global::System.ArgumentNullException(nameof(betaGroup));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaRecruitmentCriterionCreateRequestDataRelationships()
        {
        }

    }
}