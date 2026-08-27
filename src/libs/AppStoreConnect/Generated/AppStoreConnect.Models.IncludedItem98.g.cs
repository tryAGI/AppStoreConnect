#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem98 : global::System.IEquatable<IncludedItem98>
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
        public global::AppStoreConnect.GameCenterChallengeImage PickGameCenterChallengeImages() => IsGameCenterChallengeImages
            ? GameCenterChallengeImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeImages' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeLocalization? GameCenterChallengeLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeLocalization? GameCenterChallengeLocalizations1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeLocalizations1))]
#endif
        public bool IsGameCenterChallengeLocalizations1 => GameCenterChallengeLocalizations1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterChallengeLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeLocalization? value)
        {
            value = GameCenterChallengeLocalizations1;
            return IsGameCenterChallengeLocalizations1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeLocalization PickGameCenterChallengeLocalizations1() => IsGameCenterChallengeLocalizations1
            ? GameCenterChallengeLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeLocalizations1' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterChallengeVersionRelease PickGameCenterChallengeVersionReleases() => IsGameCenterChallengeVersionReleases
            ? GameCenterChallengeVersionReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersionReleases' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallengeLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallengeLocalizations2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeLocalizations2))]
#endif
        public bool IsGameCenterChallengeLocalizations2 => GameCenterChallengeLocalizations2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterChallengeLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallenge? value)
        {
            value = GameCenterChallengeLocalizations2;
            return IsGameCenterChallengeLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallengeLocalizations2() => IsGameCenterChallengeLocalizations2
            ? GameCenterChallengeLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeLocalizations2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem98(global::AppStoreConnect.GameCenterChallengeImage value) => new IncludedItem98((global::AppStoreConnect.GameCenterChallengeImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeImage?(IncludedItem98 @this) => @this.GameCenterChallengeImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem98(global::AppStoreConnect.GameCenterChallengeImage? value)
        {
            GameCenterChallengeImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem98 FromGameCenterChallengeImages(global::AppStoreConnect.GameCenterChallengeImage? value) => new IncludedItem98(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem98(global::AppStoreConnect.GameCenterChallengeLocalization value) => new IncludedItem98((global::AppStoreConnect.GameCenterChallengeLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeLocalization?(IncludedItem98 @this) => @this.GameCenterChallengeLocalizations1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem98(global::AppStoreConnect.GameCenterChallengeLocalization? value)
        {
            GameCenterChallengeLocalizations1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem98 FromGameCenterChallengeLocalizations1(global::AppStoreConnect.GameCenterChallengeLocalization? value) => new IncludedItem98(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem98(global::AppStoreConnect.GameCenterChallengeVersionRelease value) => new IncludedItem98((global::AppStoreConnect.GameCenterChallengeVersionRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersionRelease?(IncludedItem98 @this) => @this.GameCenterChallengeVersionReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem98(global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            GameCenterChallengeVersionReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem98 FromGameCenterChallengeVersionReleases(global::AppStoreConnect.GameCenterChallengeVersionRelease? value) => new IncludedItem98(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem98(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem98((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem98 @this) => @this.GameCenterChallengeLocalizations2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem98(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallengeLocalizations2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem98 FromGameCenterChallengeLocalizations2(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem98(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem98(
            global::AppStoreConnect.GameCenterChallengeVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterChallengeImage? gameCenterChallengeImages,
            global::AppStoreConnect.GameCenterChallengeLocalization? gameCenterChallengeLocalizations1,
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallengeLocalizations2
            )
        {
            Type = type;

            GameCenterChallengeImages = gameCenterChallengeImages;
            GameCenterChallengeLocalizations1 = gameCenterChallengeLocalizations1;
            GameCenterChallengeVersionReleases = gameCenterChallengeVersionReleases;
            GameCenterChallengeLocalizations2 = gameCenterChallengeLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterChallengeLocalizations2 as object ??
            GameCenterChallengeVersionReleases as object ??
            GameCenterChallengeLocalizations1 as object ??
            GameCenterChallengeImages as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterChallengeImages?.ToString() ??
            GameCenterChallengeLocalizations1?.ToString() ??
            GameCenterChallengeVersionReleases?.ToString() ??
            GameCenterChallengeLocalizations2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations1 && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallengeLocalizations2 || !IsGameCenterChallengeImages && IsGameCenterChallengeLocalizations1 && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallengeLocalizations2 || !IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations1 && IsGameCenterChallengeVersionReleases && !IsGameCenterChallengeLocalizations2 || !IsGameCenterChallengeImages && !IsGameCenterChallengeLocalizations1 && !IsGameCenterChallengeVersionReleases && IsGameCenterChallengeLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterChallengeImage, TResult>? gameCenterChallengeImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeLocalization, TResult>? gameCenterChallengeLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersionRelease, TResult>? gameCenterChallengeVersionReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallengeLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterChallengeImages && gameCenterChallengeImages != null)
            {
                return gameCenterChallengeImages(GameCenterChallengeImages!);
            }
            else if (IsGameCenterChallengeLocalizations1 && gameCenterChallengeLocalizations1 != null)
            {
                return gameCenterChallengeLocalizations1(GameCenterChallengeLocalizations1!);
            }
            else if (IsGameCenterChallengeVersionReleases && gameCenterChallengeVersionReleases != null)
            {
                return gameCenterChallengeVersionReleases(GameCenterChallengeVersionReleases!);
            }
            else if (IsGameCenterChallengeLocalizations2 && gameCenterChallengeLocalizations2 != null)
            {
                return gameCenterChallengeLocalizations2(GameCenterChallengeLocalizations2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeLocalization>? gameCenterChallengeLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallengeLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterChallengeImages)
            {
                gameCenterChallengeImages?.Invoke(GameCenterChallengeImages!);
            }
            else if (IsGameCenterChallengeLocalizations1)
            {
                gameCenterChallengeLocalizations1?.Invoke(GameCenterChallengeLocalizations1!);
            }
            else if (IsGameCenterChallengeVersionReleases)
            {
                gameCenterChallengeVersionReleases?.Invoke(GameCenterChallengeVersionReleases!);
            }
            else if (IsGameCenterChallengeLocalizations2)
            {
                gameCenterChallengeLocalizations2?.Invoke(GameCenterChallengeLocalizations2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeLocalization>? gameCenterChallengeLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallengeLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterChallengeImages)
            {
                gameCenterChallengeImages?.Invoke(GameCenterChallengeImages!);
            }
            else if (IsGameCenterChallengeLocalizations1)
            {
                gameCenterChallengeLocalizations1?.Invoke(GameCenterChallengeLocalizations1!);
            }
            else if (IsGameCenterChallengeVersionReleases)
            {
                gameCenterChallengeVersionReleases?.Invoke(GameCenterChallengeVersionReleases!);
            }
            else if (IsGameCenterChallengeLocalizations2)
            {
                gameCenterChallengeLocalizations2?.Invoke(GameCenterChallengeLocalizations2!);
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
                GameCenterChallengeLocalizations1,
                typeof(global::AppStoreConnect.GameCenterChallengeLocalization),
                GameCenterChallengeVersionReleases,
                typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease),
                GameCenterChallengeLocalizations2,
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
        public bool Equals(IncludedItem98 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeImage?>.Default.Equals(GameCenterChallengeImages, other.GameCenterChallengeImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeLocalization?>.Default.Equals(GameCenterChallengeLocalizations1, other.GameCenterChallengeLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersionRelease?>.Default.Equals(GameCenterChallengeVersionReleases, other.GameCenterChallengeVersionReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallengeLocalizations2, other.GameCenterChallengeLocalizations2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem98 obj1, IncludedItem98 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem98>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem98 obj1, IncludedItem98 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem98 o && Equals(o);
        }
    }
}
