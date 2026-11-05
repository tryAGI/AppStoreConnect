#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem156 : global::System.IEquatable<IncludedItem156>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionMessageVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacements))]
#endif
        public bool IsAppAssetLibraryPlacements => AppAssetLibraryPlacements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            value = AppAssetLibraryPlacements;
            return IsAppAssetLibraryPlacements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacement PickAppAssetLibraryPlacements() => AppAssetLibraryPlacements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.RetentionMessageLocalization? RetentionMessageLocalizations { get; init; }
#else
        public global::AppStoreConnect.RetentionMessageLocalization? RetentionMessageLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetentionMessageLocalizations))]
#endif
        public bool IsRetentionMessageLocalizations => RetentionMessageLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetentionMessageLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.RetentionMessageLocalization? value)
        {
            value = RetentionMessageLocalizations;
            return IsRetentionMessageLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionMessageLocalization PickRetentionMessageLocalizations() => RetentionMessageLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetentionMessageLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.RetentionMessage? RetentionMessages { get; init; }
#else
        public global::AppStoreConnect.RetentionMessage? RetentionMessages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetentionMessages))]
#endif
        public bool IsRetentionMessages => RetentionMessages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetentionMessages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.RetentionMessage? value)
        {
            value = RetentionMessages;
            return IsRetentionMessages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionMessage PickRetentionMessages() => RetentionMessages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetentionMessages' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppAssetLibraryPlacement value) => new IncludedItem156((global::AppStoreConnect.AppAssetLibraryPlacement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacement?(IncludedItem156 @this) => @this.AppAssetLibraryPlacements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            AppAssetLibraryPlacements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppAssetLibraryPlacements(global::AppStoreConnect.AppAssetLibraryPlacement? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.RetentionMessageLocalization value) => new IncludedItem156((global::AppStoreConnect.RetentionMessageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.RetentionMessageLocalization?(IncludedItem156 @this) => @this.RetentionMessageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.RetentionMessageLocalization? value)
        {
            RetentionMessageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromRetentionMessageLocalizations(global::AppStoreConnect.RetentionMessageLocalization? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.RetentionMessage value) => new IncludedItem156((global::AppStoreConnect.RetentionMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.RetentionMessage?(IncludedItem156 @this) => @this.RetentionMessages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.RetentionMessage? value)
        {
            RetentionMessages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromRetentionMessages(global::AppStoreConnect.RetentionMessage? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(
            global::AppStoreConnect.RetentionMessageVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements,
            global::AppStoreConnect.RetentionMessageLocalization? retentionMessageLocalizations,
            global::AppStoreConnect.RetentionMessage? retentionMessages
            )
        {
            Type = type;

            AppAssetLibraryPlacements = appAssetLibraryPlacements;
            RetentionMessageLocalizations = retentionMessageLocalizations;
            RetentionMessages = retentionMessages;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RetentionMessages as object ??
            RetentionMessageLocalizations as object ??
            AppAssetLibraryPlacements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacements?.ToString() ??
            RetentionMessageLocalizations?.ToString() ??
            RetentionMessages?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacements && !IsRetentionMessageLocalizations && !IsRetentionMessages || !IsAppAssetLibraryPlacements && IsRetentionMessageLocalizations && !IsRetentionMessages || !IsAppAssetLibraryPlacements && !IsRetentionMessageLocalizations && IsRetentionMessages;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacement, TResult>? appAssetLibraryPlacements = null,
            global::System.Func<global::AppStoreConnect.RetentionMessageLocalization, TResult>? retentionMessageLocalizations = null,
            global::System.Func<global::AppStoreConnect.RetentionMessage, TResult>? retentionMessages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0 && appAssetLibraryPlacements != null)
            {
                return appAssetLibraryPlacements(__value0);
            }
            else if (RetentionMessageLocalizations is { } __value1 && retentionMessageLocalizations != null)
            {
                return retentionMessageLocalizations(__value1);
            }
            else if (RetentionMessages is { } __value2 && retentionMessages != null)
            {
                return retentionMessages(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,

            global::System.Action<global::AppStoreConnect.RetentionMessageLocalization>? retentionMessageLocalizations = null,

            global::System.Action<global::AppStoreConnect.RetentionMessage>? retentionMessages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (RetentionMessageLocalizations is { } __value1)
            {
                retentionMessageLocalizations?.Invoke(__value1);
            }
            else if (RetentionMessages is { } __value2)
            {
                retentionMessages?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,
            global::System.Action<global::AppStoreConnect.RetentionMessageLocalization>? retentionMessageLocalizations = null,
            global::System.Action<global::AppStoreConnect.RetentionMessage>? retentionMessages = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (RetentionMessageLocalizations is { } __value1)
            {
                retentionMessageLocalizations?.Invoke(__value1);
            }
            else if (RetentionMessages is { } __value2)
            {
                retentionMessages?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacements,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacement),
                RetentionMessageLocalizations,
                typeof(global::AppStoreConnect.RetentionMessageLocalization),
                RetentionMessages,
                typeof(global::AppStoreConnect.RetentionMessage),
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
        public bool Equals(IncludedItem156 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacement?>.Default.Equals(AppAssetLibraryPlacements, other.AppAssetLibraryPlacements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.RetentionMessageLocalization?>.Default.Equals(RetentionMessageLocalizations, other.RetentionMessageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.RetentionMessage?>.Default.Equals(RetentionMessages, other.RetentionMessages)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem156 obj1, IncludedItem156 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem156>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem156 obj1, IncludedItem156 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem156 o && Equals(o);
        }
    }
}
