#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem121 : global::System.IEquatable<IncludedItem121>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? GameCenterLeaderboardSetLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? GameCenterLeaderboardSetLocalizations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetLocalizations))]
#endif
        public bool IsGameCenterLeaderboardSetLocalizations => GameCenterLeaderboardSetLocalizations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? value)
        {
            value = GameCenterLeaderboardSetLocalizations;
            return IsGameCenterLeaderboardSetLocalizations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2 PickGameCenterLeaderboardSetLocalizations() => IsGameCenterLeaderboardSetLocalizations
            ? GameCenterLeaderboardSetLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetLocalizations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetV2? GameCenterLeaderboardSets { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetV2? GameCenterLeaderboardSets { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets))]
#endif
        public bool IsGameCenterLeaderboardSets => GameCenterLeaderboardSets != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetV2? value)
        {
            value = GameCenterLeaderboardSets;
            return IsGameCenterLeaderboardSets;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetV2 PickGameCenterLeaderboardSets() => IsGameCenterLeaderboardSets
            ? GameCenterLeaderboardSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem121(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2 value) => new IncludedItem121((global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2?(IncludedItem121 @this) => @this.GameCenterLeaderboardSetLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem121(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? value)
        {
            GameCenterLeaderboardSetLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem121 FromGameCenterLeaderboardSetLocalizations(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? value) => new IncludedItem121(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem121(global::AppStoreConnect.GameCenterLeaderboardSetV2 value) => new IncludedItem121((global::AppStoreConnect.GameCenterLeaderboardSetV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetV2?(IncludedItem121 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem121(global::AppStoreConnect.GameCenterLeaderboardSetV2? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem121 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSetV2? value) => new IncludedItem121(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem121(
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2? gameCenterLeaderboardSetLocalizations,
            global::AppStoreConnect.GameCenterLeaderboardSetV2? gameCenterLeaderboardSets
            )
        {
            Type = type;

            GameCenterLeaderboardSetLocalizations = gameCenterLeaderboardSetLocalizations;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSets as object ??
            GameCenterLeaderboardSetLocalizations as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardSetLocalizations?.ToString() ??
            GameCenterLeaderboardSets?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSets || !IsGameCenterLeaderboardSetLocalizations && IsGameCenterLeaderboardSets;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2, TResult>? gameCenterLeaderboardSetLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetV2, TResult>? gameCenterLeaderboardSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetLocalizations && gameCenterLeaderboardSetLocalizations != null)
            {
                return gameCenterLeaderboardSetLocalizations(GameCenterLeaderboardSetLocalizations!);
            }
            else if (IsGameCenterLeaderboardSets && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(GameCenterLeaderboardSets!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2>? gameCenterLeaderboardSetLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetV2>? gameCenterLeaderboardSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetLocalizations)
            {
                gameCenterLeaderboardSetLocalizations?.Invoke(GameCenterLeaderboardSetLocalizations!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2>? gameCenterLeaderboardSetLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetV2>? gameCenterLeaderboardSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetLocalizations)
            {
                gameCenterLeaderboardSetLocalizations?.Invoke(GameCenterLeaderboardSetLocalizations!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterLeaderboardSetLocalizations,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2),
                GameCenterLeaderboardSets,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2),
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
        public bool Equals(IncludedItem121 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2?>.Default.Equals(GameCenterLeaderboardSetLocalizations, other.GameCenterLeaderboardSetLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetV2?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem121 obj1, IncludedItem121 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem121>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem121 obj1, IncludedItem121 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem121 o && Equals(o);
        }
    }
}
