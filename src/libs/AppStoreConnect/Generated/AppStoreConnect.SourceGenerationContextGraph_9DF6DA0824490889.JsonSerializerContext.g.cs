
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9DF6DA0824490889 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9DF6DA0824490889 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9DF6DA0824490889(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildBetaNotification))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotification(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestDataRelationshipsBuild(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestDataRelationshipsBuildData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildBetaNotificationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuildDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildBetaNotificationCreateRequestDataRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildBetaNotificationCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaNotificationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildBetaNotificationType2(options);
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