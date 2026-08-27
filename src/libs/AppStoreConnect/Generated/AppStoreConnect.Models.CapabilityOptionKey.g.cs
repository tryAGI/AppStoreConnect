
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CapabilityOptionKey
    {
        /// <summary>
        /// 
        /// </summary>
        CompleteProtection,
        /// <summary>
        /// 
        /// </summary>
        PrimaryAppConsent,
        /// <summary>
        /// 
        /// </summary>
        ProtectedUnlessOpen,
        /// <summary>
        /// 
        /// </summary>
        ProtectedUntilFirstUserAuth,
        /// <summary>
        /// 
        /// </summary>
        Xcode5,
        /// <summary>
        /// 
        /// </summary>
        Xcode6,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilityOptionKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilityOptionKey value)
        {
            return value switch
            {
                CapabilityOptionKey.CompleteProtection => "COMPLETE_PROTECTION",
                CapabilityOptionKey.PrimaryAppConsent => "PRIMARY_APP_CONSENT",
                CapabilityOptionKey.ProtectedUnlessOpen => "PROTECTED_UNLESS_OPEN",
                CapabilityOptionKey.ProtectedUntilFirstUserAuth => "PROTECTED_UNTIL_FIRST_USER_AUTH",
                CapabilityOptionKey.Xcode5 => "XCODE_5",
                CapabilityOptionKey.Xcode6 => "XCODE_6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilityOptionKey? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE_PROTECTION" => CapabilityOptionKey.CompleteProtection,
                "PRIMARY_APP_CONSENT" => CapabilityOptionKey.PrimaryAppConsent,
                "PROTECTED_UNLESS_OPEN" => CapabilityOptionKey.ProtectedUnlessOpen,
                "PROTECTED_UNTIL_FIRST_USER_AUTH" => CapabilityOptionKey.ProtectedUntilFirstUserAuth,
                "XCODE_5" => CapabilityOptionKey.Xcode5,
                "XCODE_6" => CapabilityOptionKey.Xcode6,
                _ => null,
            };
        }
    }
}