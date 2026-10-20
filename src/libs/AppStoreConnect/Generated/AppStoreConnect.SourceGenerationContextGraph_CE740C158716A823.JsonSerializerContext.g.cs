
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CE740C158716A823 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CE740C158716A823 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CE740C158716A823(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPagesGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPagesGetInstanceFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppCustomProductPagesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A23FA16197D7D5E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_615AAF68D3BE2342(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C6572A9F1ADB09A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BC38E5E56BFB85F7(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPagesGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPagesGetInstanceFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppCustomProductPagesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_547489BBBA1DE71E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A4230E897BFB7459(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9E8C450871B3003D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0BBF3E6CEEB0FC90(options);
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