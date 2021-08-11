using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiTest {
    interface IPropProvider {
        public string ProviderName { get; set; }
        List<Place> places { get; set; }
        IEnumerable<Place> AllAvailable(); // => places;
        IEnumerable<Place> SearchByAddress(string address); // => (from p in places where p.Address == address select p).ToList();
        int BookPlace(int PlaceID);
        int CancelPlace(int PlaceID);
    }
}
