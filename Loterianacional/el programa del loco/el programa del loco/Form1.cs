namespace el_programa_del_loco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public Random q = new Random();
        public int n1, n2, n3,n4,n5;
        public double numero;
        public double dinero;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double dinero1;
        public double dinero2;
        public double dinero3;

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(txtNumero.Text);
            dinero = Convert.ToDouble(txtDinero.Text);

            n1 = q.Next(0,99);
            n2 = q.Next(0,99);
            n3 = q.Next(0,99);
            n4 = q.Next(0,99);
            n5 = q.Next(0,99);

            txtn1.Text = n1.ToString();
            txtn2.Text = n2.ToString();
            txtn3.Text = n3.ToString();

            dinero1 = dinero * 20;
            txtPremio1.Text = dinero1.ToString();

            dinero2 = dinero * 10;
            txtPremio2.Text = dinero2.ToString();

            dinero3 = dinero * 5;
            txtPremio3.Text = dinero3.ToString();

            if (numero > 100)
            {
                MessageBox.Show("El numero debe ser entre 0 y 100");
            }
            if (numero == n1)
            {
                MessageBox.Show("Ganaste en priner lugar");
            }
            if (numero == n2)
            {
                MessageBox.Show("Ganaste en segundo lugar");
            }
            if (numero == n3)
            {
                MessageBox.Show("Ganaste en tercer lugar");
            }
            if (numero < 100)
            {
                MessageBox.Show("Vuelve a intentarlo");
            }

        }


    }
}