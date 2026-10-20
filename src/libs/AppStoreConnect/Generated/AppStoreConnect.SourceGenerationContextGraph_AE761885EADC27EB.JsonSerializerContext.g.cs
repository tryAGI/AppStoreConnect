
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_AE761885EADC27EB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_AE761885EADC27EB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_AE761885EADC27EB(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2NullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmission(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequest(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestDataRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionCreateRequestDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseSubmissionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseType22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshot(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshotData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContent(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceSchedule(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceScheduleData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceScheduleDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImages(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImagesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailability(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePoints))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePoints(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePointsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePointsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_18612FC2D0B60CB9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3E6DC4926168F9AC(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1A183C6D5A2F41E3(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B25A8A1E8ACC60A5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_286F7E5AD57807A4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_426B2661E4AC7F9F(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseSubmissionCreateRequestDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseSubmissionRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseSubmissionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseSubmissionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseType22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsContentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsIapPriceScheduleDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsOfferCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsPricePointsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsPromotedPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_86B7A6ABFA8C3C5F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB080C51C5965C56(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AC3A4EA9918FCDC8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8F2C88A7D72EF3C5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6969942D5F71CFE(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_35A37E22C117E90D(options);
                }
                #pragma warning restore CS0618
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