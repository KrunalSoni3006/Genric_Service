using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Genric_Service
{
    /// <summary>
    /// Summary description for Genric_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Genric_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            IDatabaseHandler handler = new DatabaseHandler();
            dynamic test = "";
            List<Company> comp = handler.GetData<Company>();

            return "Hello World";
        }
    }
}
