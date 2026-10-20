
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_3FCAEDE46A76C848 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_3FCAEDE46A76C848 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_3FCAEDE46A76C848(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationsV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationsV2Response(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImageData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImages(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImagesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9069CABAF301CBD8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5A31EFB1082190DB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E06D35CA4C51590E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2178BF6184E53908(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_8647F2CC34A90945(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_B96658EEB65423E6(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_38E452B26BCBBEFC(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseLocalizationV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_12F03CF3923CDAFF(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_61A2A9986FA95C12(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DA75E0250B4A4C8A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_772F5A94FB3A84B2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_485E1F217976CD64(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2F30F6E5B3AA2798(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4212BE5804F5645D(options);
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