
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusid,
        /// <summary>
        ///
        /// </summary>
        Minusidentifier,
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        Identifier,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetCollectionSortItem value)
        {
            return value switch
            {
                PassTypeIdsGetCollectionSortItem.Minusid => "-id",
                PassTypeIdsGetCollectionSortItem.Minusidentifier => "-identifier",
                PassTypeIdsGetCollectionSortItem.Minusname => "-name",
                PassTypeIdsGetCollectionSortItem.Id => "id",
                PassTypeIdsGetCollectionSortItem.Identifier => "identifier",
                PassTypeIdsGetCollectionSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-id" => PassTypeIdsGetCollectionSortItem.Minusid,
                "-identifier" => PassTypeIdsGetCollectionSortItem.Minusidentifier,
                "-name" => PassTypeIdsGetCollectionSortItem.Minusname,
                "id" => PassTypeIdsGetCollectionSortItem.Id,
                "identifier" => PassTypeIdsGetCollectionSortItem.Identifier,
                "name" => PassTypeIdsGetCollectionSortItem.Name,
                _ => null,
            };
        }
    }
}