
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CD7F7547FA2CCA83 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CD7F7547FA2CCA83 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CD7F7547FA2CCA83(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionGroupVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A235D6156F420405(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E505AF120F047D7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_30A0173AB978E8B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_57BD86282174EAE6(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionGroupVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7868859629013B22(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_44673486C4E3FB11(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E732CA57C5BB877D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A663F339FDEE6FF1(options);
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