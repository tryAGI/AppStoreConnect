
#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionOfferCodeCustomCodesClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}