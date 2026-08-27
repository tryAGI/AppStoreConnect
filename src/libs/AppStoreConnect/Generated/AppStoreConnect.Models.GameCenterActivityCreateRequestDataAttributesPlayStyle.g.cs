
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityCreateRequestDataAttributesPlayStyle
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
    public static class GameCenterActivityCreateRequestDataAttributesPlayStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityCreateRequestDataAttributesPlayStyle value)
        {
            return value switch
            {
                GameCenterActivityCreateRequestDataAttributesPlayStyle.Asynchronous => "ASYNCHRONOUS",
                GameCenterActivityCreateRequestDataAttributesPlayStyle.Synchronous => "SYNCHRONOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityCreateRequestDataAttributesPlayStyle? ToEnum(string value)
        {
            return value switch
            {
                "ASYNCHRONOUS" => GameCenterActivityCreateRequestDataAttributesPlayStyle.Asynchronous,
                "SYNCHRONOUS" => GameCenterActivityCreateRequestDataAttributesPlayStyle.Synchronous,
                _ => null,
            };
        }
    }
}