using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
	public partial class Form1 : Form
	{
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

		}
	}
}
