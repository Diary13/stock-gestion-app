using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockGestion.Entities
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Quantite { get; set; }
        public int PrixUnitaire { get; set; }
        public string Fournisseur { get; set; }
        public int IdFour { get; set; }
    }
}
