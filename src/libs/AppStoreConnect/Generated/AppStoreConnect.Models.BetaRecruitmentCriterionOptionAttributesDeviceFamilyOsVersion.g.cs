
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamily")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter))]
        public global::AppStoreConnect.DeviceFamily? DeviceFamily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersions")]
        public global::System.Collections.Generic.IList<string>? OsVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion" /> class.
        /// </summary>
        /// <param name="deviceFamily"></param>
        /// <param name="osVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion(
            global::AppStoreConnect.DeviceFamily? deviceFamily,
            global::System.Collections.Generic.IList<string>? osVersions)
        {
            this.DeviceFamily = deviceFamily;
            this.OsVersions = osVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion" /> class.
        /// </summary>
        public BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion()
        {
        }

    }
}