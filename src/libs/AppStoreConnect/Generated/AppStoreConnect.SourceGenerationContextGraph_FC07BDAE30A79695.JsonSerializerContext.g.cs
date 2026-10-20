
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_FC07BDAE30A79695 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_FC07BDAE30A79695 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_FC07BDAE30A79695(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem69JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesStartReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesStartReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesCancelReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesCancelReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsWorkflowDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsWorkflowDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsSourceBranchOrTagDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsSourceBranchOrTagDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsDestinationBranchDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsDestinationBranchDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsPullRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsPullRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsXcodeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsXcodeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsMacOsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsMacOsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.CiCompletionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiCompletionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress))
                {
                    return new global::AppStoreConnect.JsonConverters.CiExecutionProgressJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiExecutionProgressNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.Build))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Build(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundles(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUpload(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsDiagnosticSignatures(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIcons))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIcons(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPerfPowerMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiAction(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionDestination2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfiguration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionTestConfiguration(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfigurationKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionTestConfigurationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchPatterns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBranchPatterns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchPatternsPattern))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBranchPatternsPattern(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBranchStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRun(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunAttributesCancelReason2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesDestinationCommit))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunAttributesDestinationCommit(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesSourceCommit))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunAttributesSourceCommit(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunAttributesStartReason2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsActions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsActions(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranch))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsDestinationBranch(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsDestinationBranchData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsDestinationBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsProductData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsPullRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsPullRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsPullRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTag))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsSourceBranchOrTag(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsSourceBranchOrTagData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsSourceBranchOrTagDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsWorkflow(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsWorkflowData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunRelationshipsWorkflowDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildRunType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiCompletionStatus))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiCompletionStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiExecutionProgress))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiExecutionProgress2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRule(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiGitRefKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_CiGitRefKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiGitUser))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiGitUser(options);
                }
                if (type == typeof(global::AppStoreConnect.CiIssueCounts))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiIssueCounts(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualBranchStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualBranchStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualPullRequestStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualPullRequestStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualTagStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualTagStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductAttributesProductType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductAttributesProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAdditionalRepositories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAdditionalRepositories(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBuildRuns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBuildRuns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositories(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsWorkflows))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsWorkflows(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiPullRequestStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiPullRequestStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiScheduledStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionSchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionScheduleDay2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionScheduleFrequency2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiStartConditionFileMatcher))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiStartConditionFileMatcher(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagPatterns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTagPatterns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagPatternsPattern))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTagPatternsPattern(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiTagStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTestDestination(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflow))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflow(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsBuildRuns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsBuildRuns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsMacOsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsMacOsVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsMacOsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsProductData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsRepositoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsXcodeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsXcodeVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowRelationshipsXcodeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem69))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem692(options);
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
                if (type == typeof(global::AppStoreConnect.ScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmGitReference(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepositoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmGitReferenceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmPullRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepositoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmPullRequestType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2D7F817FEB3B058A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8F872A0DF814C3EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5F90468B7885322A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCC6B5F9FDB89FA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D1D39E952A7598F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_88079F1A701C7D9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B9B02AB79DCC8C48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D72AF13D8D95B5F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3D01A59400521D64(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AB2B53F828EB506B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiStartConditionFileMatcher>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D6C436E4DE22642B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTagPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D7072D3DD1CBCEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E5BB7C99D2A840CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem69>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7DBB07DACA06663D(options);
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
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionDestination?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionDestination2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionTestConfigurationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunAttributesCancelReason2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunAttributesStartReason2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsDestinationBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsPullRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsSourceBranchOrTagDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunRelationshipsWorkflowDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildRunType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiCompletionStatus?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiCompletionStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiExecutionProgress?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiExecutionProgress2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiGitRefKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiGitRefKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductAttributesProductType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductAttributesProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsPrimaryRepositoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiScheduledStartConditionScheduleDay2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiScheduledStartConditionScheduleFrequency2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowRelationshipsMacOsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowRelationshipsProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowRelationshipsXcodeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem69?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem692(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmGitReferenceRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmGitReferenceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmGitReferenceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmPullRequestRelationshipsRepositoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmPullRequestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmPullRequestType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE1E6F918C082922(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DECEC7A4996A17B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B3F4C1C38020CC64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7AD7BF85AB1EA6AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5057449BFE60E32E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_30C300F3BF01C9E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1A29DB9DE0A0E523(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7FD720CCE07F7FD3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C692331EFC765CEC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_679D29544747533F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiStartConditionFileMatcher>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2B4C9E09BA67CF83(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTagPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_67C7E36A129B3B07(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_76698A36C75EC160(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem69>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_48546CD0CAC045B4(options);
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