
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4497AA88A751ABBE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4497AA88A751ABBE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4497AA88A751ABBE(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem73JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?)

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
                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAudienceType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRule(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionRelationshipsXcodeVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiMacOsVersionType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiWorkflowResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributesTestDestination(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionAttributesTestDestinationAvailableRuntime(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionRelationshipsMacOsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiXcodeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem73))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem732(options);
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
                if (type == typeof(global::AppStoreConnect.ScmRepository))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ScmRepository(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranch))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranch(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranchData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsDefaultBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsGitReferences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsGitReferences(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsPullRequests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsPullRequests(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProvider))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProvider(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProviderData(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryRelationshipsScmProviderDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ScmRepositoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_88079F1A701C7D9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B9B02AB79DCC8C48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C763964D4B07F89F(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A0EDD89FA0F9F15E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1786CC8CE1014150(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E23424BFD6C0290D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem73>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_807A8F5DCE3A18D6(options);
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
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiMacOsVersionRelationshipsXcodeVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiMacOsVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiMacOsVersionType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiWorkflowType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiXcodeVersionRelationshipsMacOsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiXcodeVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiXcodeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem73?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem732(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryRelationshipsDefaultBranchDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryRelationshipsScmProviderDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmRepositoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableScmRepositoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_30C300F3BF01C9E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1A29DB9DE0A0E523(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90080C24C23F73C5(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_06049EDB80252673(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CF9CD980FACE41CC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F339D6B3059DC8C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem73>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D1A9192BFFB21960(options);
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