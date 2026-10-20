
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1EB84DA1CFDF998F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1EB84DA1CFDF998F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1EB84DA1CFDF998F(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferencesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferencesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesContestsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesContestsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulatedJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeaponsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeaponsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverrideNullableJsonConverter();
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
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributes(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV22(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesContests2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AgeRatingDeclarationUpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.KidsAgeBand))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_KidsAgeBand2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV22(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesContests?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesContests2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesGamblingSimulated2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesSexualContentOrNudity2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesViolenceRealistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic2(options);
                }
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAgeRatingDeclarationUpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.KidsAgeBand?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableKidsAgeBand2(options);
                }
                return null;
            }
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