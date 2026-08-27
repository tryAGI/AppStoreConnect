#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem84 : global::System.IEquatable<IncludedItem84>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementVersions))]
#endif
        public bool IsGameCenterAchievementVersions => GameCenterAchievementVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            value = GameCenterAchievementVersions;
            return IsGameCenterAchievementVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementVersionV2 PickGameCenterAchievementVersions() => IsGameCenterAchievementVersions
            ? GameCenterAchievementVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementVersions' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivities { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivities { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivities))]
#endif
        public bool IsGameCenterActivities => GameCenterActivities != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterActivities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivity? value)
        {
            value = GameCenterActivities;
            return IsGameCenterActivities;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivities() => IsGameCenterActivities
            ? GameCenterActivities!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivities' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => IsGameCenterDetails
            ? GameCenterDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterDetails' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterGroup? GameCenterGroups { get; init; }
#else
        public global::AppStoreConnect.GameCenterGroup? GameCenterGroups { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterGroups))]
#endif
        public bool IsGameCenterGroups => GameCenterGroups != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterGroup? value)
        {
            value = GameCenterGroups;
            return IsGameCenterGroups;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterGroup PickGameCenterGroups() => IsGameCenterGroups
            ? GameCenterGroups!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterGroups' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem84(global::AppStoreConnect.GameCenterAchievementVersionV2 value) => new IncludedItem84((global::AppStoreConnect.GameCenterAchievementVersionV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementVersionV2?(IncludedItem84 @this) => @this.GameCenterAchievementVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem84(global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            GameCenterAchievementVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem84 FromGameCenterAchievementVersions(global::AppStoreConnect.GameCenterAchievementVersionV2? value) => new IncludedItem84(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem84(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem84((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem84 @this) => @this.GameCenterActivities;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem84(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem84 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem84(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem84(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem84((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem84 @this) => @this.GameCenterDetails;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem84(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem84 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem84(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem84(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem84((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem84 @this) => @this.GameCenterGroups;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem84(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem84 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem84(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem84(
            global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups
            )
        {
            Type = type;

            GameCenterAchievementVersions = gameCenterAchievementVersions;
            GameCenterActivities = gameCenterActivities;
            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterGroups as object ??
            GameCenterDetails as object ??
            GameCenterActivities as object ??
            GameCenterAchievementVersions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementVersions?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementVersions && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementVersions && IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementVersions && !IsGameCenterActivities && IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementVersions && !IsGameCenterActivities && !IsGameCenterDetails && IsGameCenterGroups;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementVersionV2, TResult>? gameCenterAchievementVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementVersions && gameCenterAchievementVersions != null)
            {
                return gameCenterAchievementVersions(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivities && gameCenterActivities != null)
            {
                return gameCenterActivities(GameCenterActivities!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterAchievementVersions,
                typeof(global::AppStoreConnect.GameCenterAchievementVersionV2),
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
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
        public bool Equals(IncludedItem84 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementVersionV2?>.Default.Equals(GameCenterAchievementVersions, other.GameCenterAchievementVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem84 obj1, IncludedItem84 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem84>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem84 obj1, IncludedItem84 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem84 o && Equals(o);
        }
    }
}
