namespace ifTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.textBoxKop.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mon;
            try
            {
                mon = int.Parse(textBox1.Text);
            } catch (FormatException)
            {
                return;
            }
            Properties.Settings.Default.textBoxKop = mon;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.solver(mon));
        }
    }
    public class Logic
    {
        public static string solver(int n)
        {
            if (n >= 1 && n <= 9999)
            {
                return $"{n / 100} ������, {n % 100} ������";
            }
            else
            {
                return "������������ �������� n";
            }

        }
    }
}
