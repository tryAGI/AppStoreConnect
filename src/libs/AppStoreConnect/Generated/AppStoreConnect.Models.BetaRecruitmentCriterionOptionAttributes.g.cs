
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRecruitmentCriterionOptionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamilyOsVersions")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion>? DeviceFamilyOsVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionOptionAttributes" /> class.
        /// </summary>
        /// <param name="deviceFamilyOsVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRecruitmentCriterionOptionAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion>? deviceFamilyOsVersions)
        {
            this.DeviceFamilyOsVersions = deviceFamilyOsVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionOptionAttributes" /> class.
        /// </summary>
        public BetaRecruitmentCriterionOptionAttributes()
        {
        }

    }
}