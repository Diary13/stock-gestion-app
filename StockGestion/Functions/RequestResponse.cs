using Newtonsoft.Json.Linq;
using StockGestion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockGestion.Functions
{
    public static class RequestResponse
    {
        public static string GetProduitsFaible()
        {
            var response = Request.Get("http://localhost:8080/api/Produits/ProduitFaible");
            return response;
        }

        public static void PostNouveauCommande(int id, List<KeyValuePair<string, string>> produit)
        {
            var response = Request.Put("http://localhost:8080/api/Produits/"+id, produit);
        }

    }
}
