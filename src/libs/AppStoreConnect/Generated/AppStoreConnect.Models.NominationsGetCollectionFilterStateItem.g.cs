
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetCollectionFilterStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetCollectionFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFilterStateItem value)
        {
            return value switch
            {
                NominationsGetCollectionFilterStateItem.Archived => "ARCHIVED",
                NominationsGetCollectionFilterStateItem.Draft => "DRAFT",
                NominationsGetCollectionFilterStateItem.Submitted => "SUBMITTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => NominationsGetCollectionFilterStateItem.Archived,
                "DRAFT" => NominationsGetCollectionFilterStateItem.Draft,
                "SUBMITTED" => NominationsGetCollectionFilterStateItem.Submitted,
                _ => null,
            };
        }
    }
}