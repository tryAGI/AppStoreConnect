
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterLeaderboardsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterLeaderboardsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_9F247DF1DE63B5A9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_34F5CCA9EA8AAF09.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CA7EA73784B20D34.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FCA3AF4C1498986B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C6040A14FB2A71F4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_36DFDAB768B526AC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FB79556BFBA9089E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_374A7479395F43D0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_560DAB392AB5EDF8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_54F0D689C01CD60F.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[13];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_9F247DF1DE63B5A9.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_34F5CCA9EA8AAF09.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_CA7EA73784B20D34.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_FCA3AF4C1498986B.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_C6040A14FB2A71F4.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_36DFDAB768B526AC.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_FB79556BFBA9089E.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_374A7479395F43D0.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_560DAB392AB5EDF8.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_54F0D689C01CD60F.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}