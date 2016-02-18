using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Product_Service_Project
{
    [DataContract]
    public class Book : Product
    {
        private string authorName;


        [DataMember]
        public string AuthorName
        {
            get
            {
                return authorName;
            }

            set
            {
                authorName = value;
            }
        }
    }
}
