
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Replaced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem.Completed => "COMPLETED",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem.Replaced => "REPLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem.Completed,
                "REPLACED" => AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem.Replaced,
                _ => null,
            };
        }
    }
}