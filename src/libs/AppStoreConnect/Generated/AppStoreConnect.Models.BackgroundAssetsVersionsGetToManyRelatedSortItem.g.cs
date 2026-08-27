
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusversion,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetsVersionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedSortItem.Minusversion => "-version",
                BackgroundAssetsVersionsGetToManyRelatedSortItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-version" => BackgroundAssetsVersionsGetToManyRelatedSortItem.Minusversion,
                "version" => BackgroundAssetsVersionsGetToManyRelatedSortItem.Version,
                _ => null,
            };
        }
    }
}