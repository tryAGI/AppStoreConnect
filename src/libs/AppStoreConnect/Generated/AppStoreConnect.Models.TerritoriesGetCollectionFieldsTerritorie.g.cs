
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoriesGetCollectionFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoriesGetCollectionFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoriesGetCollectionFieldsTerritorie value)
        {
            return value switch
            {
                TerritoriesGetCollectionFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoriesGetCollectionFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => TerritoriesGetCollectionFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}