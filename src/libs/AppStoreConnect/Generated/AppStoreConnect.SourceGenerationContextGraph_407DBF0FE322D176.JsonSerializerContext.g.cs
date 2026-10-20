
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_407DBF0FE322D176 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_407DBF0FE322D176 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_407DBF0FE322D176(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEvents))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsInAppEvents(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsInAppEventsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedApps))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsRelatedApps(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsRelatedAppsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsSupportedTerritories(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C47828CF95D234AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B5434CEA913DF9DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C2BBDA95BADF4BCF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C42340706BAF598F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationCreateRequestDataAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationCreateRequestDataRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationCreateRequestDataRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationCreateRequestDataType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB4EC4F72F3ACB31(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0955592ACAC962DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AC3A931E3C0BF300(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8210030FA35122FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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