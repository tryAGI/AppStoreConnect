
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionAttributesState
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
    public static class AlternativeDistributionPackageVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionAttributesState value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionAttributesState.Completed => "COMPLETED",
                AlternativeDistributionPackageVersionAttributesState.Replaced => "REPLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AlternativeDistributionPackageVersionAttributesState.Completed,
                "REPLACED" => AlternativeDistributionPackageVersionAttributesState.Replaced,
                _ => null,
            };
        }
    }
}