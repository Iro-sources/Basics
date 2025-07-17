namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        //BankAccounts is global variable therefore it should start from a capital letter
        public Form1()
        {
            InitializeComponent();


            //Using the exmplicit defined constructor
            /*BankAccount bankAccount = new BankAccount("Mohamed");
            BankAccount bankAccount2 = new BankAccount("Saldina");
            BankAccount bankAccount3 = new BankAccount("Elon");*/


            //Using the implicit constructor from the Compiler
            /* BankAccount bankAccount = new BankAccount();
             bankAccount.Owner = ("Mohamed");
             bankAccount.AccountNumber = Guid.NewGuid();
             bankAccount.Balance = 266;*/

            /* BankAccount bankAccount2 = new BankAccount();
             bankAccount2.Owner = ("Saldina");
             bankAccount2.AccountNumber = Guid.NewGuid();
             bankAccount2.Balance = 250;

             BankAccount bankAccount3 = new BankAccount();
             bankAccount3.Owner = ("Elon");
             bankAccount3.AccountNumber = Guid.NewGuid();
             bankAccount3.Balance = 1050; */

            //Creating a list of accounts to display on the window
           /* List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);*/

            //Displaying the data source on the window grid
            //BankAccountsGrid.DataSource = bankAccounts;
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            //Preventing the user to register an account without an owner. 
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
            //Emptying the text input field
            OwnerTxt.Text = "";
        }

        //When ever we want to Refresh the Grid we will invoke this method
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
