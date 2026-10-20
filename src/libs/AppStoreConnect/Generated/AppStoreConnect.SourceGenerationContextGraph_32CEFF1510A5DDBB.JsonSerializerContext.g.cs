
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_32CEFF1510A5DDBB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_32CEFF1510A5DDBB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_32CEFF1510A5DDBB(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionOfferCodesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6DD5B08F1CC63920(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9F285FC0574AC2A9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_833D78B0737F60FE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E052CB20985F0E0D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FE61B99886AF0C2E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C8CBBE8380C4DCAA(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionOfferCodesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A5E15B289F84345B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E9596F31730A023A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_61E8C5467B39309D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_969D4877F4693B84(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DAE3981725516F99(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_41DEC6E1E00AE986(options);
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