
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4CDF699175E0172F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4CDF699175E0172F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4CDF699175E0172F(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.PassTypeIdsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PassTypeIdsGetInstanceFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PassTypeIdsGetInstanceFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PassTypeIdsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4AB6FD64D1279159(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F51091D39E796936(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_70A0602F9B90E775(options);
                }
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePassTypeIdsGetInstanceFieldsCertificate2(options);
                }
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePassTypeIdsGetInstanceFieldsPassTypeId2(options);
                }
                if (type == typeof(global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePassTypeIdsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F9C0DCAF34579676(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_14FC689D694291E0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6FFAD966A84A969B(options);
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