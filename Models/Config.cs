using System.IO;

namespace ApiLoterias.Models
{
    public class Config
    {

        private string path;

        public Config()
        {
            path = Directory.GetCurrentDirectory() + "\\_LoadResults\\JSON\\*game*.json";
        }

        public string getPath()
        {
            return path;
        }

    }
}
