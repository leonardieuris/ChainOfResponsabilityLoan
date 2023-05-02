namespace ChainOfResponsabilityLoanLibrary
{
    public abstract class Approver
    {
        protected Approver _successor;

        public void SetSuccessor(Approver successor)
        {
            _successor  = successor;
        }

        public abstract (bool,string) ProcessRequest(Loan loan);
    }
}