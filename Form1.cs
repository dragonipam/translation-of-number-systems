namespace taskformother
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            int Number = r.Next(1, 999);
            int NS = r.Next(1, 4);
            int AntiNS = r.Next(1, 4);
            while (AntiNS == NS)
            {
                AntiNS = r.Next(1, 4);
            }
            label1.Text = ($"Переведите число {Number} из {NumberOfSystem(NS)}-ой системы счисления " +
                $" в {NumberOfSystem(AntiNS)}-ую систему счисления");
        }
        public static int NumberOfSystem(int NS)
        {
            int outSystem = 0;
            switch (NS)
            {
                case 1:
                    outSystem = 2;
                    break;
                case 2:
                    outSystem = 8;
                    break;
                case 3:
                    outSystem = 10;
                    break;
                default:
                    outSystem = 16;
                    break;
            }
            return outSystem;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}