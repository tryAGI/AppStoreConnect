#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem126 : global::System.IEquatable<IncludedItem126>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardVersionsV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? GameCenterLeaderboardLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? GameCenterLeaderboardLocalizations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardLocalizations))]
#endif
        public bool IsGameCenterLeaderboardLocalizations => GameCenterLeaderboardLocalizations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? value)
        {
            value = GameCenterLeaderboardLocalizations;
            return IsGameCenterLeaderboardLocalizations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationV2 PickGameCenterLeaderboardLocalizations() => IsGameCenterLeaderboardLocalizations
            ? GameCenterLeaderboardLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardLocalizations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardV2? GameCenterLeaderboards { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardV2? GameCenterLeaderboards { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboards))]
#endif
        public bool IsGameCenterLeaderboards => GameCenterLeaderboards != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboards(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardV2? value)
        {
            value = GameCenterLeaderboards;
            return IsGameCenterLeaderboards;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardV2 PickGameCenterLeaderboards() => IsGameCenterLeaderboards
            ? GameCenterLeaderboards!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2 value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboardLocalizationV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardLocalizationV2?(IncludedItem126 @this) => @this.GameCenterLeaderboardLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? value)
        {
            GameCenterLeaderboardLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboardLocalizations(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? value) => new IncludedItem126(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardV2 value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboardV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardV2?(IncludedItem126 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardV2? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboardV2? value) => new IncludedItem126(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem126(
            global::AppStoreConnect.GameCenterLeaderboardVersionsV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardLocalizationV2? gameCenterLeaderboardLocalizations,
            global::AppStoreConnect.GameCenterLeaderboardV2? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterLeaderboardLocalizations = gameCenterLeaderboardLocalizations;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardLocalizations as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardLocalizations?.ToString() ??
            GameCenterLeaderboards?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboards || !IsGameCenterLeaderboardLocalizations && IsGameCenterLeaderboards;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardLocalizationV2, TResult>? gameCenterLeaderboardLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardV2, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardLocalizations && gameCenterLeaderboardLocalizations != null)
            {
                return gameCenterLeaderboardLocalizations(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboards && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(GameCenterLeaderboards!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardLocalizationV2>? gameCenterLeaderboardLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardV2>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardLocalizations)
            {
                gameCenterLeaderboardLocalizations?.Invoke(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboards)
            {
                gameCenterLeaderboards?.Invoke(GameCenterLeaderboards!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardLocalizationV2>? gameCenterLeaderboardLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardV2>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardLocalizations)
            {
                gameCenterLeaderboardLocalizations?.Invoke(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboards)
            {
                gameCenterLeaderboards?.Invoke(GameCenterLeaderboards!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterLeaderboardLocalizations,
                typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2),
                GameCenterLeaderboards,
                typeof(global::AppStoreConnect.GameCenterLeaderboardV2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(IncludedItem126 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardLocalizationV2?>.Default.Equals(GameCenterLeaderboardLocalizations, other.GameCenterLeaderboardLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardV2?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem126 obj1, IncludedItem126 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem126>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem126 obj1, IncludedItem126 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem126 o && Equals(o);
        }
    }
}
