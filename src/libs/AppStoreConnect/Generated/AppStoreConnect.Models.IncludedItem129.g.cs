#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem129 : global::System.IEquatable<IncludedItem129>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallenges { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallenges { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallenges))]
#endif
        public bool IsGameCenterChallenges => GameCenterChallenges != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallenges(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallenge? value)
        {
            value = GameCenterChallenges;
            return IsGameCenterChallenges;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallenges() => IsGameCenterChallenges
            ? GameCenterChallenges!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallenges' but the value was {ToString()}.");

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardLocalization? GameCenterLeaderboardLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardLocalization? GameCenterLeaderboardLocalizations { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardLocalization? value)
        {
            value = GameCenterLeaderboardLocalizations;
            return IsGameCenterLeaderboardLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardLocalization PickGameCenterLeaderboardLocalizations() => IsGameCenterLeaderboardLocalizations
            ? GameCenterLeaderboardLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardReleases1))]
#endif
        public bool IsGameCenterLeaderboardReleases1 => GameCenterLeaderboardReleases1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            value = GameCenterLeaderboardReleases1;
            return IsGameCenterLeaderboardReleases1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardRelease PickGameCenterLeaderboardReleases1() => IsGameCenterLeaderboardReleases1
            ? GameCenterLeaderboardReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardReleases1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            value = GameCenterLeaderboardSets;
            return IsGameCenterLeaderboardSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSets() => IsGameCenterLeaderboardSets
            ? GameCenterLeaderboardSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardReleases2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardReleases2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardReleases2))]
#endif
        public bool IsGameCenterLeaderboardReleases2 => GameCenterLeaderboardReleases2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboardReleases2;
            return IsGameCenterLeaderboardReleases2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboardReleases2() => IsGameCenterLeaderboardReleases2
            ? GameCenterLeaderboardReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardReleases2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem129((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem129 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem129((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem129 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem129((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem129 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem129((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem129 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardLocalization value) => new IncludedItem129((global::AppStoreConnect.GameCenterLeaderboardLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardLocalization?(IncludedItem129 @this) => @this.GameCenterLeaderboardLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardLocalization? value)
        {
            GameCenterLeaderboardLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterLeaderboardLocalizations(global::AppStoreConnect.GameCenterLeaderboardLocalization? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardRelease value) => new IncludedItem129((global::AppStoreConnect.GameCenterLeaderboardRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardRelease?(IncludedItem129 @this) => @this.GameCenterLeaderboardReleases1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            GameCenterLeaderboardReleases1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterLeaderboardReleases1(global::AppStoreConnect.GameCenterLeaderboardRelease? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem129((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem129 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem129(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem129((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem129 @this) => @this.GameCenterLeaderboardReleases2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardReleases2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem129 FromGameCenterLeaderboardReleases2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem129(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem129(
            global::AppStoreConnect.GameCenterLeaderboardResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardLocalization? gameCenterLeaderboardLocalizations,
            global::AppStoreConnect.GameCenterLeaderboardRelease? gameCenterLeaderboardReleases1,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardReleases2
            )
        {
            Type = type;

            GameCenterActivities = gameCenterActivities;
            GameCenterChallenges = gameCenterChallenges;
            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardLocalizations = gameCenterLeaderboardLocalizations;
            GameCenterLeaderboardReleases1 = gameCenterLeaderboardReleases1;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            GameCenterLeaderboardReleases2 = gameCenterLeaderboardReleases2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardReleases2 as object ??
            GameCenterLeaderboardSets as object ??
            GameCenterLeaderboardReleases1 as object ??
            GameCenterLeaderboardLocalizations as object ??
            GameCenterGroups as object ??
            GameCenterDetails as object ??
            GameCenterChallenges as object ??
            GameCenterActivities as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterActivities?.ToString() ??
            GameCenterChallenges?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardLocalizations?.ToString() ??
            GameCenterLeaderboardReleases1?.ToString() ??
            GameCenterLeaderboardSets?.ToString() ??
            GameCenterLeaderboardReleases2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardReleases2 || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardLocalizations && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSets && IsGameCenterLeaderboardReleases2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardLocalization, TResult>? gameCenterLeaderboardLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardRelease, TResult>? gameCenterLeaderboardReleases1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities && gameCenterActivities != null)
            {
                return gameCenterActivities(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges && gameCenterChallenges != null)
            {
                return gameCenterChallenges(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardLocalizations && gameCenterLeaderboardLocalizations != null)
            {
                return gameCenterLeaderboardLocalizations(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboardReleases1 && gameCenterLeaderboardReleases1 != null)
            {
                return gameCenterLeaderboardReleases1(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSets && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardReleases2 && gameCenterLeaderboardReleases2 != null)
            {
                return gameCenterLeaderboardReleases2(GameCenterLeaderboardReleases2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardLocalization>? gameCenterLeaderboardLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges)
            {
                gameCenterChallenges?.Invoke(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardLocalizations)
            {
                gameCenterLeaderboardLocalizations?.Invoke(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboardReleases1)
            {
                gameCenterLeaderboardReleases1?.Invoke(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardReleases2)
            {
                gameCenterLeaderboardReleases2?.Invoke(GameCenterLeaderboardReleases2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardLocalization>? gameCenterLeaderboardLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges)
            {
                gameCenterChallenges?.Invoke(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardLocalizations)
            {
                gameCenterLeaderboardLocalizations?.Invoke(GameCenterLeaderboardLocalizations!);
            }
            else if (IsGameCenterLeaderboardReleases1)
            {
                gameCenterLeaderboardReleases1?.Invoke(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardReleases2)
            {
                gameCenterLeaderboardReleases2?.Invoke(GameCenterLeaderboardReleases2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterChallenges,
                typeof(global::AppStoreConnect.GameCenterChallenge),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardLocalizations,
                typeof(global::AppStoreConnect.GameCenterLeaderboardLocalization),
                GameCenterLeaderboardReleases1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardRelease),
                GameCenterLeaderboardSets,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
                GameCenterLeaderboardReleases2,
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
        public bool Equals(IncludedItem129 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardLocalization?>.Default.Equals(GameCenterLeaderboardLocalizations, other.GameCenterLeaderboardLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardRelease?>.Default.Equals(GameCenterLeaderboardReleases1, other.GameCenterLeaderboardReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardReleases2, other.GameCenterLeaderboardReleases2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem129 obj1, IncludedItem129 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem129>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem129 obj1, IncludedItem129 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem129 o && Equals(o);
        }
    }
}
