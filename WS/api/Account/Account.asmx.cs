using System;
using System.Web.Script.Services;
using System.Web.Services;
using WS.Context;
using WS.Models;

namespace WS.api.Account
{
    /// <summary>
    /// Summary description for Account
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Account : WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Add(string nome, string email, string senha, string apelido)
        {
            using (var db = new click_ponto_context())
            {
                var account = new account { nome = nome, email = email, senha = senha, apelido = apelido, ativo = true, data_cadastro = DateTime.Now, resetar_senha = false };
                db.account.Add(account);
                db.SaveChanges();
            }
            return "Hello World";
        }


    }
}
