
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_3E85AD81DA503C8B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_3E85AD81DA503C8B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_3E85AD81DA503C8B(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCategoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsSubcategoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsSubcategoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsParentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsParentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionFilterPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionFilterPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCategoriesGetCollectionFieldsAppCategorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCategoriesGetCollectionFilterPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCategoriesGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoriesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsParent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsParent(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsParentData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsParentDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsSubcategories(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsSubcategoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryRelationshipsSubcategoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCategoryType2(options);
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
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CA2E0A604176BB2C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_937B79180D6C849C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_87AD27192CF19EA4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5069064F45BAAED2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BFA5641AE0731F05(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3798DE021B791640(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCategoriesGetCollectionFieldsAppCategorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCategoriesGetCollectionFilterPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCategoriesGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCategoryRelationshipsParentDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCategoryRelationshipsSubcategoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCategoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCategoryType2(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7EC1B6D959C30929(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6FACA563DDC83F9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_607119CE27A9DFDE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_852F4B13C4642A10(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_DB401760C9F2DE37(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Platform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_6ADAD7FAA70A2CBB(options);
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