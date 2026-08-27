
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterResponseIncludedItemDiscriminatorType
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
    public static class BetaTesterResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaTesterResponseIncludedItemDiscriminatorType.Apps => "apps",
                BetaTesterResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                BetaTesterResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaTesterResponseIncludedItemDiscriminatorType.Apps,
                "betaGroups" => BetaTesterResponseIncludedItemDiscriminatorType.BetaGroups,
                "builds" => BetaTesterResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}