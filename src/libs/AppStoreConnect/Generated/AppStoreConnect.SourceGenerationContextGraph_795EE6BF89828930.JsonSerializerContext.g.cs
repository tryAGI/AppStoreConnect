
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_795EE6BF89828930 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_795EE6BF89828930 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_795EE6BF89828930(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem5JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceDisplayPointSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceDisplayPointSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceMapActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceMapActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceRelationshipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceRelationshipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlacePhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlacePhoneNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesBusinessCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesBusinessCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsHeaderImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsHeaderImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatuJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatuNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatuJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatuNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlace))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlace(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceDisplayPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointCoordinates))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceDisplayPointCoordinates(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceMainAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumber))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlacePhoneNumber(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesPlaceStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceAttributesStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceImageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLanguage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsHeaderImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsHeaderImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperiencesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperiencesResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipAdvancedExperiences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipAdvancedExperiences(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiences(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiencesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiencesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppMediaAssetState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaStateError))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaStateError(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem5))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem52_3(options);
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
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1A6A97141C4354DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C3D38CB47AD3FA34(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_26FEFEEC1B548F87(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_71D7A1575D9105A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A24CE43F2E316111(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EFA6DAD82262A82E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_87D67AF6FB312E3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6A6F88BCBEADD3AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_990D1B0635FEF3E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5D35543F9D32A884(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0DE80D67627F533D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem5>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E818117B3BCD1918(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceDisplayPointSource?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceMapAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlacePhoneNumberType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceRelationship?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesPlaceStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceAttributesStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLanguage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsHeaderImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipRelationshipsAppClipDefaultExperiencesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem5?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem52_3(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_50C0EE4481182406(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperienceRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_FE55F073A4FB0D1A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_F2852253E013C217(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3EF6C9AFA7CDCDB3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C874F5D72CDA8434(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BD67E2BAEE3C4854(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3D524FD994DD5C86(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B7F71BB40434C371(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A551E8B8D8F719C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E8C2165A00797C52(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CF81964F8E3C05AD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem5>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_FEF70F2FE8397676(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_4C40FFC5269982A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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