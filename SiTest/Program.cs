using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SiTest {
    class Program {
        static List<PropertiesProvider> operators_pool = new List<PropertiesProvider>();
        static void Main(string[] args) {
            operators_pool.Add(new PropertiesProvider("booqween"));
            operators_pool.Add(new PropertiesProvider("tripfortuner"));

            ConcurrentDictionary<string, List<Place>> places = new ConcurrentDictionary<string, List<Place>>();
            
            foreach(PropertiesProvider curroper in operators_pool){
                Task.Run(() => places.TryAdd(curroper.ProviderName, (List<Place>)curroper.SearchByAddress("dream place")));
            }

            int selected_place = 5;
            string selected_oper = "tripfortuner";
            var oper = (from o in operators_pool where o.ProviderName == selected_oper select o).Single();
            oper.BookPlace(places[oper.ProviderName][selected_place].PlaceID);
            oper.CancelPlace(places[oper.ProviderName][selected_place].PlaceID);
        }
    }
}
