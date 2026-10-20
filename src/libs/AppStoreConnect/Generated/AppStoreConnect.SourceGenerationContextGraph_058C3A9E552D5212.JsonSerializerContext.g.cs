
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_058C3A9E552D5212 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_058C3A9E552D5212 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_058C3A9E552D5212(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesContestsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesContestsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGamblingSimulatedJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGamblingSimulatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGunsOrOtherWeaponsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGunsOrOtherWeaponsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMedicalOrTreatmentInformationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMedicalOrTreatmentInformationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesProfanityOrCrudeHumorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesProfanityOrCrudeHumorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentGraphicAndNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentGraphicAndNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentOrNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentOrNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesHorrorOrFearThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesHorrorOrFearThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMatureOrSuggestiveThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMatureOrSuggestiveThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceCartoonOrFantasyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceCartoonOrFantasyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesKoreaAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesKoreaAgeRatingOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand))
                {
                    return new global::AppStoreConnect.JsonConverters.KidsAgeBandJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?))
                {
                    return new global::AppStoreConnect.JsonConverters.KidsAgeBandNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributes(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesAgeRatingOverride2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesAgeRatingOverrideV22(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesContests2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesGamblingSimulated2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesGunsOrOtherWeapons2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesHorrorOrFearThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesKoreaAgeRatingOverride2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesMatureOrSuggestiveThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesMedicalOrTreatmentInformation2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesProfanityOrCrudeHumor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesSexualContentGraphicAndNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesSexualContentOrNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesViolenceCartoonOrFantasy2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesViolenceRealistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.KidsAgeBand))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_KidsAgeBand2(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesAgeRatingOverride2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesAgeRatingOverrideV22(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesContests2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesGamblingSimulated2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesGunsOrOtherWeapons2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesHorrorOrFearThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesKoreaAgeRatingOverride2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesMatureOrSuggestiveThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesMedicalOrTreatmentInformation2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesProfanityOrCrudeHumor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesSexualContentGraphicAndNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesSexualContentOrNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesViolenceCartoonOrFantasy2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesViolenceRealistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.KidsAgeBand?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableKidsAgeBand2(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}