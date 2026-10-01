
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType), TypeInfoPropertyName = "BetaBuildLocalizationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType), TypeInfoPropertyName = "BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType), TypeInfoPropertyName = "BetaBuildLocalizationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType), TypeInfoPropertyName = "BetaBuildLocalizationBuildLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization), TypeInfoPropertyName = "BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild), TypeInfoPropertyName = "BetaBuildLocalizationsGetCollectionFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem), TypeInfoPropertyName = "BetaBuildLocalizationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization), TypeInfoPropertyName = "BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild), TypeInfoPropertyName = "BetaBuildLocalizationsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem), TypeInfoPropertyName = "BetaBuildLocalizationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationBuildLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetCollectionFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableBetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild>))]
    internal sealed partial class BetaBuildLocalizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaBuildLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaBuildLocalizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaBuildLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationCreateRequestDataRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationBuildLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationBuildLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationBuildLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuildNullableJsonConverter();
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
                    0 => new BetaBuildLocalizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}