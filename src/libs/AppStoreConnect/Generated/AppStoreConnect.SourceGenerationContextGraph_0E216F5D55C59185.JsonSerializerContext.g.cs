
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0E216F5D55C59185 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0E216F5D55C59185 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0E216F5D55C59185(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType?)

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

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationshipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationshipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlace))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlace(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointCoordinates))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointCoordinates(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddressStructuredAddress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMainAddressStructuredAddress(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAdvancedExperienceCreateRequestDataType2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7739CDBB0710B88F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EDAA3F9319C55F75(options);
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
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataAttributesPlaceRelationship2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLanguage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLanguage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAdvancedExperienceLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_044E96957E733C36(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_5F594595B9139108(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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