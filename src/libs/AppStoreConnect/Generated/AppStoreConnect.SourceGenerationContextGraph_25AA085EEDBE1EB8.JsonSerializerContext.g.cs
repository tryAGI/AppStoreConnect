
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_25AA085EEDBE1EB8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_25AA085EEDBE1EB8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_25AA085EEDBE1EB8(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchasesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PromotedPurchasesGetInstanceFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PromotedPurchasesGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PromotedPurchasesGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_PromotedPurchasesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6EE128F669B38B4F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E9CEC3BEAEF5E56D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_062566AD406CF4DA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A39FAEFCAA036BF9(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePromotedPurchasesGetInstanceFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePromotedPurchasesGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePromotedPurchasesGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullablePromotedPurchasesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D6041B24E72BEB68(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8B1782A389B7D8B7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0A2D44FBE02B6C47(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7BDDDB8C9752741A(options);
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