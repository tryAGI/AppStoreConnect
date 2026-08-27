
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem
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
    public static class AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Draft => "DRAFT",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Published => "PUBLISHED",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Replaced => "REPLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "DRAFT" => AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Draft,
                "PUBLISHED" => AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Published,
                "REPLACED" => AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem.Replaced,
                _ => null,
            };
        }
    }
}