
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_24895E2EE9D4CEC8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_24895E2EE9D4CEC8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_24895E2EE9D4CEC8(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem57JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceConnectionType)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceConnectionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceConnectionType))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceConnectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceConnectionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceConnectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotImage(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsBuild(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsBuildData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsTester(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsTesterData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaFeedbackScreenshotSubmissionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.DeviceConnectionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeviceConnectionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem57))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem572(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4B0248AF119B759F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_38D995106D1CFE11(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A3C7ED188B4691E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_95906DAEA3A9EE33(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_294D358475DACB89(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem57>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_51B6EDF02F0A0A36(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaFeedbackScreenshotSubmissionRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaFeedbackScreenshotSubmissionRelationshipsTesterDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaFeedbackScreenshotSubmissionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.DeviceConnectionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDeviceConnectionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDeviceFamily2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem57?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem572(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaFeedbackScreenshotImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9821448106745406(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A87A607BBD926F05(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_26BC8AE555475F6B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_886AEA9E1CCEA776(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B8683DF519A91306(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem57>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2121048205B217B7(options);
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