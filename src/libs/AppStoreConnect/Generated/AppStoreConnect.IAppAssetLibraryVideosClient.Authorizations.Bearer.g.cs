
#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryVideosClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}