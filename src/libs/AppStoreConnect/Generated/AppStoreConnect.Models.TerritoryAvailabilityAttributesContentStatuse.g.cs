
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoryAvailabilityAttributesContentStatuse
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        AvailableForPreorder,
        /// <summary>
        /// 
        /// </summary>
        AvailableForPreorderOnDate,
        /// <summary>
        /// 
        /// </summary>
        AvailableForSaleUnreleasedApp,
        /// <summary>
        /// 
        /// </summary>
        BrazilGamblingNotVerified,
        /// <summary>
        /// 
        /// </summary>
        BrazilRequiredTaxId,
        /// <summary>
        /// 
        /// </summary>
        CannotSell,
        /// <summary>
        /// 
        /// </summary>
        CannotSellAdultOnly,
        /// <summary>
        /// 
        /// </summary>
        CannotSellCasino,
        /// <summary>
        /// 
        /// </summary>
        CannotSellCasinoWithoutAgeVerification,
        /// <summary>
        /// 
        /// </summary>
        CannotSellCasinoWithoutGrac,
        /// <summary>
        /// 
        /// </summary>
        CannotSellContests,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequent,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentAlcoholTobaccoDrugs,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentGambling,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntense,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntenseAlcoholTobaccoDrugs,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntenseGambling,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntenseSexualContentNudity,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntenseViolence,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentIntenseWithoutGrac,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentSexualContentNudity,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentViolence,
        /// <summary>
        /// 
        /// </summary>
        CannotSellFrequentWithoutGrac,
        /// <summary>
        /// 
        /// </summary>
        CannotSellGambling,
        /// <summary>
        /// 
        /// </summary>
        CannotSellGamblingContests,
        /// <summary>
        /// 
        /// </summary>
        CannotSellInfrequentAlcoholTobaccoDrugs,
        /// <summary>
        /// 
        /// </summary>
        CannotSellInfrequentMildAlcoholTobaccoDrugs,
        /// <summary>
        /// 
        /// </summary>
        CannotSellInfrequentMildSexualContentNudity,
        /// <summary>
        /// 
        /// </summary>
        CannotSellInfrequentSexualContentNudity,
        /// <summary>
        /// 
        /// </summary>
        CannotSellNineteenPlusWithoutGrac,
        /// <summary>
        /// 
        /// </summary>
        CannotSellNonIosGames,
        /// <summary>
        /// 
        /// </summary>
        CannotSellRestrictedRating,
        /// <summary>
        /// 
        /// </summary>
        CannotSellSeventeenPlusApps,
        /// <summary>
        /// 
        /// </summary>
        CannotSellSeventeenPlusGames,
        /// <summary>
        /// 
        /// </summary>
        CannotSellSexuallyExplicit,
        /// <summary>
        /// 
        /// </summary>
        IcpNumberInvalid,
        /// <summary>
        /// 
        /// </summary>
        IcpNumberMissing,
        /// <summary>
        /// 
        /// </summary>
        MissingGrn,
        /// <summary>
        /// 
        /// </summary>
        MissingRating,
        /// <summary>
        /// 
        /// </summary>
        PreorderOnUnreleasedApp,
        /// <summary>
        /// 
        /// </summary>
        ProcessingToAvailable,
        /// <summary>
        /// 
        /// </summary>
        ProcessingToNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        ProcessingToPreOrder,
        /// <summary>
        /// 
        /// </summary>
        TraderStatusNotProvided,
        /// <summary>
        /// 
        /// </summary>
        TraderStatusVerificationFailed,
        /// <summary>
        /// 
        /// </summary>
        TraderStatusVerificationStatusMissing,
        /// <summary>
        /// 
        /// </summary>
        UnverifiedGrn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityAttributesContentStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityAttributesContentStatuse value)
        {
            return value switch
            {
                TerritoryAvailabilityAttributesContentStatuse.Available => "AVAILABLE",
                TerritoryAvailabilityAttributesContentStatuse.AvailableForPreorder => "AVAILABLE_FOR_PREORDER",
                TerritoryAvailabilityAttributesContentStatuse.AvailableForPreorderOnDate => "AVAILABLE_FOR_PREORDER_ON_DATE",
                TerritoryAvailabilityAttributesContentStatuse.AvailableForSaleUnreleasedApp => "AVAILABLE_FOR_SALE_UNRELEASED_APP",
                TerritoryAvailabilityAttributesContentStatuse.BrazilGamblingNotVerified => "BRAZIL_GAMBLING_NOT_VERIFIED",
                TerritoryAvailabilityAttributesContentStatuse.BrazilRequiredTaxId => "BRAZIL_REQUIRED_TAX_ID",
                TerritoryAvailabilityAttributesContentStatuse.CannotSell => "CANNOT_SELL",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellAdultOnly => "CANNOT_SELL_ADULT_ONLY",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellCasino => "CANNOT_SELL_CASINO",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellCasinoWithoutAgeVerification => "CANNOT_SELL_CASINO_WITHOUT_AGE_VERIFICATION",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellCasinoWithoutGrac => "CANNOT_SELL_CASINO_WITHOUT_GRAC",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellContests => "CANNOT_SELL_CONTESTS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequent => "CANNOT_SELL_FREQUENT",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentAlcoholTobaccoDrugs => "CANNOT_SELL_FREQUENT_ALCOHOL_TOBACCO_DRUGS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentGambling => "CANNOT_SELL_FREQUENT_GAMBLING",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntense => "CANNOT_SELL_FREQUENT_INTENSE",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseAlcoholTobaccoDrugs => "CANNOT_SELL_FREQUENT_INTENSE_ALCOHOL_TOBACCO_DRUGS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseGambling => "CANNOT_SELL_FREQUENT_INTENSE_GAMBLING",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseSexualContentNudity => "CANNOT_SELL_FREQUENT_INTENSE_SEXUAL_CONTENT_NUDITY",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseViolence => "CANNOT_SELL_FREQUENT_INTENSE_VIOLENCE",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseWithoutGrac => "CANNOT_SELL_FREQUENT_INTENSE_WITHOUT_GRAC",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentSexualContentNudity => "CANNOT_SELL_FREQUENT_SEXUAL_CONTENT_NUDITY",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentViolence => "CANNOT_SELL_FREQUENT_VIOLENCE",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentWithoutGrac => "CANNOT_SELL_FREQUENT_WITHOUT_GRAC",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellGambling => "CANNOT_SELL_GAMBLING",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellGamblingContests => "CANNOT_SELL_GAMBLING_CONTESTS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentAlcoholTobaccoDrugs => "CANNOT_SELL_INFREQUENT_ALCOHOL_TOBACCO_DRUGS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentMildAlcoholTobaccoDrugs => "CANNOT_SELL_INFREQUENT_MILD_ALCOHOL_TOBACCO_DRUGS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentMildSexualContentNudity => "CANNOT_SELL_INFREQUENT_MILD_SEXUAL_CONTENT_NUDITY",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentSexualContentNudity => "CANNOT_SELL_INFREQUENT_SEXUAL_CONTENT_NUDITY",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellNineteenPlusWithoutGrac => "CANNOT_SELL_NINETEEN_PLUS_WITHOUT_GRAC",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellNonIosGames => "CANNOT_SELL_NON_IOS_GAMES",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellRestrictedRating => "CANNOT_SELL_RESTRICTED_RATING",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellSeventeenPlusApps => "CANNOT_SELL_SEVENTEEN_PLUS_APPS",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellSeventeenPlusGames => "CANNOT_SELL_SEVENTEEN_PLUS_GAMES",
                TerritoryAvailabilityAttributesContentStatuse.CannotSellSexuallyExplicit => "CANNOT_SELL_SEXUALLY_EXPLICIT",
                TerritoryAvailabilityAttributesContentStatuse.IcpNumberInvalid => "ICP_NUMBER_INVALID",
                TerritoryAvailabilityAttributesContentStatuse.IcpNumberMissing => "ICP_NUMBER_MISSING",
                TerritoryAvailabilityAttributesContentStatuse.MissingGrn => "MISSING_GRN",
                TerritoryAvailabilityAttributesContentStatuse.MissingRating => "MISSING_RATING",
                TerritoryAvailabilityAttributesContentStatuse.PreorderOnUnreleasedApp => "PREORDER_ON_UNRELEASED_APP",
                TerritoryAvailabilityAttributesContentStatuse.ProcessingToAvailable => "PROCESSING_TO_AVAILABLE",
                TerritoryAvailabilityAttributesContentStatuse.ProcessingToNotAvailable => "PROCESSING_TO_NOT_AVAILABLE",
                TerritoryAvailabilityAttributesContentStatuse.ProcessingToPreOrder => "PROCESSING_TO_PRE_ORDER",
                TerritoryAvailabilityAttributesContentStatuse.TraderStatusNotProvided => "TRADER_STATUS_NOT_PROVIDED",
                TerritoryAvailabilityAttributesContentStatuse.TraderStatusVerificationFailed => "TRADER_STATUS_VERIFICATION_FAILED",
                TerritoryAvailabilityAttributesContentStatuse.TraderStatusVerificationStatusMissing => "TRADER_STATUS_VERIFICATION_STATUS_MISSING",
                TerritoryAvailabilityAttributesContentStatuse.UnverifiedGrn => "UNVERIFIED_GRN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityAttributesContentStatuse? ToEnum(string value)
        {
            return value switch
            {
                "AVAILABLE" => TerritoryAvailabilityAttributesContentStatuse.Available,
                "AVAILABLE_FOR_PREORDER" => TerritoryAvailabilityAttributesContentStatuse.AvailableForPreorder,
                "AVAILABLE_FOR_PREORDER_ON_DATE" => TerritoryAvailabilityAttributesContentStatuse.AvailableForPreorderOnDate,
                "AVAILABLE_FOR_SALE_UNRELEASED_APP" => TerritoryAvailabilityAttributesContentStatuse.AvailableForSaleUnreleasedApp,
                "BRAZIL_GAMBLING_NOT_VERIFIED" => TerritoryAvailabilityAttributesContentStatuse.BrazilGamblingNotVerified,
                "BRAZIL_REQUIRED_TAX_ID" => TerritoryAvailabilityAttributesContentStatuse.BrazilRequiredTaxId,
                "CANNOT_SELL" => TerritoryAvailabilityAttributesContentStatuse.CannotSell,
                "CANNOT_SELL_ADULT_ONLY" => TerritoryAvailabilityAttributesContentStatuse.CannotSellAdultOnly,
                "CANNOT_SELL_CASINO" => TerritoryAvailabilityAttributesContentStatuse.CannotSellCasino,
                "CANNOT_SELL_CASINO_WITHOUT_AGE_VERIFICATION" => TerritoryAvailabilityAttributesContentStatuse.CannotSellCasinoWithoutAgeVerification,
                "CANNOT_SELL_CASINO_WITHOUT_GRAC" => TerritoryAvailabilityAttributesContentStatuse.CannotSellCasinoWithoutGrac,
                "CANNOT_SELL_CONTESTS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellContests,
                "CANNOT_SELL_FREQUENT" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequent,
                "CANNOT_SELL_FREQUENT_ALCOHOL_TOBACCO_DRUGS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentAlcoholTobaccoDrugs,
                "CANNOT_SELL_FREQUENT_GAMBLING" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentGambling,
                "CANNOT_SELL_FREQUENT_INTENSE" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntense,
                "CANNOT_SELL_FREQUENT_INTENSE_ALCOHOL_TOBACCO_DRUGS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseAlcoholTobaccoDrugs,
                "CANNOT_SELL_FREQUENT_INTENSE_GAMBLING" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseGambling,
                "CANNOT_SELL_FREQUENT_INTENSE_SEXUAL_CONTENT_NUDITY" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseSexualContentNudity,
                "CANNOT_SELL_FREQUENT_INTENSE_VIOLENCE" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseViolence,
                "CANNOT_SELL_FREQUENT_INTENSE_WITHOUT_GRAC" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentIntenseWithoutGrac,
                "CANNOT_SELL_FREQUENT_SEXUAL_CONTENT_NUDITY" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentSexualContentNudity,
                "CANNOT_SELL_FREQUENT_VIOLENCE" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentViolence,
                "CANNOT_SELL_FREQUENT_WITHOUT_GRAC" => TerritoryAvailabilityAttributesContentStatuse.CannotSellFrequentWithoutGrac,
                "CANNOT_SELL_GAMBLING" => TerritoryAvailabilityAttributesContentStatuse.CannotSellGambling,
                "CANNOT_SELL_GAMBLING_CONTESTS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellGamblingContests,
                "CANNOT_SELL_INFREQUENT_ALCOHOL_TOBACCO_DRUGS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentAlcoholTobaccoDrugs,
                "CANNOT_SELL_INFREQUENT_MILD_ALCOHOL_TOBACCO_DRUGS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentMildAlcoholTobaccoDrugs,
                "CANNOT_SELL_INFREQUENT_MILD_SEXUAL_CONTENT_NUDITY" => TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentMildSexualContentNudity,
                "CANNOT_SELL_INFREQUENT_SEXUAL_CONTENT_NUDITY" => TerritoryAvailabilityAttributesContentStatuse.CannotSellInfrequentSexualContentNudity,
                "CANNOT_SELL_NINETEEN_PLUS_WITHOUT_GRAC" => TerritoryAvailabilityAttributesContentStatuse.CannotSellNineteenPlusWithoutGrac,
                "CANNOT_SELL_NON_IOS_GAMES" => TerritoryAvailabilityAttributesContentStatuse.CannotSellNonIosGames,
                "CANNOT_SELL_RESTRICTED_RATING" => TerritoryAvailabilityAttributesContentStatuse.CannotSellRestrictedRating,
                "CANNOT_SELL_SEVENTEEN_PLUS_APPS" => TerritoryAvailabilityAttributesContentStatuse.CannotSellSeventeenPlusApps,
                "CANNOT_SELL_SEVENTEEN_PLUS_GAMES" => TerritoryAvailabilityAttributesContentStatuse.CannotSellSeventeenPlusGames,
                "CANNOT_SELL_SEXUALLY_EXPLICIT" => TerritoryAvailabilityAttributesContentStatuse.CannotSellSexuallyExplicit,
                "ICP_NUMBER_INVALID" => TerritoryAvailabilityAttributesContentStatuse.IcpNumberInvalid,
                "ICP_NUMBER_MISSING" => TerritoryAvailabilityAttributesContentStatuse.IcpNumberMissing,
                "MISSING_GRN" => TerritoryAvailabilityAttributesContentStatuse.MissingGrn,
                "MISSING_RATING" => TerritoryAvailabilityAttributesContentStatuse.MissingRating,
                "PREORDER_ON_UNRELEASED_APP" => TerritoryAvailabilityAttributesContentStatuse.PreorderOnUnreleasedApp,
                "PROCESSING_TO_AVAILABLE" => TerritoryAvailabilityAttributesContentStatuse.ProcessingToAvailable,
                "PROCESSING_TO_NOT_AVAILABLE" => TerritoryAvailabilityAttributesContentStatuse.ProcessingToNotAvailable,
                "PROCESSING_TO_PRE_ORDER" => TerritoryAvailabilityAttributesContentStatuse.ProcessingToPreOrder,
                "TRADER_STATUS_NOT_PROVIDED" => TerritoryAvailabilityAttributesContentStatuse.TraderStatusNotProvided,
                "TRADER_STATUS_VERIFICATION_FAILED" => TerritoryAvailabilityAttributesContentStatuse.TraderStatusVerificationFailed,
                "TRADER_STATUS_VERIFICATION_STATUS_MISSING" => TerritoryAvailabilityAttributesContentStatuse.TraderStatusVerificationStatusMissing,
                "UNVERIFIED_GRN" => TerritoryAvailabilityAttributesContentStatuse.UnverifiedGrn,
                _ => null,
            };
        }
    }
}