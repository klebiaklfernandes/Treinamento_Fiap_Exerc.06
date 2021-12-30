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


            //Declarando as vari�veis
            double n1, n2, n3, media;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);

            //C�lculo
            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {

                MessageBox.Show($"Parab�ns voc� est� aprovado! sua m�dia �: {media.ToString("0.00")}", 
                    "Parab�ns!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               


            }
            else if (media < 7 && media >= 4)
            {
                MessageBox.Show($"voc� est� na prova final! sua m�dia �: {media.ToString("0.00")}",
                    "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                MessageBox.Show($"Infelizmente voc� foi reprovado! sua m�dia �: {media.ToString("0.00")}",
                    "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}