
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiActionTestConfigurationKind
    {
        /// <summary>
        /// 
        /// </summary>
        SpecificTestPlans,
        /// <summary>
        /// 
        /// </summary>
        UseSchemeSettings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiActionTestConfigurationKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiActionTestConfigurationKind value)
        {
            return value switch
            {
                CiActionTestConfigurationKind.SpecificTestPlans => "SPECIFIC_TEST_PLANS",
                CiActionTestConfigurationKind.UseSchemeSettings => "USE_SCHEME_SETTINGS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiActionTestConfigurationKind? ToEnum(string value)
        {
            return value switch
            {
                "SPECIFIC_TEST_PLANS" => CiActionTestConfigurationKind.SpecificTestPlans,
                "USE_SCHEME_SETTINGS" => CiActionTestConfigurationKind.UseSchemeSettings,
                _ => null,
            };
        }
    }
}