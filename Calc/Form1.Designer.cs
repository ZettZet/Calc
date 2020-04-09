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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonMemoryAddSubstract = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Label();
            this.ordinary = new System.Windows.Forms.RadioButton();
            this.engeneer = new System.Windows.Forms.RadioButton();
            this.matrix = new System.Windows.Forms.RadioButton();
            this.isInverse = new System.Windows.Forms.CheckBox();
            this.isRad = new System.Windows.Forms.CheckBox();
            this.button10exp = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonCubeRoot = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonRand = new System.Windows.Forms.Button();
            this.buttonXexpY = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonCot = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonLog10 = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.expression = new System.Windows.Forms.Label();
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
            this.MatrixPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Mult = new System.Windows.Forms.Button();
            this.inputIn = new System.Windows.Forms.Button();
            this.clearMatrix = new System.Windows.Forms.Button();
            this.diagonal = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.powerMatrix = new System.Windows.Forms.Button();
            this.triangular = new System.Windows.Forms.Button();
            this.transpose = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.matrixMultiply = new System.Windows.Forms.Button();
            this.inversMatrix = new System.Windows.Forms.Button();
            this.determinant = new System.Windows.Forms.Button();
            this.MatrixOperandA = new System.Windows.Forms.DataGridView();
            this.MatrixOperandB = new System.Windows.Forms.DataGridView();
            this.MatrixAnswer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MatrixPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOperandA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOperandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.buttonMemoryAddSubstract);
            this.splitContainer1.Panel1.Controls.Add(this.Memory);
            this.splitContainer1.Panel1.Controls.Add(this.ordinary);
            this.splitContainer1.Panel1.Controls.Add(this.engeneer);
            this.splitContainer1.Panel1.Controls.Add(this.matrix);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel2.Controls.Add(this.isInverse);
            this.splitContainer1.Panel2.Controls.Add(this.isRad);
            this.splitContainer1.Panel2.Controls.Add(this.button10exp);
            this.splitContainer1.Panel2.Controls.Add(this.buttonFactorial);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCubeRoot);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCube);
            this.splitContainer1.Panel2.Controls.Add(this.buttonExp);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRand);
            this.splitContainer1.Panel2.Controls.Add(this.buttonXexpY);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCos);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCot);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPI);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLog10);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSin);
            this.splitContainer1.Panel2.Controls.Add(this.buttonTan);
            this.splitContainer1.Panel2.Controls.Add(this.buttonE);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonErase);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEqual);
            this.splitContainer1.Panel2.Controls.Add(this.expression);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInvert);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSubstract);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSqrt);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDivide);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.buttonMultiply);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSqr);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonProcent);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button0);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDot);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNegative);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(702, 456);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonMemoryAddSubstract
            // 
            this.buttonMemoryAddSubstract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMemoryAddSubstract.AutoSize = true;
            this.buttonMemoryAddSubstract.FlatAppearance.BorderSize = 0;
            this.buttonMemoryAddSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryAddSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemoryAddSubstract.Location = new System.Drawing.Point(12, 173);
            this.buttonMemoryAddSubstract.MaximumSize = new System.Drawing.Size(70, 43);
            this.buttonMemoryAddSubstract.MinimumSize = new System.Drawing.Size(70, 43);
            this.buttonMemoryAddSubstract.Name = "buttonMemoryAddSubstract";
            this.buttonMemoryAddSubstract.Size = new System.Drawing.Size(70, 43);
            this.buttonMemoryAddSubstract.TabIndex = 11;
            this.buttonMemoryAddSubstract.Text = "+/-";
            this.buttonMemoryAddSubstract.UseVisualStyleBackColor = true;
            this.buttonMemoryAddSubstract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMemoryAddSubstract_MouseDown);
            this.buttonMemoryAddSubstract.MouseHover += new System.EventHandler(this.buttonMemoryAddSubstract_MouseHover);
            // 
            // Memory
            // 
            this.Memory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Memory.AutoSize = true;
            this.Memory.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Memory.Location = new System.Drawing.Point(14, 134);
            this.Memory.MinimumSize = new System.Drawing.Size(31, 36);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(31, 36);
            this.Memory.TabIndex = 10;
            this.Memory.Text = "0";
            this.Memory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Memory_MouseDown);
            this.Memory.MouseHover += new System.EventHandler(this.Memory_MouseHover);
            // 
            // ordinary
            // 
            this.ordinary.Appearance = System.Windows.Forms.Appearance.Button;
            this.ordinary.Checked = true;
            this.ordinary.FlatAppearance.BorderSize = 0;
            this.ordinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordinary.Location = new System.Drawing.Point(10, 8);
            this.ordinary.Name = "ordinary";
            this.ordinary.Size = new System.Drawing.Size(113, 36);
            this.ordinary.TabIndex = 8;
            this.ordinary.TabStop = true;
            this.ordinary.Text = "Стандартный";
            this.ordinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ordinary.UseVisualStyleBackColor = true;
            this.ordinary.CheckedChanged += new System.EventHandler(this.ordinary_CheckedChanged);
            // 
            // engeneer
            // 
            this.engeneer.Appearance = System.Windows.Forms.Appearance.Button;
            this.engeneer.FlatAppearance.BorderSize = 0;
            this.engeneer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engeneer.Location = new System.Drawing.Point(10, 50);
            this.engeneer.Name = "engeneer";
            this.engeneer.Size = new System.Drawing.Size(113, 36);
            this.engeneer.TabIndex = 5;
            this.engeneer.Text = "Инженерный";
            this.engeneer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.engeneer.UseVisualStyleBackColor = true;
            this.engeneer.CheckedChanged += new System.EventHandler(this.engeneer_CheckedChanged);
            // 
            // matrix
            // 
            this.matrix.Appearance = System.Windows.Forms.Appearance.Button;
            this.matrix.FlatAppearance.BorderSize = 0;
            this.matrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrix.Location = new System.Drawing.Point(10, 92);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(113, 36);
            this.matrix.TabIndex = 7;
            this.matrix.Text = "Матричный";
            this.matrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.matrix.UseVisualStyleBackColor = true;
            this.matrix.CheckedChanged += new System.EventHandler(this.matrix_CheckedChanged);
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
            this.isInverse.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isInverse.Location = new System.Drawing.Point(484, 10);
            this.isInverse.Name = "isInverse";
            this.isInverse.Size = new System.Drawing.Size(78, 36);
            this.isInverse.TabIndex = 80;
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
            this.isRad.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isRad.Location = new System.Drawing.Point(404, 10);
            this.isRad.Name = "isRad";
            this.isRad.Size = new System.Drawing.Size(78, 36);
            this.isRad.TabIndex = 79;
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
            this.button10exp.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.button10exp.Location = new System.Drawing.Point(484, 373);
            this.button10exp.Margin = new System.Windows.Forms.Padding(1);
            this.button10exp.MaximumSize = new System.Drawing.Size(84, 84);
            this.button10exp.Name = "button10exp";
            this.button10exp.Size = new System.Drawing.Size(78, 78);
            this.button10exp.TabIndex = 78;
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
            this.buttonFactorial.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFactorial.Location = new System.Drawing.Point(404, 373);
            this.buttonFactorial.Margin = new System.Windows.Forms.Padding(1);
            this.buttonFactorial.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(78, 78);
            this.buttonFactorial.TabIndex = 77;
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
            this.buttonCubeRoot.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCubeRoot.Location = new System.Drawing.Point(324, 373);
            this.buttonCubeRoot.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCubeRoot.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonCubeRoot.Name = "buttonCubeRoot";
            this.buttonCubeRoot.Size = new System.Drawing.Size(78, 78);
            this.buttonCubeRoot.TabIndex = 76;
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
            this.buttonCube.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCube.Location = new System.Drawing.Point(244, 373);
            this.buttonCube.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCube.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(78, 78);
            this.buttonCube.TabIndex = 75;
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
            this.buttonExp.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.buttonExp.Location = new System.Drawing.Point(84, 373);
            this.buttonExp.Margin = new System.Windows.Forms.Padding(1);
            this.buttonExp.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(78, 78);
            this.buttonExp.TabIndex = 74;
            this.buttonExp.Text = "exp";
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
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
            this.buttonRand.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonRand.Location = new System.Drawing.Point(4, 373);
            this.buttonRand.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRand.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(78, 78);
            this.buttonRand.TabIndex = 73;
            this.buttonRand.Text = "rand";
            this.buttonRand.UseVisualStyleBackColor = false;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
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
            this.buttonXexpY.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXexpY.Location = new System.Drawing.Point(164, 373);
            this.buttonXexpY.Margin = new System.Windows.Forms.Padding(1);
            this.buttonXexpY.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonXexpY.Name = "buttonXexpY";
            this.buttonXexpY.Size = new System.Drawing.Size(78, 78);
            this.buttonXexpY.TabIndex = 72;
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
            this.buttonCos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonCos.Location = new System.Drawing.Point(484, 53);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCos.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(78, 78);
            this.buttonCos.TabIndex = 71;
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
            this.buttonCot.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonCot.Location = new System.Drawing.Point(484, 133);
            this.buttonCot.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCot.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonCot.Name = "buttonCot";
            this.buttonCot.Size = new System.Drawing.Size(78, 78);
            this.buttonCot.TabIndex = 70;
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
            this.buttonPI.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPI.Location = new System.Drawing.Point(484, 213);
            this.buttonPI.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPI.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(78, 78);
            this.buttonPI.TabIndex = 69;
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
            this.buttonLog10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonLog10.Location = new System.Drawing.Point(484, 293);
            this.buttonLog10.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLog10.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonLog10.Name = "buttonLog10";
            this.buttonLog10.Size = new System.Drawing.Size(78, 78);
            this.buttonLog10.TabIndex = 68;
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
            this.buttonSin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSin.Location = new System.Drawing.Point(404, 53);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSin.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(78, 78);
            this.buttonSin.TabIndex = 67;
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
            this.buttonTan.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.buttonTan.Location = new System.Drawing.Point(404, 133);
            this.buttonTan.Margin = new System.Windows.Forms.Padding(1);
            this.buttonTan.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(78, 78);
            this.buttonTan.TabIndex = 66;
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
            this.buttonE.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.buttonE.Location = new System.Drawing.Point(404, 213);
            this.buttonE.Margin = new System.Windows.Forms.Padding(1);
            this.buttonE.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(78, 78);
            this.buttonE.TabIndex = 65;
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
            this.buttonLn.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.Location = new System.Drawing.Point(404, 293);
            this.buttonLn.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLn.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(78, 78);
            this.buttonLn.TabIndex = 64;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.AutoSize = true;
            this.buttonErase.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonErase.FlatAppearance.BorderSize = 0;
            this.buttonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonErase.Location = new System.Drawing.Point(352, 10);
            this.buttonErase.Margin = new System.Windows.Forms.Padding(2);
            this.buttonErase.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(50, 36);
            this.buttonErase.TabIndex = 58;
            this.buttonErase.Text = "🠴";
            this.buttonErase.UseVisualStyleBackColor = false;
            this.buttonErase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonErase_MouseDown);
            this.buttonErase.MouseHover += new System.EventHandler(this.buttonErase_MouseHover);
            // 
            // buttonEqual
            // 
            this.buttonEqual.AutoSize = true;
            this.buttonEqual.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(298, 10);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqual.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(50, 36);
            this.buttonEqual.TabIndex = 60;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonEqual_MouseDown);
            this.buttonEqual.MouseHover += new System.EventHandler(this.buttonEqual_MouseHover);
            // 
            // expression
            // 
            this.expression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expression.AutoSize = true;
            this.expression.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.expression.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.expression.Location = new System.Drawing.Point(12, 10);
            this.expression.Margin = new System.Windows.Forms.Padding(2);
            this.expression.MaximumSize = new System.Drawing.Size(282, 36);
            this.expression.MinimumSize = new System.Drawing.Size(282, 36);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(282, 36);
            this.expression.TabIndex = 49;
            this.expression.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.expression.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expression_MouseDown);
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
            this.buttonInvert.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInvert.Location = new System.Drawing.Point(324, 53);
            this.buttonInvert.Margin = new System.Windows.Forms.Padding(1);
            this.buttonInvert.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(78, 78);
            this.buttonInvert.TabIndex = 63;
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
            this.buttonSubstract.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubstract.Location = new System.Drawing.Point(324, 213);
            this.buttonSubstract.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSubstract.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(78, 78);
            this.buttonSubstract.TabIndex = 62;
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
            this.buttonSqrt.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.Location = new System.Drawing.Point(324, 293);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSqrt.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(78, 78);
            this.buttonSqrt.TabIndex = 61;
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
            this.buttonDivide.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(324, 133);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDivide.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(78, 78);
            this.buttonDivide.TabIndex = 59;
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
            this.button7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(4, 53);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.MaximumSize = new System.Drawing.Size(84, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 78);
            this.button7.TabIndex = 57;
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
            this.button8.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(84, 53);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.MaximumSize = new System.Drawing.Size(84, 84);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 78);
            this.button8.TabIndex = 55;
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
            this.button5.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(84, 133);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.MaximumSize = new System.Drawing.Size(84, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 78);
            this.button5.TabIndex = 54;
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
            this.buttonMultiply.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(244, 133);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMultiply.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(78, 78);
            this.buttonMultiply.TabIndex = 53;
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
            this.button6.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(164, 133);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.MaximumSize = new System.Drawing.Size(84, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 78);
            this.button6.TabIndex = 52;
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
            this.buttonSqr.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqr.Location = new System.Drawing.Point(244, 293);
            this.buttonSqr.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSqr.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(78, 78);
            this.buttonSqr.TabIndex = 51;
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
            this.button4.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(4, 133);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.MaximumSize = new System.Drawing.Size(84, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 78);
            this.button4.TabIndex = 50;
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
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(244, 213);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 78);
            this.buttonAdd.TabIndex = 48;
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
            this.button2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(84, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.MaximumSize = new System.Drawing.Size(84, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 78);
            this.button2.TabIndex = 47;
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
            this.buttonProcent.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProcent.Location = new System.Drawing.Point(244, 53);
            this.buttonProcent.Margin = new System.Windows.Forms.Padding(1);
            this.buttonProcent.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonProcent.Name = "buttonProcent";
            this.buttonProcent.Size = new System.Drawing.Size(78, 78);
            this.buttonProcent.TabIndex = 46;
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
            this.button1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(4, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.MaximumSize = new System.Drawing.Size(84, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 78);
            this.button1.TabIndex = 45;
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
            this.button3.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(164, 213);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.MaximumSize = new System.Drawing.Size(84, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 78);
            this.button3.TabIndex = 44;
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
            this.button0.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(84, 293);
            this.button0.Margin = new System.Windows.Forms.Padding(1);
            this.button0.MaximumSize = new System.Drawing.Size(84, 84);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 78);
            this.button0.TabIndex = 43;
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
            this.buttonDot.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(164, 293);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDot.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(78, 78);
            this.buttonDot.TabIndex = 42;
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
            this.buttonNegative.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNegative.Location = new System.Drawing.Point(4, 293);
            this.buttonNegative.Margin = new System.Windows.Forms.Padding(1);
            this.buttonNegative.MaximumSize = new System.Drawing.Size(84, 84);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(78, 78);
            this.buttonNegative.TabIndex = 41;
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
            this.button9.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(164, 53);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.MaximumSize = new System.Drawing.Size(84, 84);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 78);
            this.button9.TabIndex = 56;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MatrixPanel.Controls.Add(this.splitContainer2);
            this.MatrixPanel.Location = new System.Drawing.Point(131, 0);
            this.MatrixPanel.MaximumSize = new System.Drawing.Size(571, 456);
            this.MatrixPanel.MinimumSize = new System.Drawing.Size(571, 456);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(571, 456);
            this.MatrixPanel.TabIndex = 81;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MatrixOperandB);
            this.splitContainer2.Panel1.Controls.Add(this.MatrixOperandA);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MatrixAnswer);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDown2);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer2.Panel2.Controls.Add(this.Mult);
            this.splitContainer2.Panel2.Controls.Add(this.inputIn);
            this.splitContainer2.Panel2.Controls.Add(this.clearMatrix);
            this.splitContainer2.Panel2.Controls.Add(this.diagonal);
            this.splitContainer2.Panel2.Controls.Add(this.Sub);
            this.splitContainer2.Panel2.Controls.Add(this.powerMatrix);
            this.splitContainer2.Panel2.Controls.Add(this.triangular);
            this.splitContainer2.Panel2.Controls.Add(this.transpose);
            this.splitContainer2.Panel2.Controls.Add(this.Add);
            this.splitContainer2.Panel2.Controls.Add(this.matrixMultiply);
            this.splitContainer2.Panel2.Controls.Add(this.inversMatrix);
            this.splitContainer2.Panel2.Controls.Add(this.determinant);
            this.splitContainer2.Size = new System.Drawing.Size(571, 456);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(298, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(254, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown2.Location = new System.Drawing.Point(180, 94);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(30, 23);
            this.numericUpDown2.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(147, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 23);
            this.numericUpDown1.TabIndex = 15;
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Mult.FlatAppearance.BorderSize = 0;
            this.Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mult.Location = new System.Drawing.Point(212, 148);
            this.Mult.Margin = new System.Windows.Forms.Padding(2);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(66, 66);
            this.Mult.TabIndex = 14;
            this.Mult.Text = "A×B";
            this.Mult.UseVisualStyleBackColor = false;
            // 
            // inputIn
            // 
            this.inputIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputIn.FlatAppearance.BorderSize = 0;
            this.inputIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputIn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputIn.Location = new System.Drawing.Point(144, 148);
            this.inputIn.Margin = new System.Windows.Forms.Padding(2);
            this.inputIn.Name = "inputIn";
            this.inputIn.Size = new System.Drawing.Size(66, 66);
            this.inputIn.TabIndex = 13;
            this.inputIn.Text = "in A/B";
            this.inputIn.UseVisualStyleBackColor = false;
            // 
            // clearMatrix
            // 
            this.clearMatrix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearMatrix.FlatAppearance.BorderSize = 0;
            this.clearMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMatrix.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.clearMatrix.Location = new System.Drawing.Point(76, 148);
            this.clearMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.clearMatrix.Name = "clearMatrix";
            this.clearMatrix.Size = new System.Drawing.Size(66, 66);
            this.clearMatrix.TabIndex = 12;
            this.clearMatrix.Text = "Clear A/B";
            this.clearMatrix.UseVisualStyleBackColor = false;
            // 
            // diagonal
            // 
            this.diagonal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diagonal.FlatAppearance.BorderSize = 0;
            this.diagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diagonal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.diagonal.Location = new System.Drawing.Point(8, 148);
            this.diagonal.Margin = new System.Windows.Forms.Padding(2);
            this.diagonal.Name = "diagonal";
            this.diagonal.Size = new System.Drawing.Size(66, 66);
            this.diagonal.TabIndex = 11;
            this.diagonal.Text = "diag A/B";
            this.diagonal.UseVisualStyleBackColor = false;
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sub.FlatAppearance.BorderSize = 0;
            this.Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(212, 80);
            this.Sub.Margin = new System.Windows.Forms.Padding(2);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(66, 66);
            this.Sub.TabIndex = 10;
            this.Sub.Text = "A-B";
            this.Sub.UseVisualStyleBackColor = false;
            // 
            // powerMatrix
            // 
            this.powerMatrix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.powerMatrix.FlatAppearance.BorderSize = 0;
            this.powerMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerMatrix.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.powerMatrix.Location = new System.Drawing.Point(144, 80);
            this.powerMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.powerMatrix.Name = "powerMatrix";
            this.powerMatrix.Size = new System.Drawing.Size(66, 66);
            this.powerMatrix.TabIndex = 9;
            this.powerMatrix.Text = "A/B";
            this.powerMatrix.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.powerMatrix.UseVisualStyleBackColor = false;
            // 
            // triangular
            // 
            this.triangular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.triangular.FlatAppearance.BorderSize = 0;
            this.triangular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangular.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.triangular.Location = new System.Drawing.Point(76, 80);
            this.triangular.Margin = new System.Windows.Forms.Padding(2);
            this.triangular.Name = "triangular";
            this.triangular.Size = new System.Drawing.Size(66, 66);
            this.triangular.TabIndex = 8;
            this.triangular.Text = "triag A/B";
            this.triangular.UseVisualStyleBackColor = false;
            // 
            // transpose
            // 
            this.transpose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.transpose.FlatAppearance.BorderSize = 0;
            this.transpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transpose.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.transpose.Location = new System.Drawing.Point(8, 80);
            this.transpose.Margin = new System.Windows.Forms.Padding(2);
            this.transpose.Name = "transpose";
            this.transpose.Size = new System.Drawing.Size(66, 66);
            this.transpose.TabIndex = 7;
            this.transpose.Text = "Aᵀ/Bᵀ";
            this.transpose.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(212, 12);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 66);
            this.Add.TabIndex = 6;
            this.Add.Text = "A+B";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // matrixMultiply
            // 
            this.matrixMultiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.matrixMultiply.FlatAppearance.BorderSize = 0;
            this.matrixMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrixMultiply.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.matrixMultiply.Location = new System.Drawing.Point(144, 12);
            this.matrixMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.matrixMultiply.Name = "matrixMultiply";
            this.matrixMultiply.Size = new System.Drawing.Size(66, 66);
            this.matrixMultiply.TabIndex = 5;
            this.matrixMultiply.Text = "    ×A/B";
            this.matrixMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.matrixMultiply.UseVisualStyleBackColor = false;
            // 
            // inversMatrix
            // 
            this.inversMatrix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inversMatrix.FlatAppearance.BorderSize = 0;
            this.inversMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inversMatrix.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.inversMatrix.Location = new System.Drawing.Point(76, 12);
            this.inversMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.inversMatrix.Name = "inversMatrix";
            this.inversMatrix.Size = new System.Drawing.Size(66, 66);
            this.inversMatrix.TabIndex = 4;
            this.inversMatrix.Text = "A⁻¹/B⁻¹";
            this.inversMatrix.UseVisualStyleBackColor = false;
            // 
            // determinant
            // 
            this.determinant.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.determinant.FlatAppearance.BorderSize = 0;
            this.determinant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.determinant.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.determinant.Location = new System.Drawing.Point(8, 12);
            this.determinant.Margin = new System.Windows.Forms.Padding(2);
            this.determinant.Name = "determinant";
            this.determinant.Size = new System.Drawing.Size(66, 66);
            this.determinant.TabIndex = 3;
            this.determinant.Text = "det A/B";
            this.determinant.UseVisualStyleBackColor = false;
            this.determinant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.determinant_MouseDown);
            // 
            // MatrixOperandA
            // 
            this.MatrixOperandA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixOperandA.Location = new System.Drawing.Point(8, 3);
            this.MatrixOperandA.Name = "MatrixOperandA";
            this.MatrixOperandA.Size = new System.Drawing.Size(240, 217);
            this.MatrixOperandA.TabIndex = 4;
            // 
            // MatrixOperandB
            // 
            this.MatrixOperandB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixOperandB.Location = new System.Drawing.Point(326, 3);
            this.MatrixOperandB.Name = "MatrixOperandB";
            this.MatrixOperandB.Size = new System.Drawing.Size(240, 217);
            this.MatrixOperandB.TabIndex = 5;
            // 
            // MatrixAnswer
            // 
            this.MatrixAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixAnswer.Location = new System.Drawing.Point(326, 4);
            this.MatrixAnswer.Name = "MatrixAnswer";
            this.MatrixAnswer.Size = new System.Drawing.Size(240, 217);
            this.MatrixAnswer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.MatrixPanel);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(718, 495);
            this.MinimumSize = new System.Drawing.Size(558, 415);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MatrixPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOperandA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOperandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton engeneer;
        private System.Windows.Forms.RadioButton matrix;
        private System.Windows.Forms.RadioButton ordinary;
        private System.Windows.Forms.Label Memory;
        private Button buttonMemoryAddSubstract;
        private CheckBox isInverse;
        private CheckBox isRad;
        private Button button10exp;
        private Button buttonFactorial;
        private Button buttonCubeRoot;
        private Button buttonCube;
        private Button buttonExp;
        private Button buttonRand;
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
        private Label expression;
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
        private Panel MatrixPanel;
        private SplitContainer splitContainer2;
        private Label label2;
        private Label label1;
        private Button Mult;
        private Button inputIn;
        private Button clearMatrix;
        private Button diagonal;
        private Button Sub;
        private Button powerMatrix;
        private Button triangular;
        private Button transpose;
        private Button Add;
        private Button matrixMultiply;
        private Button inversMatrix;
        private Button determinant;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private DataGridView MatrixOperandB;
        private DataGridView MatrixOperandA;
        private DataGridView MatrixAnswer;
    }
}

