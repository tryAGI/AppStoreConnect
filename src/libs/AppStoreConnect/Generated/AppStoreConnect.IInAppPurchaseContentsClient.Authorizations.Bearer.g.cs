
#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseContentsClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}