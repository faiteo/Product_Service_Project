using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Product_Service_Project
{

    [KnownType(typeof(CD))]
    [KnownType(typeof(Book))]
    [DataContract]
    public class Product
    {

        private int id;
        private string title;
        private decimal price;
        private string description;


        
        [DataMember]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMember]
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        [DataMember]
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        [DataMember]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [DataMember]
        public ProductType Type
        {
            get;
            set;
        }
     


 
        public enum ProductType
        {
            
            Book = 1,
            CD = 2

        }

    

   
    }




}


    


    