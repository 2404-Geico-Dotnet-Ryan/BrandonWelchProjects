class Account
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public string Type { get; set; }
    //public double Price { get; set; }
    public bool Available { get; set; }

    public Account()
    {

    }

    public Account(int id, decimal balance)
    {
        Id = id;
        Balance = balance;
    }

    //public Account(int id, decimal balance, string type, double price, bool available)
    public Account(int id, decimal balance, string type, bool available)
    {
        Id = id;
        Balance = balance;
        Type = type;
        //Price = price;
        Available = available;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Type: {Type}, Balance: {Balance.ToString("C")}"; //string interpolation to provide Account ID, Account Type and Account Balance to List of Accounts
    }
}