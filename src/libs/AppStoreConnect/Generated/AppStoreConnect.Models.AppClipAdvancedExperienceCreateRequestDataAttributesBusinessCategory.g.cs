
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory
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
    public static class AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Automotive => "AUTOMOTIVE",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Beauty => "BEAUTY",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Bikes => "BIKES",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Books => "BOOKS",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Casino => "CASINO",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Education => "EDUCATION",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.EducationJapan => "EDUCATION_JAPAN",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Entertainment => "ENTERTAINMENT",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.EvCharger => "EV_CHARGER",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialCny => "FINANCIAL_CNY",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialEur => "FINANCIAL_EUR",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialGbp => "FINANCIAL_GBP",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialJpy => "FINANCIAL_JPY",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialUsd => "FINANCIAL_USD",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Fitness => "FITNESS",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FoodAndDrink => "FOOD_AND_DRINK",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Gas => "GAS",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Grocery => "GROCERY",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.HealthAndMedical => "HEALTH_AND_MEDICAL",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.HotelAndTravel => "HOTEL_AND_TRAVEL",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Music => "MUSIC",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Parking => "PARKING",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.PetServices => "PET_SERVICES",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.ProfessionalServices => "PROFESSIONAL_SERVICES",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Shopping => "SHOPPING",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Ticketing => "TICKETING",
                AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Transit => "TRANSIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMOTIVE" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Automotive,
                "BEAUTY" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Beauty,
                "BIKES" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Bikes,
                "BOOKS" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Books,
                "CASINO" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Casino,
                "EDUCATION" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Education,
                "EDUCATION_JAPAN" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.EducationJapan,
                "ENTERTAINMENT" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Entertainment,
                "EV_CHARGER" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.EvCharger,
                "FINANCIAL_CNY" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialCny,
                "FINANCIAL_EUR" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialEur,
                "FINANCIAL_GBP" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialGbp,
                "FINANCIAL_JPY" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialJpy,
                "FINANCIAL_USD" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FinancialUsd,
                "FITNESS" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Fitness,
                "FOOD_AND_DRINK" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.FoodAndDrink,
                "GAS" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Gas,
                "GROCERY" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Grocery,
                "HEALTH_AND_MEDICAL" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.HealthAndMedical,
                "HOTEL_AND_TRAVEL" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.HotelAndTravel,
                "MUSIC" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Music,
                "PARKING" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Parking,
                "PET_SERVICES" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.PetServices,
                "PROFESSIONAL_SERVICES" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.ProfessionalServices,
                "SHOPPING" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Shopping,
                "TICKETING" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Ticketing,
                "TRANSIT" => AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory.Transit,
                _ => null,
            };
        }
    }
}