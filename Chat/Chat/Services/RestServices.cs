using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Chat.Helpers;

namespace Chat.Services
{
    public class RestServices
    {
        private static string urlBase = AppConfig.urlBase;

        //Exemplo GET
        public static async Task<string> Get(string login, string senha)
        {
            try
            {
                string uri = urlBase + "Login/Login?login=" + login + "&senha=" + senha;
                var resp = await HttpUtil.GetAsync(uri);

                if (resp.IsSuccessStatusCode)
                {
                    var resppost = await resp.Content.ReadAsStringAsync();
                    return resppost;
                }
                else return "Servidor não encontrado";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Falha no processamento e/ou no post");
                return "Servidor não encontrado";
            }
        }

        //Exemplo POST
        public static async Task<bool> Post()
        {
            try
            {
                string url = urlBase + "comentario/Publicar";

                var postExemplo = new
                {
                    id_livro = "67",
                    cpf_usuario = "08349582395923",
                    dtaPubli = DateTime.Now,
                    texto = "exemplo msg"
                };

                HttpResponseMessage response = await HttpUtil.PostAsync(url, postExemplo);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Falha no processamento e/ou no post " + ex.Message);
                return false;
            }
        }
    }
}
