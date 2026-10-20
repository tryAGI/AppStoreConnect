
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0BFD237BE8FC16C1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0BFD237BE8FC16C1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0BFD237BE8FC16C1(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceCreateRequestDataType2(options);
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