#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem9 : global::System.IEquatable<IncludedItem9>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences1 { get; init; }
#else
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences1))]
#endif
        public bool IsAppClipDefaultExperiences1 => AppClipDefaultExperiences1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipDefaultExperiences1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            value = AppClipDefaultExperiences1;
            return IsAppClipDefaultExperiences1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperience PickAppClipDefaultExperiences1() => IsAppClipDefaultExperiences1
            ? AppClipDefaultExperiences1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppClipDefaultExperiences2 { get; init; }
#else
        public global::AppStoreConnect.App? AppClipDefaultExperiences2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences2))]
#endif
        public bool IsAppClipDefaultExperiences2 => AppClipDefaultExperiences2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipDefaultExperiences2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppClipDefaultExperiences2;
            return IsAppClipDefaultExperiences2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickAppClipDefaultExperiences2() => IsAppClipDefaultExperiences2
            ? AppClipDefaultExperiences2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem9(global::AppStoreConnect.AppClipDefaultExperience value) => new IncludedItem9((global::AppStoreConnect.AppClipDefaultExperience?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipDefaultExperience?(IncludedItem9 @this) => @this.AppClipDefaultExperiences1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem9(global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            AppClipDefaultExperiences1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem9 FromAppClipDefaultExperiences1(global::AppStoreConnect.AppClipDefaultExperience? value) => new IncludedItem9(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem9(global::AppStoreConnect.App value) => new IncludedItem9((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem9 @this) => @this.AppClipDefaultExperiences2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem9(global::AppStoreConnect.App? value)
        {
            AppClipDefaultExperiences2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem9 FromAppClipDefaultExperiences2(global::AppStoreConnect.App? value) => new IncludedItem9(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem9(
            global::AppStoreConnect.AppClipsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipDefaultExperience? appClipDefaultExperiences1,
            global::AppStoreConnect.App? appClipDefaultExperiences2
            )
        {
            Type = type;

            AppClipDefaultExperiences1 = appClipDefaultExperiences1;
            AppClipDefaultExperiences2 = appClipDefaultExperiences2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppClipDefaultExperiences2 as object ??
            AppClipDefaultExperiences1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppClipDefaultExperiences1?.ToString() ??
            AppClipDefaultExperiences2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppClipDefaultExperiences1 && !IsAppClipDefaultExperiences2 || !IsAppClipDefaultExperiences1 && IsAppClipDefaultExperiences2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipDefaultExperience, TResult>? appClipDefaultExperiences1 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appClipDefaultExperiences2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences1 && appClipDefaultExperiences1 != null)
            {
                return appClipDefaultExperiences1(AppClipDefaultExperiences1!);
            }
            else if (IsAppClipDefaultExperiences2 && appClipDefaultExperiences2 != null)
            {
                return appClipDefaultExperiences2(AppClipDefaultExperiences2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences1 = null,

            global::System.Action<global::AppStoreConnect.App>? appClipDefaultExperiences2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences1)
            {
                appClipDefaultExperiences1?.Invoke(AppClipDefaultExperiences1!);
            }
            else if (IsAppClipDefaultExperiences2)
            {
                appClipDefaultExperiences2?.Invoke(AppClipDefaultExperiences2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences1 = null,
            global::System.Action<global::AppStoreConnect.App>? appClipDefaultExperiences2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences1)
            {
                appClipDefaultExperiences1?.Invoke(AppClipDefaultExperiences1!);
            }
            else if (IsAppClipDefaultExperiences2)
            {
                appClipDefaultExperiences2?.Invoke(AppClipDefaultExperiences2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipDefaultExperiences1,
                typeof(global::AppStoreConnect.AppClipDefaultExperience),
                AppClipDefaultExperiences2,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipDefaultExperience?>.Default.Equals(AppClipDefaultExperiences1, other.AppClipDefaultExperiences1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppClipDefaultExperiences2, other.AppClipDefaultExperiences2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem9 obj1, IncludedItem9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem9 obj1, IncludedItem9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem9 o && Equals(o);
        }
    }
}
