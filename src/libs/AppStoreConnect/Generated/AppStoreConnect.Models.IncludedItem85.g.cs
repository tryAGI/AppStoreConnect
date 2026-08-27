#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem85 : global::System.IEquatable<IncludedItem85>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementLocalization? GameCenterAchievementLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementLocalization? GameCenterAchievementLocalizations1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementLocalizations1))]
#endif
        public bool IsGameCenterAchievementLocalizations1 => GameCenterAchievementLocalizations1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementLocalization? value)
        {
            value = GameCenterAchievementLocalizations1;
            return IsGameCenterAchievementLocalizations1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementLocalization PickGameCenterAchievementLocalizations1() => IsGameCenterAchievementLocalizations1
            ? GameCenterAchievementLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementLocalizations1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementReleases))]
#endif
        public bool IsGameCenterAchievementReleases => GameCenterAchievementReleases != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            value = GameCenterAchievementReleases;
            return IsGameCenterAchievementReleases;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementRelease PickGameCenterAchievementReleases() => IsGameCenterAchievementReleases
            ? GameCenterAchievementReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementReleases' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievementLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievementLocalizations2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementLocalizations2))]
#endif
        public bool IsGameCenterAchievementLocalizations2 => GameCenterAchievementLocalizations2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievement? value)
        {
            value = GameCenterAchievementLocalizations2;
            return IsGameCenterAchievementLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievementLocalizations2() => IsGameCenterAchievementLocalizations2
            ? GameCenterAchievementLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementLocalizations2' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterAchievementLocalization value) => new IncludedItem85((global::AppStoreConnect.GameCenterAchievementLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementLocalization?(IncludedItem85 @this) => @this.GameCenterAchievementLocalizations1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterAchievementLocalization? value)
        {
            GameCenterAchievementLocalizations1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterAchievementLocalizations1(global::AppStoreConnect.GameCenterAchievementLocalization? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterAchievementRelease value) => new IncludedItem85((global::AppStoreConnect.GameCenterAchievementRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementRelease?(IncludedItem85 @this) => @this.GameCenterAchievementReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            GameCenterAchievementReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterAchievementReleases(global::AppStoreConnect.GameCenterAchievementRelease? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem85((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem85 @this) => @this.GameCenterAchievementLocalizations2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievementLocalizations2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterAchievementLocalizations2(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem85((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem85 @this) => @this.GameCenterActivities;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem85((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem85 @this) => @this.GameCenterDetails;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem85(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem85((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem85 @this) => @this.GameCenterGroups;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem85 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem85(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem85(
            global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementLocalization? gameCenterAchievementLocalizations1,
            global::AppStoreConnect.GameCenterAchievementRelease? gameCenterAchievementReleases,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievementLocalizations2,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups
            )
        {
            Type = type;

            GameCenterAchievementLocalizations1 = gameCenterAchievementLocalizations1;
            GameCenterAchievementReleases = gameCenterAchievementReleases;
            GameCenterAchievementLocalizations2 = gameCenterAchievementLocalizations2;
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
            GameCenterAchievementLocalizations2 as object ??
            GameCenterAchievementReleases as object ??
            GameCenterAchievementLocalizations1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementLocalizations1?.ToString() ??
            GameCenterAchievementReleases?.ToString() ??
            GameCenterAchievementLocalizations2?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementLocalizations1 && !IsGameCenterAchievementReleases && !IsGameCenterAchievementLocalizations2 && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations1 && IsGameCenterAchievementReleases && !IsGameCenterAchievementLocalizations2 && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations1 && !IsGameCenterAchievementReleases && IsGameCenterAchievementLocalizations2 && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations1 && !IsGameCenterAchievementReleases && !IsGameCenterAchievementLocalizations2 && IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations1 && !IsGameCenterAchievementReleases && !IsGameCenterAchievementLocalizations2 && !IsGameCenterActivities && IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations1 && !IsGameCenterAchievementReleases && !IsGameCenterAchievementLocalizations2 && !IsGameCenterActivities && !IsGameCenterDetails && IsGameCenterGroups;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementLocalization, TResult>? gameCenterAchievementLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementRelease, TResult>? gameCenterAchievementReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievementLocalizations2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations1 && gameCenterAchievementLocalizations1 != null)
            {
                return gameCenterAchievementLocalizations1(GameCenterAchievementLocalizations1!);
            }
            else if (IsGameCenterAchievementReleases && gameCenterAchievementReleases != null)
            {
                return gameCenterAchievementReleases(GameCenterAchievementReleases!);
            }
            else if (IsGameCenterAchievementLocalizations2 && gameCenterAchievementLocalizations2 != null)
            {
                return gameCenterAchievementLocalizations2(GameCenterAchievementLocalizations2!);
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
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalization>? gameCenterAchievementLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievementLocalizations2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations1)
            {
                gameCenterAchievementLocalizations1?.Invoke(GameCenterAchievementLocalizations1!);
            }
            else if (IsGameCenterAchievementReleases)
            {
                gameCenterAchievementReleases?.Invoke(GameCenterAchievementReleases!);
            }
            else if (IsGameCenterAchievementLocalizations2)
            {
                gameCenterAchievementLocalizations2?.Invoke(GameCenterAchievementLocalizations2!);
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
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalization>? gameCenterAchievementLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievementLocalizations2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations1)
            {
                gameCenterAchievementLocalizations1?.Invoke(GameCenterAchievementLocalizations1!);
            }
            else if (IsGameCenterAchievementReleases)
            {
                gameCenterAchievementReleases?.Invoke(GameCenterAchievementReleases!);
            }
            else if (IsGameCenterAchievementLocalizations2)
            {
                gameCenterAchievementLocalizations2?.Invoke(GameCenterAchievementLocalizations2!);
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
                GameCenterAchievementLocalizations1,
                typeof(global::AppStoreConnect.GameCenterAchievementLocalization),
                GameCenterAchievementReleases,
                typeof(global::AppStoreConnect.GameCenterAchievementRelease),
                GameCenterAchievementLocalizations2,
                typeof(global::AppStoreConnect.GameCenterAchievement),
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
        public bool Equals(IncludedItem85 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementLocalization?>.Default.Equals(GameCenterAchievementLocalizations1, other.GameCenterAchievementLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementRelease?>.Default.Equals(GameCenterAchievementReleases, other.GameCenterAchievementReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievementLocalizations2, other.GameCenterAchievementLocalizations2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem85 obj1, IncludedItem85 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem85>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem85 obj1, IncludedItem85 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem85 o && Equals(o);
        }
    }
}
