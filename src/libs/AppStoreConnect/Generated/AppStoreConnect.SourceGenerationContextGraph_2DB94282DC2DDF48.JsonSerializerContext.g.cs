
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2DB94282DC2DDF48 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2DB94282DC2DDF48 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2DB94282DC2DDF48(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAppStoreReviewDetailType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceType2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BA1FDCCB79163964(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5784DD7FAB1BF571(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAppStoreReviewDetailType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_4499E3FE06B5B460(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CB5A950731389BB1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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