
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationsGetInstanceFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationsGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                NominationsGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => NominationsGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}