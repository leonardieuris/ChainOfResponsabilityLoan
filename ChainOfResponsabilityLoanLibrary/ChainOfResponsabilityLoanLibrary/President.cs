namespace ChainOfResponsabilityLoanLibrary
{
    public class President : Approver
    {
        public override (bool,string) ProcessRequest(Loan loan)
        {
            if (loan.Amount < 100000)
                return (true, $"President approved {loan.GetDescription()}");
            return (false, "Rejected, this case needs a business meeting");
        }
    }
}
