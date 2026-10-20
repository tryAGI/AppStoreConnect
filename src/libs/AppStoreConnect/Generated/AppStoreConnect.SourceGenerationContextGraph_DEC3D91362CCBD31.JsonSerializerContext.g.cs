
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DEC3D91362CCBD31 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DEC3D91362CCBD31 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DEC3D91362CCBD31(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_2F5E40DBCD8EC9BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_10261ADF01F812A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_0B7EDC899D72CC06(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_548879E0A03D12A2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_95B03E6A437DC0B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_27196E6DF033BEAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_342051EE01CD8B88(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_23D044BE8EC9D077(options);
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