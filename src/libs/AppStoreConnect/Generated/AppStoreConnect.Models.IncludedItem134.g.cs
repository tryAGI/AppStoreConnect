#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem134 : global::System.IEquatable<IncludedItem134>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterMatchmakingQueue? GameCenterMatchmakingQueues { get; init; }
#else
        public global::AppStoreConnect.GameCenterMatchmakingQueue? GameCenterMatchmakingQueues { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterMatchmakingQueues))]
#endif
        public bool IsGameCenterMatchmakingQueues => GameCenterMatchmakingQueues != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterMatchmakingQueues(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterMatchmakingQueue? value)
        {
            value = GameCenterMatchmakingQueues;
            return IsGameCenterMatchmakingQueues;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingQueue PickGameCenterMatchmakingQueues() => IsGameCenterMatchmakingQueues
            ? GameCenterMatchmakingQueues!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterMatchmakingQueues' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterMatchmakingRule? GameCenterMatchmakingRules { get; init; }
#else
        public global::AppStoreConnect.GameCenterMatchmakingRule? GameCenterMatchmakingRules { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterMatchmakingRules))]
#endif
        public bool IsGameCenterMatchmakingRules => GameCenterMatchmakingRules != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterMatchmakingRules(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterMatchmakingRule? value)
        {
            value = GameCenterMatchmakingRules;
            return IsGameCenterMatchmakingRules;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingRule PickGameCenterMatchmakingRules() => IsGameCenterMatchmakingRules
            ? GameCenterMatchmakingRules!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterMatchmakingRules' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterMatchmakingTeam? GameCenterMatchmakingTeams { get; init; }
#else
        public global::AppStoreConnect.GameCenterMatchmakingTeam? GameCenterMatchmakingTeams { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterMatchmakingTeams))]
