
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType), TypeInfoPropertyName = "AppEventVideoClipCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType), TypeInfoPropertyName = "AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType), TypeInfoPropertyName = "AppEventVideoClipUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip), TypeInfoPropertyName = "AppEventVideoClipsGetInstanceFieldsAppEventVideoClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization), TypeInfoPropertyName = "AppEventVideoClipsGetInstanceFieldsAppEventLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem), TypeInfoPropertyName = "AppEventVideoClipsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType?), TypeInfoPropertyName = "NullableAppEventVideoClipCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType?), TypeInfoPropertyName = "NullableAppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType?), TypeInfoPropertyName = "NullableAppEventVideoClipUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip?), TypeInfoPropertyName = "NullableAppEventVideoClipsGetInstanceFieldsAppEventVideoClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization?), TypeInfoPropertyName = "NullableAppEventVideoClipsGetInstanceFieldsAppEventLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppEventVideoClipsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem>))]
    internal sealed partial class AppEventVideoClipsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventVideoClipsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppEventVideoClipsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppEventVideoClipsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceFieldsAppEventVideoClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventVideoClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceFieldsAppEventVideoClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceFieldsAppEventLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceFieldsAppEventLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceFieldsAppEventLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventVideoClipsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventVideoClipsGetInstanceIncludeItemNullableJsonConverter();
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
                    0 => new AppEventVideoClipsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}