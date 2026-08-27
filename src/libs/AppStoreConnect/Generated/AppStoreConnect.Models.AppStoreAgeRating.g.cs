
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreAgeRating
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        EighteenPlus,
        /// <summary>
        /// 
        /// </summary>
        EightPlus,
        /// <summary>
        /// 
        /// </summary>
        ElevenPlus,
        /// <summary>
        /// 
        /// </summary>
        FifteenPlus,
        /// <summary>
        /// 
        /// </summary>
        FivePlus,
        /// <summary>
        /// 
        /// </summary>
        FourteenPlus,
        /// <summary>
        /// 
        /// </summary>
        FourPlus,
        /// <summary>
        /// 
        /// </summary>
        L,
        /// <summary>
        /// 
        /// </summary>
        NineteenPlus,
        /// <summary>
        /// 
        /// </summary>
        NinePlus,
        /// <summary>
        /// 
        /// </summary>
        OnePlus,
        /// <summary>
        /// 
        /// </summary>
        SeventeenPlus,
        /// <summary>
        /// 
        /// </summary>
        SevenPlus,
        /// <summary>
        /// 
        /// </summary>
        SixteenPlus,
        /// <summary>
        /// 
        /// </summary>
        SixPlus,
        /// <summary>
        /// 
        /// </summary>
        TenPlus,
        /// <summary>
        /// 
        /// </summary>
        ThirteenPlus,
        /// <summary>
        /// 
        /// </summary>
        ThreePlus,
        /// <summary>
        /// 
        /// </summary>
        TwelvePlus,
        /// <summary>
        /// 
        /// </summary>
        TwentyOnePlus,
        /// <summary>
        /// 
        /// </summary>
        TwentyPlus,
        /// <summary>
        /// 
        /// </summary>
        TwoPlus,
        /// <summary>
        /// 
        /// </summary>
        Unrated,
        /// <summary>
        /// 
        /// </summary>
        ZeroZero,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreAgeRating value)
        {
            return value switch
            {
                AppStoreAgeRating.All => "ALL",
                AppStoreAgeRating.EighteenPlus => "EIGHTEEN_PLUS",
                AppStoreAgeRating.EightPlus => "EIGHT_PLUS",
                AppStoreAgeRating.ElevenPlus => "ELEVEN_PLUS",
                AppStoreAgeRating.FifteenPlus => "FIFTEEN_PLUS",
                AppStoreAgeRating.FivePlus => "FIVE_PLUS",
                AppStoreAgeRating.FourteenPlus => "FOURTEEN_PLUS",
                AppStoreAgeRating.FourPlus => "FOUR_PLUS",
                AppStoreAgeRating.L => "L",
                AppStoreAgeRating.NineteenPlus => "NINETEEN_PLUS",
                AppStoreAgeRating.NinePlus => "NINE_PLUS",
                AppStoreAgeRating.OnePlus => "ONE_PLUS",
                AppStoreAgeRating.SeventeenPlus => "SEVENTEEN_PLUS",
                AppStoreAgeRating.SevenPlus => "SEVEN_PLUS",
                AppStoreAgeRating.SixteenPlus => "SIXTEEN_PLUS",
                AppStoreAgeRating.SixPlus => "SIX_PLUS",
                AppStoreAgeRating.TenPlus => "TEN_PLUS",
                AppStoreAgeRating.ThirteenPlus => "THIRTEEN_PLUS",
                AppStoreAgeRating.ThreePlus => "THREE_PLUS",
                AppStoreAgeRating.TwelvePlus => "TWELVE_PLUS",
                AppStoreAgeRating.TwentyOnePlus => "TWENTY_ONE_PLUS",
                AppStoreAgeRating.TwentyPlus => "TWENTY_PLUS",
                AppStoreAgeRating.TwoPlus => "TWO_PLUS",
                AppStoreAgeRating.Unrated => "UNRATED",
                AppStoreAgeRating.ZeroZero => "ZERO_ZERO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => AppStoreAgeRating.All,
                "EIGHTEEN_PLUS" => AppStoreAgeRating.EighteenPlus,
                "EIGHT_PLUS" => AppStoreAgeRating.EightPlus,
                "ELEVEN_PLUS" => AppStoreAgeRating.ElevenPlus,
                "FIFTEEN_PLUS" => AppStoreAgeRating.FifteenPlus,
                "FIVE_PLUS" => AppStoreAgeRating.FivePlus,
                "FOURTEEN_PLUS" => AppStoreAgeRating.FourteenPlus,
                "FOUR_PLUS" => AppStoreAgeRating.FourPlus,
                "L" => AppStoreAgeRating.L,
                "NINETEEN_PLUS" => AppStoreAgeRating.NineteenPlus,
                "NINE_PLUS" => AppStoreAgeRating.NinePlus,
                "ONE_PLUS" => AppStoreAgeRating.OnePlus,
                "SEVENTEEN_PLUS" => AppStoreAgeRating.SeventeenPlus,
                "SEVEN_PLUS" => AppStoreAgeRating.SevenPlus,
                "SIXTEEN_PLUS" => AppStoreAgeRating.SixteenPlus,
                "SIX_PLUS" => AppStoreAgeRating.SixPlus,
                "TEN_PLUS" => AppStoreAgeRating.TenPlus,
                "THIRTEEN_PLUS" => AppStoreAgeRating.ThirteenPlus,
                "THREE_PLUS" => AppStoreAgeRating.ThreePlus,
                "TWELVE_PLUS" => AppStoreAgeRating.TwelvePlus,
                "TWENTY_ONE_PLUS" => AppStoreAgeRating.TwentyOnePlus,
                "TWENTY_PLUS" => AppStoreAgeRating.TwentyPlus,
                "TWO_PLUS" => AppStoreAgeRating.TwoPlus,
                "UNRATED" => AppStoreAgeRating.Unrated,
                "ZERO_ZERO" => AppStoreAgeRating.ZeroZero,
                _ => null,
            };
        }
    }
}