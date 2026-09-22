
#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEncryptionDeclarationDocumentsClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}