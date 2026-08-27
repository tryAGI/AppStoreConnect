
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesBusinessCategory
    {
        /// <summary>
        ///
        /// </summary>
        Automotive,
        /// <summary>
        ///
        /// </summary>
        Beauty,
        /// <summary>
        ///
        /// </summary>
        Bikes,
        /// <summary>
        ///
        /// </summary>
        Books,
        /// <summary>
        ///
        /// </summary>
        Casino,
        /// <summary>
        ///
        /// </summary>
        Education,
        /// <summary>
        ///
        /// </summary>
        EducationJapan,
        /// <summary>
        ///
        /// </summary>
        Entertainment,
        /// <summary>
        ///
        /// </summary>
        EvCharger,
        /// <summary>
        ///
        /// </summary>
        FinancialCny,
        /// <summary>
        ///
        /// </summary>
        FinancialEur,
        /// <summary>
        ///
        /// </summary>
        FinancialGbp,
        /// <summary>
        ///
        /// </summary>
        FinancialJpy,
        /// <summary>
        ///
        /// </summary>
        FinancialUsd,
        /// <summary>
        ///
        /// </summary>
        Fitness,
        /// <summary>
        ///
        /// </summary>
        FoodAndDrink,
        /// <summary>
        ///
        /// </summary>
        Gas,
        /// <summary>
        ///
        /// </summary>
        Grocery,
        /// <summary>
        ///
        /// </summary>
        HealthAndMedical,
        /// <summary>
        ///
        /// </summary>
        HotelAndTravel,
        /// <summary>
        ///
        /// </summary>
        Music,
        /// <summary>
        ///
        /// </summary>
        Parking,
        /// <summary>
        ///
        /// </summary>
        PetServices,
        /// <summary>
        ///
        /// </summary>
        ProfessionalServices,
        /// <summary>
        ///
        /// </summary>
        Shopping,
        /// <summary>
        ///
        /// </summary>
        Ticketing,
        /// <summary>
        ///
        /// </summary>
        Transit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceAttributesBusinessCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesBusinessCategory value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesBusinessCategory.Automotive => "AUTOMOTIVE",
                AppClipAdvancedExperienceAttributesBusinessCategory.Beauty => "BEAUTY",
                AppClipAdvancedExperienceAttributesBusinessCategory.Bikes => "BIKES",
                AppClipAdvancedExperienceAttributesBusinessCategory.Books => "BOOKS",
                AppClipAdvancedExperienceAttributesBusinessCategory.Casino => "CASINO",
                AppClipAdvancedExperienceAttributesBusinessCategory.Education => "EDUCATION",
                AppClipAdvancedExperienceAttributesBusinessCategory.EducationJapan => "EDUCATION_JAPAN",
                AppClipAdvancedExperienceAttributesBusinessCategory.Entertainment => "ENTERTAINMENT",
                AppClipAdvancedExperienceAttributesBusinessCategory.EvCharger => "EV_CHARGER",
                AppClipAdvancedExperienceAttributesBusinessCategory.FinancialCny => "FINANCIAL_CNY",
                AppClipAdvancedExperienceAttributesBusinessCategory.FinancialEur => "FINANCIAL_EUR",
                AppClipAdvancedExperienceAttributesBusinessCategory.FinancialGbp => "FINANCIAL_GBP",
                AppClipAdvancedExperienceAttributesBusinessCategory.FinancialJpy => "FINANCIAL_JPY",
                AppClipAdvancedExperienceAttributesBusinessCategory.FinancialUsd => "FINANCIAL_USD",
                AppClipAdvancedExperienceAttributesBusinessCategory.Fitness => "FITNESS",
                AppClipAdvancedExperienceAttributesBusinessCategory.FoodAndDrink => "FOOD_AND_DRINK",
                AppClipAdvancedExperienceAttributesBusinessCategory.Gas => "GAS",
                AppClipAdvancedExperienceAttributesBusinessCategory.Grocery => "GROCERY",
                AppClipAdvancedExperienceAttributesBusinessCategory.HealthAndMedical => "HEALTH_AND_MEDICAL",
                AppClipAdvancedExperienceAttributesBusinessCategory.HotelAndTravel => "HOTEL_AND_TRAVEL",
                AppClipAdvancedExperienceAttributesBusinessCategory.Music => "MUSIC",
                AppClipAdvancedExperienceAttributesBusinessCategory.Parking => "PARKING",
                AppClipAdvancedExperienceAttributesBusinessCategory.PetServices => "PET_SERVICES",
                AppClipAdvancedExperienceAttributesBusinessCategory.ProfessionalServices => "PROFESSIONAL_SERVICES",
                AppClipAdvancedExperienceAttributesBusinessCategory.Shopping => "SHOPPING",
                AppClipAdvancedExperienceAttributesBusinessCategory.Ticketing => "TICKETING",
                AppClipAdvancedExperienceAttributesBusinessCategory.Transit => "TRANSIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesBusinessCategory? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMOTIVE" => AppClipAdvancedExperienceAttributesBusinessCategory.Automotive,
                "BEAUTY" => AppClipAdvancedExperienceAttributesBusinessCategory.Beauty,
                "BIKES" => AppClipAdvancedExperienceAttributesBusinessCategory.Bikes,
                "BOOKS" => AppClipAdvancedExperienceAttributesBusinessCategory.Books,
                "CASINO" => AppClipAdvancedExperienceAttributesBusinessCategory.Casino,
                "EDUCATION" => AppClipAdvancedExperienceAttributesBusinessCategory.Education,
                "EDUCATION_JAPAN" => AppClipAdvancedExperienceAttributesBusinessCategory.EducationJapan,
                "ENTERTAINMENT" => AppClipAdvancedExperienceAttributesBusinessCategory.Entertainment,
                "EV_CHARGER" => AppClipAdvancedExperienceAttributesBusinessCategory.EvCharger,
                "FINANCIAL_CNY" => AppClipAdvancedExperienceAttributesBusinessCategory.FinancialCny,
                "FINANCIAL_EUR" => AppClipAdvancedExperienceAttributesBusinessCategory.FinancialEur,
                "FINANCIAL_GBP" => AppClipAdvancedExperienceAttributesBusinessCategory.FinancialGbp,
                "FINANCIAL_JPY" => AppClipAdvancedExperienceAttributesBusinessCategory.FinancialJpy,
                "FINANCIAL_USD" => AppClipAdvancedExperienceAttributesBusinessCategory.FinancialUsd,
                "FITNESS" => AppClipAdvancedExperienceAttributesBusinessCategory.Fitness,
                "FOOD_AND_DRINK" => AppClipAdvancedExperienceAttributesBusinessCategory.FoodAndDrink,
                "GAS" => AppClipAdvancedExperienceAttributesBusinessCategory.Gas,
                "GROCERY" => AppClipAdvancedExperienceAttributesBusinessCategory.Grocery,
                "HEALTH_AND_MEDICAL" => AppClipAdvancedExperienceAttributesBusinessCategory.HealthAndMedical,
                "HOTEL_AND_TRAVEL" => AppClipAdvancedExperienceAttributesBusinessCategory.HotelAndTravel,
                "MUSIC" => AppClipAdvancedExperienceAttributesBusinessCategory.Music,
                "PARKING" => AppClipAdvancedExperienceAttributesBusinessCategory.Parking,
                "PET_SERVICES" => AppClipAdvancedExperienceAttributesBusinessCategory.PetServices,
                "PROFESSIONAL_SERVICES" => AppClipAdvancedExperienceAttributesBusinessCategory.ProfessionalServices,
                "SHOPPING" => AppClipAdvancedExperienceAttributesBusinessCategory.Shopping,
                "TICKETING" => AppClipAdvancedExperienceAttributesBusinessCategory.Ticketing,
                "TRANSIT" => AppClipAdvancedExperienceAttributesBusinessCategory.Transit,
                _ => null,
            };
        }
    }
}