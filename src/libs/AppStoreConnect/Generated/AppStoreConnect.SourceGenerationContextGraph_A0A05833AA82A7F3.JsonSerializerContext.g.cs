
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A0A05833AA82A7F3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A0A05833AA82A7F3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A0A05833AA82A7F3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionVersionsGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionVersionsGetInstanceFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionVersionsGetInstanceFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F75AEE4387ABB5E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F4842010ADAD63AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C76312C75F9C1FE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2663843363057DB9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_733B1CC54AC99966(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionVersionsGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionVersionsGetInstanceFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionVersionsGetInstanceFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionVersionsGetInstanceFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE05DD4FAE1F9401(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_72BA06321603992E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D689E52B3E22547C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B7CE91C4BB3763EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE1894923503405D(options);
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