
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_6C1C4F1A72597490 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_6C1C4F1A72597490 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_6C1C4F1A72597490(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.DeviceType)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu?)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice)

                    || typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.DeviceType))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceAttributesDeviceClassJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceAttributesDeviceClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceAttributesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceAttributesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFilterStatuJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu?))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFilterStatuNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFieldsDeviceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice?))
                {
                    return new global::AppStoreConnect.JsonConverters.DevicesGetCollectionFieldsDeviceNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.Device))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_Device(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeviceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeviceAttributesDeviceClass2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceAttributesStatus))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeviceAttributesStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeviceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DevicesGetCollectionFieldsDevice2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DevicesGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DevicesGetCollectionFilterStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DevicesGetCollectionSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DevicesResponse(options);
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
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Device>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_EB61C9467A02814A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFieldsDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5971BB2FF37903D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2C0BC9C2C918706C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_760C59885A232389(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5A6CDDB3691684A1(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDeviceAttributesDeviceClass2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceAttributesStatus?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDeviceAttributesStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableDeviceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFieldsDevice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableDevicesGetCollectionFieldsDevice2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableDevicesGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionFilterStatu?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableDevicesGetCollectionFilterStatu2(options);
                }
                if (type == typeof(global::AppStoreConnect.DevicesGetCollectionSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableDevicesGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Device>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4419A613BA74B49D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DevicesGetCollectionFieldsDevice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3C98A0F32ED9A346(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CCCB1DE12F484C2A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DevicesGetCollectionFilterStatu>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DBBB754D2AF4D96B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DevicesGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6A0556C0BABC0CF1(options);
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