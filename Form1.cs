namespace ifTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class Logic
    {
        public static string solver(int n)
        {
            if (n >= 1 && n <= 9999)
            {
                return $"{n / 100} рублей, {n % 100} копеек";
            }
            else
            {
                return "Ќедопустимое значение n";
            }

        }
    }
}
