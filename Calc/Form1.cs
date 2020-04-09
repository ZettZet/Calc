using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calc
{
	public partial class Form1 : Form
	{
		#region Библиотека парсинга
		/// <summary>
		/// Библиотека парсинга выражений
		/// </summary>
		#endregion
		private Pars Pars { get; } = new Pars();
		/// <summary>
		/// Выражение, которое будет расчитано
		/// </summary>
		private string ToComputeExprsion { get; set; } = new string(new char[] { '\0' });

		private Matrix operandA, operandB;


		/// <summary>
		/// Операции, по которым выражение разбивается по частям
		/// </summary>
		public char[] SplitersOperation { get; } = new char[] { '+', '-', '/', '×' };
		/// <summary>
		/// Вообще все доступные бинарные операции
		/// </summary>
		public string AllOperations { get; } = "+-/×^";
		/// <summary>
		/// Состояние ошибки
		/// </summary>
		public bool ErrorState { get; set; } = false;
		/// <summary>
		/// Состояние посчитаного выражения
		/// </summary>
		public bool Evalueted { get; set; } = true;
		/// <summary>
		/// Вычисляет x/100
		/// </summary>
		/// <param name="x">Доля</param>
		/// <returns>Процентный множитель</returns>
		private static double Procent(double x) => x / 100d;
		/// <summary>
		/// Вычисялет обратную величину к х
		/// </summary>
		/// <param name="x">Число</param>
		/// <returns>Обратное число</returns>
		private static double Inverse(double x) => 1d / x;
		/// <summary>
		/// Квадрат числа х
		/// </summary>
		/// <param name="x">Число, которое требуется возвести в квадрат</param>
		/// <returns>Квадрат числа</returns>
		private static double Sqr(double x) => x * x;
		/// <summary>
		/// Куб числа х
		/// </summary>
		/// <param name="x">Число, которое требуется возвести в куб</param>
		/// <returns>Куб числа</returns>
		private static double Cube(double x) => x * x * x;
		/// <summary>
		/// Переводит радианы в градусы
		/// </summary>
		/// <param name="x">Радиальная мера угла</param>
		/// <returns>Угол</returns>
		private static double ToAngle(double x) => x * 180 / Math.PI;
		/// <summary>
		/// Переводит градусы в радианы
		/// </summary>
		/// <param name="x">Градусная мера угла</param>
		/// <returns>Радианы</returns>
		private static double ToRadians(double x) => x * Math.PI / 180;
		/// <summary>
		/// Тангенс угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Аргумент дан в радианах?</param>
		/// <returns>Число</returns>
		private static double Tan(string x, bool isRad)
		{
			try
			{
				double value = double.Parse(x);
				double angle = isRad ? ToAngle(value) : value;
				return angle % 180 != 0 && angle % 90 == 0
					? angle / 90d % 4 == 1 
						? double.PositiveInfinity 
						: double.NegativeInfinity
					: Math.Tan(isRad ? value : ToRadians(value));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Котангенс угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Аргумент дан в радианах?</param>
		/// <returns>Число</returns>
		private static double Cot(string x, bool isRad)
		{
			try {
				double value = double.Parse(x);
				double angle = isRad ? ToAngle(value) : value;
				return angle % 180 == 0 && angle % 90 != 0
					? angle / 90d % 4 == 0
						? double.PositiveInfinity
						: double.NegativeInfinity
					: 1d / Math.Tan(isRad ? value : ToRadians(value));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Синус угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Аргумент дан в радианах?</param>
		/// <returns>Число</returns>
		private static double Sin(string x, bool isRad)
		{
			try
			{
				return Math.Sin(isRad 
								? double.Parse(x) 
								: ToRadians(double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Косинус угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Аргумент дан в радианах?</param>
		/// <returns>Число</returns>
		private static double Cos(string x, bool isRad)
		{
			try
			{
				return Math.Cos(isRad
								? double.Parse(x) 
								: ToRadians(double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Арксинус угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Угол требуется вернуть в радианах?</param>
		/// <returns>Число</returns>
		private static double Asin(string x, bool isRad) 
		{
			try
			{
				return isRad? Math.Asin(double.Parse(x)) : ToAngle(Math.Asin(double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Арккосинус угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Угол требуется вернуть в радианах?</param>
		/// <returns>Число</returns>
		private static double Acos(string x, bool isRad)
		{
			try
			{
				return isRad ? Math.Acos(double.Parse(x)) : ToAngle(Math.Acos(double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Арктангенс угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Угол требуется вернуть в радианах?</param>
		/// <returns>Число</returns>
		private static double Atan(string x, bool isRad)
		{
			try
			{
				return isRad ? Math.Atan(double.Parse(x)) : ToAngle(Math.Atan(double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Арккотангенс угла
		/// </summary>
		/// <param name="x">Строка, содержащая аргумент, т.е. double</param>
		/// <param name="isRad">Угол требуется вернуть в радианах?</param>
		/// <returns>Число</returns>
		private static double Acot(string x, bool isRad)
		{
			try
			{
				return isRad ? Math.Atan(1d / double.Parse(x)) : ToAngle(Math.Atan(1d / double.Parse(x)));
			}
			catch (Exception)
			{
				return double.NaN;
			}
		}
		/// <summary>
		/// Делегат унарных функций
		/// </summary>
		public delegate double operat();
		/// <summary>
		/// Делегат унарных функций
		/// </summary>
		public delegate double operation(double input);
		/// <summary>
		/// Делегат унарных функций
		/// </summary>
		public delegate double ifoperation(string input, bool flag);
		/// <summary>
		/// Делегат унарных функций
		/// </summary>
		public delegate double twooperation(double input, double parametr);


		/// <summary>
		/// Изменяет строку состояния калькулятора, меняя последнее число операцией
		/// </summary>
		/// <param name="stingStart">Изначальная строка</param>
		/// <param name="lexem">Слово, которое нужно заменить посчитанным значением</param>
		/// <param name="use">Операция</param>
		/// <returns>Готовую строку</returns>
		private string Apply(string stingStart, string lexem, operat use)
		{
			return $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(use()).Replace(',', '.')}";
		}
		/// <summary>
		/// Изменяет строку состояния калькулятора, вычисляя для последнего числа заданную операцию
		/// </summary>
		/// <param name="stingStart">Изначальная строка</param>
		/// <param name="lexem">Слово, которое нужно заменить посчитанным значением</param>
		/// <param name="use">Операция</param>
		/// <param name="input">Аргумент функции use</param>
		/// <returns>Готовую строку</returns>
		private string ApplyOne(string stingStart, string lexem, operation use, double input)
		{
			return $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(use(input)).Replace(',', '.')}";
		}
		/// <summary>
		/// Изменяет строку состояния калькулятора, вычисляя для последнего числа заданную операцию
		/// </summary>
		/// <param name="stingStart">Изначальная строка</param>
		/// <param name="lexem">Слово, которое нужно заменить посчитанным значением</param>
		/// <param name="use">Операция</param>
		/// <param name="input">Аргумент функции use</param>
		/// <param name="flag">В данном случае, флаг — требуется ли переводить вычисления из радиан в углы</param>
		/// <returns>Готовую строку</returns>
		private string ApplyTrig(string stingStart, string lexem, ifoperation use, string input, bool flag)
		{
			return $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(use(input, flag)).Replace(',', '.')}";
		}
		/// <summary>
		/// Изменяет строку состояния калькулятора, вычисляя для последнего числа заданную операцию
		/// </summary>
		/// <param name="stingStart">Изначальная строка</param>
		/// <param name="lexem">Слово, которое нужно заменить посчитанным значением</param>
		/// <param name="use">Операция</param>
		/// <param name="input">Первый аргумент функции use</param>
		/// <param name="parametr">Второй аргумент функции use</param>
		/// <returns>Готовую строку</returns>
		private string ApplyTwo(string stingStart, string lexem, twooperation use, double input, double parametr)
		{
			return $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(use(input, parametr)).Replace(',', '.')}";
		}

		private Color[] colors;
		public Form1()
		{
			InitializeComponent();
			ordinary.Checked = true;
			isRad.Checked = true;
			isInverse.Checked = true;
			expression.Text = "0";
			MaximizeBox = false;
			SaveColor();
		}
		private void SaveColor()
		{
			int n = splitContainer1.Panel1.Controls.Count + splitContainer1.Panel2.Controls.Count;
			int i = 0;
			colors = new Color[n];
			foreach (Control item in splitContainer1.Panel1.Controls)
			{
				colors[i] = item.BackColor;
				i++;
			}
			foreach (Control item in splitContainer1.Panel2.Controls)
			{
				colors[i] = item.BackColor;
				i++;
			}
		}
		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!matrix.Checked)
			{
				switch (e.KeyChar.ToString())
				{
					case "0":
						button0_Click(button0, new EventArgs());
						break;
					case "1":
						button1_Click(button1, new EventArgs());
						break;
					case "2":
						button2_Click(button2, new EventArgs());
						break;
					case "3":
						button3_Click(button3, new EventArgs());
						break;
					case "4":
						button4_Click(button4, new EventArgs());
						break;
					case "5":
						button5_Click(button5, new EventArgs());
						break;
					case "6":
						button6_Click(button6, new EventArgs());
						break;
					case "7":
						button7_Click(button7, new EventArgs());
						break;
					case "8":
						button8_Click(button8, new EventArgs());
						break;
					case "9":
						button9_Click(button9, new EventArgs());
						break;
					case "":
						buttonErase_MouseDown(buttonErase, new MouseEventArgs(MouseButtons.Left, 1, buttonErase.Location.X, buttonErase.Location.Y, 0));
						break;
					case "*":
						buttonMultiply_Click(buttonMultiply, new EventArgs());
						break;
					case "/":
						buttonDivide_Click(buttonDivide, new EventArgs());
						break;
					case "%":
						buttonProcent_Click(buttonProcent, new EventArgs());
						break;
					case ",":
						buttonDot_Click(buttonDot, new EventArgs());
						break;
					case ".":
						buttonDot_Click(buttonDot, new EventArgs());
						break;
					case "+":
						buttonAdd_Click(buttonAdd, new EventArgs());
						break;
					case "-":
						buttonSubstract_Click(buttonSubstract, new EventArgs());
						break;
					case "e":
						buttonE_Click(buttonE, new EventArgs());
						break;
					default:
						Console.WriteLine(e.KeyChar.ToString());
						break;
				}
			}
			else
			{
				switch (e.KeyChar)
				{
					default:
						Console.WriteLine(e.KeyChar.ToString());
						break;
				}
			}
		}
		private void engeneer_CheckedChanged(object sender, EventArgs e)
		{
			MatrixPanel.Hide();
			splitContainer1.Panel2.Show();
			Memory.Show();
			buttonMemoryAddSubstract.Show();
			Size = new Size(718, 495);
		}
		private void ordinary_CheckedChanged(object sender, EventArgs e)
		{
			MatrixPanel.Hide();
			splitContainer1.Panel2.Show();
			Memory.Show();
			buttonMemoryAddSubstract.Show();
			Size = new Size(558, 415);
		}
		private void matrix_CheckedChanged(object sender, EventArgs e)
		{
			splitContainer1.Panel2.Hide();
			Memory.Hide();
			buttonMemoryAddSubstract.Hide();
			Size = new Size(718, 495);
			MatrixPanel.BringToFront();
			MatrixPanel.Show();
			SetUpMatrix(MatrixOperandA);
			SetUpMatrix(MatrixOperandB);
			SetUpMatrix(MatrixAnswer);
		}
		private void isRad_CheckedChanged(object sender, EventArgs e)
		{
			isRad.Text = isRad.Checked ? "RAD" : "DEG";
		}
		private void isInverse_CheckedChanged(object sender, EventArgs e)
		{
			if (isInverse.Checked)
			{
				buttonSin.Text = "sin";
				buttonCos.Text = "cos";
				buttonTan.Text = "tan";
				buttonCot.Text = "cot";
			}
			else
			{
				buttonSin.Text = "sin⁻¹";
				buttonCos.Text = "cos⁻¹";
				buttonTan.Text = "tan⁻¹";
				buttonCot.Text = "cot⁻¹";
			}
		}
		private static string ConvertToString(double number, int decimalPlaces = 100) => number.ToString("f99").TrimEnd('0').TrimEnd(',');
		private string PrepareStringToCompute(string ex)
		{
			ex = ex.TrimStart('+');
			string[] lexems = ex.Split(SplitersOperation);
			int i = 0;
			foreach (string str in lexems)
			{
				if (str.Contains('^'))
				{
					string[] mini = str.Split('^');
					ex = ex.Replace(str, $"Pow({mini[0]},{mini[1]})");
				}
				i++;
			}
			return ex.Replace('×', '*');
		}
		private void DisableButtons()
		{
			foreach (Control item in splitContainer1.Panel1.Controls)
			{
				item.Enabled = false;
			}
			foreach (Control item in splitContainer1.Panel2.Controls)
			{
				item.Enabled = false;
				item.BackColor = Color.LightGray;
			}
			buttonErase.Enabled = true;
			buttonErase.BackColor = Color.FromArgb(0xFF, 0x92, 0x00);
		}
		private void EnableButtons()
		{
			int i = 0;
			foreach (Control item in splitContainer1.Panel1.Controls)
			{
				item.Enabled = true;
				item.BackColor = colors[i];
				i++;
			}
			foreach (Control item in splitContainer1.Panel2.Controls)
			{
				item.Enabled = true;
				item.BackColor = colors[i];
				i++;
			}
		}
		private void SetUpMatrix(DataGridView table)
		{
			table.ColumnHeadersVisible = false;
			table.RowHeadersVisible = false;
			table.Columns.Add(new DataGridViewTextBoxColumn());
			table.Columns.Add(new DataGridViewTextBoxColumn());
			table.Columns.Add(new DataGridViewTextBoxColumn());
			table.Rows.Add();
			table.Rows.Add();
			table.Rows.Add();
			table.ScrollBars = ScrollBars.None;
			table.AllowUserToAddRows = false;
			foreach (DataGridViewColumn item in table.Columns)
			{
				item.Width = table.Width / 3;
			}
			foreach (DataGridViewRow item in table.Rows)
			{
				item.Height = table.Height / 3;
			}
		}

		private void buttonNegative_Click(object sender, EventArgs e)
		{
			string[] lexems = expression.Text.Split(SplitersOperation);
			if (lexems.Length != 1 || lexems[lexems.Length - 1] != "0")
			{
				int nearestOperationIndex = expression.Text.LastIndexOf("+") > expression.Text.LastIndexOf("-") ? expression.Text.LastIndexOf("+") : expression.Text.LastIndexOf("-");
				
				if (nearestOperationIndex != -1)
				{
					expression.Text = $"{expression.Text.Substring(0, nearestOperationIndex)}{expression.Text.Substring(nearestOperationIndex).Remove(0, 1).Insert(0, expression.Text[nearestOperationIndex] == '+' ? "-" : "+")}";
				}
				else if (!(expression.Text.EndsWith("+") || expression.Text.EndsWith("-")))
				{
					expression.Text = expression.Text.Insert(0, "-");
				}
			}
		}
		private void buttonSqr_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Sqr);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					{
						double input = Convert.ToDouble(lexems.Last().Replace('.', ','));
						expression.Text = ConvertToString(input * input).Replace(',', '.');
						break;
					}

				default:
					{
						double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) 
														? lexems[lexems.Length - 2] 
														: lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
					}
			}
			if (expression.Text.Contains("∞"))
			{
				DisableButtons();
				ErrorState = true;
			}
		}
		private void buttonSqrt_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Math.Sqrt);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default:
					{
						double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last())
														? lexems[lexems.Length - 2]
														: lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
					}
			}
		}
		private void buttonInvert_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Inverse);
			if (!string.IsNullOrEmpty(lexems.Last()))
			{
				double input = Convert.ToDouble(lexems.Last().Replace('.', ','));
				switch (input)
				{
					case 0:
						expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
						expression.Text = "Деление на ноль";
						DisableButtons();
						ErrorState = true;
						break;
					default:
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
				}
			}
		}
		private void buttonProcent_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			String[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Procent);
			double input;

			input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
			expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
		}
		private void buttonCube_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Cube);
			double input;
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					input = Convert.ToDouble(lexems.Last().Replace('.', ','));
					expression.Text = ConvertToString(input * input * input).Replace(',', '.');
					break;
				default:
					input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
					break;
			}

			if (expression.Text.Contains("∞"))
			{
				DisableButtons();
				ErrorState = true;
			}
		}
		private void buttonCubeRoot_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			double input;
			twooperation local = new twooperation(Math.Pow);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					{
						input = Convert.ToDouble(lexems.Last());
						expression.Text = $"-{ConvertToString(Math.Pow(input, 1d / 3d)).Replace(',', '.')}";
						break;
					}

				default:
					{
						input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyTwo(expression.Text, lexems.Last(), local, input, 1d / 3d);
						break;
					}
			}
		}
		private void buttonFactorial_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default:
					{
						using (Chart a = new Chart())
						{
							double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
							operation local = new operation(a.DataManipulator.Statistics.GammaFunction);
							expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input + 1);
						}

						break;
					}
			}
		}
		private void button10exp_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			twooperation local = new twooperation(Math.Pow);
			double input;
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					{
						input = Convert.ToDouble(lexems.Last().Replace('.', ','));
						expression.Text = ConvertToString(Math.Pow(10d, input)).Replace(',', '.');
					}

					break;
				default:
					{
						input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyTwo(expression.Text, lexems.Last(), local, 10d, input);
						break;
					}
			}
		}
		private void buttonLn_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Math.Log);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default:
					{
						double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
					}
			}
		}
		private void buttonLog10_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Math.Log10);
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default:
					{
						double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
					}
			}
		}
		private void buttonExp_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			operation local = new operation(Math.Exp);
			double input;
			switch (lexems.Length)
			{
				case 2 when expression.Text[0] == '-':
					{
						input = Convert.ToDouble(lexems.Last().Replace('.', ','));
						expression.Text = ConvertToString(Math.Exp(input)).Replace(',', '.');
					}

					break;
				default:
					{
						input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), local, input);
						break;
					}
			}
		}
		private void buttonSin_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			ifoperation local = isInverse.Checked ? new ifoperation(Sin) : new ifoperation(Asin);
			string input;
			if (lexems.Length == 2)
			{
				input = lexems[lexems.Length - 1].Replace('.', ',');
			}
			else
			{
				input = (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');
			}

			expression.Text = ApplyTrig(expression.Text, lexems.Last(), local, input, isRad.Checked);
		}
		private void buttonCos_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			ifoperation local = isInverse.Checked ? new ifoperation(Cos) : new ifoperation(Acos);
			string input;
			if (lexems.Length == 2)
			{
				input = lexems[lexems.Length - 1].Replace('.', ',');
			}
			else
			{
				input = (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');
			}

			expression.Text = ApplyTrig(expression.Text, lexems.Last(), local, input, isRad.Checked);
		}
		private void buttonTan_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			ifoperation local = isInverse.Checked ? new ifoperation(Tan) : new ifoperation(Atan);
			string input;
			if (lexems.Length == 2)
			{
				input = lexems[lexems.Length - 1].Replace('.', ',');
			}
			else
			{
				input = (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');
			}

			expression.Text = ApplyTrig(expression.Text, lexems.Last(), local, input, isRad.Checked);
		}
		private void buttonCot_Click(object sender, EventArgs e)
		{
			Evalueted = true;

			string[] lexems = expression.Text.Split(SplitersOperation);
			ifoperation local = isInverse.Checked ? new ifoperation(Cot) : new ifoperation(Acot);
			string input;
			if (lexems.Length == 2)
			{
				input = lexems[lexems.Length - 1].Replace('.', ',');
			}
			else
			{
				input = (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');
			}

			expression.Text = ApplyTrig(expression.Text, lexems.Last(), local, input, isRad.Checked);
		}


		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (AllOperations.Contains(expression.Text.Last()))
			{
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}+";
			}
			else
			{
				expression.Text += "+";
			}
		}
		private void buttonSubstract_Click(object sender, EventArgs e)
		{
			if (AllOperations.Contains(expression.Text.Last()))
			{
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}-";
			}
			else
			{
				expression.Text += "-";
			}
		}
		private void buttonMultiply_Click(object sender, EventArgs e)
		{
			if (AllOperations.Contains(expression.Text.Last()))
			{
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}×";
			}
			else
			{
				expression.Text += "×";
			}
		}
		private void buttonDivide_Click(object sender, EventArgs e)
		{
			if (AllOperations.Contains(expression.Text.Last()))
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}/";
			else
				expression.Text += "/";
		}
		private void buttonXexpY_Click(object sender, EventArgs e)
		{
			if (AllOperations.Contains(expression.Text.Last()))
			{
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}^";
			}
			else
			{
				expression.Text += "^";
			}
		}


		private void button0_Click(object sender, EventArgs e)
		{
			if (expression.Text != "0")
				expression.Text += '0';
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "1";
				Evalueted = false;
			}
			else
				expression.Text += "1";
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "2";
				Evalueted = false;
			}
			else
				expression.Text += "2";
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "3";
				Evalueted = false;

			}
			else
				expression.Text += "3";
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "4";
				Evalueted = false;
			}
			else
				expression.Text += "4";
		}
		private void button5_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "5";
				Evalueted = false;
			}
			else
				expression.Text += "5";
		}
		private void button6_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "6";
				Evalueted = false;
			}
			else
				expression.Text += "6";
		}
		private void button7_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "7";
				Evalueted = false;
			}
			else
				expression.Text += "7";
		}
		private void button8_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "8";
				Evalueted = false;
			}
			else
				expression.Text += "8";
		}
		private void button9_Click(object sender, EventArgs e)
		{
			if (expression.Text == "0" || Evalueted)
			{
				expression.Text = "9";
				Evalueted = false;
			}
			else
				expression.Text += "9";
		}
		private void buttonDot_Click(object sender, EventArgs e)
		{
			String[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			if (!lexems.Last().Contains("."))
				expression.Text += ".";
		}
		private void buttonE_Click(object sender, EventArgs e)
		{
			string[] lexems = expression.Text.Split(SplitersOperation);

			if (expression.Text == "0" || lexems.Last().Contains("."))
			{
				expression.Text = Math.E.ToString().Replace(",", ".");
				Evalueted = false;

			}
			else
			{
				expression.Text += Math.E.ToString().Replace(",", ".");
			}
		}
		private void buttonPI_Click(object sender, EventArgs e)
		{
			string[] lexems = expression.Text.Split(SplitersOperation);

			if (expression.Text == "0" || lexems.Last().Contains("."))
			{
				expression.Text = Math.PI.ToString().Replace(",", ".");
				Evalueted = false;

			}
			else
			{
				expression.Text += Math.PI.ToString().Replace(",", ".");
			}
		}
		private void buttonRand_Click(object sender, EventArgs e)
		{
			Evalueted = true;
			string[] lexems = expression.Text.Split(SplitersOperation);

			Random rand = new Random();
			operat local = new operat(rand.NextDouble);
			expression.Text = Apply(expression.Text, lexems.Last(), local);
		}


		private void buttonErase_MouseDown(object sender, MouseEventArgs e)
		{
			switch (ErrorState)
			{
				case true:
					expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size + 10);
					expression.Text = "0";
					EnableButtons();
					ErrorState = false;
					break;
				default:
					switch (e.Button)
					{
						case MouseButtons.Left:
							if (expression.Text.Length > 0)
								expression.Text = expression.Text.Remove(expression.Text.Length - 1, 1);

							if (expression.Text.Length == 0)
								expression.Text = "0";
							break;
						case MouseButtons.Right:
							expression.Text = "0";
							break;
					}
					break;
			}
		}
		private void buttonEqual_MouseDown(object sender, MouseEventArgs e)
		{
			if ((expression.Text.Any(char.IsLetter) && !expression.Text.Contains('E')) 
				|| expression.Text.Contains("∞") 
				|| SplitersOperation.Contains(expression.Text.Last()))
			{
				expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
				expression.Text = "Неверный формат";
				DisableButtons();
				ErrorState = true;
			}
			else
			{
				ToComputeExprsion = PrepareStringToCompute(expression.Text);
				Console.WriteLine(ToComputeExprsion);
				Pars.Exp = ToComputeExprsion;
				try
				{
					string temp = Pars.Compute();

					if (temp.Contains("∞"))
					{
						expression.Font = new Font(expression.Font.FontFamily, expression.Font.Size - 10);
						expression.Text = "Деление на ноль";
						DisableButtons();
						ErrorState = true;
					}
					else
					{
						expression.Text = temp.Replace(',', '.');
						switch (e.Button)
						{
							case MouseButtons.Right:
								Memory.Text = expression.Text;
								break;
							case MouseButtons.Middle:
								Clipboard.SetText(expression.Text);
								break;
						}
					}
				}
				catch(Exception A)
				{
					Console.WriteLine($"{A.Message}\n{A.InnerException}");
				}
			}
		}
		private void buttonMemoryAddSubstract_MouseDown(object sender, MouseEventArgs e)
		{
			buttonEqual_MouseDown(buttonMemoryAddSubstract, new MouseEventArgs(MouseButtons.Left, 1, buttonEqual.Location.X, buttonEqual.Location.Y, 0));
			double result = Convert.ToDouble(expression.Text.Replace(".", ","));
			double memory = Convert.ToDouble(Memory.Text.Replace(".", ","));
			switch (e.Button)
			{
				case MouseButtons.Left:
					Memory.Text = ConvertToString(memory + result).Replace(",", ".");
					break;
				case MouseButtons.Right:
					Memory.Text = ConvertToString(memory - result).Replace(",", ".");
					break;
			}
		}
		private void Memory_MouseDown(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					Memory.Text = "0";
					break;
				case MouseButtons.Middle:
					Clipboard.SetText(Memory.Text);
					break;
				case MouseButtons.Right:
					expression.Text = expression.Text == "0"
										? Memory.Text
										: (expression.Text + Memory.Text);
					break;
			}
		}
		private void expression_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				expression.Text = Clipboard.GetText();
			}
		}


		private void buttonEqual_MouseHover(object sender, EventArgs e)
		{
			using (ToolTip toolTip = new ToolTip())
			{
				toolTip.SetToolTip(buttonEqual, "ПКМ — посчитать и сохранить\nЩелчек колесом мыши — скопировать результат");
			}
		}
		private void buttonErase_MouseHover(object sender, EventArgs e)
		{
			using (ToolTip toolTip = new ToolTip())
			{
				toolTip.SetToolTip(buttonErase, "ПКМ — очистить");
			}
		}
		private void buttonMemoryAddSubstract_MouseHover(object sender, EventArgs e)
		{
			using (ToolTip toolTip = new ToolTip())
			{
				toolTip.SetToolTip(buttonMemoryAddSubstract, "ЛКМ — прибавить результат к сохраненному\nПКМ — отнять результат от сохраненного");
			}
		}
		private void Memory_MouseHover(object sender, EventArgs e)
		{
			using (ToolTip toolTip = new ToolTip())
			{
				toolTip.SetToolTip(Memory, "Сохраненное\nЩелчок колесом мыши — скопировать результат\nПКМ чтобы поместить результат\nЛКМ — очистить");
			}
		}

		private void determinant_MouseDown(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					operandA = new Matrix(MatrixOperandA.RowCount, MatrixOperandA.ColumnCount);
					break;
				case MouseButtons.Right:
					break;
			}
		}
	}
}

namespace NCalc
{
	public class Pars
	{
		private string _exp;
		public string Exp { set => _exp = value; }

		public string Compute()
		{
			Expression toCompute = new Expression(_exp);
			if (toCompute.HasErrors())
			{
				throw new EvaluateException("Неверный формат");
			}
			return toCompute.Evaluate().ToString();
		}
	}
}