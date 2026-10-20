
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_504C0CC0E9248B8B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_504C0CC0E9248B8B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_504C0CC0E9248B8B(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiProductsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiProductsGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiProductsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiProductsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiProductsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8CB52B11DB5727C4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7C820BEBB50341E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EE3EB7FA1798D462(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AFFAB2A70D17EBA9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F283CFFE121432AC(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsGetInstanceFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20820C160095FC5B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7650A20EC63020F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D9810BF890445044(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B2BAF7FE4DDE638D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FFC5942EA180F7A2(options);
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