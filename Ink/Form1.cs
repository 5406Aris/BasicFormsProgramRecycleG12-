namespace Ink
{
    public partial class Form1 : Form
    {

        int[] Cartridges = new int[5]{0, 0, 0, 0, 0};
        int highest = 0, lowest = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Cartridges[0] = int.Parse(textBox1.Text);
            Cartridges[1] = int.Parse(textBox2.Text);
            Cartridges[2] = int.Parse(textBox3.Text);
            Cartridges[3] = int.Parse(textBox4.Text);
            Cartridges[4] = int.Parse(textBox5.Text);

            Array.Sort(Cartridges);

            textBox6.Text = Cartridges[0].ToString();
            textBox7.Text = Cartridges[4].ToString();

        }
    }
}
