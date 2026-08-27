#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem4 : global::System.IEquatable<IncludedItem4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipAdvancedExperienceImage? AppClipAdvancedExperienceImages { get; init; }
#else
        public global::AppStoreConnect.AppClipAdvancedExperienceImage? AppClipAdvancedExperienceImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAdvancedExperienceImages))]
#endif
        public bool IsAppClipAdvancedExperienceImages => AppClipAdvancedExperienceImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipAdvancedExperienceImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipAdvancedExperienceImage? value)
        {
            value = AppClipAdvancedExperienceImages;
            return IsAppClipAdvancedExperienceImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperienceImage PickAppClipAdvancedExperienceImages() => IsAppClipAdvancedExperienceImages
            ? AppClipAdvancedExperienceImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAdvancedExperienceImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization? AppClipAdvancedExperienceLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization? AppClipAdvancedExperienceLocalizations1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAdvancedExperienceLocalizations1))]
#endif
        public bool IsAppClipAdvancedExperienceLocalizations1 => AppClipAdvancedExperienceLocalizations1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipAdvancedExperienceLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value)
        {
            value = AppClipAdvancedExperienceLocalizations1;
            return IsAppClipAdvancedExperienceLocalizations1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization PickAppClipAdvancedExperienceLocalizations1() => IsAppClipAdvancedExperienceLocalizations1
            ? AppClipAdvancedExperienceLocalizations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAdvancedExperienceLocalizations1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClip? AppClipAdvancedExperienceLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.AppClip? AppClipAdvancedExperienceLocalizations2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAdvancedExperienceLocalizations2))]
