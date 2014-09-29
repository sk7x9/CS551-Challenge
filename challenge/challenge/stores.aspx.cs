using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Net;

namespace challenge
{
    public partial class stores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            resultbox.Text = "";
            String data = SearchBox.Text.ToString();
            String StoreRequest = CreateRequest(data);
            XmlDocument StoreResponse = MakeRequest(StoreRequest);

            ProcessResponse(StoreResponse);



        }
        public string CreateRequest(string queryString)
        {
            string UrlRequest = "http://www.supermarketapi.com/api.asmx/ReturnStoresByName?APIKEY=0295cbc332&StoreName=" + queryString;
            return (UrlRequest);


        }
        public XmlDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return (xmlDoc);

            }
            catch (Exception e)
            {
                resultbox.Text = e.Message;
                return null;
            }
        }
        public void ProcessResponse(XmlDocument locationsResponse)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(locationsResponse.NameTable);
            nsmgr.AddNamespace("product", "http://www.SupermarketAPI.com");
            //Get formatted addresses: Option 1
            //Get all locations in the response and then extract the formatted address for each location
            XmlNodeList locationElements = locationsResponse.SelectNodes("//product:Store", nsmgr);

            foreach (XmlNode StoreName in locationElements)
            {
                for (int i = 0; i < StoreName.ChildNodes.Count; i++)
                {
                    
                        resultbox.Text = resultbox.Text + StoreName.ChildNodes[i].Name + ": " + StoreName.ChildNodes[i].InnerText + "<br/>";
                    }
                resultbox.Text = resultbox.Text + "<hr/>";
                }
                
            }
        }
    }
