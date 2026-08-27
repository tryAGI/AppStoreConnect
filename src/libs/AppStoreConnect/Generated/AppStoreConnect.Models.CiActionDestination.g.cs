
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiActionDestination
    {
        /// <summary>
        ///
        /// </summary>
        AnyIosDevice,
        /// <summary>
        ///
        /// </summary>
        AnyIosSimulator,
        /// <summary>
        ///
        /// </summary>
        AnyMac,
        /// <summary>
        ///
        /// </summary>
        AnyMacCatalyst,
        /// <summary>
        ///
        /// </summary>
        AnyTvosDevice,
        /// <summary>
        ///
        /// </summary>
        AnyTvosSimulator,
        /// <summary>
        ///
        /// </summary>
        AnyVisionosDevice,
        /// <summary>
        ///
        /// </summary>
        AnyVisionosSimulator,
        /// <summary>
        ///
        /// </summary>
        AnyWatchosDevice,
        /// <summary>
        ///
        /// </summary>
        AnyWatchosSimulator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiActionDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiActionDestination value)
        {
            return value switch
            {
                CiActionDestination.AnyIosDevice => "ANY_IOS_DEVICE",
                CiActionDestination.AnyIosSimulator => "ANY_IOS_SIMULATOR",
                CiActionDestination.AnyMac => "ANY_MAC",
                CiActionDestination.AnyMacCatalyst => "ANY_MAC_CATALYST",
                CiActionDestination.AnyTvosDevice => "ANY_TVOS_DEVICE",
                CiActionDestination.AnyTvosSimulator => "ANY_TVOS_SIMULATOR",
                CiActionDestination.AnyVisionosDevice => "ANY_VISIONOS_DEVICE",
                CiActionDestination.AnyVisionosSimulator => "ANY_VISIONOS_SIMULATOR",
                CiActionDestination.AnyWatchosDevice => "ANY_WATCHOS_DEVICE",
                CiActionDestination.AnyWatchosSimulator => "ANY_WATCHOS_SIMULATOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiActionDestination? ToEnum(string value)
        {
            return value switch
            {
                "ANY_IOS_DEVICE" => CiActionDestination.AnyIosDevice,
                "ANY_IOS_SIMULATOR" => CiActionDestination.AnyIosSimulator,
                "ANY_MAC" => CiActionDestination.AnyMac,
                "ANY_MAC_CATALYST" => CiActionDestination.AnyMacCatalyst,
                "ANY_TVOS_DEVICE" => CiActionDestination.AnyTvosDevice,
                "ANY_TVOS_SIMULATOR" => CiActionDestination.AnyTvosSimulator,
                "ANY_VISIONOS_DEVICE" => CiActionDestination.AnyVisionosDevice,
                "ANY_VISIONOS_SIMULATOR" => CiActionDestination.AnyVisionosSimulator,
                "ANY_WATCHOS_DEVICE" => CiActionDestination.AnyWatchosDevice,
                "ANY_WATCHOS_SIMULATOR" => CiActionDestination.AnyWatchosSimulator,
                _ => null,
            };
        }
    }
}