#endif
        public bool IsAppClipAdvancedExperienceLocalizations2 => AppClipAdvancedExperienceLocalizations2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipAdvancedExperienceLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClip? value)
        {
            value = AppClipAdvancedExperienceLocalizations2;
            return IsAppClipAdvancedExperienceLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClip PickAppClipAdvancedExperienceLocalizations2() => IsAppClipAdvancedExperienceLocalizations2
            ? AppClipAdvancedExperienceLocalizations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAdvancedExperienceLocalizations2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem4(global::AppStoreConnect.AppClipAdvancedExperienceImage value) => new IncludedItem4((global::AppStoreConnect.AppClipAdvancedExperienceImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipAdvancedExperienceImage?(IncludedItem4 @this) => @this.AppClipAdvancedExperienceImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem4(global::AppStoreConnect.AppClipAdvancedExperienceImage? value)
        {
            AppClipAdvancedExperienceImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem4 FromAppClipAdvancedExperienceImages(global::AppStoreConnect.AppClipAdvancedExperienceImage? value) => new IncludedItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem4(global::AppStoreConnect.AppClipAdvancedExperienceLocalization value) => new IncludedItem4((global::AppStoreConnect.AppClipAdvancedExperienceLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipAdvancedExperienceLocalization?(IncludedItem4 @this) => @this.AppClipAdvancedExperienceLocalizations1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem4(global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value)
        {
            AppClipAdvancedExperienceLocalizations1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem4 FromAppClipAdvancedExperienceLocalizations1(global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value) => new IncludedItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem4(global::AppStoreConnect.AppClip value) => new IncludedItem4((global::AppStoreConnect.AppClip?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClip?(IncludedItem4 @this) => @this.AppClipAdvancedExperienceLocalizations2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem4(global::AppStoreConnect.AppClip? value)
        {
            AppClipAdvancedExperienceLocalizations2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem4 FromAppClipAdvancedExperienceLocalizations2(global::AppStoreConnect.AppClip? value) => new IncludedItem4(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem4(
            global::AppStoreConnect.AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipAdvancedExperienceImage? appClipAdvancedExperienceImages,
            global::AppStoreConnect.AppClipAdvancedExperienceLocalization? appClipAdvancedExperienceLocalizations1,
            global::AppStoreConnect.AppClip? appClipAdvancedExperienceLocalizations2
            )
        {
            Type = type;

            AppClipAdvancedExperienceImages = appClipAdvancedExperienceImages;
            AppClipAdvancedExperienceLocalizations1 = appClipAdvancedExperienceLocalizations1;
            AppClipAdvancedExperienceLocalizations2 = appClipAdvancedExperienceLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppClipAdvancedExperienceLocalizations2 as object ??
            AppClipAdvancedExperienceLocalizations1 as object ??
            AppClipAdvancedExperienceImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppClipAdvancedExperienceImages?.ToString() ??
            AppClipAdvancedExperienceLocalizations1?.ToString() ??
            AppClipAdvancedExperienceLocalizations2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppClipAdvancedExperienceImages && !IsAppClipAdvancedExperienceLocalizations1 && !IsAppClipAdvancedExperienceLocalizations2 || !IsAppClipAdvancedExperienceImages && IsAppClipAdvancedExperienceLocalizations1 && !IsAppClipAdvancedExperienceLocalizations2 || !IsAppClipAdvancedExperienceImages && !IsAppClipAdvancedExperienceLocalizations1 && IsAppClipAdvancedExperienceLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipAdvancedExperienceImage, TResult>? appClipAdvancedExperienceImages = null,
            global::System.Func<global::AppStoreConnect.AppClipAdvancedExperienceLocalization, TResult>? appClipAdvancedExperienceLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.AppClip, TResult>? appClipAdvancedExperienceLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAdvancedExperienceImages && appClipAdvancedExperienceImages != null)
            {
                return appClipAdvancedExperienceImages(AppClipAdvancedExperienceImages!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations1 && appClipAdvancedExperienceLocalizations1 != null)
            {
                return appClipAdvancedExperienceLocalizations1(AppClipAdvancedExperienceLocalizations1!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations2 && appClipAdvancedExperienceLocalizations2 != null)
            {
                return appClipAdvancedExperienceLocalizations2(AppClipAdvancedExperienceLocalizations2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceImage>? appClipAdvancedExperienceImages = null,

            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceLocalization>? appClipAdvancedExperienceLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.AppClip>? appClipAdvancedExperienceLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAdvancedExperienceImages)
            {
                appClipAdvancedExperienceImages?.Invoke(AppClipAdvancedExperienceImages!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations1)
            {
                appClipAdvancedExperienceLocalizations1?.Invoke(AppClipAdvancedExperienceLocalizations1!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations2)
            {
                appClipAdvancedExperienceLocalizations2?.Invoke(AppClipAdvancedExperienceLocalizations2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceImage>? appClipAdvancedExperienceImages = null,
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceLocalization>? appClipAdvancedExperienceLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.AppClip>? appClipAdvancedExperienceLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipAdvancedExperienceImages)
            {
                appClipAdvancedExperienceImages?.Invoke(AppClipAdvancedExperienceImages!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations1)
            {
                appClipAdvancedExperienceLocalizations1?.Invoke(AppClipAdvancedExperienceLocalizations1!);
            }
            else if (IsAppClipAdvancedExperienceLocalizations2)
            {
                appClipAdvancedExperienceLocalizations2?.Invoke(AppClipAdvancedExperienceLocalizations2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipAdvancedExperienceImages,
                typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage),
                AppClipAdvancedExperienceLocalizations1,
                typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization),
                AppClipAdvancedExperienceLocalizations2,
                typeof(global::AppStoreConnect.AppClip),
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
        public bool Equals(IncludedItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipAdvancedExperienceImage?>.Default.Equals(AppClipAdvancedExperienceImages, other.AppClipAdvancedExperienceImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipAdvancedExperienceLocalization?>.Default.Equals(AppClipAdvancedExperienceLocalizations1, other.AppClipAdvancedExperienceLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClip?>.Default.Equals(AppClipAdvancedExperienceLocalizations2, other.AppClipAdvancedExperienceLocalizations2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem4 obj1, IncludedItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem4 obj1, IncludedItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem4 o && Equals(o);
        }
    }
}
