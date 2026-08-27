#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem81 : global::System.IEquatable<IncludedItem81>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementLocalizationV2? GameCenterAchievementLocalizations { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementLocalizationV2? GameCenterAchievementLocalizations { get; }
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
            out global::AppStoreConnect.GameCenterAchievementLocalizationV2? value)
        {
            value = GameCenterAchievementLocalizations;
            return IsGameCenterAchievementLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementLocalizationV2 PickGameCenterAchievementLocalizations() => IsGameCenterAchievementLocalizations
            ? GameCenterAchievementLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementV2? GameCenterAchievements { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementV2? GameCenterAchievements { get; }
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
            out global::AppStoreConnect.GameCenterAchievementV2? value)
        {
            value = GameCenterAchievements;
            return IsGameCenterAchievements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementV2 PickGameCenterAchievements() => IsGameCenterAchievements
            ? GameCenterAchievements!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem81(global::AppStoreConnect.GameCenterAchievementLocalizationV2 value) => new IncludedItem81((global::AppStoreConnect.GameCenterAchievementLocalizationV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementLocalizationV2?(IncludedItem81 @this) => @this.GameCenterAchievementLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem81(global::AppStoreConnect.GameCenterAchievementLocalizationV2? value)
        {
            GameCenterAchievementLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem81 FromGameCenterAchievementLocalizations(global::AppStoreConnect.GameCenterAchievementLocalizationV2? value) => new IncludedItem81(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem81(global::AppStoreConnect.GameCenterAchievementV2 value) => new IncludedItem81((global::AppStoreConnect.GameCenterAchievementV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementV2?(IncludedItem81 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem81(global::AppStoreConnect.GameCenterAchievementV2? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem81 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievementV2? value) => new IncludedItem81(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem81(
            global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementLocalizationV2? gameCenterAchievementLocalizations,
            global::AppStoreConnect.GameCenterAchievementV2? gameCenterAchievements
            )
        {
            Type = type;

            GameCenterAchievementLocalizations = gameCenterAchievementLocalizations;
            GameCenterAchievements = gameCenterAchievements;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterAchievements as object ??
            GameCenterAchievementLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementLocalizations?.ToString() ??
            GameCenterAchievements?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementLocalizations && !IsGameCenterAchievements || !IsGameCenterAchievementLocalizations && IsGameCenterAchievements;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementLocalizationV2, TResult>? gameCenterAchievementLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementV2, TResult>? gameCenterAchievements = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations && gameCenterAchievementLocalizations != null)
            {
                return gameCenterAchievementLocalizations(GameCenterAchievementLocalizations!);
            }
            else if (IsGameCenterAchievements && gameCenterAchievements != null)
            {
                return gameCenterAchievements(GameCenterAchievements!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalizationV2>? gameCenterAchievementLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementV2>? gameCenterAchievements = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations)
            {
                gameCenterAchievementLocalizations?.Invoke(GameCenterAchievementLocalizations!);
            }
            else if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementLocalizationV2>? gameCenterAchievementLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementV2>? gameCenterAchievements = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementLocalizations)
            {
                gameCenterAchievementLocalizations?.Invoke(GameCenterAchievementLocalizations!);
            }
            else if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
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
                typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2),
                GameCenterAchievements,
                typeof(global::AppStoreConnect.GameCenterAchievementV2),
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
        public bool Equals(IncludedItem81 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementLocalizationV2?>.Default.Equals(GameCenterAchievementLocalizations, other.GameCenterAchievementLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementV2?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem81 obj1, IncludedItem81 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem81>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem81 obj1, IncludedItem81 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem81 o && Equals(o);
        }
    }
}
