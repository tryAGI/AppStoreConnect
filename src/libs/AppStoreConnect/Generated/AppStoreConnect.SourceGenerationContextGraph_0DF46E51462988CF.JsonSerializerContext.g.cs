
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0DF46E51462988CF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0DF46E51462988CF Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0DF46E51462988CF(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataAttributesPlayStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataAttributesPlayStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionInlineCreateRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionInlineCreateRelationshipsActivityDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataAttributesPlayStyle2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateRelationshipsActivity(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateRelationshipsActivityData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateRelationshipsActivityDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterActivityVersionInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_CEBBFB091C1C98F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A84BDE91E305C4A3(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityCreateRequestDataAttributesPlayStyle2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityCreateRequestDataRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityVersionInlineCreateRelationshipsActivityDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterActivityVersionInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterActivityVersionInlineCreateType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1F035F44EFB5ACCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_42B28E1E5D6C90B1(options);
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