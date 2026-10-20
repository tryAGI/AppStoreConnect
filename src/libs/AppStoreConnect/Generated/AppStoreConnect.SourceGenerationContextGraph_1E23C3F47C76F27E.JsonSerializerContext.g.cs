
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1E23C3F47C76F27E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1E23C3F47C76F27E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1E23C3F47C76F27E(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiMacOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributesTestDestination(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributesTestDestinationAvailableRuntime(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_FA480D2D21484CEA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C763964D4B07F89F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A9AC8373B47C27E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A0EDD89FA0F9F15E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1786CC8CE1014150(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E23424BFD6C0290D(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiMacOsVersionRelationshipsXcodeVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiMacOsVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiXcodeVersionRelationshipsMacOsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiXcodeVersionType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiMacOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_900C93AE4F2A930A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90080C24C23F73C5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2ED8F8357BE29652(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_06049EDB80252673(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CF9CD980FACE41CC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F339D6B3059DC8C2(options);
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