
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CF8D803CAA4B068B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CF8D803CAA4B068B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CF8D803CAA4B068B(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataAttributesProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataAttributesProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsDevicesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsDevicesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsCertificatesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsCertificatesDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataAttributesProfileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsBundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsBundleIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificates))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsCertificates(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsCertificatesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsCertificatesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsDevices(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsDevicesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataRelationshipsDevicesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5418E1E10716157A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F81FB34057CB7723(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileCreateRequestDataAttributesProfileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileCreateRequestDataRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileCreateRequestDataRelationshipsCertificatesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileCreateRequestDataRelationshipsDevicesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_23BC38F4B432BFFA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2647B09E7F2E7359(options);
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