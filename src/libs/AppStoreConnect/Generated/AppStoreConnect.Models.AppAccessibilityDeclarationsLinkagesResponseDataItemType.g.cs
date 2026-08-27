
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAccessibilityDeclarationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessibilityDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAccessibilityDeclarationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAccessibilityDeclarationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAccessibilityDeclarationsLinkagesResponseDataItemType.AccessibilityDeclarations => "accessibilityDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAccessibilityDeclarationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppAccessibilityDeclarationsLinkagesResponseDataItemType.AccessibilityDeclarations,
                _ => null,
            };
        }
    }
}