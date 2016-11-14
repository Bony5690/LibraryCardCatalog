using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    [DataContract]
    class CardCatalog
    {
        [DataMember]
        public List<Book> BookListHolder = new List<Book>();

        [DataMember]
        public string filename;

        //  private Book books;

        public void CatalogMenu()
        {

        }

    }
}
