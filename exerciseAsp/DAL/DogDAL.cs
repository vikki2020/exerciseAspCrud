using exerciseAsp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace exerciseAsp.DAL
{
    public class DogDAL
    {
        //Bring in the db cnstr
        string mainconn = ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString;

        //Create,add new dog to database
        public void CreateDog(DogClass dog)
        {
            using (SqlConnection sqlconn = new SqlConnection(mainconn))
            {
                SqlCommand sqlcomm = new SqlCommand("CreateDog", sqlconn);
                sqlcomm.CommandType = CommandType.StoredProcedure;

                //pass in the dogclass model properties
                sqlcomm.Parameters.AddWithValue("@DogName", dog.Name);
                sqlcomm.Parameters.AddWithValue("@Breed", dog.Breed);
                sqlcomm.Parameters.AddWithValue("@Gender", dog.Gender);
                sqlcomm.Parameters.AddWithValue("@Comment", dog.Comment);

                //open db connection
                sqlconn.Open();
                //Excute or invoke the CreateDog stored procedure
                sqlcomm.ExecuteNonQuery();
                //Close db connection
                sqlconn.Close();



            }
        }


        //Read, Details of a specific dog
        public DogClass ReadOne(int? id)
        { 
            DogClass d = new DogClass();

        using (SqlConnection sqlconn = new SqlConnection(mainconn))
        {
                SqlCommand sqlcomm = new SqlCommand("SP_ReadDog", sqlconn);
                        sqlcomm.CommandType = CommandType.StoredProcedure;

                        //pass in the dogclass model properties
                        sqlcomm.Parameters.AddWithValue("@DogID", id);
                        
                        //open db connection
                        sqlconn.Open();
                SqlDataReader rdr = sqlcomm.ExecuteReader();
                //Excute or invoke the CreateDog stored procedure
                //use while loop

                while (rdr.Read())
                {
                    d.ID = Convert.ToInt32(rdr["DogId"]);
                    d.Name = rdr["DogName"].ToString();
                    d.Breed = rdr["Breed"].ToString();
                    d.Gender = rdr["Gender"].ToString();
                    d.Comment = rdr["Comment"].ToString();
                }
                        //Close db connection
                        sqlconn.Close();

            }
            return d;
      
        }
        //Update or Edit
        public void UpdateDog(DogClass dog)
        {
            using (SqlConnection sqlconn = new SqlConnection(mainconn))
            {
                SqlCommand sqlcomm = new SqlCommand("SP_UpdateDog", sqlconn);
                sqlcomm.CommandType = CommandType.StoredProcedure;

                //pass in the dogclass model properties
                sqlcomm.Parameters.AddWithValue("@DogId", dog.ID);
                sqlcomm.Parameters.AddWithValue("@DogName", dog.Name);
                sqlcomm.Parameters.AddWithValue("@Breed", dog.Breed);
                sqlcomm.Parameters.AddWithValue("@Gender", dog.Gender);
                sqlcomm.Parameters.AddWithValue("@Comment", dog.Comment);

                //open db connection
                sqlconn.Open();
                //Excute or invoke the CreateDog stored procedure
                sqlcomm.ExecuteNonQuery();
                //Close db connection
                sqlconn.Close();



            }
        }
        //Delete
        public void DeleteDog(int? id)
        {
            using (SqlConnection sqlconn = new SqlConnection(mainconn))
            {
                SqlCommand sqlcomm = new SqlCommand("SP_DeleteDog", sqlconn);
                sqlcomm.CommandType = CommandType.StoredProcedure;

                //pass in the dogclass model properties that will be used to locate the dog and then delete it.
                sqlcomm.Parameters.AddWithValue("@DogId", id);
              
                //open db connection
                sqlconn.Open();
                //Excute or invoke the CreateDog stored procedure
                sqlcomm.ExecuteNonQuery();
                //Close db connection
                sqlconn.Close();

            }
        }

        //List
        public List<DogClass>ListDogs()
        {
            List<DogClass> Ldog = new List<DogClass>();

            using (SqlConnection sqlconn = new SqlConnection(mainconn))
            {
                SqlCommand sqlcomm = new SqlCommand("ListDog", sqlconn);
                sqlcomm.CommandType = CommandType.StoredProcedure;

                //open db connection
                sqlconn.Open();
                SqlDataReader rdr = sqlcomm.ExecuteReader();
                //Excute or invoke the CreateDog stored procedure
                //use while loop

                while(rdr.Read())
                {
                    DogClass d = new DogClass();
                    d.ID = Convert.ToInt32(rdr["DogId"]);
                    d.Name = rdr["DogName"].ToString();
                    d.Breed = rdr["Breed"].ToString();
                    d.Gender = rdr["Gender"].ToString();
                    d.Comment = rdr["Comment"].ToString();
                    //populate the Ldog List
                    Ldog.Add(d);

                  
                }
                
                //Close db connection
                sqlconn.Close();

            }
            return Ldog;
        }
           

    }
}