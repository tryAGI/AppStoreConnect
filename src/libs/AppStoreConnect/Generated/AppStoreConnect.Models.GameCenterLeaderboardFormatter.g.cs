
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardFormatter
    {
        /// <summary>
        ///
        /// </summary>
        DecimalPoint1Place,
        /// <summary>
        ///
        /// </summary>
        DecimalPoint2Place,
        /// <summary>
        ///
        /// </summary>
        DecimalPoint3Place,
        /// <summary>
        ///
        /// </summary>
        ElapsedTimeCentisecond,
        /// <summary>
        ///
        /// </summary>
        ElapsedTimeMinute,
        /// <summary>
        ///
        /// </summary>
        ElapsedTimeSecond,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        MoneyDollar,
        /// <summary>
        ///
        /// </summary>
        MoneyDollarDecimal,
        /// <summary>
        ///
        /// </summary>
        MoneyEuro,
        /// <summary>
        ///
        /// </summary>
        MoneyEuroDecimal,
        /// <summary>
        ///
        /// </summary>
        MoneyFranc,
        /// <summary>
        ///
        /// </summary>
        MoneyFrancDecimal,
        /// <summary>
        ///
        /// </summary>
        MoneyKroner,
        /// <summary>
        ///
        /// </summary>
        MoneyKronerDecimal,
        /// <summary>
        ///
        /// </summary>
        MoneyPound,
        /// <summary>
        ///
        /// </summary>
        MoneyPoundDecimal,
        /// <summary>
        ///
        /// </summary>
        MoneyYen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardFormatterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardFormatter value)
        {
            return value switch
            {
                GameCenterLeaderboardFormatter.DecimalPoint1Place => "DECIMAL_POINT_1_PLACE",
                GameCenterLeaderboardFormatter.DecimalPoint2Place => "DECIMAL_POINT_2_PLACE",
                GameCenterLeaderboardFormatter.DecimalPoint3Place => "DECIMAL_POINT_3_PLACE",
                GameCenterLeaderboardFormatter.ElapsedTimeCentisecond => "ELAPSED_TIME_CENTISECOND",
                GameCenterLeaderboardFormatter.ElapsedTimeMinute => "ELAPSED_TIME_MINUTE",
                GameCenterLeaderboardFormatter.ElapsedTimeSecond => "ELAPSED_TIME_SECOND",
                GameCenterLeaderboardFormatter.Integer => "INTEGER",
                GameCenterLeaderboardFormatter.MoneyDollar => "MONEY_DOLLAR",
                GameCenterLeaderboardFormatter.MoneyDollarDecimal => "MONEY_DOLLAR_DECIMAL",
                GameCenterLeaderboardFormatter.MoneyEuro => "MONEY_EURO",
                GameCenterLeaderboardFormatter.MoneyEuroDecimal => "MONEY_EURO_DECIMAL",
                GameCenterLeaderboardFormatter.MoneyFranc => "MONEY_FRANC",
                GameCenterLeaderboardFormatter.MoneyFrancDecimal => "MONEY_FRANC_DECIMAL",
                GameCenterLeaderboardFormatter.MoneyKroner => "MONEY_KRONER",
                GameCenterLeaderboardFormatter.MoneyKronerDecimal => "MONEY_KRONER_DECIMAL",
                GameCenterLeaderboardFormatter.MoneyPound => "MONEY_POUND",
                GameCenterLeaderboardFormatter.MoneyPoundDecimal => "MONEY_POUND_DECIMAL",
                GameCenterLeaderboardFormatter.MoneyYen => "MONEY_YEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardFormatter? ToEnum(string value)
        {
            return value switch
            {
                "DECIMAL_POINT_1_PLACE" => GameCenterLeaderboardFormatter.DecimalPoint1Place,
                "DECIMAL_POINT_2_PLACE" => GameCenterLeaderboardFormatter.DecimalPoint2Place,
                "DECIMAL_POINT_3_PLACE" => GameCenterLeaderboardFormatter.DecimalPoint3Place,
                "ELAPSED_TIME_CENTISECOND" => GameCenterLeaderboardFormatter.ElapsedTimeCentisecond,
                "ELAPSED_TIME_MINUTE" => GameCenterLeaderboardFormatter.ElapsedTimeMinute,
                "ELAPSED_TIME_SECOND" => GameCenterLeaderboardFormatter.ElapsedTimeSecond,
                "INTEGER" => GameCenterLeaderboardFormatter.Integer,
                "MONEY_DOLLAR" => GameCenterLeaderboardFormatter.MoneyDollar,
                "MONEY_DOLLAR_DECIMAL" => GameCenterLeaderboardFormatter.MoneyDollarDecimal,
                "MONEY_EURO" => GameCenterLeaderboardFormatter.MoneyEuro,
                "MONEY_EURO_DECIMAL" => GameCenterLeaderboardFormatter.MoneyEuroDecimal,
                "MONEY_FRANC" => GameCenterLeaderboardFormatter.MoneyFranc,
                "MONEY_FRANC_DECIMAL" => GameCenterLeaderboardFormatter.MoneyFrancDecimal,
                "MONEY_KRONER" => GameCenterLeaderboardFormatter.MoneyKroner,
                "MONEY_KRONER_DECIMAL" => GameCenterLeaderboardFormatter.MoneyKronerDecimal,
                "MONEY_POUND" => GameCenterLeaderboardFormatter.MoneyPound,
                "MONEY_POUND_DECIMAL" => GameCenterLeaderboardFormatter.MoneyPoundDecimal,
                "MONEY_YEN" => GameCenterLeaderboardFormatter.MoneyYen,
                _ => null,
            };
        }
    }
}