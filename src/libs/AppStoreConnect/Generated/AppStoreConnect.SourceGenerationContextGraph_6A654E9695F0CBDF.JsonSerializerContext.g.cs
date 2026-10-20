
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_6A654E9695F0CBDF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_6A654E9695F0CBDF Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_6A654E9695F0CBDF(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFilterCertificateTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFilterCertificateTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesGetCollectionFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesGetCollectionFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesGetCollectionFilterCertificateTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CertificatesGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0E33ECBEFB4BF1BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FF0584B5507FE9CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6B0729BAC404F0BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CF174B9D4FB7F974(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2BEA050AD4A312C1(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCertificatesGetCollectionFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCertificatesGetCollectionFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCertificatesGetCollectionFilterCertificateTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCertificatesGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCertificatesGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5DC180C136369C34(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1760637FAB765148(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_252619BE61356B29(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_531C31B6C259DC2D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F791DB1AFBCF7EC0(options);
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