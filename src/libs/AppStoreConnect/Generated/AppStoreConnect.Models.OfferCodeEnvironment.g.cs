
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum OfferCodeEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Production,
        /// <summary>
        /// 
        /// </summary>
        Sandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OfferCodeEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OfferCodeEnvironment value)
        {
            return value switch
            {
                OfferCodeEnvironment.Production => "PRODUCTION",
                OfferCodeEnvironment.Sandbox => "SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OfferCodeEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "PRODUCTION" => OfferCodeEnvironment.Production,
                "SANDBOX" => OfferCodeEnvironment.Sandbox,
                _ => null,
            };
        }
    }
}