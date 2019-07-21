using System.Net.Http;
using System.Threading.Tasks;

namespace MyClient.Services
{
    public interface IImageGalleryHttpClient
    {
        Task<HttpClient> GetClient();
    }
}
