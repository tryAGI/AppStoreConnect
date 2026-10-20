
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_C10CEA20BDBF8F83.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_08F1F20E76368772.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B9FE8C28D5B947CA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A2EB16019DF91851.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F7010C4789141F69.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3458DC038891188D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_89340C3837562B70.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DC6DAF74FB766BD2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3C59D9FF594C3B12.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6E5BC7AD5A17253D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AE0DA0616EA92333.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D6EC6DE32B35DBC0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0C9E27518400CBE1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_492B2AC7A84664CB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CD54524082003684.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D5B73989A2052550.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E94F92B713D31078.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0A065E1F2ECD0843.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2E0C5DC3061DD274.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9DDF8A952B5B550A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3F7B64CC87F0CA15.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_17761AEBF81E268E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FFDF8E406940807E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F2EB493CF514248E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_258E141CFD80DA58.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[28];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_C10CEA20BDBF8F83.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_08F1F20E76368772.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_B9FE8C28D5B947CA.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_A2EB16019DF91851.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_F7010C4789141F69.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_3458DC038891188D.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_89340C3837562B70.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_DC6DAF74FB766BD2.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_3C59D9FF594C3B12.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_6E5BC7AD5A17253D.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_AE0DA0616EA92333.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_D6EC6DE32B35DBC0.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_0C9E27518400CBE1.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_492B2AC7A84664CB.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_CD54524082003684.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_D5B73989A2052550.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_E94F92B713D31078.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_0A065E1F2ECD0843.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_2E0C5DC3061DD274.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_9DDF8A952B5B550A.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_3F7B64CC87F0CA15.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_17761AEBF81E268E.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_FFDF8E406940807E.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_F2EB493CF514248E.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_258E141CFD80DA58.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}