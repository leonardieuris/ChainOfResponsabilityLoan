using ChainOfResponsabilityLoanLibrary;

var business1 = new Loan(1, 500, "Smartphone");
var business2 = new Loan(2, 20000, "Car");
var business3 = new Loan(3, 80000, "Luxury Car");
var business4 = new Loan(4, 200000, "House");

var approver = new SetUpChain().GetChain;

Console.WriteLine($"case 1: {approver.ProcessRequest(business1)}");
Console.WriteLine($"case 2: {approver.ProcessRequest(business2)}");
Console.WriteLine($"case 3: {approver.ProcessRequest(business3)}");
Console.WriteLine($"case 4: {approver.ProcessRequest(business4)}");

