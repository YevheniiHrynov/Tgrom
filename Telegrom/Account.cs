namespace Telegrom
{
    public class Account
    {
        private string phone;

        public Account(string phone)
        {
            this.phone = phone;
            this.Path = "Accounts/" + phone + ".txt";
        }

        public override string ToString() =>
            this.phone;

        public string Path { get; set; }
    }
}
