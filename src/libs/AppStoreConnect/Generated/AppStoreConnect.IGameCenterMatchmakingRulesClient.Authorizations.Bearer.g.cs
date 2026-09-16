
#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterMatchmakingRulesClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}