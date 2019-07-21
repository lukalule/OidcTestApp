using System.Net.Http;
using System.Threading.Tasks;

namespace MeinKlient.Services
{
    public interface IImageGalleryHttpClient
    {
        Task<HttpClient> GetClient();
    }
}
