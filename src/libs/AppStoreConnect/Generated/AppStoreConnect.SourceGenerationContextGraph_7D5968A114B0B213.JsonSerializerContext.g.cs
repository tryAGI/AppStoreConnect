
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_7D5968A114B0B213 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_7D5968A114B0B213 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_7D5968A114B0B213(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem153JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceType)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesDeviceClass?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceAttributesStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileState)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType2)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateType2?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateRelationshipsPassTypeIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateRelationshipsPassTypeIdDataTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileAttributesProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileAttributesProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileState))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileAttributesProfileStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileAttributesProfileState?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileAttributesProfileStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsDevicesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsDevicesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsCertificatesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileRelationshipsCertificatesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType2))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateType2NullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.Certificate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_Certificate(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeId(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateRelationshipsPassTypeIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CertificateType22(options);
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem153))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1532(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.Profile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_Profile(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileAttributesProfileState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileAttributesProfileState2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileAttributesProfileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileAttributesProfileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsBundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsBundleIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsCertificates))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsCertificates(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsCertificatesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsCertificatesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsDevices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsDevices(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsDevicesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileRelationshipsDevicesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ProfileType2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem153>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_49BCD464EDF494CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileRelationshipsCertificatesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_156667BE9F4BB96C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileRelationshipsDevicesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E87EBD17CA27CB5C(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
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
                if (type == typeof(global::AppStoreConnect.CertificateRelationshipsPassTypeIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateRelationshipsPassTypeIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.CertificateType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCertificateType22(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem153?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1532(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileAttributesProfileState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileAttributesProfileState2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileAttributesProfileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileAttributesProfileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsBundleIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsCertificatesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileRelationshipsCertificatesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileRelationshipsDevicesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileRelationshipsDevicesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ProfileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem153>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5B0656D20D8993CD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileRelationshipsCertificatesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5FDAE65B9855FBEC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileRelationshipsDevicesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_95564B10F86140CB(options);
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