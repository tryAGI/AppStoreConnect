
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetCollectionFilterProductTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Framework,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsGetCollectionFilterProductTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionFilterProductTypeItem value)
        {
            return value switch
            {
                CiProductsGetCollectionFilterProductTypeItem.App => "APP",
                CiProductsGetCollectionFilterProductTypeItem.Framework => "FRAMEWORK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionFilterProductTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP" => CiProductsGetCollectionFilterProductTypeItem.App,
                "FRAMEWORK" => CiProductsGetCollectionFilterProductTypeItem.Framework,
                _ => null,
            };
        }
    }
}