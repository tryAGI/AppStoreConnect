
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType), TypeInfoPropertyName = "BetaAppLocalizationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "BetaAppLocalizationCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType), TypeInfoPropertyName = "BetaAppLocalizationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType), TypeInfoPropertyName = "BetaAppLocalizationAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization), TypeInfoPropertyName = "BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp), TypeInfoPropertyName = "BetaAppLocalizationsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem), TypeInfoPropertyName = "BetaAppLocalizationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization), TypeInfoPropertyName = "BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp), TypeInfoPropertyName = "BetaAppLocalizationsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem), TypeInfoPropertyName = "BetaAppLocalizationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp), TypeInfoPropertyName = "BetaAppLocalizationsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType?), TypeInfoPropertyName = "NullableBetaAppLocalizationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBetaAppLocalizationCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType?), TypeInfoPropertyName = "NullableBetaAppLocalizationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType?), TypeInfoPropertyName = "NullableBetaAppLocalizationAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetCollectionFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetInstanceFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableBetaAppLocalizationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp?), TypeInfoPropertyName = "NullableBetaAppLocalizationsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp>))]
    internal sealed partial class BetaAppLocalizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaAppLocalizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaAppLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationAppLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationAppLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationAppLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsAppGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationsAppGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationsAppGetToOneRelatedFieldsAppNullableJsonConverter();
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
                    0 => new BetaAppLocalizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}