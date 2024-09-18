namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //store some values in ram as feilds for my app
        //store a variable to accumulate the cost
        decimal total = 0;
        //decimal for tax
        decimal tax = 0;
        //Another one for tip amount (15%)
        decimal tipPercent = 0.15m;
        //grand total
        decimal grandtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUber_Click(object sender, EventArgs e)
        {
            //take the toal value existing form ram
            //add 20 to it
            total = total + 20.50m;
            //ad the item to my receipt
            lstReciept.Items.Add("You Purchased Uber for $20.50");
            //display the total in the lbl text prop.
            lblTotal.Text = "$" + total;
            //try and set the value of tax to the value of 
            //total multiplied by 0.05
            tax = total * 0.05m;
            //display in the vorresponding lable
            lblTotalwTax.Text = (total + tax).ToString("C");
            //calculate the tip amount by itself and show it in the label
            //do you calculate the tip after tax, or before tax?
            decimal tipamount = total * tipPercent;
            lblTip.Text = tipamount.ToString("C");
            grandtotal = total + tipamount + tax;
           this.Text = grandtotal.ToString("C");
        }
    }
}
