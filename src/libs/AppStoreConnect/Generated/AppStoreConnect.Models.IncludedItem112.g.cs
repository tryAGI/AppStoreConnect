#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem112 : global::System.IEquatable<IncludedItem112>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; init; }
#else
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterDetails))]
#endif
        public bool IsGameCenterDetails => GameCenterDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterDetail? value)
        {
            value = GameCenterDetails;
            return IsGameCenterDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => GameCenterDetails is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboards { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboards { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboards;
            return IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboards() => GameCenterLeaderboards is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem112(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem112((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem112 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem112(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem112 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem112(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem112(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem112((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem112 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem112(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem112 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem112(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem112(
            global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterDetails = gameCenterDetails;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterDetails as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterDetails?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterDetails && !IsGameCenterLeaderboards || !IsGameCenterDetails && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterDetails is { } __value0 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterDetails is { } __value0)
            {
                gameCenterDetails?.Invoke(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1)
            {
                gameCenterLeaderboards?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterDetails is { } __value0)
            {
                gameCenterDetails?.Invoke(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1)
            {
                gameCenterLeaderboards?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterLeaderboards,
                typeof(global::AppStoreConnect.GameCenterLeaderboard),
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
        public bool Equals(IncludedItem112 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem112 obj1, IncludedItem112 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem112>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem112 obj1, IncludedItem112 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem112 o && Equals(o);
        }
    }
}
