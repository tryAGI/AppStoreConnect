#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem87 : global::System.IEquatable<IncludedItem87>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementLocalization? GameCenterAchievementLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementLocalization? GameCenterAchievementLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementLocalizations))]
#endif
        public bool IsGameCenterAchievementLocalizations => GameCenterAchievementLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAchievementLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementLocalization? value)
        {
            value = GameCenterAchievementLocalizations;
            return IsGameCenterAchievementLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementLocalization PickGameCenterAchievementLocalizations() => GameCenterAchievementLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementLocalizations' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterAchievementRelease PickGameCenterAchievementReleases() => GameCenterAchievementReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievements))]
#endif
        public bool IsGameCenterAchievements => GameCenterAchievements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAchievements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievement? value)
        {
            value = GameCenterAchievements;
            return IsGameCenterAchievements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => GameCenterAchievements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivities() => GameCenterActivities is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => GameCenterDetails is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterGroup PickGameCenterGroups() => GameCenterGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterGroups' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterAchievementLocalization value) => new IncludedItem87((global::AppStoreConnect.GameCenterAchievementLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementLocalization?(IncludedItem87 @this) => @this.GameCenterAchievementLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterAchievementLocalization? value)
        {
            GameCenterAchievementLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterAchievementLocalizations(global::AppStoreConnect.GameCenterAchievementLocalization? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterAchievementRelease value) => new IncludedItem87((global::AppStoreConnect.GameCenterAchievementRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementRelease?(IncludedItem87 @this) => @this.GameCenterAchievementReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            GameCenterAchievementReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterAchievementReleases(global::AppStoreConnect.GameCenterAchievementRelease? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem87((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem87 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem87((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem87 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem87((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem87 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem87((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem87 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(
            global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementLocalization? gameCenterAchievementLocalizations,
            global::AppStoreConnect.GameCenterAchievementRelease? gameCenterAchievementReleases,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups
            )
        {
            Type = type;

            GameCenterAchievementLocalizations = gameCenterAchievementLocalizations;
            GameCenterAchievementReleases = gameCenterAchievementReleases;
            GameCenterAchievements = gameCenterAchievements;
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
            GameCenterAchievements as object ??
            GameCenterAchievementReleases as object ??
            GameCenterAchievementLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementLocalizations?.ToString() ??
            GameCenterAchievementReleases?.ToString() ??
            GameCenterAchievements?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementLocalizations && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations && IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations && !IsGameCenterAchievementReleases && IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && IsGameCenterActivities && !IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && IsGameCenterDetails && !IsGameCenterGroups || !IsGameCenterAchievementLocalizations && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterDetails && IsGameCenterGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementLocalization, TResult>? gameCenterAchievementLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementRelease, TResult>? gameCenterAchievementReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievementLocalizations is { } __value0 && gameCenterAchievementLocalizations != null)
            {
                return gameCenterAchievementLocalizations(__value0);
            }
            else if (GameCenterAchievementReleases is { } __value1 && gameCenterAchievementReleases != null)
            {
                return gameCenterAchievementReleases(__value1);
            }
            else if (GameCenterAchievements is { } __value2 && gameCenterAchievements != null)
            {
                return gameCenterAchievements(__value2);
            }
            else if (GameCenterActivities is { } __value3 && gameCenterActivities != null)
            {
                return gameCenterActivities(__value3);
            }
            else if (GameCenterDetails is { } __value4 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value4);
            }
            else if (GameCenterGroups is { } __value5 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalization>? gameCenterAchievementLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievementLocalizations is { } __value0)
            {
                gameCenterAchievementLocalizations?.Invoke(__value0);
            }
            else if (GameCenterAchievementReleases is { } __value1)
            {
                gameCenterAchievementReleases?.Invoke(__value1);
            }
            else if (GameCenterAchievements is { } __value2)
            {
                gameCenterAchievements?.Invoke(__value2);
            }
            else if (GameCenterActivities is { } __value3)
            {
                gameCenterActivities?.Invoke(__value3);
            }
            else if (GameCenterDetails is { } __value4)
            {
                gameCenterDetails?.Invoke(__value4);
            }
            else if (GameCenterGroups is { } __value5)
            {
                gameCenterGroups?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalization>? gameCenterAchievementLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievementLocalizations is { } __value0)
            {
                gameCenterAchievementLocalizations?.Invoke(__value0);
            }
            else if (GameCenterAchievementReleases is { } __value1)
            {
                gameCenterAchievementReleases?.Invoke(__value1);
            }
            else if (GameCenterAchievements is { } __value2)
            {
                gameCenterAchievements?.Invoke(__value2);
            }
            else if (GameCenterActivities is { } __value3)
            {
                gameCenterActivities?.Invoke(__value3);
            }
            else if (GameCenterDetails is { } __value4)
            {
                gameCenterDetails?.Invoke(__value4);
            }
            else if (GameCenterGroups is { } __value5)
            {
                gameCenterGroups?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterAchievementLocalizations,
                typeof(global::AppStoreConnect.GameCenterAchievementLocalization),
                GameCenterAchievementReleases,
                typeof(global::AppStoreConnect.GameCenterAchievementRelease),
                GameCenterAchievements,
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
        public bool Equals(IncludedItem87 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementLocalization?>.Default.Equals(GameCenterAchievementLocalizations, other.GameCenterAchievementLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementRelease?>.Default.Equals(GameCenterAchievementReleases, other.GameCenterAchievementReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem87 obj1, IncludedItem87 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem87>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem87 obj1, IncludedItem87 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem87 o && Equals(o);
        }
    }
}
