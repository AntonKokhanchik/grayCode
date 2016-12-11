using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grayCode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			try
			{ 
				recursive();
				nonRecursive();
			}
			catch (Exception)
			{
				MessageBox.Show("Неверно заполнено поле");
			}
		}

		private void recursive()
		{
			int n = Int32.Parse(textBoxInput.Text);
			if (n < 2)
				throw new Exception();

			List<StringBuilder> code = new List<StringBuilder>();
			code.Add(new StringBuilder("0"));
			code.Add(new StringBuilder("1"));

			rec(ref code, 2, (int)Math.Pow(2, n));

			textBoxRec.Clear();
			for (int i = 0; i < code.Count; i++)
				textBoxRec.AppendText(code[i] + "\n");
		}

		private void rec(ref List<StringBuilder> code, int length, int n)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				code.Add(new StringBuilder(code[i].ToString() + " 1"));
				code[i].Append(" 0");
			}

			length *= 2;

			if (length != n)
				rec(ref code, length, n);
		}

		private void nonRecursive()
		{
			int n = Int32.Parse(textBoxInput.Text);

			if (n < 2)
				throw new Exception();

			textBoxNonRec.Clear();


			int[] code = new int[n];

			int i = 0; // номер кода
			int p; // наиб. показатель степени 2
			do
			{
				writeCode(code, textBoxNonRec);
				i++;

				p = 0;
				int j = i;	// вспомогательная переменная
				while (j % 2 == 0)
				{
					j /= 2;
					p++;
				}

				if (p < n)
					code[p] = 1 - code[p];
			} while (p < n);
		}

		private void writeCode(int[] code, TextBox outBox)
		{
			for (int i = 0; i < code.Length; i++)
				outBox.AppendText(code[i].ToString() + " ");
			outBox.AppendText("\n");
		}
	}
}
