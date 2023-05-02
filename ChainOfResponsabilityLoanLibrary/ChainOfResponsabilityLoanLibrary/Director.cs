namespace ChainOfResponsabilityLoanLibrary
{
    public class Director : Approver
    {
        public override (bool,string) ProcessRequest(Loan loan)
        {
            if (loan.Amount < 10000)
                return (true, $"Director approved {loan.GetDescription()}");
            if (_successor != null)
                return _successor.ProcessRequest(loan);
            return (false, "Rejected");
        }
    }
}