#endif
        public bool IsGameCenterMatchmakingTeams => GameCenterMatchmakingTeams != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterMatchmakingTeams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterMatchmakingTeam? value)
        {
            value = GameCenterMatchmakingTeams;
            return IsGameCenterMatchmakingTeams;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingTeam PickGameCenterMatchmakingTeams() => IsGameCenterMatchmakingTeams
            ? GameCenterMatchmakingTeams!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterMatchmakingTeams' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingQueue value) => new IncludedItem134((global::AppStoreConnect.GameCenterMatchmakingQueue?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterMatchmakingQueue?(IncludedItem134 @this) => @this.GameCenterMatchmakingQueues;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingQueue? value)
        {
            GameCenterMatchmakingQueues = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem134 FromGameCenterMatchmakingQueues(global::AppStoreConnect.GameCenterMatchmakingQueue? value) => new IncludedItem134(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingRule value) => new IncludedItem134((global::AppStoreConnect.GameCenterMatchmakingRule?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterMatchmakingRule?(IncludedItem134 @this) => @this.GameCenterMatchmakingRules;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingRule? value)
        {
            GameCenterMatchmakingRules = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem134 FromGameCenterMatchmakingRules(global::AppStoreConnect.GameCenterMatchmakingRule? value) => new IncludedItem134(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingTeam value) => new IncludedItem134((global::AppStoreConnect.GameCenterMatchmakingTeam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterMatchmakingTeam?(IncludedItem134 @this) => @this.GameCenterMatchmakingTeams;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem134(global::AppStoreConnect.GameCenterMatchmakingTeam? value)
        {
            GameCenterMatchmakingTeams = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem134 FromGameCenterMatchmakingTeams(global::AppStoreConnect.GameCenterMatchmakingTeam? value) => new IncludedItem134(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem134(
            global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterMatchmakingQueue? gameCenterMatchmakingQueues,
            global::AppStoreConnect.GameCenterMatchmakingRule? gameCenterMatchmakingRules,
            global::AppStoreConnect.GameCenterMatchmakingTeam? gameCenterMatchmakingTeams
            )
        {
            Type = type;

            GameCenterMatchmakingQueues = gameCenterMatchmakingQueues;
            GameCenterMatchmakingRules = gameCenterMatchmakingRules;
            GameCenterMatchmakingTeams = gameCenterMatchmakingTeams;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterMatchmakingTeams as object ??
            GameCenterMatchmakingRules as object ??
            GameCenterMatchmakingQueues as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterMatchmakingQueues?.ToString() ??
            GameCenterMatchmakingRules?.ToString() ??
            GameCenterMatchmakingTeams?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterMatchmakingQueues && !IsGameCenterMatchmakingRules && !IsGameCenterMatchmakingTeams || !IsGameCenterMatchmakingQueues && IsGameCenterMatchmakingRules && !IsGameCenterMatchmakingTeams || !IsGameCenterMatchmakingQueues && !IsGameCenterMatchmakingRules && IsGameCenterMatchmakingTeams;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterMatchmakingQueue, TResult>? gameCenterMatchmakingQueues = null,
            global::System.Func<global::AppStoreConnect.GameCenterMatchmakingRule, TResult>? gameCenterMatchmakingRules = null,
            global::System.Func<global::AppStoreConnect.GameCenterMatchmakingTeam, TResult>? gameCenterMatchmakingTeams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingQueues && gameCenterMatchmakingQueues != null)
            {
                return gameCenterMatchmakingQueues(GameCenterMatchmakingQueues!);
            }
            else if (IsGameCenterMatchmakingRules && gameCenterMatchmakingRules != null)
            {
                return gameCenterMatchmakingRules(GameCenterMatchmakingRules!);
            }
            else if (IsGameCenterMatchmakingTeams && gameCenterMatchmakingTeams != null)
            {
                return gameCenterMatchmakingTeams(GameCenterMatchmakingTeams!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingQueue>? gameCenterMatchmakingQueues = null,

            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingRule>? gameCenterMatchmakingRules = null,

            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTeam>? gameCenterMatchmakingTeams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingQueues)
            {
                gameCenterMatchmakingQueues?.Invoke(GameCenterMatchmakingQueues!);
            }
            else if (IsGameCenterMatchmakingRules)
            {
                gameCenterMatchmakingRules?.Invoke(GameCenterMatchmakingRules!);
            }
            else if (IsGameCenterMatchmakingTeams)
            {
                gameCenterMatchmakingTeams?.Invoke(GameCenterMatchmakingTeams!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingQueue>? gameCenterMatchmakingQueues = null,
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingRule>? gameCenterMatchmakingRules = null,
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTeam>? gameCenterMatchmakingTeams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingQueues)
            {
                gameCenterMatchmakingQueues?.Invoke(GameCenterMatchmakingQueues!);
            }
            else if (IsGameCenterMatchmakingRules)
            {
                gameCenterMatchmakingRules?.Invoke(GameCenterMatchmakingRules!);
            }
            else if (IsGameCenterMatchmakingTeams)
            {
                gameCenterMatchmakingTeams?.Invoke(GameCenterMatchmakingTeams!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterMatchmakingQueues,
                typeof(global::AppStoreConnect.GameCenterMatchmakingQueue),
                GameCenterMatchmakingRules,
                typeof(global::AppStoreConnect.GameCenterMatchmakingRule),
                GameCenterMatchmakingTeams,
                typeof(global::AppStoreConnect.GameCenterMatchmakingTeam),
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
        public bool Equals(IncludedItem134 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterMatchmakingQueue?>.Default.Equals(GameCenterMatchmakingQueues, other.GameCenterMatchmakingQueues) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterMatchmakingRule?>.Default.Equals(GameCenterMatchmakingRules, other.GameCenterMatchmakingRules) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterMatchmakingTeam?>.Default.Equals(GameCenterMatchmakingTeams, other.GameCenterMatchmakingTeams)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem134 obj1, IncludedItem134 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem134>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem134 obj1, IncludedItem134 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem134 o && Equals(o);
        }
    }
}
