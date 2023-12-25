using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Entities;
using MyAkademi_DesignPattern_ChainOfResponbility.Models;

namespace MyAkademi_DesignPattern_ChainOfResponbility.ChainOfResponbility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
