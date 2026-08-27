
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessibilityDeclarationUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessibilityDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessibilityDeclarationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessibilityDeclarationUpdateRequestDataType value)
        {
            return value switch
            {
                AccessibilityDeclarationUpdateRequestDataType.AccessibilityDeclarations => "accessibilityDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessibilityDeclarationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AccessibilityDeclarationUpdateRequestDataType.AccessibilityDeclarations,
                _ => null,
            };
        }
    }
}