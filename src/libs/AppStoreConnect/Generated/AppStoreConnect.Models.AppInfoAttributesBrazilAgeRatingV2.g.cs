
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoAttributesBrazilAgeRatingV2
    {
        /// <summary>
        /// 
        /// </summary>
        OfficialEighteen,
        /// <summary>
        /// 
        /// </summary>
        OfficialFourteen,
        /// <summary>
        /// 
        /// </summary>
        OfficialL,
        /// <summary>
        /// 
        /// </summary>
        OfficialSixteen,
        /// <summary>
        /// 
        /// </summary>
        OfficialTen,
        /// <summary>
        /// 
        /// </summary>
        OfficialTwelve,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedEighteen,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedFourteen,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedL,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedSixteen,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedTen,
        /// <summary>
        /// 
        /// </summary>
        SelfRatedTwelve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAttributesBrazilAgeRatingV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAttributesBrazilAgeRatingV2 value)
        {
            return value switch
            {
                AppInfoAttributesBrazilAgeRatingV2.OfficialEighteen => "OFFICIAL_EIGHTEEN",
                AppInfoAttributesBrazilAgeRatingV2.OfficialFourteen => "OFFICIAL_FOURTEEN",
                AppInfoAttributesBrazilAgeRatingV2.OfficialL => "OFFICIAL_L",
                AppInfoAttributesBrazilAgeRatingV2.OfficialSixteen => "OFFICIAL_SIXTEEN",
                AppInfoAttributesBrazilAgeRatingV2.OfficialTen => "OFFICIAL_TEN",
                AppInfoAttributesBrazilAgeRatingV2.OfficialTwelve => "OFFICIAL_TWELVE",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedEighteen => "SELF_RATED_EIGHTEEN",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedFourteen => "SELF_RATED_FOURTEEN",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedL => "SELF_RATED_L",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedSixteen => "SELF_RATED_SIXTEEN",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedTen => "SELF_RATED_TEN",
                AppInfoAttributesBrazilAgeRatingV2.SelfRatedTwelve => "SELF_RATED_TWELVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAttributesBrazilAgeRatingV2? ToEnum(string value)
        {
            return value switch
            {
                "OFFICIAL_EIGHTEEN" => AppInfoAttributesBrazilAgeRatingV2.OfficialEighteen,
                "OFFICIAL_FOURTEEN" => AppInfoAttributesBrazilAgeRatingV2.OfficialFourteen,
                "OFFICIAL_L" => AppInfoAttributesBrazilAgeRatingV2.OfficialL,
                "OFFICIAL_SIXTEEN" => AppInfoAttributesBrazilAgeRatingV2.OfficialSixteen,
                "OFFICIAL_TEN" => AppInfoAttributesBrazilAgeRatingV2.OfficialTen,
                "OFFICIAL_TWELVE" => AppInfoAttributesBrazilAgeRatingV2.OfficialTwelve,
                "SELF_RATED_EIGHTEEN" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedEighteen,
                "SELF_RATED_FOURTEEN" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedFourteen,
                "SELF_RATED_L" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedL,
                "SELF_RATED_SIXTEEN" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedSixteen,
                "SELF_RATED_TEN" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedTen,
                "SELF_RATED_TWELVE" => AppInfoAttributesBrazilAgeRatingV2.SelfRatedTwelve,
                _ => null,
            };
        }
    }
}