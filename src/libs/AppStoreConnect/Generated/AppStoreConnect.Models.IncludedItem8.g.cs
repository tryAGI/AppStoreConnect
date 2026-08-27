#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem8 : global::System.IEquatable<IncludedItem8>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipAppStoreReviewDetail? AppClipAppStoreReviewDetails { get; init; }
#else
        public global::AppStoreConnect.AppClipAppStoreReviewDetail? AppClipAppStoreReviewDetails { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAppStoreReviewDetails))]
#endif
        public bool IsAppClipAppStoreReviewDetails => AppClipAppStoreReviewDetails != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipAppStoreReviewDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipAppStoreReviewDetail? value)
        {
            value = AppClipAppStoreReviewDetails;
            return IsAppClipAppStoreReviewDetails;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipAppStoreReviewDetail PickAppClipAppStoreReviewDetails() => IsAppClipAppStoreReviewDetails
            ? AppClipAppStoreReviewDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAppStoreReviewDetails' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipDefaultExperienceLocalization? AppClipDefaultExperienceLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.AppClipDefaultExperienceLocalization? AppClipDefaultExperienceLocalizations1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperienceLocalizations1))]
#endif
        public bool IsAppClipDefaultExperienceLocalizations1 => AppClipDefaultExperienceLocalizations1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipDefaultExperienceLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipDefaultExperienceLocalization? value)
        {
            value = AppClipDefaultExperienceLocalizations1;
            return IsAppClipDefaultExperienceLocalizations1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperienceLocalization PickAppClipDefaultExperienceLocalizations1() => IsAppClipDefaultExperienceLocalizations1
            ? AppClipDefaultExperienceLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperienceLocalizations1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClip? AppClipDefaultExperienceLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.AppClip? AppClipDefaultExperienceLocalizations2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperienceLocalizations2))]
#endif
        public bool IsAppClipDefaultExperienceLocalizations2 => AppClipDefaultExperienceLocalizations2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipDefaultExperienceLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClip? value)
        {
            value = AppClipDefaultExperienceLocalizations2;
            return IsAppClipDefaultExperienceLocalizations2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClip PickAppClipDefaultExperienceLocalizations2() => IsAppClipDefaultExperienceLocalizations2
            ? AppClipDefaultExperienceLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperienceLocalizations2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions))]
