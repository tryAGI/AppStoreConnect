
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgeRatingDeclarationUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advertising")]
        public bool? Advertising { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alcoholTobaccoOrDrugUseOrReferences")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferencesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences? AlcoholTobaccoOrDrugUseOrReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesContestsJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests? Contests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gambling")]
        public bool? Gambling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gamblingSimulated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulatedJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated? GamblingSimulated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gunsOrOtherWeapons")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeaponsJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons? GunsOrOtherWeapons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthOrWellnessTopics")]
        public bool? HealthOrWellnessTopics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kidsAgeBand")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.KidsAgeBandJsonConverter))]
        public global::AppStoreConnect.KidsAgeBand? KidsAgeBand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lootBox")]
        public bool? LootBox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medicalOrTreatmentInformation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformationJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation? MedicalOrTreatmentInformation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagingAndChat")]
        public bool? MessagingAndChat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentalControls")]
        public bool? ParentalControls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanityOrCrudeHumor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumorJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor? ProfanityOrCrudeHumor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageAssurance")]
        public bool? AgeAssurance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexualContentGraphicAndNudity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudityJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity? SexualContentGraphicAndNudity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexualContentOrNudity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudityJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity? SexualContentOrNudity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialMedia")]
        public bool? SocialMedia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialMediaAgeRestricted")]
        public bool? SocialMediaAgeRestricted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horrorOrFearThemes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes? HorrorOrFearThemes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matureOrSuggestiveThemes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes? MatureOrSuggestiveThemes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrestrictedWebAccess")]
        public bool? UnrestrictedWebAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userGeneratedContent")]
        public bool? UserGeneratedContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceCartoonOrFantasy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasyJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy? ViolenceCartoonOrFantasy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceRealisticProlongedGraphicOrSadistic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadisticJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic? ViolenceRealisticProlongedGraphicOrSadistic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violenceRealistic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic? ViolenceRealistic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageRatingOverride")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride? AgeRatingOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ageRatingOverrideV2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2JsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2? AgeRatingOverrideV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("koreaAgeRatingOverride")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverrideJsonConverter))]
        public global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride? KoreaAgeRatingOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developerAgeRatingInfoUrl")]
        public string? DeveloperAgeRatingInfoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRatingDeclarationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="advertising"></param>
        /// <param name="alcoholTobaccoOrDrugUseOrReferences"></param>
        /// <param name="contests"></param>
        /// <param name="gambling"></param>
        /// <param name="gamblingSimulated"></param>
        /// <param name="gunsOrOtherWeapons"></param>
        /// <param name="healthOrWellnessTopics"></param>
        /// <param name="kidsAgeBand"></param>
        /// <param name="lootBox"></param>
        /// <param name="medicalOrTreatmentInformation"></param>
        /// <param name="messagingAndChat"></param>
        /// <param name="parentalControls"></param>
        /// <param name="profanityOrCrudeHumor"></param>
        /// <param name="ageAssurance"></param>
        /// <param name="sexualContentGraphicAndNudity"></param>
        /// <param name="sexualContentOrNudity"></param>
        /// <param name="socialMedia"></param>
        /// <param name="socialMediaAgeRestricted"></param>
        /// <param name="horrorOrFearThemes"></param>
        /// <param name="matureOrSuggestiveThemes"></param>
        /// <param name="unrestrictedWebAccess"></param>
        /// <param name="userGeneratedContent"></param>
        /// <param name="violenceCartoonOrFantasy"></param>
        /// <param name="violenceRealisticProlongedGraphicOrSadistic"></param>
        /// <param name="violenceRealistic"></param>
        /// <param name="ageRatingOverrideV2"></param>
        /// <param name="koreaAgeRatingOverride"></param>
        /// <param name="developerAgeRatingInfoUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgeRatingDeclarationUpdateRequestDataAttributes(
            bool? advertising,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences? alcoholTobaccoOrDrugUseOrReferences,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests? contests,
            bool? gambling,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated? gamblingSimulated,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons? gunsOrOtherWeapons,
            bool? healthOrWellnessTopics,
            global::AppStoreConnect.KidsAgeBand? kidsAgeBand,
            bool? lootBox,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation? medicalOrTreatmentInformation,
            bool? messagingAndChat,
            bool? parentalControls,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor? profanityOrCrudeHumor,
            bool? ageAssurance,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity? sexualContentGraphicAndNudity,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity? sexualContentOrNudity,
            bool? socialMedia,
            bool? socialMediaAgeRestricted,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes? horrorOrFearThemes,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes? matureOrSuggestiveThemes,
            bool? unrestrictedWebAccess,
            bool? userGeneratedContent,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy? violenceCartoonOrFantasy,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic? violenceRealisticProlongedGraphicOrSadistic,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic? violenceRealistic,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2? ageRatingOverrideV2,
            global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride? koreaAgeRatingOverride,
            string? developerAgeRatingInfoUrl)
        {
            this.Advertising = advertising;
            this.AlcoholTobaccoOrDrugUseOrReferences = alcoholTobaccoOrDrugUseOrReferences;
            this.Contests = contests;
            this.Gambling = gambling;
            this.GamblingSimulated = gamblingSimulated;
            this.GunsOrOtherWeapons = gunsOrOtherWeapons;
            this.HealthOrWellnessTopics = healthOrWellnessTopics;
            this.KidsAgeBand = kidsAgeBand;
            this.LootBox = lootBox;
            this.MedicalOrTreatmentInformation = medicalOrTreatmentInformation;
            this.MessagingAndChat = messagingAndChat;
            this.ParentalControls = parentalControls;
            this.ProfanityOrCrudeHumor = profanityOrCrudeHumor;
            this.AgeAssurance = ageAssurance;
            this.SexualContentGraphicAndNudity = sexualContentGraphicAndNudity;
            this.SexualContentOrNudity = sexualContentOrNudity;
            this.SocialMedia = socialMedia;
            this.SocialMediaAgeRestricted = socialMediaAgeRestricted;
            this.HorrorOrFearThemes = horrorOrFearThemes;
            this.MatureOrSuggestiveThemes = matureOrSuggestiveThemes;
            this.UnrestrictedWebAccess = unrestrictedWebAccess;
            this.UserGeneratedContent = userGeneratedContent;
            this.ViolenceCartoonOrFantasy = violenceCartoonOrFantasy;
            this.ViolenceRealisticProlongedGraphicOrSadistic = violenceRealisticProlongedGraphicOrSadistic;
            this.ViolenceRealistic = violenceRealistic;
            this.AgeRatingOverrideV2 = ageRatingOverrideV2;
            this.KoreaAgeRatingOverride = koreaAgeRatingOverride;
            this.DeveloperAgeRatingInfoUrl = developerAgeRatingInfoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRatingDeclarationUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AgeRatingDeclarationUpdateRequestDataAttributes()
        {
        }

    }
}