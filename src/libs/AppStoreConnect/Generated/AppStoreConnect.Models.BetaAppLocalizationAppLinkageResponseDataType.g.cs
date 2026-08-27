
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppLocalizationAppLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationAppLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationAppLinkageResponseDataType value)
        {
            return value switch
            {
                BetaAppLocalizationAppLinkageResponseDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationAppLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaAppLocalizationAppLinkageResponseDataType.Apps,
                _ => null,
            };
        }
    }
}