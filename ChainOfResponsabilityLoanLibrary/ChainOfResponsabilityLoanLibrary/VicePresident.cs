namespace ChainOfResponsabilityLoanLibrary
{
    public class VicePresident : Approver
    {
        public override (bool,string) ProcessRequest(Loan loan)
        {
            if (loan.Amount < 25000)
                return (true,$"VicePresident approved {loan.GetDescription()}");
            if (_successor != null)
                return _successor.ProcessRequest(loan);
            return (false,"Rejected");
        }
    }
}
