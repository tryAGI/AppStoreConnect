
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_C7A36449DDB0D1B6 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_C7A36449DDB0D1B6 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_C7A36449DDB0D1B6(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem67JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.CapabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdCapabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdCapabilityTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityOptionKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityOptionKey?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityOptionKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingKey?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingAllowedInstancesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilitySettingAllowedInstancesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CapabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CapabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.App))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_App(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAccessibilityDeclarations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAccessibilityDeclarations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAlternativeDistributionKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAlternativeDistributionKey(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAnalyticsReportRequests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAnalyticsReportRequests(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetails))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetails(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetailsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetailsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppAvailabilityV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppAvailabilityV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClips))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClips(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClipsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClipsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPages(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPagesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEvents))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEvents(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEventsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfos))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfos(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfosDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfosDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppPricePoints))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppPricePoints(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppPriceSchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIcon(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIconData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIconDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2DataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppTags))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppTags(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAssetLibrary))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAssetLibrary(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBackgroundAssets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBackgroundAssets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackCrashSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBetaFeedbackCrashSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackScreenshotSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBetaFeedbackScreenshotSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreementData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildUploads))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBuildUploads(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProductData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCustomerReviewSummarizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsCustomerReviewSummarizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCustomerReviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsCustomerReviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreementData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2DataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppRelationshipsMarketplaceSearchDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsMarketplaceSearchDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPerfPowerMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPerfPowerMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPerformanceOverviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPerformanceOverviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchases(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchasesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSearchKeywords))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSearchKeywords(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriod(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriodData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriodDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsWebhooks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsWebhooks(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapability(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdCapabilityType2(options);
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
                if (type == typeof(global::AppStoreConnect.BundleIdResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BundleIdType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOption))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilityOption(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOptionKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilityOptionKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySetting))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CapabilitySetting(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilitySettingAllowedInstances2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CapabilitySettingKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CapabilityType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem67))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem672(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A81096F4683775F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_88D63AE29F447D68(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_52892132E482B394(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B7F74DF0AB69287B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0711D4F322A14BA3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9922042AE28F3F85(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B0A695A50FDAE79E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D2B95E9366D05F52(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E47C0345EF7AD78A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A3E9AF35CD422B4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BF4590F01D98A3B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3699403235399A4E(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_83101BFA8FE2BD3E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E916A4103D9A38AC(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C8D42E423BE1C8DA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C0B82376799DFE38(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_13E761684A152621(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D08F36F46AF2743A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B3BAE8379027C643(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B77263C8E479D80A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilityOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_61E92FEC63716F0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilitySetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_82CDE6AA9DF6A859(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem67>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_100857EA3316DF2E(options);
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
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAndroidToIosAppMappingDetailsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppClipsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppCustomProductPagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppEncryptionDeclarationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppInfosDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreIconDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaAppLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaAppReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsCiProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsEndUserLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsGameCenterEnabledVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsInAppPurchasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsInAppPurchasesV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsPreReleaseVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsPromotedPurchasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsReviewSubmissionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsSubscriptionGracePeriodDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsSubscriptionGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdCapabilityType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdCapabilityType2(options);
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
                if (type == typeof(global::AppStoreConnect.BundleIdResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BundleIdType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBundleIdType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityOptionKey?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilityOptionKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingAllowedInstances?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilitySettingAllowedInstances2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilitySettingKey?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCapabilitySettingKey2(options);
                }
                if (type == typeof(global::AppStoreConnect.CapabilityType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCapabilityType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem67?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem672(options);
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
                if (type == typeof(global::AppStoreConnect.ProfileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableProfileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableSubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1E16040B1CA894C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE3F859287B4D312(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_82A7FF975CBA14D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6FB51AADF653540(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6CDEE18D2BD07DBE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_36E3D7E06EE390D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_029AF4ACCD26326D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8CFE33DE85E6053A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C7F4A6534F8EC787(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_02E9BA0284CAEF52(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB616A8841A35472(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A4977263AB08005E(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A90549EFC081CF12(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DBBF058A40A57F80(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5EC28E0686D24064(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20D83F20570515A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90454CB27F822DEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D2758BDC4B77341B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6105FEA000DDC166(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_73DC718E80A1A556(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CapabilityOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6F717346AAC294E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CapabilitySetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE78664BD19FA0E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem67>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_008921EF7BDA2CC3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileRelationshipsCertificatesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5FDAE65B9855FBEC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileRelationshipsDevicesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_95564B10F86140CB(options);
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