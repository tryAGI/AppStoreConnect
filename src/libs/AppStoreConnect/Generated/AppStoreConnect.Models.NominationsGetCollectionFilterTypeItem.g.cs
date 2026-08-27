
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetCollectionFilterTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppEnhancements,
        /// <summary>
        /// 
        /// </summary>
        AppLaunch,
        /// <summary>
        /// 
        /// </summary>
        NewContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetCollectionFilterTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFilterTypeItem value)
        {
            return value switch
            {
                NominationsGetCollectionFilterTypeItem.AppEnhancements => "APP_ENHANCEMENTS",
                NominationsGetCollectionFilterTypeItem.AppLaunch => "APP_LAUNCH",
                NominationsGetCollectionFilterTypeItem.NewContent => "NEW_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFilterTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_ENHANCEMENTS" => NominationsGetCollectionFilterTypeItem.AppEnhancements,
                "APP_LAUNCH" => NominationsGetCollectionFilterTypeItem.AppLaunch,
                "NEW_CONTENT" => NominationsGetCollectionFilterTypeItem.NewContent,
                _ => null,
            };
        }
    }
}