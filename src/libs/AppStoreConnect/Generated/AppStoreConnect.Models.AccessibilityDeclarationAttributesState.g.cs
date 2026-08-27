
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessibilityDeclarationAttributesState
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Published,
        /// <summary>
        /// 
        /// </summary>
        Replaced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessibilityDeclarationAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessibilityDeclarationAttributesState value)
        {
            return value switch
            {
                AccessibilityDeclarationAttributesState.Draft => "DRAFT",
                AccessibilityDeclarationAttributesState.Published => "PUBLISHED",
                AccessibilityDeclarationAttributesState.Replaced => "REPLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessibilityDeclarationAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "DRAFT" => AccessibilityDeclarationAttributesState.Draft,
                "PUBLISHED" => AccessibilityDeclarationAttributesState.Published,
                "REPLACED" => AccessibilityDeclarationAttributesState.Replaced,
                _ => null,
            };
        }
    }
}