using System.IO;
using System.Net;

namespace csxto.Model
{
    class JsonDownloader
    {
        internal static string GetJson(string id, string company)
        {
            string rawJson = null;
            var url = "http://www.kuaidi100.com/query?type=" + company + "&postid=" + id;
            var httpWReq = (HttpWebRequest)WebRequest.Create(url);
            var httpWResp = (HttpWebResponse)httpWReq.GetResponse();
            var rawStream = httpWResp.GetResponseStream();
            if (rawStream != null)
            {
                var reader = new StreamReader(rawStream);
                rawJson = reader.ReadToEnd();
            }
            httpWResp.Close();
            return rawJson;
        }
    }
}
