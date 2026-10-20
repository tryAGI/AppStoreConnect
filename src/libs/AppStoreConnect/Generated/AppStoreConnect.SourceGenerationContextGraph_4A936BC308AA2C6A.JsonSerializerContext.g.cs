
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4A936BC308AA2C6A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4A936BC308AA2C6A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4A936BC308AA2C6A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsBundleIdCapabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsBundleIdCapabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdsGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdsGetInstanceFieldsBundleIdCapabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdsGetInstanceFieldsProfile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_36A954AECBF503E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_425414232EA30DBA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EB4E9B6C68F28C92(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_45ECF78134B625FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C2C70CA4DC7C2F51(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBundleIdsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBundleIdsGetInstanceFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBundleIdsGetInstanceFieldsBundleIdCapabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBundleIdsGetInstanceFieldsProfile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBundleIdsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_254CA3E62877CAC9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_33AF5612B4CB456E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5D4E24A498F38A0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D4125DF0702DFFB6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7B6DDF1F322FA487(options);
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