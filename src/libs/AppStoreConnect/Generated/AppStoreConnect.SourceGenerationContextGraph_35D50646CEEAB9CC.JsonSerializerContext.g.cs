
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_35D50646CEEAB9CC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_35D50646CEEAB9CC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_35D50646CEEAB9CC(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceFieldsCustomerReviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceFieldsCustomerReviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponsesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewResponsesGetInstanceFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewResponsesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_899B35EC5999F896(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3E9A366D7107C693(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FE45700EF9D97F77(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewResponsesGetInstanceFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewResponsesGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FC767230E9DA40E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20F9FA89C0D59368(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_409F790560067EAB(options);
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