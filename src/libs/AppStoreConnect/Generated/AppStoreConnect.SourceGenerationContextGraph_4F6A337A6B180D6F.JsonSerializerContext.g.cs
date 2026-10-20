
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4F6A337A6B180D6F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4F6A337A6B180D6F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4F6A337A6B180D6F(global::System.Text.Json.JsonSerializerOptions options)
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
                if (type == typeof(global::AppStoreConnect.DiagnosticLogCallStackNode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogCallStackNode(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogs))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogs(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticInsight))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItemDiagnosticInsight(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLog))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItemDiagnosticLog(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack(options);
                }
                if (type == typeof(global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogCallStackNode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0E954A947A2BBDF2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_73589F9D6A70EC18(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticInsight>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8391528B4D2A681A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLog>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AE709018F51121FF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8A48A4399499B921(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_88C5F74D6DDC5009(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogCallStackNode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4105872FFC560B11(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogsProductDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7ABDA8F1DF1FDDC6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticInsight>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2EC46128916637EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLog>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_85F7C5C4C6B00760(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_10B436D57450C4F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_255432CF7277F5B0(options);
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