#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem91 : global::System.IEquatable<IncludedItem91>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivityImages1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivityImages1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityImages1))]
#endif
        public bool IsGameCenterActivityImages1 => GameCenterActivityImages1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterActivityImages1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivity? value)
        {
            value = GameCenterActivityImages1;
            return IsGameCenterActivityImages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivityImages1() => IsGameCenterActivityImages1
            ? GameCenterActivityImages1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityImages1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityImages2))]
#endif
        public bool IsGameCenterActivityImages2 => GameCenterActivityImages2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterActivityImages2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityImage? value)
        {
            value = GameCenterActivityImages2;
            return IsGameCenterActivityImages2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityImage PickGameCenterActivityImages2() => IsGameCenterActivityImages2
            ? GameCenterActivityImages2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityImages2' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterActivityLocalization PickGameCenterActivityLocalizations() => IsGameCenterActivityLocalizations
            ? GameCenterActivityLocalizations!
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
        public global::AppStoreConnect.GameCenterActivityVersionRelease PickGameCenterActivityVersionReleases() => IsGameCenterActivityVersionReleases
            ? GameCenterActivityVersionReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersionReleases' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem91(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem91((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem91 @this) => @this.GameCenterActivityImages1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem91(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivityImages1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem91 FromGameCenterActivityImages1(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem91(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem91(global::AppStoreConnect.GameCenterActivityImage value) => new IncludedItem91((global::AppStoreConnect.GameCenterActivityImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityImage?(IncludedItem91 @this) => @this.GameCenterActivityImages2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem91(global::AppStoreConnect.GameCenterActivityImage? value)
        {
            GameCenterActivityImages2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem91 FromGameCenterActivityImages2(global::AppStoreConnect.GameCenterActivityImage? value) => new IncludedItem91(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem91(global::AppStoreConnect.GameCenterActivityLocalization value) => new IncludedItem91((global::AppStoreConnect.GameCenterActivityLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityLocalization?(IncludedItem91 @this) => @this.GameCenterActivityLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem91(global::AppStoreConnect.GameCenterActivityLocalization? value)
        {
            GameCenterActivityLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem91 FromGameCenterActivityLocalizations(global::AppStoreConnect.GameCenterActivityLocalization? value) => new IncludedItem91(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem91(global::AppStoreConnect.GameCenterActivityVersionRelease value) => new IncludedItem91((global::AppStoreConnect.GameCenterActivityVersionRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersionRelease?(IncludedItem91 @this) => @this.GameCenterActivityVersionReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem91(global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            GameCenterActivityVersionReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem91 FromGameCenterActivityVersionReleases(global::AppStoreConnect.GameCenterActivityVersionRelease? value) => new IncludedItem91(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem91(
            global::AppStoreConnect.GameCenterActivityVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivityImages1,
            global::AppStoreConnect.GameCenterActivityImage? gameCenterActivityImages2,
            global::AppStoreConnect.GameCenterActivityLocalization? gameCenterActivityLocalizations,
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases
            )
        {
            Type = type;

            GameCenterActivityImages1 = gameCenterActivityImages1;
            GameCenterActivityImages2 = gameCenterActivityImages2;
            GameCenterActivityLocalizations = gameCenterActivityLocalizations;
            GameCenterActivityVersionReleases = gameCenterActivityVersionReleases;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterActivityVersionReleases as object ??
            GameCenterActivityLocalizations as object ??
            GameCenterActivityImages2 as object ??
            GameCenterActivityImages1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterActivityImages1?.ToString() ??
            GameCenterActivityImages2?.ToString() ??
            GameCenterActivityLocalizations?.ToString() ??
            GameCenterActivityVersionReleases?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterActivityImages1 && !IsGameCenterActivityImages2 && !IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivityImages1 && IsGameCenterActivityImages2 && !IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivityImages1 && !IsGameCenterActivityImages2 && IsGameCenterActivityLocalizations && !IsGameCenterActivityVersionReleases || !IsGameCenterActivityImages1 && !IsGameCenterActivityImages2 && !IsGameCenterActivityLocalizations && IsGameCenterActivityVersionReleases;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivityImages1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityImage, TResult>? gameCenterActivityImages2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityLocalization, TResult>? gameCenterActivityLocalizations = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersionRelease, TResult>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages1 && gameCenterActivityImages1 != null)
            {
                return gameCenterActivityImages1(GameCenterActivityImages1!);
            }
            else if (IsGameCenterActivityImages2 && gameCenterActivityImages2 != null)
            {
                return gameCenterActivityImages2(GameCenterActivityImages2!);
            }
            else if (IsGameCenterActivityLocalizations && gameCenterActivityLocalizations != null)
            {
                return gameCenterActivityLocalizations(GameCenterActivityLocalizations!);
            }
            else if (IsGameCenterActivityVersionReleases && gameCenterActivityVersionReleases != null)
            {
                return gameCenterActivityVersionReleases(GameCenterActivityVersionReleases!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivityImages1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityLocalization>? gameCenterActivityLocalizations = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages1)
            {
                gameCenterActivityImages1?.Invoke(GameCenterActivityImages1!);
            }
            else if (IsGameCenterActivityImages2)
            {
                gameCenterActivityImages2?.Invoke(GameCenterActivityImages2!);
            }
            else if (IsGameCenterActivityLocalizations)
            {
                gameCenterActivityLocalizations?.Invoke(GameCenterActivityLocalizations!);
            }
            else if (IsGameCenterActivityVersionReleases)
            {
                gameCenterActivityVersionReleases?.Invoke(GameCenterActivityVersionReleases!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivityImages1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityLocalization>? gameCenterActivityLocalizations = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages1)
            {
                gameCenterActivityImages1?.Invoke(GameCenterActivityImages1!);
            }
            else if (IsGameCenterActivityImages2)
            {
                gameCenterActivityImages2?.Invoke(GameCenterActivityImages2!);
            }
            else if (IsGameCenterActivityLocalizations)
            {
                gameCenterActivityLocalizations?.Invoke(GameCenterActivityLocalizations!);
            }
            else if (IsGameCenterActivityVersionReleases)
            {
                gameCenterActivityVersionReleases?.Invoke(GameCenterActivityVersionReleases!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterActivityImages1,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterActivityImages2,
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
        public bool Equals(IncludedItem91 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivityImages1, other.GameCenterActivityImages1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityImage?>.Default.Equals(GameCenterActivityImages2, other.GameCenterActivityImages2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityLocalization?>.Default.Equals(GameCenterActivityLocalizations, other.GameCenterActivityLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersionRelease?>.Default.Equals(GameCenterActivityVersionReleases, other.GameCenterActivityVersionReleases) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem91 obj1, IncludedItem91 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem91>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem91 obj1, IncludedItem91 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem91 o && Equals(o);
        }
    }
}
