#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem132 : global::System.IEquatable<IncludedItem132>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? GameCenterMatchmakingTestPlayerProperties { get; init; }
#else
        public global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? GameCenterMatchmakingTestPlayerProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterMatchmakingTestPlayerProperties))]
#endif
        public bool IsGameCenterMatchmakingTestPlayerProperties => GameCenterMatchmakingTestPlayerProperties != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterMatchmakingTestPlayerProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? value)
        {
            value = GameCenterMatchmakingTestPlayerProperties;
            return IsGameCenterMatchmakingTestPlayerProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty PickGameCenterMatchmakingTestPlayerProperties() => IsGameCenterMatchmakingTestPlayerProperties
            ? GameCenterMatchmakingTestPlayerProperties!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterMatchmakingTestPlayerProperties' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterMatchmakingTestRequest? GameCenterMatchmakingTestRequests { get; init; }
#else
        public global::AppStoreConnect.GameCenterMatchmakingTestRequest? GameCenterMatchmakingTestRequests { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterMatchmakingTestRequests))]
#endif
        public bool IsGameCenterMatchmakingTestRequests => GameCenterMatchmakingTestRequests != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterMatchmakingTestRequests(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterMatchmakingTestRequest? value)
        {
            value = GameCenterMatchmakingTestRequests;
            return IsGameCenterMatchmakingTestRequests;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterMatchmakingTestRequest PickGameCenterMatchmakingTestRequests() => IsGameCenterMatchmakingTestRequests
            ? GameCenterMatchmakingTestRequests!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterMatchmakingTestRequests' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem132(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty value) => new IncludedItem132((global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty?(IncludedItem132 @this) => @this.GameCenterMatchmakingTestPlayerProperties;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem132(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? value)
        {
            GameCenterMatchmakingTestPlayerProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem132 FromGameCenterMatchmakingTestPlayerProperties(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? value) => new IncludedItem132(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem132(global::AppStoreConnect.GameCenterMatchmakingTestRequest value) => new IncludedItem132((global::AppStoreConnect.GameCenterMatchmakingTestRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterMatchmakingTestRequest?(IncludedItem132 @this) => @this.GameCenterMatchmakingTestRequests;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem132(global::AppStoreConnect.GameCenterMatchmakingTestRequest? value)
        {
            GameCenterMatchmakingTestRequests = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem132 FromGameCenterMatchmakingTestRequests(global::AppStoreConnect.GameCenterMatchmakingTestRequest? value) => new IncludedItem132(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem132(
            global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? gameCenterMatchmakingTestPlayerProperties,
            global::AppStoreConnect.GameCenterMatchmakingTestRequest? gameCenterMatchmakingTestRequests
            )
        {
            Type = type;

            GameCenterMatchmakingTestPlayerProperties = gameCenterMatchmakingTestPlayerProperties;
            GameCenterMatchmakingTestRequests = gameCenterMatchmakingTestRequests;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterMatchmakingTestRequests as object ??
            GameCenterMatchmakingTestPlayerProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterMatchmakingTestPlayerProperties?.ToString() ??
            GameCenterMatchmakingTestRequests?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterMatchmakingTestPlayerProperties && !IsGameCenterMatchmakingTestRequests || !IsGameCenterMatchmakingTestPlayerProperties && IsGameCenterMatchmakingTestRequests;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty, TResult>? gameCenterMatchmakingTestPlayerProperties = null,
            global::System.Func<global::AppStoreConnect.GameCenterMatchmakingTestRequest, TResult>? gameCenterMatchmakingTestRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingTestPlayerProperties && gameCenterMatchmakingTestPlayerProperties != null)
            {
                return gameCenterMatchmakingTestPlayerProperties(GameCenterMatchmakingTestPlayerProperties!);
            }
            else if (IsGameCenterMatchmakingTestRequests && gameCenterMatchmakingTestRequests != null)
            {
                return gameCenterMatchmakingTestRequests(GameCenterMatchmakingTestRequests!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty>? gameCenterMatchmakingTestPlayerProperties = null,

            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTestRequest>? gameCenterMatchmakingTestRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingTestPlayerProperties)
            {
                gameCenterMatchmakingTestPlayerProperties?.Invoke(GameCenterMatchmakingTestPlayerProperties!);
            }
            else if (IsGameCenterMatchmakingTestRequests)
            {
                gameCenterMatchmakingTestRequests?.Invoke(GameCenterMatchmakingTestRequests!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty>? gameCenterMatchmakingTestPlayerProperties = null,
            global::System.Action<global::AppStoreConnect.GameCenterMatchmakingTestRequest>? gameCenterMatchmakingTestRequests = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterMatchmakingTestPlayerProperties)
            {
                gameCenterMatchmakingTestPlayerProperties?.Invoke(GameCenterMatchmakingTestPlayerProperties!);
            }
            else if (IsGameCenterMatchmakingTestRequests)
            {
                gameCenterMatchmakingTestRequests?.Invoke(GameCenterMatchmakingTestRequests!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterMatchmakingTestPlayerProperties,
                typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty),
                GameCenterMatchmakingTestRequests,
                typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest),
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
        public bool Equals(IncludedItem132 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty?>.Default.Equals(GameCenterMatchmakingTestPlayerProperties, other.GameCenterMatchmakingTestPlayerProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterMatchmakingTestRequest?>.Default.Equals(GameCenterMatchmakingTestRequests, other.GameCenterMatchmakingTestRequests) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem132 obj1, IncludedItem132 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem132>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem132 obj1, IncludedItem132 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem132 o && Equals(o);
        }
    }
}
