
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppInfosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppInfosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_058C3A9E552D5212.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C3DA5B08EBA5D50F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CB35FDB33DFBAF29.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1DFF855675800C8A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7FA59B1C4CE96DD8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DC9E2306000A6A96.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DEFBC14D2B062D04.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_82241DFAA19AADF2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F98A3AFE21344553.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_175F2BDAEC3210DF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7CFAA04172550A63.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FAA56A012E2D0D03.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_841E544A62222A19.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_89D1FFFB5F450E70.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AED80C56613367AC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7599D291F16FF29E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_816726A18012A1E6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F9F976828FE88CAB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C64210088A72683F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AF9A30866D64B99C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_ED34FD33F684C156.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_16F7558DE6510074.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_17BC10B45B956763.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[26];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_058C3A9E552D5212.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_C3DA5B08EBA5D50F.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_CB35FDB33DFBAF29.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_1DFF855675800C8A.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_7FA59B1C4CE96DD8.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_DC9E2306000A6A96.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_DEFBC14D2B062D04.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_82241DFAA19AADF2.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_F98A3AFE21344553.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_175F2BDAEC3210DF.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_7CFAA04172550A63.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_FAA56A012E2D0D03.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_841E544A62222A19.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_89D1FFFB5F450E70.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_AED80C56613367AC.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_7599D291F16FF29E.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_816726A18012A1E6.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_F9F976828FE88CAB.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_C64210088A72683F.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_AF9A30866D64B99C.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_ED34FD33F684C156.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_16F7558DE6510074.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_17BC10B45B956763.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}