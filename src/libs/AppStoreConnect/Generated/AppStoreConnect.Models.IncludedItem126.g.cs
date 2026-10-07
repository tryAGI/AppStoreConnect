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
        public global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalization? GameCenterLeaderboardSetLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalization? GameCenterLeaderboardSetLocalizations { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardSetLocalization? value)
        {
            value = GameCenterLeaderboardSetLocalizations;
            return IsGameCenterLeaderboardSetLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalization PickGameCenterLeaderboardSetLocalizations() => GameCenterLeaderboardSetLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetReleases))]
#endif
        public bool IsGameCenterLeaderboardSetReleases => GameCenterLeaderboardSetReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            value = GameCenterLeaderboardSetReleases;
            return IsGameCenterLeaderboardSetReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease PickGameCenterLeaderboardSetReleases() => GameCenterLeaderboardSetReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets1))]
#endif
        public bool IsGameCenterLeaderboardSets1 => GameCenterLeaderboardSets1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            value = GameCenterLeaderboardSets1;
            return IsGameCenterLeaderboardSets1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSets1() => GameCenterLeaderboardSets1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardSets2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardSets2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets2))]
#endif
        public bool IsGameCenterLeaderboardSets2 => GameCenterLeaderboardSets2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboardSets2;
            return IsGameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboardSets2() => GameCenterLeaderboardSets2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem126((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem126 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem126((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem126 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSetLocalization value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboardSetLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetLocalization?(IncludedItem126 @this) => @this.GameCenterLeaderboardSetLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSetLocalization? value)
        {
            GameCenterLeaderboardSetLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboardSetLocalizations(global::AppStoreConnect.GameCenterLeaderboardSetLocalization? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSetRelease value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboardSetRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetRelease?(IncludedItem126 @this) => @this.GameCenterLeaderboardSetReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            GameCenterLeaderboardSetReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboardSetReleases(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem126 @this) => @this.GameCenterLeaderboardSets1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboardSets1(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem126(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem126((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem126 @this) => @this.GameCenterLeaderboardSets2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardSets2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem126 FromGameCenterLeaderboardSets2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem126(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem126(
            global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardSetLocalization? gameCenterLeaderboardSetLocalizations,
            global::AppStoreConnect.GameCenterLeaderboardSetRelease? gameCenterLeaderboardSetReleases,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets1,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardSets2
            )
        {
            Type = type;

            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardSetLocalizations = gameCenterLeaderboardSetLocalizations;
            GameCenterLeaderboardSetReleases = gameCenterLeaderboardSetReleases;
            GameCenterLeaderboardSets1 = gameCenterLeaderboardSets1;
            GameCenterLeaderboardSets2 = gameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSets2 as object ??
            GameCenterLeaderboardSets1 as object ??
            GameCenterLeaderboardSetReleases as object ??
            GameCenterLeaderboardSetLocalizations as object ??
            GameCenterGroups as object ??
            GameCenterDetails as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardSetLocalizations?.ToString() ??
            GameCenterLeaderboardSetReleases?.ToString() ??
            GameCenterLeaderboardSets1?.ToString() ??
            GameCenterLeaderboardSets2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetLocalizations && IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSetReleases && IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetLocalizations && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets1 && IsGameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetLocalization, TResult>? gameCenterLeaderboardSetLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetRelease, TResult>? gameCenterLeaderboardSetReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardSets2 = null,
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
            else if (GameCenterGroups is { } __value1 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value1);
            }
            else if (GameCenterLeaderboardSetLocalizations is { } __value2 && gameCenterLeaderboardSetLocalizations != null)
            {
                return gameCenterLeaderboardSetLocalizations(__value2);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value3 && gameCenterLeaderboardSetReleases != null)
            {
                return gameCenterLeaderboardSetReleases(__value3);
            }
            else if (GameCenterLeaderboardSets1 is { } __value4 && gameCenterLeaderboardSets1 != null)
            {
                return gameCenterLeaderboardSets1(__value4);
            }
            else if (GameCenterLeaderboardSets2 is { } __value5 && gameCenterLeaderboardSets2 != null)
            {
                return gameCenterLeaderboardSets2(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetLocalization>? gameCenterLeaderboardSetLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
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
            else if (GameCenterGroups is { } __value1)
            {
                gameCenterGroups?.Invoke(__value1);
            }
            else if (GameCenterLeaderboardSetLocalizations is { } __value2)
            {
                gameCenterLeaderboardSetLocalizations?.Invoke(__value2);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value3)
            {
                gameCenterLeaderboardSetReleases?.Invoke(__value3);
            }
            else if (GameCenterLeaderboardSets1 is { } __value4)
            {
                gameCenterLeaderboardSets1?.Invoke(__value4);
            }
            else if (GameCenterLeaderboardSets2 is { } __value5)
            {
                gameCenterLeaderboardSets2?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetLocalization>? gameCenterLeaderboardSetLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
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
            else if (GameCenterGroups is { } __value1)
            {
                gameCenterGroups?.Invoke(__value1);
            }
            else if (GameCenterLeaderboardSetLocalizations is { } __value2)
            {
                gameCenterLeaderboardSetLocalizations?.Invoke(__value2);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value3)
            {
                gameCenterLeaderboardSetReleases?.Invoke(__value3);
            }
            else if (GameCenterLeaderboardSets1 is { } __value4)
            {
                gameCenterLeaderboardSets1?.Invoke(__value4);
            }
            else if (GameCenterLeaderboardSets2 is { } __value5)
            {
                gameCenterLeaderboardSets2?.Invoke(__value5);
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
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardSetLocalizations,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalization),
                GameCenterLeaderboardSetReleases,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease),
                GameCenterLeaderboardSets1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
                GameCenterLeaderboardSets2,
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
        public bool Equals(IncludedItem126 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetLocalization?>.Default.Equals(GameCenterLeaderboardSetLocalizations, other.GameCenterLeaderboardSetLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetRelease?>.Default.Equals(GameCenterLeaderboardSetReleases, other.GameCenterLeaderboardSetReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets1, other.GameCenterLeaderboardSets1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardSets2, other.GameCenterLeaderboardSets2)
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
