
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType), TypeInfoPropertyName = "AppScreenshotCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType), TypeInfoPropertyName = "AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType), TypeInfoPropertyName = "AppScreenshotUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot), TypeInfoPropertyName = "AppScreenshotsGetInstanceFieldsAppScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet), TypeInfoPropertyName = "AppScreenshotsGetInstanceFieldsAppScreenshotSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem), TypeInfoPropertyName = "AppScreenshotsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType?), TypeInfoPropertyName = "NullableAppScreenshotCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType?), TypeInfoPropertyName = "NullableAppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType?), TypeInfoPropertyName = "NullableAppScreenshotUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot?), TypeInfoPropertyName = "NullableAppScreenshotsGetInstanceFieldsAppScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet?), TypeInfoPropertyName = "NullableAppScreenshotsGetInstanceFieldsAppScreenshotSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppScreenshotsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem>))]
    internal sealed partial class AppScreenshotsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppScreenshotsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppScreenshotsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppScreenshotsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceFieldsAppScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceFieldsAppScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotsGetInstanceIncludeItemNullableJsonConverter();
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
                    0 => new AppScreenshotsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}