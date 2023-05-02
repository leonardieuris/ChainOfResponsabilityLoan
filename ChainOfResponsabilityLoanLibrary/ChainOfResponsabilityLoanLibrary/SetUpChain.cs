using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityLoanLibrary
{
    public class SetUpChain
    {
        private readonly Approver _chain;

        public SetUpChain()
        {
            var director = new Director();
            var vicePresident = new VicePresident();
            var president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);
            _chain = director;
        }

        public Approver GetChain => _chain;
    }
}
