using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Context;
using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Entities;
using MyAkademi_DesignPattern_ChainOfResponbility.Models;

namespace MyAkademi_DesignPattern_ChainOfResponbility.ChainOfResponbility
{
    public class AreaDirector:Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Mehmet Aslan";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdür  - Mehmet Aslan";
                customerProcess.Description = "Müşterinin talep ettiği tutar bankanın günlük ödeme limitlerini aştığı için işlem gerçekleştirilemedi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
             

            }
        }
    }
}
