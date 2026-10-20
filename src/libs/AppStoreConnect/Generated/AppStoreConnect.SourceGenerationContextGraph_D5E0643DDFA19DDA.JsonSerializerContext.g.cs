
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D5E0643DDFA19DDA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D5E0643DDFA19DDA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D5E0643DDFA19DDA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEvents))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsInAppEvents(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsInAppEventsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedApps))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsRelatedApps(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsRelatedAppsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsSupportedTerritories(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationUpdateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C47828CF95D234AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_41C388EF43F13FAF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_41CA4BA9EC0FB395(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E9CFB2D3D50D82F4(options);
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
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationUpdateRequestDataAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationUpdateRequestDataRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationUpdateRequestDataRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationUpdateRequestDataType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB4EC4F72F3ACB31(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3B5BDA94F3B5E74C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7F2288DFAE548364(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_74130F547542CCEC(options);
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