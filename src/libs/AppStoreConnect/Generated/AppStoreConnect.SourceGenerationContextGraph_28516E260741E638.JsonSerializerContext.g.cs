
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_28516E260741E638 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_28516E260741E638 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_28516E260741E638(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem38JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperiment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatments))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatments(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalization(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacements(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentsResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExp_315c59d1a235d8d1(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem38))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem382(options);
                }
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6DFFBAED08AF96CB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6A771C2359C72B86(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4500CDA7623C24B7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_062049DB262F22F0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_052B25D6EAAD6B0B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_262BDBEABF4ED396(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_283F5A05E512DDE5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F3394EC934987078(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F5A0EEA9C811AE93(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EAC549B5AE6D7BF4(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem38>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A8A2AC909DA3C219(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentRelationshipsAppStoreVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExp_678eaca98939dd6f(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExp_23ce81a42d5befec(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem38?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem382(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CFDBA89E23C205AA(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_E3C28ADAC71E03DE(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_344F5A10F3688504(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_566C33F02254E929(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_ED9C675E384A1CF2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_346FE0AD2F2E5E85(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_095A62A1C5D40E78(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3CA7E9305E1714D4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_01F913016EFF0ACB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_89A8AB094F964134(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem38>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_D6FDA46782098DA1(options);
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