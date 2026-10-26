#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem100 : global::System.IEquatable<IncludedItem100>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeImage? GameCenterChallengeImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeImage? GameCenterChallengeImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeImages))]
#endif
        public bool IsGameCenterChallengeImages => GameCenterChallengeImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeImage? value)
        {
            value = GameCenterChallengeImages;
            return IsGameCenterChallengeImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeImage PickGameCenterChallengeImages() => GameCenterChallengeImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeLocalization? GameCenterChallengeLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeLocalization? GameCenterChallengeLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeLocalizations))]
#endif
        public bool IsGameCenterChallengeLocalizations => GameCenterChallengeLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeLocalization? value)
        {
            value = GameCenterChallengeLocalizations;
            return IsGameCenterChallengeLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeLocalization PickGameCenterChallengeLocalizations() => GameCenterChallengeLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersionReleases))]
#endif
        public bool IsGameCenterChallengeVersionReleases => GameCenterChallengeVersionReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeVersionReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            value = GameCenterChallengeVersionReleases;
            return IsGameCenterChallengeVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersionRelease PickGameCenterChallengeVersionReleases() => GameCenterChallengeVersionReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersionReleases' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallenges() => GameCenterChallenges is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallenges' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem100(global::AppStoreConnect.GameCenterChallengeImage value) => new IncludedItem100((global::AppStoreConnect.GameCenterChallengeImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeImage?(IncludedItem100 @this) => @this.GameCenterChallengeImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem100(global::AppStoreConnect.GameCenterChallengeImage? value)
        {
            GameCenterChallengeImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem100 FromGameCenterChallengeImages(global::AppStoreConnect.GameCenterChallengeImage? value) => new IncludedItem100(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem100(global::AppStoreConnect.GameCenterChallengeLocalization value) => new IncludedItem100((global::AppStoreConnect.GameCenterChallengeLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeLocalization?(IncludedItem100 @this) => @this.GameCenterChallengeLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem100(global::AppStoreConnect.GameCenterChallengeLocalization? value)
        {
            GameCenterChallengeLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem100 FromGameCenterChallengeLocalizations(global::AppStoreConnect.GameCenterChallengeLocalization? value) => new IncludedItem100(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem100(global::AppStoreConnect.GameCenterChallengeVersionRelease value) => new IncludedItem100((global::AppStoreConnect.GameCenterChallengeVersionRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersionRelease?(IncludedItem100 @this) => @this.GameCenterChallengeVersionReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem100(global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            GameCenterChallengeVersionReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem100 FromGameCenterChallengeVersionReleases(global::AppStoreConnect.GameCenterChallengeVersionRelease? value) => new IncludedItem100(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem100(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem100((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem100 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem100(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem100 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem100(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem100(
            global::AppStoreConnect.GameCenterChallengeVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterChallengeImage? gameCenterChallengeImages,
            global::AppStoreConnect.GameCenterChallengeLocalization? gameCenterChallengeLocalizations,
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges
            )
        {
            Type = type;

            GameCenterChallengeImages = gameCenterChallengeImages;
            GameCenterChallengeLocalizations = gameCenterChallengeLocalizations;
            GameCenterChallengeVersionReleases = gameCenterChallengeVersionReleases;
            GameCenterChallenges = gameCenterChallenges;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterChallenges as object ??
            GameCenterChallengeVersionReleases as object ??
            GameCenterChallengeLocalizations as object ??
            GameCenterChallengeImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterChallengeImages?.ToString() ??
            GameCenterChallengeLocalizations?.ToString() ??
            GameCenterChallengeVersionReleases?.ToString() ??
            GameCenterChallenges?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges || !IsGameCenterChallengeImages && IsGameCenterChallengeLocalizations && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges || !IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations && IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges || !IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations && !IsGameCenterChallengeVersionReleases && IsGameCenterChallenges;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterChallengeImage, TResult>? gameCenterChallengeImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeLocalization, TResult>? gameCenterChallengeLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersionRelease, TResult>? gameCenterChallengeVersionReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeImages is { } __value0 && gameCenterChallengeImages != null)
            {
                return gameCenterChallengeImages(__value0);
            }
            else if (GameCenterChallengeLocalizations is { } __value1 && gameCenterChallengeLocalizations != null)
            {
                return gameCenterChallengeLocalizations(__value1);
            }
            else if (GameCenterChallengeVersionReleases is { } __value2 && gameCenterChallengeVersionReleases != null)
            {
                return gameCenterChallengeVersionReleases(__value2);
            }
            else if (GameCenterChallenges is { } __value3 && gameCenterChallenges != null)
            {
                return gameCenterChallenges(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeLocalization>? gameCenterChallengeLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeImages is { } __value0)
            {
                gameCenterChallengeImages?.Invoke(__value0);
            }
            else if (GameCenterChallengeLocalizations is { } __value1)
            {
                gameCenterChallengeLocalizations?.Invoke(__value1);
            }
            else if (GameCenterChallengeVersionReleases is { } __value2)
            {
                gameCenterChallengeVersionReleases?.Invoke(__value2);
            }
            else if (GameCenterChallenges is { } __value3)
            {
                gameCenterChallenges?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeLocalization>? gameCenterChallengeLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeImages is { } __value0)
            {
                gameCenterChallengeImages?.Invoke(__value0);
            }
            else if (GameCenterChallengeLocalizations is { } __value1)
            {
                gameCenterChallengeLocalizations?.Invoke(__value1);
            }
            else if (GameCenterChallengeVersionReleases is { } __value2)
            {
                gameCenterChallengeVersionReleases?.Invoke(__value2);
            }
            else if (GameCenterChallenges is { } __value3)
            {
                gameCenterChallenges?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterChallengeImages,
                typeof(global::AppStoreConnect.GameCenterChallengeImage),
                GameCenterChallengeLocalizations,
                typeof(global::AppStoreConnect.GameCenterChallengeLocalization),
                GameCenterChallengeVersionReleases,
                typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease),
                GameCenterChallenges,
                typeof(global::AppStoreConnect.GameCenterChallenge),
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
        public bool Equals(IncludedItem100 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeImage?>.Default.Equals(GameCenterChallengeImages, other.GameCenterChallengeImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeLocalization?>.Default.Equals(GameCenterChallengeLocalizations, other.GameCenterChallengeLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersionRelease?>.Default.Equals(GameCenterChallengeVersionReleases, other.GameCenterChallengeVersionReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem100 obj1, IncludedItem100 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem100>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem100 obj1, IncludedItem100 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem100 o && Equals(o);
        }
    }
}
