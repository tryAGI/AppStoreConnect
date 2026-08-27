
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration
    {
        /// <summary>
        ///
        /// </summary>
        Advertising,
        /// <summary>
        ///
        /// </summary>
        AgeAssurance,
        /// <summary>
        ///
        /// </summary>
        AgeRatingOverride,
        /// <summary>
        ///
        /// </summary>
        AgeRatingOverrideV2,
        /// <summary>
        ///
        /// </summary>
        AlcoholTobaccoOrDrugUseOrReferences,
        /// <summary>
        ///
        /// </summary>
        Contests,
        /// <summary>
        ///
        /// </summary>
        DeveloperAgeRatingInfoUrl,
        /// <summary>
        ///
        /// </summary>
        Gambling,
        /// <summary>
        ///
        /// </summary>
        GamblingSimulated,
        /// <summary>
        ///
        /// </summary>
        GunsOrOtherWeapons,
        /// <summary>
        ///
        /// </summary>
        HealthOrWellnessTopics,
        /// <summary>
        ///
        /// </summary>
        HorrorOrFearThemes,
        /// <summary>
        ///
        /// </summary>
        KidsAgeBand,
        /// <summary>
        ///
        /// </summary>
        KoreaAgeRatingOverride,
        /// <summary>
        ///
        /// </summary>
        LootBox,
        /// <summary>
        ///
        /// </summary>
        MatureOrSuggestiveThemes,
        /// <summary>
        ///
        /// </summary>
        MedicalOrTreatmentInformation,
        /// <summary>
        ///
        /// </summary>
        MessagingAndChat,
        /// <summary>
        ///
        /// </summary>
        ParentalControls,
        /// <summary>
        ///
        /// </summary>
        ProfanityOrCrudeHumor,
        /// <summary>
        ///
        /// </summary>
        SexualContentGraphicAndNudity,
        /// <summary>
        ///
        /// </summary>
        SexualContentOrNudity,
        /// <summary>
        ///
        /// </summary>
        SocialMedia,
        /// <summary>
        ///
        /// </summary>
        SocialMediaAgeRestricted,
        /// <summary>
        ///
        /// </summary>
        UnrestrictedWebAccess,
        /// <summary>
        ///
        /// </summary>
        UserGeneratedContent,
        /// <summary>
        ///
        /// </summary>
        ViolenceCartoonOrFantasy,
        /// <summary>
        ///
        /// </summary>
        ViolenceRealistic,
        /// <summary>
        ///
        /// </summary>
        ViolenceRealisticProlongedGraphicOrSadistic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration value)
        {
            return value switch
            {
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Advertising => "advertising",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeAssurance => "ageAssurance",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeRatingOverride => "ageRatingOverride",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeRatingOverrideV2 => "ageRatingOverrideV2",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences => "alcoholTobaccoOrDrugUseOrReferences",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Contests => "contests",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl => "developerAgeRatingInfoUrl",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Gambling => "gambling",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.GamblingSimulated => "gamblingSimulated",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.GunsOrOtherWeapons => "gunsOrOtherWeapons",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.HealthOrWellnessTopics => "healthOrWellnessTopics",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.HorrorOrFearThemes => "horrorOrFearThemes",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.KidsAgeBand => "kidsAgeBand",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.KoreaAgeRatingOverride => "koreaAgeRatingOverride",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.LootBox => "lootBox",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes => "matureOrSuggestiveThemes",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation => "medicalOrTreatmentInformation",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MessagingAndChat => "messagingAndChat",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ParentalControls => "parentalControls",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor => "profanityOrCrudeHumor",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity => "sexualContentGraphicAndNudity",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SexualContentOrNudity => "sexualContentOrNudity",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SocialMedia => "socialMedia",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SocialMediaAgeRestricted => "socialMediaAgeRestricted",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.UnrestrictedWebAccess => "unrestrictedWebAccess",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.UserGeneratedContent => "userGeneratedContent",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy => "violenceCartoonOrFantasy",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceRealistic => "violenceRealistic",
                AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic => "violenceRealisticProlongedGraphicOrSadistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "advertising" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Advertising,
                "ageAssurance" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeAssurance,
                "ageRatingOverride" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeRatingOverride,
                "ageRatingOverrideV2" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AgeRatingOverrideV2,
                "alcoholTobaccoOrDrugUseOrReferences" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.AlcoholTobaccoOrDrugUseOrReferences,
                "contests" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Contests,
                "developerAgeRatingInfoUrl" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.DeveloperAgeRatingInfoUrl,
                "gambling" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.Gambling,
                "gamblingSimulated" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.GamblingSimulated,
                "gunsOrOtherWeapons" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.GunsOrOtherWeapons,
                "healthOrWellnessTopics" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.HealthOrWellnessTopics,
                "horrorOrFearThemes" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.HorrorOrFearThemes,
                "kidsAgeBand" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.KidsAgeBand,
                "koreaAgeRatingOverride" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.KoreaAgeRatingOverride,
                "lootBox" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.LootBox,
                "matureOrSuggestiveThemes" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MatureOrSuggestiveThemes,
                "medicalOrTreatmentInformation" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MedicalOrTreatmentInformation,
                "messagingAndChat" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.MessagingAndChat,
                "parentalControls" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ParentalControls,
                "profanityOrCrudeHumor" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ProfanityOrCrudeHumor,
                "sexualContentGraphicAndNudity" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SexualContentGraphicAndNudity,
                "sexualContentOrNudity" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SexualContentOrNudity,
                "socialMedia" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SocialMedia,
                "socialMediaAgeRestricted" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.SocialMediaAgeRestricted,
                "unrestrictedWebAccess" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.UnrestrictedWebAccess,
                "userGeneratedContent" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.UserGeneratedContent,
                "violenceCartoonOrFantasy" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceCartoonOrFantasy,
                "violenceRealistic" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceRealistic,
                "violenceRealisticProlongedGraphicOrSadistic" => AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration.ViolenceRealisticProlongedGraphicOrSadistic,
                _ => null,
            };
        }
    }
}