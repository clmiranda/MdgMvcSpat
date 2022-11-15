using RestSharp;

namespace ModalidadGradoSpat
{
    public class APIConnection
    {
        public static RestClient client = new RestClient("https://localhost:44398/");
    }
}