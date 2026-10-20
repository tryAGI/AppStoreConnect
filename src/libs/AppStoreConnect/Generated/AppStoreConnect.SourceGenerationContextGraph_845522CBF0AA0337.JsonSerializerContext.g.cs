
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_845522CBF0AA0337 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_845522CBF0AA0337 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_845522CBF0AA0337(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaTesterType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterAttributesAppDevicePlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterAttributesAppDevicePlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaInviteType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaInviteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaInviteType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaInviteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterState))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterStateNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPointValues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItemDataPointValues(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItemDimensions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaInviteType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaInviteType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTester(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterAttributesAppDevice(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterAttributesAppDevicePlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsApps))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsApps(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsAppsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaTesterType2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6FE56B7119002C05(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6AE3D627E6B1D8CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4A531443F5B07C38(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterAttributesAppDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C5DD649BD19962E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D68E93F11728C96F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_72CA697554BD4CA5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B5CD5EF2C22DDC0F(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaInviteType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaInviteType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterAttributesAppDevicePlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterRelationshipsAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaTesterType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaTesterType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E97232134F31D639(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A2D82BCBFC5A7EC9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1B60D15646C4946E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterAttributesAppDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CFBB02B4734951DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9A1AAD824D4A8CAB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6EEF1C795DCB86A9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2FEFD7ADF8BA1B0C(options);
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