
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_B9C93946467C29B3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_B9C93946467C29B3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_B9C93946467C29B3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EB4C508DFF3ED6CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1205496106F718C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2543C294277D3587(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_918A2C936ABA9017(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1CF91B1C24BF7A4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_785566AA54C96833(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_30B20A7061E1AB85(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A759F293679A355E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3F955778FDFC9AAA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E0125A336A76C145(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7514C894FBBD7485(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F79D786869818289(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2F0BB4BB4D98A01A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_73584FCC2628851B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BBAA72E7F86B97E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_464F7BDE0413F553(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EB33336EEC325C82(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6127515324D340D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_38A224451C03BC8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1C7CEB5028322E12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C741A6D40FE22C1D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D90DDFE79875AC0D(options);
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