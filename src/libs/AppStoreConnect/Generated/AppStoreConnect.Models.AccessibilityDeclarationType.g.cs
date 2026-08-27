
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessibilityDeclarationType
    {
        /// <summary>
        ///
        /// </summary>
        AccessibilityDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessibilityDeclarationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessibilityDeclarationType value)
        {
            return value switch
            {
                AccessibilityDeclarationType.AccessibilityDeclarations => "accessibilityDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessibilityDeclarationType? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AccessibilityDeclarationType.AccessibilityDeclarations,
                _ => null,
            };
        }
    }
}