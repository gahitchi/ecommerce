using ramansanzon;

namespace ecommerce
{
    public partial class Form1 : Form
    {

        private Cart cart = new("carelopisnelo");
        private Product p1 = new("", "buzz lightyear", "purplepazzo", 104.27);

        public Form1()
        {
            InitializeComponent();
            Controls.Add(listed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart.addProd(p1);
            listed.Items.Add(p1.Name);
            //totalPrice.Text = ((int)totalPrice.Text += p1.Prezzo);
        }

        private void empty_Click(object sender, EventArgs e)
        {
            cart.emptyCart();
            listed.Items.Clear();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            cart.removeProd(p1);
            listed.Items.Remove(listed.SelectedItem);
        }
    }
}
