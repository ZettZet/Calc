using System;
using System.Windows.Forms;

namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Memory = new System.Windows.Forms.Label();
			this.buttonMemoryAddSubstract = new System.Windows.Forms.Button();
			this.buttonErase = new System.Windows.Forms.Button();
			this.buttonEqual = new System.Windows.Forms.Button();
			this.ordinary = new System.Windows.Forms.RadioButton();
			this.engeneer = new System.Windows.Forms.RadioButton();
			this.buttonMod = new System.Windows.Forms.Button();
			this.expression = new System.Windows.Forms.TextBox();
			this.buttonRand = new System.Windows.Forms.Button();
			this.isInverse = new System.Windows.Forms.CheckBox();
			this.isRad = new System.Windows.Forms.CheckBox();
			this.button10exp = new System.Windows.Forms.Button();
			this.buttonFactorial = new System.Windows.Forms.Button();
			this.buttonCubeRoot = new System.Windows.Forms.Button();
			this.buttonCube = new System.Windows.Forms.Button();
			this.buttonExp = new System.Windows.Forms.Button();
			this.buttonXexpY = new System.Windows.Forms.Button();
			this.buttonCos = new System.Windows.Forms.Button();
			this.buttonCot = new System.Windows.Forms.Button();
			this.buttonPI = new System.Windows.Forms.Button();
			this.buttonLog10 = new System.Windows.Forms.Button();
			this.buttonSin = new System.Windows.Forms.Button();
			this.buttonTan = new System.Windows.Forms.Button();
			this.buttonE = new System.Windows.Forms.Button();
			this.buttonLn = new System.Windows.Forms.Button();
			this.buttonInvert = new System.Windows.Forms.Button();
			this.buttonSubstract = new System.Windows.Forms.Button();
			this.buttonSqrt = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.buttonMultiply = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.buttonSqr = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonProcent = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonDot = new System.Windows.Forms.Button();
			this.buttonNegative = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Memory
			// 
			this.Memory.AutoEllipsis = true;
			this.Memory.AutoSize = true;
			this.Memory.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Memory.Location = new System.Drawing.Point(164, 52);
			this.Memory.MaximumSize = new System.Drawing.Size(78, 38);
			this.Memory.MinimumSize = new System.Drawing.Size(78, 38);
			this.Memory.Name = "Memory";
			this.Memory.Size = new System.Drawing.Size(78, 38);
			this.Memory.TabIndex = 89;
			this.Memory.Text = "0";
			this.toolTip1.SetToolTip(this.Memory, "Сохраненное\r\nЛКМ — очистить\r\nЩелчок колесом мыши — скопировать результат\r\nПКМ — п" +
        "оместить результат в строку");
			this.Memory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Memory_MouseDown);
			// 
			// buttonMemoryAddSubstract
			// 
			this.buttonMemoryAddSubstract.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonMemoryAddSubstract.FlatAppearance.BorderSize = 0;
			this.buttonMemoryAddSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMemoryAddSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.buttonMemoryAddSubstract.Location = new System.Drawing.Point(244, 52);
			this.buttonMemoryAddSubstract.Margin = new System.Windows.Forms.Padding(1);
			this.buttonMemoryAddSubstract.Name = "buttonMemoryAddSubstract";
			this.buttonMemoryAddSubstract.Size = new System.Drawing.Size(78, 38);
			this.buttonMemoryAddSubstract.TabIndex = 90;
			this.buttonMemoryAddSubstract.Text = "+/-";
			this.toolTip1.SetToolTip(this.buttonMemoryAddSubstract, "ЛКМ — прибавить результат к сохраненному\r\nПКМ — отнять результат от сохраненного");
			this.buttonMemoryAddSubstract.UseVisualStyleBackColor = false;
			this.buttonMemoryAddSubstract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMemoryAddSubstract_MouseDown);
			// 
			// buttonErase
			// 
			this.buttonErase.AutoSize = true;
			this.buttonErase.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonErase.FlatAppearance.BorderSize = 0;
			this.buttonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonErase.Location = new System.Drawing.Point(524, 7);
			this.buttonErase.Margin = new System.Windows.Forms.Padding(1);
			this.buttonErase.MaximumSize = new System.Drawing.Size(50, 50);
			this.buttonErase.Name = "buttonErase";
			this.buttonErase.Size = new System.Drawing.Size(38, 36);
			this.buttonErase.TabIndex = 107;
			this.buttonErase.Text = "🠴";
			this.toolTip1.SetToolTip(this.buttonErase, "ЛКМ — стереть символ\r\nПКМ — очистить");
			this.buttonErase.UseVisualStyleBackColor = false;
			this.buttonErase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonErase_MouseDown);
			// 
			// buttonEqual
			// 
			this.buttonEqual.AutoSize = true;
			this.buttonEqual.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonEqual.FlatAppearance.BorderSize = 0;
			this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEqual.Location = new System.Drawing.Point(484, 7);
			this.buttonEqual.Margin = new System.Windows.Forms.Padding(1);
			this.buttonEqual.MaximumSize = new System.Drawing.Size(50, 50);
			this.buttonEqual.Name = "buttonEqual";
			this.buttonEqual.Size = new System.Drawing.Size(38, 36);
			this.buttonEqual.TabIndex = 109;
			this.buttonEqual.Text = "=";
			this.toolTip1.SetToolTip(this.buttonEqual, "ЛКМ — посчитать\r\nЩелчек колесом мыши — скопировать результат\r\nПКМ — посчитать и с" +
        "охранить");
			this.buttonEqual.UseVisualStyleBackColor = false;
			this.buttonEqual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonEqual_MouseDown);
			// 
			// ordinary
			// 
			this.ordinary.Appearance = System.Windows.Forms.Appearance.Button;
			this.ordinary.FlatAppearance.BorderSize = 0;
			this.ordinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ordinary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ordinary.Location = new System.Drawing.Point(4, 52);
			this.ordinary.Margin = new System.Windows.Forms.Padding(1);
			this.ordinary.Name = "ordinary";
			this.ordinary.Size = new System.Drawing.Size(78, 38);
			this.ordinary.TabIndex = 88;
			this.ordinary.Text = "Ordinary";
			this.ordinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ordinary.UseVisualStyleBackColor = true;
			this.ordinary.CheckedChanged += new System.EventHandler(this.ordinary_CheckedChanged);
			// 
			// engeneer
			// 
			this.engeneer.Appearance = System.Windows.Forms.Appearance.Button;
			this.engeneer.Checked = true;
			this.engeneer.FlatAppearance.BorderSize = 0;
			this.engeneer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.engeneer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.engeneer.Location = new System.Drawing.Point(84, 52);
			this.engeneer.Margin = new System.Windows.Forms.Padding(1);
			this.engeneer.Name = "engeneer";
			this.engeneer.Size = new System.Drawing.Size(78, 38);
			this.engeneer.TabIndex = 87;
			this.engeneer.TabStop = true;
			this.engeneer.Text = "Engineer";
			this.engeneer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.engeneer.UseVisualStyleBackColor = true;
			this.engeneer.CheckedChanged += new System.EventHandler(this.engeneer_CheckedChanged);
			// 
			// buttonMod
			// 
			this.buttonMod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonMod.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonMod.FlatAppearance.BorderSize = 0;
			this.buttonMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonMod.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.buttonMod.Location = new System.Drawing.Point(4, 412);
			this.buttonMod.Margin = new System.Windows.Forms.Padding(1);
			this.buttonMod.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonMod.Name = "buttonMod";
			this.buttonMod.Size = new System.Drawing.Size(78, 78);
			this.buttonMod.TabIndex = 130;
			this.buttonMod.Text = "MOD";
			this.buttonMod.UseVisualStyleBackColor = false;
			this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
			// 
			// expression
			// 
			this.expression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.expression.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.expression.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.expression.Font = new System.Drawing.Font("Century Gothic", 22F);
			this.expression.Location = new System.Drawing.Point(2, 7);
			this.expression.Name = "expression";
			this.expression.ReadOnly = true;
			this.expression.Size = new System.Drawing.Size(480, 36);
			this.expression.TabIndex = 131;
			this.expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.expression.TextChanged += new System.EventHandler(this.expression_TextChanged);
			this.expression.Enter += new System.EventHandler(this.Expression_Enter);
			this.expression.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expression_MouseDown);
			// 
			// buttonRand
			// 
			this.buttonRand.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonRand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonRand.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonRand.FlatAppearance.BorderSize = 0;
			this.buttonRand.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonRand.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonRand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.buttonRand.Location = new System.Drawing.Point(324, 52);
			this.buttonRand.Margin = new System.Windows.Forms.Padding(1);
			this.buttonRand.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonRand.Name = "buttonRand";
			this.buttonRand.Size = new System.Drawing.Size(78, 38);
			this.buttonRand.TabIndex = 122;
			this.buttonRand.Text = "rand";
			this.buttonRand.UseVisualStyleBackColor = false;
			this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
			// 
			// isInverse
			// 
			this.isInverse.Appearance = System.Windows.Forms.Appearance.Button;
			this.isInverse.BackColor = System.Drawing.Color.Teal;
			this.isInverse.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.isInverse.FlatAppearance.BorderSize = 0;
			this.isInverse.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ScrollBar;
			this.isInverse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.isInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isInverse.Location = new System.Drawing.Point(484, 52);
			this.isInverse.Margin = new System.Windows.Forms.Padding(1);
			this.isInverse.Name = "isInverse";
			this.isInverse.Size = new System.Drawing.Size(78, 38);
			this.isInverse.TabIndex = 129;
			this.isInverse.Text = "2nd";
			this.isInverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.isInverse.UseVisualStyleBackColor = false;
			this.isInverse.CheckedChanged += new System.EventHandler(this.isInverse_CheckedChanged);
			// 
			// isRad
			// 
			this.isRad.Appearance = System.Windows.Forms.Appearance.Button;
			this.isRad.BackColor = System.Drawing.Color.Teal;
			this.isRad.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.isRad.FlatAppearance.BorderSize = 0;
			this.isRad.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ScrollBar;
			this.isRad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.isRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isRad.Location = new System.Drawing.Point(404, 52);
			this.isRad.Margin = new System.Windows.Forms.Padding(1);
			this.isRad.Name = "isRad";
			this.isRad.Size = new System.Drawing.Size(78, 38);
			this.isRad.TabIndex = 128;
			this.isRad.Text = "RAD";
			this.isRad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.isRad.UseVisualStyleBackColor = false;
			this.isRad.CheckedChanged += new System.EventHandler(this.isRad_CheckedChanged);
			// 
			// button10exp
			// 
			this.button10exp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button10exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button10exp.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button10exp.FlatAppearance.BorderSize = 0;
			this.button10exp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button10exp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button10exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.button10exp.Location = new System.Drawing.Point(484, 412);
			this.button10exp.Margin = new System.Windows.Forms.Padding(1);
			this.button10exp.MaximumSize = new System.Drawing.Size(84, 84);
			this.button10exp.Name = "button10exp";
			this.button10exp.Size = new System.Drawing.Size(78, 78);
			this.button10exp.TabIndex = 127;
			this.button10exp.Text = "10ʸ";
			this.button10exp.UseVisualStyleBackColor = false;
			this.button10exp.Click += new System.EventHandler(this.button10exp_Click);
			// 
			// buttonFactorial
			// 
			this.buttonFactorial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonFactorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonFactorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonFactorial.FlatAppearance.BorderSize = 0;
			this.buttonFactorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonFactorial.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFactorial.Location = new System.Drawing.Point(404, 412);
			this.buttonFactorial.Margin = new System.Windows.Forms.Padding(1);
			this.buttonFactorial.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonFactorial.Name = "buttonFactorial";
			this.buttonFactorial.Size = new System.Drawing.Size(78, 78);
			this.buttonFactorial.TabIndex = 126;
			this.buttonFactorial.Text = "x!";
			this.buttonFactorial.UseVisualStyleBackColor = false;
			this.buttonFactorial.Click += new System.EventHandler(this.buttonFactorial_Click);
			// 
			// buttonCubeRoot
			// 
			this.buttonCubeRoot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonCubeRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCubeRoot.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCubeRoot.FlatAppearance.BorderSize = 0;
			this.buttonCubeRoot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonCubeRoot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonCubeRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCubeRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCubeRoot.Location = new System.Drawing.Point(324, 412);
			this.buttonCubeRoot.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCubeRoot.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonCubeRoot.Name = "buttonCubeRoot";
			this.buttonCubeRoot.Size = new System.Drawing.Size(78, 78);
			this.buttonCubeRoot.TabIndex = 125;
			this.buttonCubeRoot.Text = "³√x";
			this.buttonCubeRoot.UseVisualStyleBackColor = false;
			this.buttonCubeRoot.Click += new System.EventHandler(this.buttonCubeRoot_Click);
			// 
			// buttonCube
			// 
			this.buttonCube.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonCube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCube.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCube.FlatAppearance.BorderSize = 0;
			this.buttonCube.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonCube.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCube.Location = new System.Drawing.Point(244, 412);
			this.buttonCube.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCube.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonCube.Name = "buttonCube";
			this.buttonCube.Size = new System.Drawing.Size(78, 78);
			this.buttonCube.TabIndex = 124;
			this.buttonCube.Text = "x³";
			this.buttonCube.UseVisualStyleBackColor = false;
			this.buttonCube.Click += new System.EventHandler(this.buttonCube_Click);
			// 
			// buttonExp
			// 
			this.buttonExp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonExp.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonExp.FlatAppearance.BorderSize = 0;
			this.buttonExp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonExp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.buttonExp.Location = new System.Drawing.Point(84, 412);
			this.buttonExp.Margin = new System.Windows.Forms.Padding(1);
			this.buttonExp.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonExp.Name = "buttonExp";
			this.buttonExp.Size = new System.Drawing.Size(78, 78);
			this.buttonExp.TabIndex = 123;
			this.buttonExp.Text = "exp";
			this.buttonExp.UseVisualStyleBackColor = false;
			this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
			// 
			// buttonXexpY
			// 
			this.buttonXexpY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonXexpY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonXexpY.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonXexpY.FlatAppearance.BorderSize = 0;
			this.buttonXexpY.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonXexpY.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonXexpY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonXexpY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonXexpY.Location = new System.Drawing.Point(164, 412);
			this.buttonXexpY.Margin = new System.Windows.Forms.Padding(1);
			this.buttonXexpY.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonXexpY.Name = "buttonXexpY";
			this.buttonXexpY.Size = new System.Drawing.Size(78, 78);
			this.buttonXexpY.TabIndex = 121;
			this.buttonXexpY.Text = "xʸ";
			this.buttonXexpY.UseVisualStyleBackColor = false;
			this.buttonXexpY.Click += new System.EventHandler(this.buttonXexpY_Click);
			// 
			// buttonCos
			// 
			this.buttonCos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCos.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCos.FlatAppearance.BorderSize = 0;
			this.buttonCos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonCos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.buttonCos.Location = new System.Drawing.Point(484, 92);
			this.buttonCos.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCos.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonCos.Name = "buttonCos";
			this.buttonCos.Size = new System.Drawing.Size(78, 78);
			this.buttonCos.TabIndex = 120;
			this.buttonCos.Text = "cos";
			this.buttonCos.UseVisualStyleBackColor = false;
			this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
			// 
			// buttonCot
			// 
			this.buttonCot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCot.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCot.FlatAppearance.BorderSize = 0;
			this.buttonCot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonCot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.buttonCot.Location = new System.Drawing.Point(484, 172);
			this.buttonCot.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCot.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonCot.Name = "buttonCot";
			this.buttonCot.Size = new System.Drawing.Size(78, 78);
			this.buttonCot.TabIndex = 119;
			this.buttonCot.Text = "cot";
			this.buttonCot.UseVisualStyleBackColor = false;
			this.buttonCot.Click += new System.EventHandler(this.buttonCot_Click);
			// 
			// buttonPI
			// 
			this.buttonPI.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonPI.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonPI.FlatAppearance.BorderSize = 0;
			this.buttonPI.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonPI.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPI.Location = new System.Drawing.Point(484, 252);
			this.buttonPI.Margin = new System.Windows.Forms.Padding(1);
			this.buttonPI.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonPI.Name = "buttonPI";
			this.buttonPI.Size = new System.Drawing.Size(78, 78);
			this.buttonPI.TabIndex = 118;
			this.buttonPI.Text = "π";
			this.buttonPI.UseVisualStyleBackColor = false;
			this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
			// 
			// buttonLog10
			// 
			this.buttonLog10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonLog10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonLog10.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonLog10.FlatAppearance.BorderSize = 0;
			this.buttonLog10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonLog10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonLog10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.buttonLog10.Location = new System.Drawing.Point(484, 332);
			this.buttonLog10.Margin = new System.Windows.Forms.Padding(1);
			this.buttonLog10.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonLog10.Name = "buttonLog10";
			this.buttonLog10.Size = new System.Drawing.Size(78, 78);
			this.buttonLog10.TabIndex = 117;
			this.buttonLog10.Text = "log₁₀";
			this.buttonLog10.UseVisualStyleBackColor = false;
			this.buttonLog10.Click += new System.EventHandler(this.buttonLog10_Click);
			// 
			// buttonSin
			// 
			this.buttonSin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSin.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSin.FlatAppearance.BorderSize = 0;
			this.buttonSin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonSin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.buttonSin.Location = new System.Drawing.Point(404, 92);
			this.buttonSin.Margin = new System.Windows.Forms.Padding(1);
			this.buttonSin.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonSin.Name = "buttonSin";
			this.buttonSin.Size = new System.Drawing.Size(78, 78);
			this.buttonSin.TabIndex = 116;
			this.buttonSin.Text = "sin";
			this.buttonSin.UseVisualStyleBackColor = false;
			this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
			// 
			// buttonTan
			// 
			this.buttonTan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonTan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonTan.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonTan.FlatAppearance.BorderSize = 0;
			this.buttonTan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonTan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.buttonTan.Location = new System.Drawing.Point(404, 172);
			this.buttonTan.Margin = new System.Windows.Forms.Padding(1);
			this.buttonTan.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonTan.Name = "buttonTan";
			this.buttonTan.Size = new System.Drawing.Size(78, 78);
			this.buttonTan.TabIndex = 115;
			this.buttonTan.Text = "tan";
			this.buttonTan.UseVisualStyleBackColor = false;
			this.buttonTan.Click += new System.EventHandler(this.buttonTan_Click);
			// 
			// buttonE
			// 
			this.buttonE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonE.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonE.FlatAppearance.BorderSize = 0;
			this.buttonE.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
			this.buttonE.Location = new System.Drawing.Point(404, 252);
			this.buttonE.Margin = new System.Windows.Forms.Padding(1);
			this.buttonE.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonE.Name = "buttonE";
			this.buttonE.Size = new System.Drawing.Size(78, 78);
			this.buttonE.TabIndex = 114;
			this.buttonE.Text = "e";
			this.buttonE.UseVisualStyleBackColor = false;
			this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
			// 
			// buttonLn
			// 
			this.buttonLn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonLn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonLn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonLn.FlatAppearance.BorderSize = 0;
			this.buttonLn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonLn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLn.Location = new System.Drawing.Point(404, 332);
			this.buttonLn.Margin = new System.Windows.Forms.Padding(1);
			this.buttonLn.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonLn.Name = "buttonLn";
			this.buttonLn.Size = new System.Drawing.Size(78, 78);
			this.buttonLn.TabIndex = 113;
			this.buttonLn.Text = "ln";
			this.buttonLn.UseVisualStyleBackColor = false;
			this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
			// 
			// buttonInvert
			// 
			this.buttonInvert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonInvert.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonInvert.FlatAppearance.BorderSize = 0;
			this.buttonInvert.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonInvert.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonInvert.Location = new System.Drawing.Point(324, 92);
			this.buttonInvert.Margin = new System.Windows.Forms.Padding(1);
			this.buttonInvert.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonInvert.Name = "buttonInvert";
			this.buttonInvert.Size = new System.Drawing.Size(78, 78);
			this.buttonInvert.TabIndex = 112;
			this.buttonInvert.Text = "1/x";
			this.buttonInvert.UseVisualStyleBackColor = false;
			this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
			// 
			// buttonSubstract
			// 
			this.buttonSubstract.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSubstract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSubstract.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSubstract.FlatAppearance.BorderSize = 0;
			this.buttonSubstract.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonSubstract.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSubstract.Location = new System.Drawing.Point(324, 252);
			this.buttonSubstract.Margin = new System.Windows.Forms.Padding(1);
			this.buttonSubstract.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonSubstract.Name = "buttonSubstract";
			this.buttonSubstract.Size = new System.Drawing.Size(78, 78);
			this.buttonSubstract.TabIndex = 111;
			this.buttonSubstract.Text = "—";
			this.buttonSubstract.UseVisualStyleBackColor = false;
			this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
			// 
			// buttonSqrt
			// 
			this.buttonSqrt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSqrt.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSqrt.FlatAppearance.BorderSize = 0;
			this.buttonSqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSqrt.Location = new System.Drawing.Point(324, 332);
			this.buttonSqrt.Margin = new System.Windows.Forms.Padding(1);
			this.buttonSqrt.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonSqrt.Name = "buttonSqrt";
			this.buttonSqrt.Size = new System.Drawing.Size(78, 78);
			this.buttonSqrt.TabIndex = 110;
			this.buttonSqrt.Text = "√x";
			this.buttonSqrt.UseVisualStyleBackColor = false;
			this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
			// 
			// buttonDivide
			// 
			this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonDivide.FlatAppearance.BorderSize = 0;
			this.buttonDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonDivide.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDivide.Location = new System.Drawing.Point(324, 172);
			this.buttonDivide.Margin = new System.Windows.Forms.Padding(1);
			this.buttonDivide.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(78, 78);
			this.buttonDivide.TabIndex = 108;
			this.buttonDivide.Text = "/";
			this.buttonDivide.UseVisualStyleBackColor = false;
			this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.Location = new System.Drawing.Point(4, 92);
			this.button7.Margin = new System.Windows.Forms.Padding(1);
			this.button7.MaximumSize = new System.Drawing.Size(84, 84);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(78, 78);
			this.button7.TabIndex = 106;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.Location = new System.Drawing.Point(84, 92);
			this.button8.Margin = new System.Windows.Forms.Padding(1);
			this.button8.MaximumSize = new System.Drawing.Size(84, 84);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(78, 78);
			this.button8.TabIndex = 104;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(84, 172);
			this.button5.Margin = new System.Windows.Forms.Padding(1);
			this.button5.MaximumSize = new System.Drawing.Size(84, 84);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(78, 78);
			this.button5.TabIndex = 103;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// buttonMultiply
			// 
			this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonMultiply.FlatAppearance.BorderSize = 0;
			this.buttonMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMultiply.Location = new System.Drawing.Point(244, 172);
			this.buttonMultiply.Margin = new System.Windows.Forms.Padding(1);
			this.buttonMultiply.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.Size = new System.Drawing.Size(78, 78);
			this.buttonMultiply.TabIndex = 102;
			this.buttonMultiply.Text = "×";
			this.buttonMultiply.UseVisualStyleBackColor = false;
			this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(164, 172);
			this.button6.Margin = new System.Windows.Forms.Padding(1);
			this.button6.MaximumSize = new System.Drawing.Size(84, 84);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(78, 78);
			this.button6.TabIndex = 101;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// buttonSqr
			// 
			this.buttonSqr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonSqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSqr.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSqr.FlatAppearance.BorderSize = 0;
			this.buttonSqr.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonSqr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSqr.Location = new System.Drawing.Point(244, 332);
			this.buttonSqr.Margin = new System.Windows.Forms.Padding(1);
			this.buttonSqr.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonSqr.Name = "buttonSqr";
			this.buttonSqr.Size = new System.Drawing.Size(78, 78);
			this.buttonSqr.TabIndex = 100;
			this.buttonSqr.Text = "x²";
			this.buttonSqr.UseVisualStyleBackColor = false;
			this.buttonSqr.Click += new System.EventHandler(this.buttonSqr_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(4, 172);
			this.button4.Margin = new System.Windows.Forms.Padding(1);
			this.button4.MaximumSize = new System.Drawing.Size(84, 84);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(78, 78);
			this.button4.TabIndex = 99;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(244, 252);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonAdd.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(78, 78);
			this.buttonAdd.TabIndex = 98;
			this.buttonAdd.Text = "+";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(84, 252);
			this.button2.Margin = new System.Windows.Forms.Padding(1);
			this.button2.MaximumSize = new System.Drawing.Size(84, 84);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 78);
			this.button2.TabIndex = 97;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonProcent
			// 
			this.buttonProcent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonProcent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonProcent.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonProcent.FlatAppearance.BorderSize = 0;
			this.buttonProcent.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonProcent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonProcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonProcent.Location = new System.Drawing.Point(244, 92);
			this.buttonProcent.Margin = new System.Windows.Forms.Padding(1);
			this.buttonProcent.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonProcent.Name = "buttonProcent";
			this.buttonProcent.Size = new System.Drawing.Size(78, 78);
			this.buttonProcent.TabIndex = 96;
			this.buttonProcent.Text = "%";
			this.buttonProcent.UseVisualStyleBackColor = false;
			this.buttonProcent.Click += new System.EventHandler(this.buttonProcent_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(4, 252);
			this.button1.Margin = new System.Windows.Forms.Padding(1);
			this.button1.MaximumSize = new System.Drawing.Size(84, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 78);
			this.button1.TabIndex = 95;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(164, 252);
			this.button3.Margin = new System.Windows.Forms.Padding(1);
			this.button3.MaximumSize = new System.Drawing.Size(84, 84);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(78, 78);
			this.button3.TabIndex = 94;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button0
			// 
			this.button0.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button0.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button0.FlatAppearance.BorderSize = 0;
			this.button0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.Location = new System.Drawing.Point(84, 332);
			this.button0.Margin = new System.Windows.Forms.Padding(1);
			this.button0.MaximumSize = new System.Drawing.Size(84, 84);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(78, 78);
			this.button0.TabIndex = 93;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = false;
			this.button0.Click += new System.EventHandler(this.button0_Click);
			// 
			// buttonDot
			// 
			this.buttonDot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonDot.FlatAppearance.BorderSize = 0;
			this.buttonDot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonDot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDot.Location = new System.Drawing.Point(164, 332);
			this.buttonDot.Margin = new System.Windows.Forms.Padding(1);
			this.buttonDot.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonDot.Name = "buttonDot";
			this.buttonDot.Size = new System.Drawing.Size(78, 78);
			this.buttonDot.TabIndex = 92;
			this.buttonDot.Text = ".";
			this.buttonDot.UseVisualStyleBackColor = false;
			this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
			// 
			// buttonNegative
			// 
			this.buttonNegative.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonNegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonNegative.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonNegative.FlatAppearance.BorderSize = 0;
			this.buttonNegative.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonNegative.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNegative.Location = new System.Drawing.Point(4, 332);
			this.buttonNegative.Margin = new System.Windows.Forms.Padding(1);
			this.buttonNegative.MaximumSize = new System.Drawing.Size(84, 84);
			this.buttonNegative.Name = "buttonNegative";
			this.buttonNegative.Size = new System.Drawing.Size(78, 78);
			this.buttonNegative.TabIndex = 91;
			this.buttonNegative.Text = "+/-";
			this.buttonNegative.UseVisualStyleBackColor = false;
			this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.Location = new System.Drawing.Point(164, 92);
			this.button9.Margin = new System.Windows.Forms.Padding(1);
			this.button9.MaximumSize = new System.Drawing.Size(84, 84);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(78, 78);
			this.button9.TabIndex = 105;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonEqual;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(564, 493);
			this.Controls.Add(this.ordinary);
			this.Controls.Add(this.engeneer);
			this.Controls.Add(this.Memory);
			this.Controls.Add(this.buttonMemoryAddSubstract);
			this.Controls.Add(this.buttonMod);
			this.Controls.Add(this.expression);
			this.Controls.Add(this.buttonRand);
			this.Controls.Add(this.isInverse);
			this.Controls.Add(this.isRad);
			this.Controls.Add(this.button10exp);
			this.Controls.Add(this.buttonFactorial);
			this.Controls.Add(this.buttonCubeRoot);
			this.Controls.Add(this.buttonCube);
			this.Controls.Add(this.buttonExp);
			this.Controls.Add(this.buttonXexpY);
			this.Controls.Add(this.buttonCos);
			this.Controls.Add(this.buttonCot);
			this.Controls.Add(this.buttonPI);
			this.Controls.Add(this.buttonLog10);
			this.Controls.Add(this.buttonSin);
			this.Controls.Add(this.buttonTan);
			this.Controls.Add(this.buttonE);
			this.Controls.Add(this.buttonLn);
			this.Controls.Add(this.buttonErase);
			this.Controls.Add(this.buttonEqual);
			this.Controls.Add(this.buttonInvert);
			this.Controls.Add(this.buttonSubstract);
			this.Controls.Add(this.buttonSqrt);
			this.Controls.Add(this.buttonDivide);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.buttonMultiply);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.buttonSqr);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonProcent);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.buttonDot);
			this.Controls.Add(this.buttonNegative);
			this.Controls.Add(this.button9);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(580, 532);
			this.MinimumSize = new System.Drawing.Size(419, 451);
			this.Name = "Form1";
			this.Text = "Калькулятор";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private ToolTip toolTip1;
		private RadioButton ordinary;
		private RadioButton engeneer;
		private Label Memory;
		private Button buttonMemoryAddSubstract;
		private Button buttonMod;
		private TextBox expression;
		private Button buttonRand;
		private CheckBox isInverse;
		private CheckBox isRad;
		private Button button10exp;
		private Button buttonFactorial;
		private Button buttonCubeRoot;
		private Button buttonCube;
		private Button buttonExp;
		private Button buttonXexpY;
		private Button buttonCos;
		private Button buttonCot;
		private Button buttonPI;
		private Button buttonLog10;
		private Button buttonSin;
		private Button buttonTan;
		private Button buttonE;
		private Button buttonLn;
		private Button buttonErase;
		private Button buttonEqual;
		private Button buttonInvert;
		private Button buttonSubstract;
		private Button buttonSqrt;
		private Button buttonDivide;
		private Button button7;
		private Button button8;
		private Button button5;
		private Button buttonMultiply;
		private Button button6;
		private Button buttonSqr;
		private Button button4;
		private Button buttonAdd;
		private Button button2;
		private Button buttonProcent;
		private Button button1;
		private Button button3;
		private Button button0;
		private Button buttonDot;
		private Button buttonNegative;
		private Button button9;
	}
}

