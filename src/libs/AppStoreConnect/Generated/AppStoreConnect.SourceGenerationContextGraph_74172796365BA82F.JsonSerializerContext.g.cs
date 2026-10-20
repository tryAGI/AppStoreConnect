
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_74172796365BA82F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_74172796365BA82F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_74172796365BA82F(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4865C92F476CBBE0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4229E6B522468BB3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ADA151EA806F73B5(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0F84FAE27C372D1A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7709030560B1E0AD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_850F98B8E1CF04BB(options);
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