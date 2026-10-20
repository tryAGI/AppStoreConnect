
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_10475E6665E6259C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_10475E6665E6259C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_10475E6665E6259C(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem149JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.ActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.NominationType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.NominationType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsCreatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsCreatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsLastModifiedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsLastModifiedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSubmittedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSubmittedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.Actor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Actor(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorAttributesActorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorAttributesActorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEvent(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesArchivedTerritorySchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesBadge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesEventState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesEventState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPriority))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPurpose))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesTerritorySchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesTerritorySchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventType2(options);
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
                if (type == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem149))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1492(options);
                }
                if (type == typeof(global::AppStoreConnect.Nomination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_Nomination(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationAttributesType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsCreatedByActor(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsCreatedByActorData(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsCreatedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsInAppEvents))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsInAppEvents(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsInAppEventsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsLastModifiedByActor(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsLastModifiedByActorData(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsLastModifiedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsRelatedApps))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsRelatedApps(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsRelatedAppsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSubmittedByActor(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSubmittedByActorData(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSubmittedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSupportedTerritories(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSupportedTerritoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_NominationType2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.Territory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Territory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_22CDBA339F2D7CA4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8F8C64169B2CC510(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8C963298A67F96ED(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C47828CF95D234AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem149>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B67C26F2B952914D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EE4F7099BA66EC15(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BA95B919C8E710C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A52FCBD4DA3C8381(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
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
                if (type == typeof(global::AppStoreConnect.ActorAttributesActorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableActorAttributesActorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableActorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesBadge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesEventState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesEventState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPriority?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPurpose?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventType2(options);
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
                if (type == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem149?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1492(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationAttributesType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsCreatedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsInAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsLastModifiedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsRelatedAppsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsSubmittedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationRelationshipsSupportedTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableNominationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableSubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_0FA4FCB8B324E823(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_2214838658DE42A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3AE0303F8FAC920A(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeviceFamily>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB4EC4F72F3ACB31(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem149>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2A324BAC6529D6DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D071AA97FFA79197(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D18C834FCA9E99BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2BAC5F2218150CB9(options);
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