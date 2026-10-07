#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem97 : global::System.IEquatable<IncludedItem97>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterChallengeVersion? GameCenterChallengeVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeVersion? GameCenterChallengeVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersions))]
#endif
        public bool IsGameCenterChallengeVersions => GameCenterChallengeVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            value = GameCenterChallengeVersions;
            return IsGameCenterChallengeVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersion PickGameCenterChallengeVersions() => GameCenterChallengeVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem97(global::AppStoreConnect.GameCenterChallengeImage value) => new IncludedItem97((global::AppStoreConnect.GameCenterChallengeImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeImage?(IncludedItem97 @this) => @this.GameCenterChallengeImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem97(global::AppStoreConnect.GameCenterChallengeImage? value)
        {
            GameCenterChallengeImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem97 FromGameCenterChallengeImages(global::AppStoreConnect.GameCenterChallengeImage? value) => new IncludedItem97(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem97(global::AppStoreConnect.GameCenterChallengeVersion value) => new IncludedItem97((global::AppStoreConnect.GameCenterChallengeVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersion?(IncludedItem97 @this) => @this.GameCenterChallengeVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem97(global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            GameCenterChallengeVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem97 FromGameCenterChallengeVersions(global::AppStoreConnect.GameCenterChallengeVersion? value) => new IncludedItem97(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem97(
            global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterChallengeImage? gameCenterChallengeImages,
            global::AppStoreConnect.GameCenterChallengeVersion? gameCenterChallengeVersions
            )
        {
            Type = type;

            GameCenterChallengeImages = gameCenterChallengeImages;
            GameCenterChallengeVersions = gameCenterChallengeVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterChallengeVersions as object ??
            GameCenterChallengeImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterChallengeImages?.ToString() ??
            GameCenterChallengeVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterChallengeImages && !IsGameCenterChallengeVersions || !IsGameCenterChallengeImages && IsGameCenterChallengeVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterChallengeImage, TResult>? gameCenterChallengeImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersion, TResult>? gameCenterChallengeVersions = null,
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
            else if (GameCenterChallengeVersions is { } __value1 && gameCenterChallengeVersions != null)
            {
                return gameCenterChallengeVersions(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,
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
            else if (GameCenterChallengeVersions is { } __value1)
            {
                gameCenterChallengeVersions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeImage>? gameCenterChallengeImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,
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
            else if (GameCenterChallengeVersions is { } __value1)
            {
                gameCenterChallengeVersions?.Invoke(__value1);
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
                GameCenterChallengeVersions,
                typeof(global::AppStoreConnect.GameCenterChallengeVersion),
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
        public bool Equals(IncludedItem97 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeImage?>.Default.Equals(GameCenterChallengeImages, other.GameCenterChallengeImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersion?>.Default.Equals(GameCenterChallengeVersions, other.GameCenterChallengeVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem97 obj1, IncludedItem97 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem97>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem97 obj1, IncludedItem97 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem97 o && Equals(o);
        }
    }
}
