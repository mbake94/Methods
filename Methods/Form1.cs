using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Methods
{
	public partial class Form1 : Form
	{
		List<int> divisible = new List<int>();
		List<int> factors = new List<int>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnProcessNumber_Click(object sender, EventArgs e)
		{
			int myNum = int.Parse(txtInput.Text);
			/*1. Wtite a subprocedure named ShowDivisots that recives myNum as an argument
			 * and displays all the numbers that is evenly divisible by in the lstDivisor
			 * lostbos.
			 * 2. Write a function named IsPrime that reveives myNum as an argument and 
			 * returns a string og "yes" or "no" depending on whther myNum is a Prime
			 * number or not. The calling statement here assigns the return string to the
			 * text of the lblPrime label.
			 * 
			 * 3. Write a statement that calls a funcition named PrimeFactors which is 
			 * passed the inputted intger (myNum) and retuens a string showing the prime
			 * factors that make up the number. 
			 * EG if 120 was the inputted number returned the string would be:
			 * "120! - 1 x 2 x 2 x 2 x 3 x 5
			 * NOTE - There should only be three lines of excue statements here in addition 
			 * to the myNum edclaration. All calculations are performed in the functions.
			 */
		    listBox1.Items.Clear();
			divisible.Clear();
			factors.Clear();
			prime(myNum);
			divisibleList();
			if (factors.Contains(myNum))
			{
				lblPrime.Text = "Yes";
			}
			else
			{
				lblPrime.Text = "No";
			}
			foreach (int i in divisible)
			{
				listBox1.Items.Add(i);
			}
			string tempPrime = "";
			string tempFormat = "";
		    for (int i = factors.Count; i > 0; i--)
			{
				tempFormat = factors[i-1] + " ";
				tempPrime += tempFormat;
			}


			lblFactors.Text = tempPrime;


		}

		public void prime(int myNum)
		{


			for (int i = myNum; i > 0; i--)
			{
				if (myNum % i == 0)
				{
					divisible.Add(i);
				}

			}
		}

		public void divisibleList()
		{
				foreach (int i in divisible)
				{
					findPrime(i);
				}
		
		}

		public void findPrime(int num)
		{

			int num1 = num;

			//Console.WriteLine("Accept number:");
			//num1 = Convert.ToInt32(Console.ReadLine());
			if (num1 == 0 || num1 == 1)
			{
				Console.WriteLine(num1 + " is not prime number");
				Console.ReadLine();
			}
			else
			{
				for (int a = 2; a <= num1 / 2; a++)
				{
					if (num1 % a == 0)
					{
						Console.WriteLine(num1 + " is not prime number");
						return;
					}

				}
				Console.WriteLine(num1 + " is a prime number");
				factors.Add(num1);
			}
		}
	}
}
