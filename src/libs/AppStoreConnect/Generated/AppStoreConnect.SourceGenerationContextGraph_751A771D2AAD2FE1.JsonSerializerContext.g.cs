
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_751A771D2AAD2FE1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_751A771D2AAD2FE1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_751A771D2AAD2FE1(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionRelationshipsBuildRunDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionRelationshipsBuildRunDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiActionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildAction(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsArtifacts))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsArtifacts(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsBuildRun(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsBuildRunData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsBuildRunDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsIssues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsIssues(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsTestResults))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionRelationshipsTestResults(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBuildActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildActionsGetInstanceFieldsCiBuildAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildActionsGetInstanceFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBuildActionsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.CiGitUser))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiGitUser(options);
                }
                if (type == typeof(global::AppStoreConnect.CiIssueCounts))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiIssueCounts(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_89AACB7D54500D16(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_18C339B83B899FCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B25E036603A7A287(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_385A0163FC3B71A8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D72AF13D8D95B5F8(options);
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
                if (type == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildActionRelationshipsBuildRunDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiBuildActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildActionsGetInstanceFieldsCiBuildAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildActionsGetInstanceFieldsCiBuildRun2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiBuildActionsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7274BE58D93623F0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_036295F1A719CE1D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CD31DBBD722B6D62(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRun>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_652B739C5DA0F5C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7FD720CCE07F7FD3(options);
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