#endif
        public bool IsAppStoreVersions => AppStoreVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppStoreVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions;
            return IsAppStoreVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => IsAppStoreVersions
            ? AppStoreVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem8(global::AppStoreConnect.AppClipAppStoreReviewDetail value) => new IncludedItem8((global::AppStoreConnect.AppClipAppStoreReviewDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipAppStoreReviewDetail?(IncludedItem8 @this) => @this.AppClipAppStoreReviewDetails;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem8(global::AppStoreConnect.AppClipAppStoreReviewDetail? value)
        {
            AppClipAppStoreReviewDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem8 FromAppClipAppStoreReviewDetails(global::AppStoreConnect.AppClipAppStoreReviewDetail? value) => new IncludedItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem8(global::AppStoreConnect.AppClipDefaultExperienceLocalization value) => new IncludedItem8((global::AppStoreConnect.AppClipDefaultExperienceLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipDefaultExperienceLocalization?(IncludedItem8 @this) => @this.AppClipDefaultExperienceLocalizations1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem8(global::AppStoreConnect.AppClipDefaultExperienceLocalization? value)
        {
            AppClipDefaultExperienceLocalizations1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem8 FromAppClipDefaultExperienceLocalizations1(global::AppStoreConnect.AppClipDefaultExperienceLocalization? value) => new IncludedItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem8(global::AppStoreConnect.AppClip value) => new IncludedItem8((global::AppStoreConnect.AppClip?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClip?(IncludedItem8 @this) => @this.AppClipDefaultExperienceLocalizations2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem8(global::AppStoreConnect.AppClip? value)
        {
            AppClipDefaultExperienceLocalizations2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem8 FromAppClipDefaultExperienceLocalizations2(global::AppStoreConnect.AppClip? value) => new IncludedItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem8(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem8((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem8 @this) => @this.AppStoreVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem8(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem8 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem8(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem8(
            global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipAppStoreReviewDetail? appClipAppStoreReviewDetails,
            global::AppStoreConnect.AppClipDefaultExperienceLocalization? appClipDefaultExperienceLocalizations1,
            global::AppStoreConnect.AppClip? appClipDefaultExperienceLocalizations2,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions
            )
        {
            Type = type;

            AppClipAppStoreReviewDetails = appClipAppStoreReviewDetails;
            AppClipDefaultExperienceLocalizations1 = appClipDefaultExperienceLocalizations1;
            AppClipDefaultExperienceLocalizations2 = appClipDefaultExperienceLocalizations2;
            AppStoreVersions = appStoreVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppStoreVersions as object ??
            AppClipDefaultExperienceLocalizations2 as object ??
            AppClipDefaultExperienceLocalizations1 as object ??
            AppClipAppStoreReviewDetails as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppClipAppStoreReviewDetails?.ToString() ??
            AppClipDefaultExperienceLocalizations1?.ToString() ??
            AppClipDefaultExperienceLocalizations2?.ToString() ??
            AppStoreVersions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppClipAppStoreReviewDetails && !IsAppClipDefaultExperienceLocalizations1 && !IsAppClipDefaultExperienceLocalizations2 && !IsAppStoreVersions || !IsAppClipAppStoreReviewDetails && IsAppClipDefaultExperienceLocalizations1 && !IsAppClipDefaultExperienceLocalizations2 && !IsAppStoreVersions || !IsAppClipAppStoreReviewDetails && !IsAppClipDefaultExperienceLocalizations1 && IsAppClipDefaultExperienceLocalizations2 && !IsAppStoreVersions || !IsAppClipAppStoreReviewDetails && !IsAppClipDefaultExperienceLocalizations1 && !IsAppClipDefaultExperienceLocalizations2 && IsAppStoreVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipAppStoreReviewDetail, TResult>? appClipAppStoreReviewDetails = null,
            global::System.Func<global::AppStoreConnect.AppClipDefaultExperienceLocalization, TResult>? appClipDefaultExperienceLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.AppClip, TResult>? appClipDefaultExperienceLocalizations2 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAppStoreReviewDetails && appClipAppStoreReviewDetails != null)
            {
                return appClipAppStoreReviewDetails(AppClipAppStoreReviewDetails!);
            }
            else if (IsAppClipDefaultExperienceLocalizations1 && appClipDefaultExperienceLocalizations1 != null)
            {
                return appClipDefaultExperienceLocalizations1(AppClipDefaultExperienceLocalizations1!);
            }
            else if (IsAppClipDefaultExperienceLocalizations2 && appClipDefaultExperienceLocalizations2 != null)
            {
                return appClipDefaultExperienceLocalizations2(AppClipDefaultExperienceLocalizations2!);
            }
            else if (IsAppStoreVersions && appStoreVersions != null)
            {
                return appStoreVersions(AppStoreVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipAppStoreReviewDetail>? appClipAppStoreReviewDetails = null,

            global::System.Action<global::AppStoreConnect.AppClipDefaultExperienceLocalization>? appClipDefaultExperienceLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.AppClip>? appClipDefaultExperienceLocalizations2 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAppStoreReviewDetails)
            {
                appClipAppStoreReviewDetails?.Invoke(AppClipAppStoreReviewDetails!);
            }
            else if (IsAppClipDefaultExperienceLocalizations1)
            {
                appClipDefaultExperienceLocalizations1?.Invoke(AppClipDefaultExperienceLocalizations1!);
            }
            else if (IsAppClipDefaultExperienceLocalizations2)
            {
                appClipDefaultExperienceLocalizations2?.Invoke(AppClipDefaultExperienceLocalizations2!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipAppStoreReviewDetail>? appClipAppStoreReviewDetails = null,
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperienceLocalization>? appClipDefaultExperienceLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.AppClip>? appClipDefaultExperienceLocalizations2 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAppStoreReviewDetails)
            {
                appClipAppStoreReviewDetails?.Invoke(AppClipAppStoreReviewDetails!);
            }
            else if (IsAppClipDefaultExperienceLocalizations1)
            {
                appClipDefaultExperienceLocalizations1?.Invoke(AppClipDefaultExperienceLocalizations1!);
            }
            else if (IsAppClipDefaultExperienceLocalizations2)
            {
                appClipDefaultExperienceLocalizations2?.Invoke(AppClipDefaultExperienceLocalizations2!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipAppStoreReviewDetails,
                typeof(global::AppStoreConnect.AppClipAppStoreReviewDetail),
                AppClipDefaultExperienceLocalizations1,
                typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalization),
                AppClipDefaultExperienceLocalizations2,
                typeof(global::AppStoreConnect.AppClip),
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
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
        public bool Equals(IncludedItem8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipAppStoreReviewDetail?>.Default.Equals(AppClipAppStoreReviewDetails, other.AppClipAppStoreReviewDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipDefaultExperienceLocalization?>.Default.Equals(AppClipDefaultExperienceLocalizations1, other.AppClipDefaultExperienceLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClip?>.Default.Equals(AppClipDefaultExperienceLocalizations2, other.AppClipDefaultExperienceLocalizations2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem8 obj1, IncludedItem8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem8 obj1, IncludedItem8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem8 o && Equals(o);
        }
    }
}
