
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A321A1A2843C84BA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A321A1A2843C84BA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A321A1A2843C84BA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ADD5CDB6A7468D22(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_988A6443A6E50E91(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F9FC6E1E4AF0404A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B2274D4219575018(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_51EEDAA6611BA4C9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B8F2547A8F0F37D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C95C32097A2128DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EE7220B7BAE6E932(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1762573A79B1C057(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2A4444A539792F97(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4414604419043029(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3EC3A046E74F7999(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_ADE7795A4F391B18(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BF4150A7D2A9FC7C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FCC46C7CB849ED12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FC88667529823AA5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_90A5666D8F888E0A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_8B0586FFDBCCD1EC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_85D90DA7BFBAD395(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_12D1D3524024EECE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_514EDC03E0A4467A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7E6DEDB823F73E33(options);
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