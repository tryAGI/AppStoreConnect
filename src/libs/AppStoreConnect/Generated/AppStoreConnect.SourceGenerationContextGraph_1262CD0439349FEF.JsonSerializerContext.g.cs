
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1262CD0439349FEF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1262CD0439349FEF Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1262CD0439349FEF(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_MerchantIdsCertificatesGetToManyRelatedFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_MerchantIdsCertificatesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_MerchantIdsCertificatesGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_2F3EB270BDAC1399(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_3D4D5EEA59A6A385(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_CD18B03582465464(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_C6BECA2732F0F23B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_B892CA22CE2BD0EC(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableMerchantIdsCertificatesGetToManyRelatedFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableMerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableMerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableMerchantIdsCertificatesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableMerchantIdsCertificatesGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4FD8CDAA5373CC3B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AD496F322D682138(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E1292FB64E079E6E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9E62063850AA612E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C18354F32E86DF0B(options);
                }
                return null;
            }
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