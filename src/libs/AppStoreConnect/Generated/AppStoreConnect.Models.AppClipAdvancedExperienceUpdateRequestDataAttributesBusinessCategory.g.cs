
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory
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
    public static class AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Automotive => "AUTOMOTIVE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Beauty => "BEAUTY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Bikes => "BIKES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Books => "BOOKS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Casino => "CASINO",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Education => "EDUCATION",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.EducationJapan => "EDUCATION_JAPAN",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Entertainment => "ENTERTAINMENT",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.EvCharger => "EV_CHARGER",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialCny => "FINANCIAL_CNY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialEur => "FINANCIAL_EUR",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialGbp => "FINANCIAL_GBP",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialJpy => "FINANCIAL_JPY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialUsd => "FINANCIAL_USD",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Fitness => "FITNESS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FoodAndDrink => "FOOD_AND_DRINK",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Gas => "GAS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Grocery => "GROCERY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.HealthAndMedical => "HEALTH_AND_MEDICAL",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.HotelAndTravel => "HOTEL_AND_TRAVEL",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Music => "MUSIC",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Parking => "PARKING",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.PetServices => "PET_SERVICES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.ProfessionalServices => "PROFESSIONAL_SERVICES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Shopping => "SHOPPING",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Ticketing => "TICKETING",
                AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Transit => "TRANSIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMOTIVE" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Automotive,
                "BEAUTY" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Beauty,
                "BIKES" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Bikes,
                "BOOKS" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Books,
                "CASINO" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Casino,
                "EDUCATION" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Education,
                "EDUCATION_JAPAN" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.EducationJapan,
                "ENTERTAINMENT" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Entertainment,
                "EV_CHARGER" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.EvCharger,
                "FINANCIAL_CNY" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialCny,
                "FINANCIAL_EUR" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialEur,
                "FINANCIAL_GBP" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialGbp,
                "FINANCIAL_JPY" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialJpy,
                "FINANCIAL_USD" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FinancialUsd,
                "FITNESS" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Fitness,
                "FOOD_AND_DRINK" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.FoodAndDrink,
                "GAS" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Gas,
                "GROCERY" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Grocery,
                "HEALTH_AND_MEDICAL" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.HealthAndMedical,
                "HOTEL_AND_TRAVEL" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.HotelAndTravel,
                "MUSIC" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Music,
                "PARKING" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Parking,
                "PET_SERVICES" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.PetServices,
                "PROFESSIONAL_SERVICES" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.ProfessionalServices,
                "SHOPPING" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Shopping,
                "TICKETING" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Ticketing,
                "TRANSIT" => AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory.Transit,
                _ => null,
            };
        }
    }
}