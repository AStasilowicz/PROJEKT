using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfel.Class
{
    public class ClassCategory
    {
        //Utworzenie Obiektu Kategoria
        private string id;
        private string userID;
        private string type;

        public ClassCategory(string id, string userID, string type)
        {
            this.id = id;
            this.userID = userID;
            this.type = type;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
