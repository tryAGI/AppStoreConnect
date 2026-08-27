#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem6 : global::System.IEquatable<IncludedItem6>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperienceLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences { get; init; }
#else
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences))]
#endif
        public bool IsAppClipDefaultExperiences => AppClipDefaultExperiences != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipDefaultExperiences(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            value = AppClipDefaultExperiences;
            return IsAppClipDefaultExperiences;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperience PickAppClipDefaultExperiences() => IsAppClipDefaultExperiences
            ? AppClipDefaultExperiences!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipHeaderImage? AppClipHeaderImages { get; init; }
#else
        public global::AppStoreConnect.AppClipHeaderImage? AppClipHeaderImages { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipHeaderImages))]
#endif
        public bool IsAppClipHeaderImages => AppClipHeaderImages != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppClipHeaderImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipHeaderImage? value)
        {
            value = AppClipHeaderImages;
            return IsAppClipHeaderImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppClipHeaderImage PickAppClipHeaderImages() => IsAppClipHeaderImages
            ? AppClipHeaderImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipHeaderImages' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem6(global::AppStoreConnect.AppClipDefaultExperience value) => new IncludedItem6((global::AppStoreConnect.AppClipDefaultExperience?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipDefaultExperience?(IncludedItem6 @this) => @this.AppClipDefaultExperiences;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem6(global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            AppClipDefaultExperiences = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem6 FromAppClipDefaultExperiences(global::AppStoreConnect.AppClipDefaultExperience? value) => new IncludedItem6(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem6(global::AppStoreConnect.AppClipHeaderImage value) => new IncludedItem6((global::AppStoreConnect.AppClipHeaderImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipHeaderImage?(IncludedItem6 @this) => @this.AppClipHeaderImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem6(global::AppStoreConnect.AppClipHeaderImage? value)
        {
            AppClipHeaderImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem6 FromAppClipHeaderImages(global::AppStoreConnect.AppClipHeaderImage? value) => new IncludedItem6(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem6(
            global::AppStoreConnect.AppClipDefaultExperienceLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipDefaultExperience? appClipDefaultExperiences,
            global::AppStoreConnect.AppClipHeaderImage? appClipHeaderImages
            )
        {
            Type = type;

            AppClipDefaultExperiences = appClipDefaultExperiences;
            AppClipHeaderImages = appClipHeaderImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppClipHeaderImages as object ??
            AppClipDefaultExperiences as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppClipDefaultExperiences?.ToString() ??
            AppClipHeaderImages?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppClipDefaultExperiences && !IsAppClipHeaderImages || !IsAppClipDefaultExperiences && IsAppClipHeaderImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipDefaultExperience, TResult>? appClipDefaultExperiences = null,
            global::System.Func<global::AppStoreConnect.AppClipHeaderImage, TResult>? appClipHeaderImages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences && appClipDefaultExperiences != null)
            {
                return appClipDefaultExperiences(AppClipDefaultExperiences!);
            }
            else if (IsAppClipHeaderImages && appClipHeaderImages != null)
            {
                return appClipHeaderImages(AppClipHeaderImages!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences = null,

            global::System.Action<global::AppStoreConnect.AppClipHeaderImage>? appClipHeaderImages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences)
            {
                appClipDefaultExperiences?.Invoke(AppClipDefaultExperiences!);
            }
            else if (IsAppClipHeaderImages)
            {
                appClipHeaderImages?.Invoke(AppClipHeaderImages!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences = null,
            global::System.Action<global::AppStoreConnect.AppClipHeaderImage>? appClipHeaderImages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppClipDefaultExperiences)
            {
                appClipDefaultExperiences?.Invoke(AppClipDefaultExperiences!);
            }
            else if (IsAppClipHeaderImages)
            {
                appClipHeaderImages?.Invoke(AppClipHeaderImages!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipDefaultExperiences,
                typeof(global::AppStoreConnect.AppClipDefaultExperience),
                AppClipHeaderImages,
                typeof(global::AppStoreConnect.AppClipHeaderImage),
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
        public bool Equals(IncludedItem6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipDefaultExperience?>.Default.Equals(AppClipDefaultExperiences, other.AppClipDefaultExperiences) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipHeaderImage?>.Default.Equals(AppClipHeaderImages, other.AppClipHeaderImages) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem6 obj1, IncludedItem6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem6 obj1, IncludedItem6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem6 o && Equals(o);
        }
    }
}
