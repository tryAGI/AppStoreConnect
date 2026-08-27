
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessibilityDeclarationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessibilityDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessibilityDeclarationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessibilityDeclarationCreateRequestDataType value)
        {
            return value switch
            {
                AccessibilityDeclarationCreateRequestDataType.AccessibilityDeclarations => "accessibilityDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessibilityDeclarationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AccessibilityDeclarationCreateRequestDataType.AccessibilityDeclarations,
                _ => null,
            };
        }
    }
}