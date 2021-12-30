namespace MediaAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {


            //Declarando as variáveis
            double n1, n2, n3, media;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);

            //Cálculo
            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {

                MessageBox.Show($"Parabéns você está aprovado! sua média é: {media.ToString("0.00")}", 
                    "Parabéns!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               


            }
            else if (media < 7 && media >= 4)
            {
                MessageBox.Show($"você está na prova final! sua média é: {media.ToString("0.00")}",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                MessageBox.Show($"Infelizmente você foi reprovado! sua média é: {media.ToString("0.00")}",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}