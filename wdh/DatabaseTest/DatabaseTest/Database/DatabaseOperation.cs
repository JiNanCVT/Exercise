using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using DatabaseTest.Entity;

namespace DatabaseTest.Database
{
   public static class DatabaseOperation
    {
       public static ObservableCollection<Calligraphyer> Load()
       {
           ObservableCollection<Calligraphyer> calligraphyers = new ObservableCollection<Calligraphyer>();

           var cnn = Database.CreateConnection();
           string sql = "select * from DatabaseTable";
           SqlCommand cmmd = new SqlCommand(sql,cnn);
           cnn.Open();
           var reader = cmmd.ExecuteReader();
           while (reader.Read())
           {
               Calligraphyer c = new Calligraphyer((int)reader["ID"], (string)reader["Name"], (string)reader["Description"]);
               calligraphyers.Add(c);
           }
           cnn.Close();
           return calligraphyers;
       }

       public static void Insert(Calligraphyer c)
       {
           var cnn = Database.CreateConnection();
           string sql = @"insert into DatabaseTable
                    (Name,Description) values (@Name,@Description)";
           SqlCommand cmmd = new SqlCommand(sql, cnn);
           cmmd.Parameters.Add(new SqlParameter("Name", c.Name));
           cmmd.Parameters.Add(new SqlParameter("Description", c.Description));
           cnn.Open();
           cmmd.ExecuteNonQuery();
           cnn.Close();
       }

       public static void Update(Calligraphyer c)
       {
           var cnn = Database.CreateConnection();
           string sql=@"update DatabaseTable set Description=@Description where ID=@ID";
           SqlCommand cmmd = new SqlCommand(sql, cnn);
           cmmd.Parameters.Add(new SqlParameter("ID", c.Id));
           //cmmd.Parameters.Add(new SqlParameter("Name", c.Name));
           cmmd.Parameters.Add(new SqlParameter("Description", c.Description));
           cnn.Open();
           cmmd.ExecuteNonQuery();
           cnn.Close();
       }

      

       public static void  Save(ObservableCollection<Calligraphyer> calligraphyers)
       {
           foreach (var c in calligraphyers)
           {
               if (c.Status == EntityBase.Statuses.New)
               {
                   Insert(c);
              
                   c.Status = EntityBase.Statuses.Updated;
               }
               else if (c.Status == EntityBase.Statuses.Edit)
               {
                   Update(c);
                 
                   c.Status = EntityBase.Statuses.Updated;
               }
           }
       }

       public static void Delect(string Name)
       {
           var cnn = Database.CreateConnection();
           string sql = @"delete FROM DatabaseTable where Name=Name";
           SqlCommand cmmd = new SqlCommand(sql, cnn);
           //cmmd.Parameters.Remove(new SqlParameter("ID", c.Id));
           //cmmd.Parameters.Remove(new SqlParameter("Name", Name));
           //cmmd.Parameters.Remove(new SqlParameter("Description", c.Description));
           cnn.Open();
           cmmd.ExecuteNonQuery();
           cnn.Close();
       }
    }
}
