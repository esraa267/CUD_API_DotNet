using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public class clientServise
    {
        static List<clients> clientsList { get; }
        static clientServise()
        {
            clientsList = new List<clients>()
            {
                new clients { Id=1,
                              Name = "esraa",Place="cairo"},
                new clients{  Id=2, Name ="mohammad",Place="Alex"}
            };
        }
   
    public static List<clients> GetAll()=>clientsList;
    public static clients GetById(int id)
        {
            var res = clientsList.Find(h => h.Id == id);

            if (res != null)
            {
                return res;
            }
            return null;
        }

    public static clients Add(clients data)
        {
            data.Id = clientsList.Count+1;
            clientsList.Add(data);
            return data;
        }
     public static clients Update(clients data)
        {
            var res = clientsList.Find(h => h.Id == data.Id);
            if (res != null)
            {
                res.Name = data.Name;
                res.Place = data.Place;
                return res;
            }
         
            return null;
        }
      public static List<clients> Delete(int id)
        {
            var res = clientsList.Find(h => h.Id == id);
            if (res != null)
            {
               clientsList.Remove(res);
                return clientsList;
            }
            return null;
        }
    }
}
