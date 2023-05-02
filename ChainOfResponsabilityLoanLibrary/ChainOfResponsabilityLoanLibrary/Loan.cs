namespace ChainOfResponsabilityLoanLibrary
{
    public class Loan
    {
        private readonly int _idLoan;
        private double _amount;
        private readonly string _purpose;

        public int IdLoan => _idLoan;
        public double Amount => _amount;
        public string Purpose => _purpose;

        public Loan(int idLoan, double amount, string purpose)
        {
                _idLoan = idLoan;
                _amount = amount;
                _purpose = purpose;
        }

        public string GetDescription() => $"LoanId: {_idLoan}, {Amount} Euro, about: {_purpose}";

    }
}
