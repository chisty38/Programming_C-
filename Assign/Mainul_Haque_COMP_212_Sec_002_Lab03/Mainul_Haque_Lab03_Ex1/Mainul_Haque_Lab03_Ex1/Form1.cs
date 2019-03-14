using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainul_Haque_Lab03_Ex1
{
    public partial class Form1 : Form
    {
        public delegate bool IfEven(int v);

        public delegate bool IfOdd(int v);
        public Form1()
        {
            InitializeComponent();
        }
 
        // question (b)
       //calculate Factorial
        public long longFactorial(long num)
        {
            long result = 1;
            if (num < 0)
            {
                throw new Exception("number must be > or = to 0");
            }
            else if (num == 0 )
            {
                return result = 1;
            }
            else
            {
                while (num != 1)
                {
                    result = result * num;
                    num = num - 1;
                }
                return result;
            }
        }

        //button click even handler for factorial
        private async void FactorialButton_Click_1(object sender, EventArgs e)
        {
            // retrieve user's input as an integer
            int n = int.Parse(factorialInput.Text);

            facResult.Text = "Calculating...";
            // Task to perform Fibonacci calculation in separate thread
            Task<long> facTask = Task.Run(() => longFactorial(n));
            // wait for Task in separate thread to complete
            await facTask;
            // display result after Task in separate thread completes
            facResult.Text = facTask.Result.ToString();
        }

        // question (c)
        //button click even handler for odd and even
        private void oddButton_Click(object sender, EventArgs e)
        {
            // parse value to int from text box text
            int n = int.Parse(oddInput.Text);

            IfEven isEven = IsEven;

            IfOdd isOdd = IsOdd;

            // check condition to find even or odd
            if (n <= 0)
            {
                throw new Exception("number must be >  0");
            }
            else
            {
                if (isEven(n) == true)
                {
                    oddResult.Text = "Even";
                }
                else
                {
                    oddResult.Text = "Odd";
                }
            }


        }

        //bool method even number
        public bool IsEven(int n) => n % 2 == 0;

        //bool method odd number
        public bool IsOdd(int n) => n % 2 != 0;

        //Display list and search -- (d)
        //// question (d-i)

        //declare and initial array
        int[] intArray =  new int[10];
        double[] doubleArray =  new double[10];
        char[] charArray = new char[10];


        // use rendom class to generate number
        Random r = new Random();

        //button click event handler to generate int, double, char values
        private void buttonValue_Click(object sender, EventArgs e)
        {
            showIndex.Clear();
            indexLowText.Clear();
            indexHighText.Clear();
            searchBox1.Clear();
            //method for radio button check
            if (radioInt.Checked)
            {
                listValues.Items.Clear();
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = r.Next(10, 99);
                }
                //set value for list box control
                foreach (var item in intArray)
                {
                    listValues.Items.Add(item);
                }
            }
            if (radioDouble.Checked)
            {
                listValues.Items.Clear();
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Math.Round(10 + (r.NextDouble() * (99 - 10)), 2);
                }
                //set value for list box control
                foreach (var item in doubleArray)
                {
                    listValues.Items.Add(item);
                }
            }
            if (radioChar.Checked)
            {
                listValues.Items.Clear();
                for (int i = 0; i < charArray.Length; i++)
                {
                    //charArray[i] = (char) ('A' + r.Next(10, 99));
                    charArray[i] = (char)r.Next(10, 99);
                }
                //set value for list box control
                foreach (var item in charArray)
                {
                    listValues.Items.Add(item);
                }
            }
        }

        // search data - (d)--ii

            //method for search data from list box
        private static bool SearchData<T1, T2>(T1[] inputArray, T2 num) => Array.IndexOf(inputArray, num) >= 0 ? true : false;

        //event handler for search data
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showIndex.Clear();
            indexLowText.Clear();
            indexHighText.Clear();
            //event handler for radio button
            if (radioInt.Checked)
            {
                int n = int.Parse(searchBox1.Text);
                bool a = SearchData(intArray, n);
                MessageBox.Show(a.ToString());
            }
            if (radioDouble.Checked)
            {
                double d = double.Parse(searchBox1.Text);
                bool b = SearchData(doubleArray, d);
                MessageBox.Show(b.ToString());
            }
            if (radioChar.Checked)
            {
                char c = char.Parse(searchBox1.Text);
                bool t = SearchData(charArray, c);
                MessageBox.Show(t.ToString());
            }
        }
        //display low index and high index -- d(iii)
        
            //method for display high and low index value
        private void PrintData<T>(T[] inputArray, int low, int high)
        {
            if (low < 0 || high > 10)
            {
                throw new ArgumentException(String.Format("out of range exception"));
            }
            else
            {
                for (int i = low; i <= high; i++)
                {
                    showIndex.Text += inputArray[i] + ", ";
                }
            }
        }

        //event handler for high and low index button
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            showIndex.Clear();
            
            searchBox1.Clear();
            int low = int.Parse(indexLowText.Text);
            int high = int.Parse(indexHighText.Text);
            if (radioInt.Checked)
            {
                PrintData(intArray, low , high);
            }
            if (radioDouble.Checked)
            {
                PrintData(doubleArray, low, high);
            }
            if (radioChar.Checked)
            {
                PrintData(charArray, low, high);
            }
            
        }

       
    }
}
