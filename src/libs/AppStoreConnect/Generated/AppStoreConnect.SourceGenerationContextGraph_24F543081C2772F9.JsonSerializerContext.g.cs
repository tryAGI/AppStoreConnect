
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_24F543081C2772F9 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_24F543081C2772F9 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_24F543081C2772F9(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BundleIdType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsProfilesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsProfilesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsBundleIdCapabilitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsBundleIdCapabilitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesBundleIdGetToOneRelatedFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesBundleIdGetToOneRelatedFieldsBundleIdNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilities))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsBundleIdCapabilities(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsBundleIdCapabilitiesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsBundleIdCapabilitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsProfiles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsProfiles(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsProfilesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdRelationshipsProfilesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdWithoutIncludesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BundleIdWithoutIncludesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ProfilesBundleIdGetToOneRelatedFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B3BAE8379027C643(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B77263C8E479D80A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_21F84545AC762885(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdRelationshipsBundleIdCapabilitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdRelationshipsProfilesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableProfilesBundleIdGetToOneRelatedFieldsBundleId2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6105FEA000DDC166(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_73DC718E80A1A556(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CFF2F2FD6375583A(options);
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