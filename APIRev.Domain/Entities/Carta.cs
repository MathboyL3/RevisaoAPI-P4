using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Domain.Entities
{
    public class Carta
    {
        public Carta(string toName, string content, bool enviar)
        {
            ToName = toName;
            Content = content;
            Enviar = enviar;
        }

        public Carta(Guid codeID, string toName, string content, bool enviar)
        {
            CodeID = codeID;
            ToName = toName;
            Content = content;
            Enviar = enviar;
        }

        public Guid CodeID { get; private set; }
        public string ToName { get; private set; }
        public string Content { get; private set; }
        public bool Enviar {  get; private set; }


        public void GenerateID() => CodeID = Guid.NewGuid();
    }
}
