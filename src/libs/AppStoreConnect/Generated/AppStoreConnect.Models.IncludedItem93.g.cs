#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem93 : global::System.IEquatable<IncludedItem93>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersionsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityImages))]
#endif
        public bool IsGameCenterActivityImages => GameCenterActivityImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityImage? value)
        {
            value = GameCenterActivityImages;
            return IsGameCenterActivityImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityImage PickGameCenterActivityImages() => GameCenterActivityImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityLocalization? GameCenterActivityLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityLocalization? GameCenterActivityLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityLocalizations))]
#endif
        public bool IsGameCenterActivityLocalizations => GameCenterActivityLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityLocalization? value)
        {
            value = GameCenterActivityLocalizations;
            return IsGameCenterActivityLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityLocalization PickGameCenterActivityLocalizations() => GameCenterActivityLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityVersionRelease? GameCenterActivityVersionReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityVersionRelease? GameCenterActivityVersionReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityVersionReleases))]
#endif
        public bool IsGameCenterActivityVersionReleases => GameCenterActivityVersionReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityVersionReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            value = GameCenterActivityVersionReleases;
            return IsGameCenterActivityVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersionRelease PickGameCenterActivityVersionReleases() => GameCenterActivityVersionReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersionReleases' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem93(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem93((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem93 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem93(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem93 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem93(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem93(global::AppStoreConnect.GameCenterActivityImage value) => new IncludedItem93((global::AppStoreConnect.GameCenterActivityImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityImage?(IncludedItem93 @this) => @this.GameCenterActivityImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem93(global::AppStoreConnect.GameCenterActivityImage? value)
        {
            GameCenterActivityImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem93 FromGameCenterActivityImages(global::AppStoreConnect.GameCenterActivityImage? value) => new IncludedItem93(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem93(global::AppStoreConnect.GameCenterActivityLocalization value) => new IncludedItem93((global::AppStoreConnect.GameCenterActivityLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityLocalization?(IncludedItem93 @this) => @this.GameCenterActivityLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem93(global::AppStoreConnect.GameCenterActivityLocalization? value)
        {
            GameCenterActivityLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem93 FromGameCenterActivityLocalizations(global::AppStoreConnect.GameCenterActivityLocalization? value) => new IncludedItem93(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem93(global::AppStoreConnect.GameCenterActivityVersionRelease value) => new IncludedItem93((global::AppStoreConnect.GameCenterActivityVersionRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersionRelease?(IncludedItem93 @this) => @this.GameCenterActivityVersionReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem93(global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            GameCenterActivityVersionReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem93 FromGameCenterActivityVersionReleases(global::AppStoreConnect.GameCenterActivityVersionRelease? value) => new IncludedItem93(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem93(
            global::AppStoreConnect.GameCenterActivityVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterActivityImage? gameCenterActivityImages,
            global::AppStoreConnect.GameCenterActivityLocalization? gameCenterActivityLocalizations,
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases
            )
        {
            Type = type;

            GameCenterActivities = gameCenterActivities;
            GameCenterActivityImages = gameCenterActivityImages;
            GameCenterActivityLocalizations = gameCenterActivityLocalizations;
            GameCenterActivityVersionReleases = gameCenterActivityVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterActivityVersionReleases as object ??
            GameCenterActivityLocalizations as object ??
            GameCenterActivityImages as object ??
            GameCenterActivities as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterActivities?.ToString() ??
            GameCenterActivityImages?.ToString() ??
            GameCenterActivityLocalizations?.ToString() ??
            GameCenterActivityVersionReleases?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterActivities && !IsGameCenterActivityImages && !IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivities && IsGameCenterActivityImages && !IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivities && !IsGameCenterActivityImages && IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivities && !IsGameCenterActivityImages && !IsGameCenterActivityLocalizations && IsGameCenterActivityVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityImage, TResult>? gameCenterActivityImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityLocalization, TResult>? gameCenterActivityLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersionRelease, TResult>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterActivities is { } __value0 && gameCenterActivities != null)
            {
                return gameCenterActivities(__value0);
            }
            else if (GameCenterActivityImages is { } __value1 && gameCenterActivityImages != null)
            {
                return gameCenterActivityImages(__value1);
            }
            else if (GameCenterActivityLocalizations is { } __value2 && gameCenterActivityLocalizations != null)
            {
                return gameCenterActivityLocalizations(__value2);
            }
            else if (GameCenterActivityVersionReleases is { } __value3 && gameCenterActivityVersionReleases != null)
            {
                return gameCenterActivityVersionReleases(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityLocalization>? gameCenterActivityLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterActivities is { } __value0)
            {
                gameCenterActivities?.Invoke(__value0);
            }
            else if (GameCenterActivityImages is { } __value1)
            {
                gameCenterActivityImages?.Invoke(__value1);
            }
            else if (GameCenterActivityLocalizations is { } __value2)
            {
                gameCenterActivityLocalizations?.Invoke(__value2);
            }
            else if (GameCenterActivityVersionReleases is { } __value3)
            {
                gameCenterActivityVersionReleases?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityLocalization>? gameCenterActivityLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterActivities is { } __value0)
            {
                gameCenterActivities?.Invoke(__value0);
            }
            else if (GameCenterActivityImages is { } __value1)
            {
                gameCenterActivityImages?.Invoke(__value1);
            }
            else if (GameCenterActivityLocalizations is { } __value2)
            {
                gameCenterActivityLocalizations?.Invoke(__value2);
            }
            else if (GameCenterActivityVersionReleases is { } __value3)
            {
                gameCenterActivityVersionReleases?.Invoke(__value3);
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
                GameCenterActivityImages,
                typeof(global::AppStoreConnect.GameCenterActivityImage),
                GameCenterActivityLocalizations,
                typeof(global::AppStoreConnect.GameCenterActivityLocalization),
                GameCenterActivityVersionReleases,
                typeof(global::AppStoreConnect.GameCenterActivityVersionRelease),
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
        public bool Equals(IncludedItem93 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityImage?>.Default.Equals(GameCenterActivityImages, other.GameCenterActivityImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityLocalization?>.Default.Equals(GameCenterActivityLocalizations, other.GameCenterActivityLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersionRelease?>.Default.Equals(GameCenterActivityVersionReleases, other.GameCenterActivityVersionReleases)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem93 obj1, IncludedItem93 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem93>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem93 obj1, IncludedItem93 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem93 o && Equals(o);
        }
    }
}
