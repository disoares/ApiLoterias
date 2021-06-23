using System;
using System.IO;

namespace ApiLoterias.Models
{
    public class ReadFile
    {

        public static string ReadJsonFile(string game)
        {
            string json = "";
            try
            {
                Config config = new Config();
                json = File.ReadAllText(config.getPath().Replace("*game*", game));

            }catch(Exception e)
            {
                json = @"{ ""status"" : ""error"", ""message"" : """ + e.Message + @""" }";
            }
            return json;
        }

    }
}
