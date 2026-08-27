
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRecruitmentCriterionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedDate")]
        public global::System.DateTime? LastModifiedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamilyOsVersionFilters")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamilyOsVersionFilter>? DeviceFamilyOsVersionFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionAttributes" /> class.
        /// </summary>
        /// <param name="lastModifiedDate"></param>
        /// <param name="deviceFamilyOsVersionFilters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRecruitmentCriterionAttributes(
            global::System.DateTime? lastModifiedDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamilyOsVersionFilter>? deviceFamilyOsVersionFilters)
        {
            this.LastModifiedDate = lastModifiedDate;
            this.DeviceFamilyOsVersionFilters = deviceFamilyOsVersionFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionAttributes" /> class.
        /// </summary>
        public BetaRecruitmentCriterionAttributes()
        {
        }

    }
}