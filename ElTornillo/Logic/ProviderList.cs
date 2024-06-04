using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProviderList
    {
        private List<Provider> providerList;

        public ProviderList()
        {
            providerList = new List<Provider>();
        }

        public void AddProvider(Provider provider)
        {
            providerList.Add(provider);
        }

        public void RemoveProvider(Provider provider)
        {
            providerList.Remove(provider);
        }

        public List<Provider> GetProviderList()
        {
            return providerList;
        }

        public Provider GetProviderById(int id)
        {
            return providerList.Find(p => p.Id == id);
        }

        public void ModifyProvider(Provider provider)
        {
            int index = providerList.FindIndex(p => p.Id == provider.Id);
            if (index >= 0)
            {
                providerList[index] = provider;
            }
        }

        public StringBuilder GetProviders()
        {
            StringBuilder providers = new StringBuilder();
            foreach (Provider p in providerList)
                providers.Append($"[{p.ToString()}]\n");
            return providers;
        }
    }
}
