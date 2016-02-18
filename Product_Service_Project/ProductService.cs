using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Product_Service_Project
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {

        public Product GetProduct(int productID)
        {
            Product prodObjToReturn = null;

            string connString = ConfigurationManager.ConnectionStrings["CS1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                string selectCmd = "SELECT * FROM Product WHERE Id=@productID";
                SqlCommand cmd = new SqlCommand(selectCmd, con);
                cmd.CommandType = CommandType.Text;

                SqlParameter parameterID = new SqlParameter();
                parameterID.ParameterName = "@productID";
                parameterID.Value = productID;
                cmd.Parameters.Add(parameterID);
                con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //if ((Product.ProductType)reader["productype"] == Product.ProductType.Book)
                            if (Convert.ToInt32(reader["productype"]) == 1)
                            {
                                prodObjToReturn = new Book()
                                {

                                    Id = Convert.ToInt32(reader["Id"]),
                                    Title = reader["producttitle"].ToString(),
                                    Price = Convert.ToDecimal(reader["price"]),
                                    Description = reader["description"].ToString(),
                                    AuthorName = reader["authorname"].ToString(),
                                    Type = Product.ProductType.Book
                                };
                            }
                            else
                            {
                                prodObjToReturn = new CD()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Title = reader["producttitle"].ToString(),
                                    Price = Convert.ToDecimal(reader["price"]),
                                    Description = reader["description"].ToString(),
                                    ArtistName = reader["artistname"].ToString(),
                                    NumberOfTracks = Convert.ToInt32(reader["numberoftracks"]),
                                    Type = Product.ProductType.CD
                                };
                            }
                        }


                    }
                    return prodObjToReturn;
                }
            
              

        }

    }
}
