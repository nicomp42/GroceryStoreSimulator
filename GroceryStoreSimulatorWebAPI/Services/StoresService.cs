using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class StoresService
    {
        public StoresService()
        {
           

        }
        public List<Store> GetStores()
        {
            return new List<Store>()
                {
                    new Store(){ Name = "Meijer", Address = "888 Eastgate North Drive", Id = 2},
                    new Store(){ Name = "Kroger", Address= "1234 Beechmond Ave", Id=3},
                    new Store(){ Name = "Walmart", Address="7872 Walmart Ln.", Id=4 }
                };
        }
    }
}
