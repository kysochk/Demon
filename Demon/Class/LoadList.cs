using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    public class LoadList
    {
        public List<Service> service;
        public List<Client> clients;
        public LoadList()
        {
            service = skidka(); //вызывает метод подсчета скидки и формирования листа на вывод
            clients = BaseConnect.BaseModel.Client.ToList(); //заполняем лист клиентами
        }
        List<Service> skidka()
        {
            service = BaseConnect.BaseModel.Service.ToList();
            foreach (Service s in service)
            {
                s.newcost = s.Cost;
                if (s.Discount > 0)
                {
                    s.Visible = "Visible";
                    s.VisibleD = "Visible";
                    s.Decor = "Strikethrough";
                    s.green = "LightGreen";
                    s.newcost = Convert.ToDecimal(Convert.ToDouble(s.Cost) - Convert.ToDouble(s.Cost) * s.Discount);

                }
                else
                {
                    s.green = "none";
                    s.Visible = "Collapsed";
                    s.VisibleD = "Hidden";
                }
            }
            return service;
        }
    }
}
