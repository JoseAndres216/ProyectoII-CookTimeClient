using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyEnterprisesRecomendationsVM
    {

        private SimpleList<Enterprise> myEnterprisesrecomendations { get; set; }
        public ObservableCollection<Enterprise> myEnterpriserecomendationsIL;
        

        public MyEnterprisesRecomendationsVM()
        {
            myEnterprisesrecomendations = new SimpleList<Enterprise>();
            myEnterprisesrecomendations.setHead(new Node<Enterprise>());
            myEnterprisesrecomendations.getHead().setData(new Enterprise("email", "EnterpriseRecomendada", "pass"));
        }

        public SimpleList<Enterprise> getMyenterpriseRecomendations()
        {
            return this.myEnterprisesrecomendations;
        }

        public async void getMyenterpriseRecomendationsFS()
        {
            this.myEnterpriserecomendationsIL = new ObservableCollection<Enterprise>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/enterprises/suggest/ranked");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            myEnterprisesrecomendations = JsonConvert.DeserializeObject<SimpleList<Enterprise>>(json);
            Node<Enterprise> current = this.myEnterprisesrecomendations.getHead();
            while (current != null)
            {
                myEnterpriserecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
        }

        public ObservableCollection<Enterprise> getMyenterpriseRecomendationsIL()
        {
            this.getMyenterpriseRecomendationsFS();
            return this.myEnterpriserecomendationsIL;
        }
    }
}
