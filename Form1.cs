namespace Práctica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sue, nsue;                       //Se declaran las variables a usar.
            sue = double.Parse(textBox1.Text);           //Se declara que el sueldo será el que escribamos en la caja 1.
            if (sue < 400000.0) nsue = sue * 1.15;       //Se aplica un condicional que activará una fórmula si se sumple, si no, no lo hará.
            else nsue = sue * 1.08;                      //En el caso de que no se cumpla, se ejecutará esta fórmula.


            textBox2.Text = nsue.ToString();         //Si se cumple o no el condicional, aparecerá el resultado en la caja 2.



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";      //Se declara que al apretar el botón se elimine lo aparecido en caja 1 y 2.
            textBox2.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}