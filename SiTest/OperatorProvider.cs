using System;
using System.Collections.Generic;
using System.Text;

namespace SiTest {
    class PropertiesProvider : IPropProvider {
        public List<Place> places { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProviderName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PropertiesProvider(string prov_name) {
            ProviderName = prov_name;
        }
        public int BookPlace(int id) {
            throw new NotImplementedException();
        }

        public int CancelPlace(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Place> AllAvailable() {
            throw new NotImplementedException();
        }

        public IEnumerable<Place> SearchByAddress(string address) {
            throw new NotImplementedException();
        }
    }
}
