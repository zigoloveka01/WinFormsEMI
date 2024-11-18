namespace WinFormsEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);

            double Bmi = 0;
            Bmi = weight / Math.Pow(height, 2);
            string result = "";

            if (Bmi < 18.5)
            {
                result = "underweight(thin)";
            }
            else if (Bmi < 18.5 && Bmi < 24.9)
            {
                result = "normal weight(normal)";
            }
            else if (Bmi < 25 && Bmi < 29.9)
            {
                result = "overweight(fat)";
            }
            else
            {
                result = "obesity(Obesity)";
            }
           label3.Text = "Your Body mass index (BMI) is" + Bmi.ToString("0.00");
           label4.Text = "From your body mass indox, you are" + result;
            

        }
    }
}
