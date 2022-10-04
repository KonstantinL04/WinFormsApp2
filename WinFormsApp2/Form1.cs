namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double circleRadius, squareRadius;
            try
            {
                circleRadius = double.Parse(this.txtAreaOfCircle.Text);
                squareRadius = double.Parse(this.txtAreaOfSquare.Text);
            }
            catch (FormatException)
            {
                return;
            }
            MessageBox.Show(Logic.Compare(circleRadius, circleRadius));
        }
    }
    public class Logic
    {
        public static string Compare(double circleRadius, double squareSide)
        {
            string result = "";
            if ((circleRadius >= 0) || (squareSide >= 0))
            {
                double areaOfCircle = Math.PI * Math.Pow(circleRadius, 2);
                double areaOfSquare = Math.Pow(squareSide, 2);
                if (areaOfCircle > areaOfSquare)
                {
                    result = "������� ����� ������";
                }
                else if (areaOfCircle < areaOfSquare)
                {
                    result = "������� �������� ������";
                }
                else
                {
                    result = "������� �����";
                }
            }
            else result = "������������� ������.\n\n��������� ����.";
            return result;
        }
    }
}