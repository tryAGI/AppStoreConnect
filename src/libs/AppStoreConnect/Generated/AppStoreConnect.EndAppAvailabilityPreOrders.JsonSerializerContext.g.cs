
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType), TypeInfoPropertyName = "EndAppAvailabilityPreOrderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType), TypeInfoPropertyName = "EndAppAvailabilityPreOrderCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType), TypeInfoPropertyName = "EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType?), TypeInfoPropertyName = "NullableEndAppAvailabilityPreOrderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType?), TypeInfoPropertyName = "NullableEndAppAvailabilityPreOrderCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType?), TypeInfoPropertyName = "NullableEndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItem>))]
    internal sealed partial class EndAppAvailabilityPreOrdersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndAppAvailabilityPreOrdersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EndAppAvailabilityPreOrdersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EndAppAvailabilityPreOrdersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderCreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemTypeNullableJsonConverter();
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
                    0 => new EndAppAvailabilityPreOrdersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}