
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_8F5D2B0B32722BF5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_8F5D2B0B32722BF5 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_8F5D2B0B32722BF5(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_37E9A0C16F00F68D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0C1BA7CD7E5CBA01(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3CBDD2AC0B2BBFE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B94F9A9E49A3EE31(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C1FD68916A1FBC1B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3764E6F90B0C6381(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0E03288A80085F00(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A771E2726EF9232A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2F5AF7ECFB71D67F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CF5C5015BB26193C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7AA3691AB11042CA(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibraryImagesPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8749CA6A8694EC27(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1AD78F3AEA5FAE6E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D736AAE45646B92B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4F89DB3784F0CBB1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B6A5549449B6E3E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E3C926910D87BDFC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0A014B90F9F39C8B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B4CB0EE3B65F7E21(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8DFEB372C5FBA467(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C24A853BAA5AEF4C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4087B8110184ECF2(options);
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