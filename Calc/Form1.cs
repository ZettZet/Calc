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

namespace Calc {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			isRad.Checked = true;
			isInverse.Checked = true;
			expression.Text = "0";
			MaximizeBox = false;
			Evalueted = true;
			ErrorState = false;
			SaveColor();
			engeneer_CheckedChanged(new object(), new EventArgs());
		}

		#region Поля и свойства
		private Pars Pars { get; } = new Pars();
		private string ToComputeExprsion { get; set; } = new string(new char[] { '\0' });
		public char[] SplitersOperation { get; } = new char[] { '+', '-', '/', '×' };
		public string AllOperations { get; } = "+-/×^";
		public bool ErrorState { get; set; }
		public bool Evalueted { get; set; }
		private Color[] colors;
		#endregion

		#region Унарные функции, которые считаются сразу
		private static double Procent(double x) => x / 100d;
		private static double Inverse(double x) => 1d / x;
		private static double Sqr(double x) => x * x;
		private static double Cube(double x) => x * x * x;
		private static double ToAngle(double x) => Math.Round(x * 180 / Math.PI, 8);
		private static double ToRadians(double x) => Math.Round(x * Math.PI / 180, 10);
		private static double Tan(string x, bool isRad) {
			try {
				double value = double.Parse(x);
				double angle = isRad ? ToAngle(value) : value;
				return angle % 90 == 0 && (angle / 90) % 2 != 0
						? (angle / 90) % 4 == 3
							? double.NegativeInfinity
							: double.PositiveInfinity
						: Math.Tan(isRad ? value : ToRadians(value));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Cot(string x, bool isRad) {
			try {
				double value = double.Parse(x);
				double angle = isRad ? ToAngle(value) : value;
				Console.WriteLine($"{angle % 180 == 0}&&{angle % 90}\n{angle / 90d % 4 == 0}");
				return angle % 90 == 0 && (angle / 90) % 2 != 1
						? (angle / 90) % 4 == 2
							? double.NegativeInfinity
							: double.PositiveInfinity
						: 1d / Tan(x, isRad);
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Sin(string x, bool isRad) {
			try {
				return Math.Sin(isRad
								? double.Parse(x)
								: ToRadians(double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Cos(string x, bool isRad) {
			try {
				return Math.Cos(isRad
								? double.Parse(x)
								: ToRadians(double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Asin(string x, bool isRad) {
			try {
				return isRad ? Math.Asin(double.Parse(x)) : ToAngle(Math.Asin(double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Acos(string x, bool isRad) {
			try {
				return isRad ? Math.Acos(double.Parse(x)) : ToAngle(Math.Acos(double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Atan(string x, bool isRad) {
			try {
				return isRad ? Math.Atan(double.Parse(x)) : ToAngle(Math.Atan(double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		private static double Acot(string x, bool isRad) {
			try {
				return isRad ? Math.Atan(1d / double.Parse(x)) : ToAngle(Math.Atan(1d / double.Parse(x)));
			}
			catch(Exception) {
				return double.NaN;
			}
		}
		#endregion

		#region Делегаты разных операций и функции применения
		public delegate double operat();
		public delegate double operation(double input);
		public delegate double ifoperation(string input, bool flag);
		public delegate double twooperation(double input, double parametr);

		private string Apply(string stingStart, string lexem, operat use) => $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(Math.Round(use(), 10)).Replace(',', '.')}";
		private string ApplyOne(string stingStart, string lexem, operation use, double input) => $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(Math.Round(use(input), 10)).Replace(',', '.')}";
		private string ApplyTrig(string stingStart, string lexem, ifoperation use, string input, bool flag) => $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(Math.Round(use(input, flag), 10)).Replace(',', '.')}";
		private string ApplyTwo(string stingStart, string lexem, twooperation use, double input, double parametr) => $"{stingStart.TrimEnd(lexem.ToCharArray())}{ConvertToString(Math.Round(use(input, parametr))).Replace(',', '.')}";

		#endregion

		#region Дополнительные методы
		private void SaveColor() {
			int n = splitContainer1.Panel1.Controls.Count + splitContainer1.Panel2.Controls.Count;
			int i = 0;
			colors = new Color[n];
			foreach(Control item in splitContainer1.Panel1.Controls) {
				colors[i] = item.BackColor;
				i++;
			}
			foreach(Control item in splitContainer1.Panel2.Controls) {
				colors[i] = item.BackColor;
				i++;
			}
		}
		private static string ConvertToString(double number, int decimalPlaces = 80) => Math.Round(number, 10).ToString("f99").TrimEnd('0').TrimEnd(',');
		private string PrepareStringToCompute(string ex) {
			ex = ex.TrimStart('+');
			string[] lexems = ex.Split(SplitersOperation);
			int i = 0;
			foreach(string str in lexems) {
				if(str.Contains('^')) {
					string[] mini = str.Split('^');
					ex = ex.Replace(str, $"Pow({mini[0]},{mini[1]})");
				}
				i++;
			}
			return ex.Replace('×', '*');
		}
		private void DisableButtons() {
			foreach(Control item in splitContainer1.Panel1.Controls) {
				item.Enabled = false;
			}
			foreach(Control item in splitContainer1.Panel2.Controls) {
				item.Enabled = false;
				item.BackColor = Color.LightGray;
			}
			buttonErase.Enabled = true;
			buttonErase.BackColor = Color.FromArgb(0xFF, 0x92, 0x00);
		}
		private void EnableButtons() {
			int i = 0;
			foreach(Control item in splitContainer1.Panel1.Controls) {
				item.Enabled = true;
				item.BackColor = colors[i];
				i++;
			}
			foreach(Control item in splitContainer1.Panel2.Controls) {
				item.Enabled = true;
				item.BackColor = colors[i];
				i++;
			}
		}
		#endregion

		#region Технические методы событий
		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			switch(e.KeyChar.ToString()) {
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
		private void engeneer_CheckedChanged(object sender, EventArgs e) {
			splitContainer1.Panel2.Show();
			Memory.Show();
			buttonMemoryAddSubstract.Show();
			MaximumSize = new Size(718, 495);
			Size = new Size(718, 495);
			MinimumSize = new Size(718, 495);
		}
		private void ordinary_CheckedChanged(object sender, EventArgs e) {
			splitContainer1.Panel2.Show();
			Memory.Show();
			buttonMemoryAddSubstract.Show();
			MinimumSize = new Size(555, 412);
			Size = new Size(555, 412);
			MaximumSize = new Size(555, 412);
		}
		private void isRad_CheckedChanged(object sender, EventArgs e) {
			isRad.Text = isRad.Checked ? "RAD" : "DEG";
		}
		private void isInverse_CheckedChanged(object sender, EventArgs e) {
			if(isInverse.Checked) {
				buttonSin.Text = "sin";
				buttonCos.Text = "cos";
				buttonTan.Text = "tan";
				buttonCot.Text = "cot";
			}
			else {
				buttonSin.Text = "sin⁻¹";
				buttonCos.Text = "cos⁻¹";
				buttonTan.Text = "tan⁻¹";
				buttonCot.Text = "cot⁻¹";
			}
		}
		private void expression_TextChanged(object sender, EventArgs e) {
			if((expression.Text.Any(char.IsLetter) && !expression.Text.Contains('E'))
				|| expression.Text.Contains("∞")) {
				expression.Font = new Font(expression.Font.FontFamily, 16.25f);
				expression.Text = "Неверный формат";
				DisableButtons();
				ErrorState = true;
			}
		}
		#endregion

		#region Кнопки унарных операций
		private void buttonNegative_Click(object sender, EventArgs e) {
			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			if(lexems.Length != 1 || lexems[lexems.Length - 1] != "0") {
				int nearestOperationIndex = expression.Text.LastIndexOf("+") > expression.Text.LastIndexOf("-") ? expression.Text.LastIndexOf("+") : expression.Text.LastIndexOf("-");

				if(nearestOperationIndex != -1) {
					expression.Text = $"{expression.Text.Substring(0, nearestOperationIndex)}{expression.Text.Substring(nearestOperationIndex).Remove(0, 1).Insert(0, expression.Text[nearestOperationIndex] == '+' ? "-" : "+")}";
				}
				else if(!(expression.Text.EndsWith("+") || expression.Text.EndsWith("-"))) {
					expression.Text = expression.Text.Insert(0, "-");
				}
			}
		}
		private void buttonSqr_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-': {
					double input = Convert.ToDouble(lexems.Last().Replace('.', ','));
					expression.Text = ConvertToString(Sqr(input)).Replace(',', '.');
					break;
				}

				default: {
					double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last())
													? lexems[lexems.Length - 2]
													: lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Sqr), input);
					break;
				}
			}
		}
		private void buttonSqrt_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, 16.25f);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default: {
					double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last())
													? lexems[lexems.Length - 2]
													: lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Math.Sqrt), input);
					break;
				}
			}
		}
		private void buttonInvert_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			if(!string.IsNullOrEmpty(lexems.Last())) {
				double input = Convert.ToDouble(lexems.Last().Replace('.', ','));
				expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Inverse), input);

			}
		}
		private void buttonProcent_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			double input;

			input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
			expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Procent), input);
		}
		private void buttonCube_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			double input;
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-':
					input = Convert.ToDouble(lexems.Last().Replace('.', ','));
					expression.Text = ConvertToString(Cube(input)).Replace(',', '.');
					break;
				default:
					input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Cube), input);
					break;
			}
		}
		private void buttonCubeRoot_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			double input;
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-': {
					input = Convert.ToDouble(lexems.Last());
					expression.Text = $"-{ConvertToString(Math.Pow(input, 1d / 3d)).Replace(',', '.')}";
					break;
				}

				default: {
					input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyTwo(expression.Text, lexems.Last(), new twooperation(Math.Pow), input, 1d / 3d);
					break;
				}
			}
		}
		private void buttonFactorial_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, 16.25f);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default: {
					using(Chart a = new Chart()) {
						double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
						expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(a.DataManipulator.Statistics.GammaFunction), input + 1);
					}

					break;
				}
			}
		}
		private void button10exp_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			double input;
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-': {
					input = Convert.ToDouble(lexems.Last().Replace('.', ','));
					expression.Text = ConvertToString(Math.Pow(8d, input)).Replace(',', '.');
				}

				break;
				default: {
					input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyTwo(expression.Text, lexems.Last(), new twooperation(Math.Pow), 8d, input);
					break;
				}
			}
		}
		private void buttonLn_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, 16.25f);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default: {
					double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Math.Log), input);
					break;
				}
			}
		}
		private void buttonLog10_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-':
					expression.Font = new Font(expression.Font.FontFamily, 16.25f);
					expression.Text = "Неверный формат";
					DisableButtons();
					ErrorState = true;
					break;
				default: {
					double input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Math.Log10), input);
					break;
				}
			}
		}
		private void buttonExp_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			double input;
			switch(lexems.Length) {
				case 2 when expression.Text[0] == '-': {
					input = Convert.ToDouble(lexems.Last().Replace('.', ','));
					expression.Text = ConvertToString(Math.Exp(input)).Replace(',', '.');
				}

				break;
				default: {
					input = Convert.ToDouble((string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ','));
					expression.Text = ApplyOne(expression.Text, lexems.Last(), new operation(Math.Exp), input);
					break;
				}
			}
		}
		private void buttonSin_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			string input = lexems.Length == 2
				? lexems[lexems.Length - 1].Replace('.', ',')
				: (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');

			expression.Text = ApplyTrig(expression.Text,
							   lexems.Last(),
							   isInverse.Checked ? new ifoperation(Sin) : new ifoperation(Asin),
							   input,
							   isRad.Checked);
		}
		private void buttonCos_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			string input = lexems.Length == 2
				? lexems[lexems.Length - 1].Replace('.', ',')
				: (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');

			expression.Text = ApplyTrig(expression.Text,
							   lexems.Last(),
							   isInverse.Checked ? new ifoperation(Cos) : new ifoperation(Acos),
							   input,
							   isRad.Checked);
		}
		private void buttonTan_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			string input = lexems.Length == 2
				? lexems[lexems.Length - 1].Replace('.', ',')
				: (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');

			expression.Text = ApplyTrig(expression.Text,
							   lexems.Last(),
							   isInverse.Checked ? new ifoperation(Tan) : new ifoperation(Atan),
							   input,
							   isRad.Checked);
		}
		private void buttonCot_Click(object sender, EventArgs e) {
			Evalueted = true;

			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			string input = lexems.Length == 2
				? lexems[lexems.Length - 1].Replace('.', ',')
				: (string.IsNullOrEmpty(lexems.Last()) ? lexems[lexems.Length - 2] : lexems.Last()).Replace('.', ',');

			expression.Text = ApplyTrig(expression.Text,
							   lexems.Last(),
							   isInverse.Checked ? new ifoperation(Cot) : new ifoperation(Acot),
							   input,
							   isRad.Checked);
		}
		#endregion

		#region Кнопки бинарных операций
		private void buttonAdd_Click(object sender, EventArgs e) {
			Evalueted = false;
			if(AllOperations.Contains(expression.Text.Last())) {
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}+";
			}
			else {
				expression.Text += "+";
			}
		}
		private void buttonSubstract_Click(object sender, EventArgs e) {
			Evalueted = false;
			if(AllOperations.Contains(expression.Text.Last())) {
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}-";
			}
			else {
				expression.Text += "-";
			}
		}
		private void buttonMultiply_Click(object sender, EventArgs e) {
			Evalueted = false;
			if(AllOperations.Contains(expression.Text.Last())) {
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}×";
			}
			else {
				expression.Text += "×";
			}
		}
		private void buttonDivide_Click(object sender, EventArgs e) {
			Evalueted = false;
			if(AllOperations.Contains(expression.Text.Last()))
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}/";
			else {
				expression.Text += "/";
			}
		}
		private void buttonXexpY_Click(object sender, EventArgs e) {
			Evalueted = false;
			if(AllOperations.Contains(expression.Text.Last())) {
				expression.Text = $"{expression.Text.Remove(expression.Text.Length - 1, 1)}^";
			}
			else {
				expression.Text += "^";
			}
		}
		#endregion

		#region Кнопки ввода чисел
		private void button0_Click(object sender, EventArgs e) {
			if(expression.Text != "0")
				expression.Text += '0';
		}
		private void button1_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "1";
				Evalueted = false;
			}
			else
				expression.Text += "1";
		}
		private void button2_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "2";
				Evalueted = false;
			}
			else
				expression.Text += "2";
		}
		private void button3_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "3";
				Evalueted = false;
			}
			else
				expression.Text += "3";
		}
		private void button4_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "4";
				Evalueted = false;
			}
			else
				expression.Text += "4";
		}
		private void button5_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "5";
				Evalueted = false;
			}
			else
				expression.Text += "5";
		}
		private void button6_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "6";
				Evalueted = false;
			}
			else
				expression.Text += "6";
		}
		private void button7_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "7";
				Evalueted = false;
			}
			else
				expression.Text += "7";
		}
		private void button8_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "8";
				Evalueted = false;
			}
			else
				expression.Text += "8";
		}
		private void button9_Click(object sender, EventArgs e) {
			if(expression.Text == "0" || Evalueted) {
				expression.Text = "9";
				Evalueted = false;
			}
			else
				expression.Text += "9";
		}
		private void buttonDot_Click(object sender, EventArgs e) {
			string[] lexems = expression.Text.Split(AllOperations.ToCharArray());
			if(!lexems.Last().Contains("."))
				expression.Text += ".";
		}
		private void buttonE_Click(object sender, EventArgs e) {
			string[] lexems = expression.Text.Split(SplitersOperation);

			if(expression.Text == "0" || lexems.Last().Contains(".") || !AllOperations.Contains(expression.Text.Last())) {
				expression.Text = Math.Round(Math.E, 10).ToString().Replace(",", ".");
				Evalueted = false;
			}
			else {
				expression.Text += Math.E.ToString().Replace(",", ".");
			}
		}
		private void buttonPI_Click(object sender, EventArgs e) {
			string[] lexems = expression.Text.Split(SplitersOperation);

			if(expression.Text == "0" || lexems.Last().Contains(".") || !AllOperations.Contains(expression.Text.Last())) {
				expression.Text = Math.Round(Math.PI, 10).ToString().Replace(",", ".");
				Evalueted = false;
			}
			else {
				expression.Text += Math.PI.ToString().Replace(",", ".");
			}
		}
		private void buttonRand_Click(object sender, EventArgs e) {
			Evalueted = true;
			string[] lexems = expression.Text.Split(SplitersOperation);

			Random rand = new Random();
			operat local = new operat(rand.NextDouble);
			expression.Text = Apply(expression.Text, lexems.Last(), local);
		}
		#endregion

		#region Кнопки множественного нажатия
		private void buttonErase_MouseDown(object sender, MouseEventArgs e) {
			switch(ErrorState) {
				case true:
					expression.Font = new Font(expression.Font.FontFamily, 26.25f);
					expression.Text = "0";
					EnableButtons();
					ErrorState = false;
					break;
				default:
					switch(e.Button) {
						case MouseButtons.Left:
							if(expression.Text.Length > 0)
								expression.Text = expression.Text.Remove(expression.Text.Length - 1, 1);

							if(expression.Text.Length == 0)
								expression.Text = "0";
							break;
						case MouseButtons.Right:
							expression.Text = "0";
							break;
					}
					break;
			}
		}
		private void buttonEqual_MouseDown(object sender, MouseEventArgs e) {
			if(SplitersOperation.Contains(expression.Text.Last())) {
				expression.Font = new Font(expression.Font.FontFamily, 16.25f);
				expression.Text = "Неверный формат";
				DisableButtons();
				ErrorState = true;
			}
			else {
				ToComputeExprsion = PrepareStringToCompute(expression.Text);
				Console.WriteLine(ToComputeExprsion);
				Pars.Exp = ToComputeExprsion;
				try {
					string temp = Pars.Compute();

					if(temp.Contains("∞")) {
						expression.Font = new Font(expression.Font.FontFamily, 16.25f);
						expression.Text = "Деление на ноль";
						DisableButtons();
						ErrorState = true;
					}
					else {
						Evalueted = true;
						temp = Math.Round(double.Parse(temp), 10).ToString();
						expression.Text = temp.Replace(',', '.');
						switch(e.Button) {
							case MouseButtons.Right:
								Memory.Text = expression.Text;
								break;
							case MouseButtons.Middle:
								Clipboard.SetText(expression.Text);
								break;
						}
					}
				}
				catch(Exception A) {
					Console.WriteLine($"{A.Message}\n{A.InnerException}");
				}
			}
		}
		private void buttonMemoryAddSubstract_MouseDown(object sender, MouseEventArgs e) {
			buttonEqual_MouseDown(buttonMemoryAddSubstract, new MouseEventArgs(MouseButtons.Left, 1, buttonEqual.Location.X, buttonEqual.Location.Y, 0));
			double result = Convert.ToDouble(expression.Text.Replace(".", ","));
			double memory = Convert.ToDouble(Memory.Text.Replace(".", ","));
			switch(e.Button) {
				case MouseButtons.Left:
					Memory.Text = ConvertToString(memory + result).Replace(",", ".");
					break;
				case MouseButtons.Right:
					Memory.Text = ConvertToString(memory - result).Replace(",", ".");
					break;
			}
		}
		private void Memory_MouseDown(object sender, MouseEventArgs e) {
			switch(e.Button) {
				case MouseButtons.Left:
					Memory.Text = "0";
					break;
				case MouseButtons.Middle:
					Clipboard.SetText(Memory.Text);
					break;
				case MouseButtons.Right:
					expression.Text = !AllOperations.Contains(expression.Text.Last())
										? Memory.Text
										: (expression.Text + Memory.Text);
					break;
			}
		}
		private void expression_MouseDown(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Right) {
				expression.Text = Clipboard.GetText();
			}
		}
		#endregion
	}
}

namespace NCalc {
	public class Pars {
		private string _exp;
		public string Exp { set => _exp = value; }

		public string Compute() {
			Expression toCompute = new Expression(_exp);
			if(toCompute.HasErrors()) {
				throw new EvaluateException("Неверный формат");
			}
			return toCompute.Evaluate().ToString();
		}
	}
}