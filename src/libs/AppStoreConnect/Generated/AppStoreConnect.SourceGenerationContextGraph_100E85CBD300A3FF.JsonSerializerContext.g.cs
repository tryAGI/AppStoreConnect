
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_100E85CBD300A3FF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_100E85CBD300A3FF Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_100E85CBD300A3FF(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLocalizationInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLocalizationInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationshipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationshipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLanguage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalizationInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalizationInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlace))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlace(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointCoordinates))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointCoordinates(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddressStructuredAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMainAddressStructuredAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumber))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumber(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceUpdateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EDAA3F9319C55F75(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_211DD081FDF9903E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
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
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLanguage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceUpdateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_5F594595B9139108(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_79C0F6963A48D567(options);
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