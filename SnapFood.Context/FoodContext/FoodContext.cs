using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Text.Json;

namespace SnapFood.Context.FoodContext
{
    public class FoodContext
    {

        public FoodContext()
        {
            PathDirectory = System.IO.Directory.GetCurrentDirectory();
            Restaurants = Load<Restaurant>("restaurant");
        }
        public ICollection<User> Users { get; set; } = new Collection<User>();
        public ICollection<Restaurant> Restaurants { get; set; } = new Collection<Restaurant>();
        public ICollection<OrderItem> OrderItems { get; set; } = new Collection<OrderItem>();
        public ICollection<Order> Orders { get; set; } = new Collection<Order>();
        public ICollection<Food> Foods { get; set; } = new Collection<Food>();
        public string PathDirectory { get; set; }



        public void save<T>(ICollection<T> Lst, string FileName)
        {
            FileName = GetFileAddress(FileName);
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            FileInfo fi = new FileInfo(FileName);
            if (fi.Exists)
            {
                fi.Delete();

            }
         
            byte[] utf8byteJson = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(Lst,opt);
            string JsonStr = System.Text.Encoding.UTF8.GetString(utf8byteJson);
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(JsonStr);
            sw.Close();
        }

        private string GetFileAddress(string FileName)
        {
            FileName = PathDirectory + "\\" + FileName.ToLower() + ".json";
            return FileName;
        }

        public void update<T>(ICollection<T> Lst, string FileName)
        {
            FileName = GetFileAddress(FileName);
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            try
            {
                FileInfo fi = new FileInfo(FileName);
                fi.Delete();
            }
            catch (Exception)
            {

            }

            byte[] utf8byteJson =System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(Lst, opt);
            string JsonStr = System.Text.Encoding.UTF8.GetString(utf8byteJson);
            File.WriteAllText(FileName, JsonStr);

        }

        public Collection<T> Load<T>(String FileName)
        {
            FileName = GetFileAddress(FileName);
            if (File.Exists(FileName))
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string json = sr.ReadToEnd();
                    // List<T> Lst = JsonConvert.DeserializeObject<List<T>>(json);
                    Collection<T> Lst = JsonConvert.DeserializeObject<Collection<T>>(json);
                    return Lst;
                }
            }
            return null;
        }
    }
}
