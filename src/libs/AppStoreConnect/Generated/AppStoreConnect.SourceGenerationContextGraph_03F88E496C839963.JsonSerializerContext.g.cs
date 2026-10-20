
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_03F88E496C839963 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_03F88E496C839963 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_03F88E496C839963(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTestersGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaTestersGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaTestersGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaTestersGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaTestersGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaTestersGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_57B4BCF87A17C047(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C2787439847BD1F4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9346D42387BA7634(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A77A5C67E6109EC7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6965630EAC37BAAE(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaTestersGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaTestersGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaTestersGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaTestersGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTestersGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaTestersGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTestersGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_835A42A38596398C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_47746A46EE4DB376(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AF28F16C125045BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E69ED560E3025B0E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTestersGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E0D5C0816B1EA82B(options);
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