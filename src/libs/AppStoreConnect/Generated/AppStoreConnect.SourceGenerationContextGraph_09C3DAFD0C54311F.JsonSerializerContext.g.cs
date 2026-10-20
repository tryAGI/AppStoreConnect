
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_09C3DAFD0C54311F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_09C3DAFD0C54311F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_09C3DAFD0C54311F(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityAttributesContentStatuseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityAttributesContentStatuseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAvailabilityUpdateRequestDataTypeNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.Territory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Territory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_TerritoryAvailability(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityAttributesContentStatuse2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityUpdateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAvailabilityUpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Territory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9F4289B69AA2C0EC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2BA1B9B8A1321094(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryAvailabilityAttributesContentStatuse2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryAvailabilityRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryAvailabilityType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAvailabilityUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryAvailabilityUpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Territory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F260B12DCFDBCB53(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_13A7858780FEEBD5(options);
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