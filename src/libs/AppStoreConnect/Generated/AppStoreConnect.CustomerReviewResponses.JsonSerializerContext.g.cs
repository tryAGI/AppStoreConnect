
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType), TypeInfoPropertyName = "CustomerReviewResponseV1CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType), TypeInfoPropertyName = "CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse), TypeInfoPropertyName = "CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview), TypeInfoPropertyName = "CustomerReviewResponsesGetInstanceFieldsCustomerReview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem), TypeInfoPropertyName = "CustomerReviewResponsesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType?), TypeInfoPropertyName = "NullableCustomerReviewResponseV1CreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType?), TypeInfoPropertyName = "NullableCustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse?), TypeInfoPropertyName = "NullableCustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview?), TypeInfoPropertyName = "NullableCustomerReviewResponsesGetInstanceFieldsCustomerReview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCustomerReviewResponsesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>))]
    internal sealed partial class CustomerReviewResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CustomerReviewResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CustomerReviewResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse)

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
                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1CreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1CreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataTypeNullableJsonConverter();
                }

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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new CustomerReviewResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}