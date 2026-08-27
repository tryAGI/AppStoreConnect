
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTestersResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaTestersResponseIncludedItemDiscriminatorType.Apps => "apps",
                BetaTestersResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                BetaTestersResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaTestersResponseIncludedItemDiscriminatorType.Apps,
                "betaGroups" => BetaTestersResponseIncludedItemDiscriminatorType.BetaGroups,
                "builds" => BetaTestersResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}