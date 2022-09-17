namespace Major_and_minor
{
    public partial class ExerciseMajorAndMinor : Form
    {
        public ExerciseMajorAndMinor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string txtNumber1 = textBox1.Text;
            int numero1 = Int32.Parse(txtNumber1);
            */
            int numero1 = Int32.Parse(textBox1.Text);
            int numero2 = Int32.Parse(textBox2.Text);
            int numero3 = Int32.Parse(textBox3.Text);

            int mayor = numero1;

            if(numero2 > mayor)
            {
                mayor = numero2;
            }

            if(numero3 > mayor)
            {
                mayor = numero3;
            }

            //Now we have the logic but we need to show the message
            MessageBox.Show("The number major is: " + mayor);


            //Number minor
            int minor = numero1;

            if(numero2 < minor)
            {
                minor = numero2;
            }

            if(numero3 < minor)
            {
                minor = numero3;
            }

            MessageBox.Show("The minor number is: " + minor);
        }
    }
}