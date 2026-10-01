
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryParentLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType), TypeInfoPropertyName = "AppCategoryParentLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType), TypeInfoPropertyName = "AppCategorySubcategoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform), TypeInfoPropertyName = "AppCategoriesGetCollectionFilterPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie), TypeInfoPropertyName = "AppCategoriesGetCollectionFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem), TypeInfoPropertyName = "AppCategoriesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie), TypeInfoPropertyName = "AppCategoriesGetInstanceFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem), TypeInfoPropertyName = "AppCategoriesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppCategoriesParentGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppCategoryParentLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppCategorySubcategoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform?), TypeInfoPropertyName = "NullableAppCategoriesGetCollectionFilterPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppCategoriesGetCollectionFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableAppCategoriesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppCategoriesGetInstanceFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppCategoriesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppCategoriesParentGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie>))]
    internal sealed partial class AppCategoriesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCategoriesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppCategoriesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppCategoriesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryParentLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryParentLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryParentLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategorySubcategoriesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategorySubcategoriesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategorySubcategoriesLinkagesResponseDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetInstanceFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetInstanceFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesParentGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesParentGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorieNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new AppCategoriesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}