namespace Tarea_5_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void num2_TextChanged(object sender, EventArgs e)
        {
            Validatetextbox(num1);
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            Validatetextbox(num2);
        }

        private void Validatetextbox(TextBox textbox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, @"^\d*\.?\d*$"))
            {
                MessageBox.Show("Ingrese un numero valido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Text = string.Empty;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text);
            result.ToString();
            Resultados.Items.Add($"{num1.Text} + {num2.Text} = {result}");
        }

        private void substract_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text);
            result.ToString();
            Resultados.Items.Add($"{num1.Text} - {num2.Text} = {result}");
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Resultados.Items.Clear();
            num1.Text = string.Empty;
            num2.Text = string.Empty;
        }
    }
}