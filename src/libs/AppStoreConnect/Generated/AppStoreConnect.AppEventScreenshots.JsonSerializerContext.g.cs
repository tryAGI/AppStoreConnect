
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType), TypeInfoPropertyName = "AppEventScreenshotCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType), TypeInfoPropertyName = "AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType), TypeInfoPropertyName = "AppEventScreenshotUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot), TypeInfoPropertyName = "AppEventScreenshotsGetInstanceFieldsAppEventScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization), TypeInfoPropertyName = "AppEventScreenshotsGetInstanceFieldsAppEventLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem), TypeInfoPropertyName = "AppEventScreenshotsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType?), TypeInfoPropertyName = "NullableAppEventScreenshotCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType?), TypeInfoPropertyName = "NullableAppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType?), TypeInfoPropertyName = "NullableAppEventScreenshotUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot?), TypeInfoPropertyName = "NullableAppEventScreenshotsGetInstanceFieldsAppEventScreenshot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization?), TypeInfoPropertyName = "NullableAppEventScreenshotsGetInstanceFieldsAppEventLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppEventScreenshotsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem>))]
    internal sealed partial class AppEventScreenshotsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventScreenshotsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppEventScreenshotsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppEventScreenshotsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceFieldsAppEventScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceFieldsAppEventScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventScreenshotsGetInstanceIncludeItemNullableJsonConverter();
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
                    0 => new AppEventScreenshotsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}