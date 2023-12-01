using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Data.Provider.MongoDB.Collections
{
    [BsonCollection("Carta")]
    public class CartaCollection : Document
    {
        public Guid CodeID { get; set; }
        public string ToName { get; set; }
        public string Content { get; set; }
        public bool Enviar { get; set; }
    }
}
