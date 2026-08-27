#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem80 : global::System.IEquatable<IncludedItem80>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => IsGameCenterAchievements
            ? GameCenterAchievements!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem80(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem80((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem80 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem80(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem80 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem80(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem80(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem80((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem80 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem80(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem80 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem80(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem80(
            global::AppStoreConnect.GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails
            )
        {
            Type = type;

            GameCenterAchievements = gameCenterAchievements;
            GameCenterDetails = gameCenterDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterDetails as object ??
            GameCenterAchievements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievements?.ToString() ??
            GameCenterDetails?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievements && !IsGameCenterDetails || !IsGameCenterAchievements && IsGameCenterDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements && gameCenterAchievements != null)
            {
                return gameCenterAchievements(GameCenterAchievements!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterAchievements,
                typeof(global::AppStoreConnect.GameCenterAchievement),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
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
        public bool Equals(IncludedItem80 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem80 obj1, IncludedItem80 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem80>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem80 obj1, IncludedItem80 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem80 o && Equals(o);
        }
    }
}
