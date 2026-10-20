
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_759228C95D05D01B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_759228C95D05D01B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_759228C95D05D01B(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibrary))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibrary(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C802E622256C6044(options);
                }
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageCreateRequestDataType2(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_28E23132BB7DE290(options);
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