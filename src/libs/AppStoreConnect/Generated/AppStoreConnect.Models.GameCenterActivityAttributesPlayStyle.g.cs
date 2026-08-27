
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityAttributesPlayStyle
    {
        /// <summary>
        ///
        /// </summary>
        Asynchronous,
        /// <summary>
        ///
        /// </summary>
        Synchronous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityAttributesPlayStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityAttributesPlayStyle value)
        {
            return value switch
            {
                GameCenterActivityAttributesPlayStyle.Asynchronous => "ASYNCHRONOUS",
                GameCenterActivityAttributesPlayStyle.Synchronous => "SYNCHRONOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityAttributesPlayStyle? ToEnum(string value)
        {
            return value switch
            {
                "ASYNCHRONOUS" => GameCenterActivityAttributesPlayStyle.Asynchronous,
                "SYNCHRONOUS" => GameCenterActivityAttributesPlayStyle.Synchronous,
                _ => null,
            };
        }
    }
}