
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_E442F73834FE5306 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_E442F73834FE5306 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_E442F73834FE5306(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaRecruitmentCriterionOptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaRecruitmentCriterionOptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOptionNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOption))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaRecruitmentCriterionOption(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaRecruitmentCriterionOptionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaRecruitmentCriterionOptionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaRecruitmentCriterionOptionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DeviceFamily2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaRecruitmentCriterionOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4CA3E3766D28832F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_867539F2C236B36C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_648B51D6DD46BBF5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaRecruitmentCriterionOptionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption2(options);
                }
                if (type == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDeviceFamily2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaRecruitmentCriterionOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_752BD8A53655C1DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaRecruitmentCriterionOptionAttributesDeviceFamilyOsVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6F09035009C3B327(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9092C9DA34A69DB3(options);
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