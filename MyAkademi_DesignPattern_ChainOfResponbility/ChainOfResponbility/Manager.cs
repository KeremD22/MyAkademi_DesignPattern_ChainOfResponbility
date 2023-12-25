using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Context;
using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Entities;
using MyAkademi_DesignPattern_ChainOfResponbility.Models;

namespace MyAkademi_DesignPattern_ChainOfResponbility.ChainOfResponbility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 280000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Kerem Aslan";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Kerem Aslan";
                customerProcess.Description = "Müşterinin talep ettiği tutar tarafımca ödenemediği için işlem bölge müdürüne aktarılmıştır.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);

            }
        }
    }
}