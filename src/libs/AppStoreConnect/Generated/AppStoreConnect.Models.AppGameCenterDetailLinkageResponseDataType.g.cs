
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppGameCenterDetailLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppGameCenterDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppGameCenterDetailLinkageResponseDataType value)
        {
            return value switch
            {
                AppGameCenterDetailLinkageResponseDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppGameCenterDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => AppGameCenterDetailLinkageResponseDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}