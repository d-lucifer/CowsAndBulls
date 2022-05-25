
namespace Курсова
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.початиГруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зДругомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаГраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpl1 = new System.Windows.Forms.Label();
            this.labelpl2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.початиГруToolStripMenuItem,
            this.новаГраToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // початиГруToolStripMenuItem
            // 
            this.початиГруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withPCToolStripMenuItem,
            this.зДругомToolStripMenuItem});
            this.початиГруToolStripMenuItem.Name = "початиГруToolStripMenuItem";
            this.початиГруToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.початиГруToolStripMenuItem.Text = "Почати гру";
            this.початиГруToolStripMenuItem.Click += new System.EventHandler(this.початиГруToolStripMenuItem_Click);
            // 
            // withPCToolStripMenuItem
            // 
            this.withPCToolStripMenuItem.Name = "withPCToolStripMenuItem";
            this.withPCToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.withPCToolStripMenuItem.Text = "З ПК";
            this.withPCToolStripMenuItem.Click += new System.EventHandler(this.withPCToolStripMenuItem_Click);
            // 
            // зДругомToolStripMenuItem
            // 
            this.зДругомToolStripMenuItem.Name = "зДругомToolStripMenuItem";
            this.зДругомToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.зДругомToolStripMenuItem.Text = "З другом";
            this.зДругомToolStripMenuItem.Click += new System.EventHandler(this.зДругомToolStripMenuItem_Click);
            // 
            // новаГраToolStripMenuItem
            // 
            this.новаГраToolStripMenuItem.Name = "новаГраToolStripMenuItem";
            this.новаГраToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.новаГраToolStripMenuItem.Text = "Нова гра";
            this.новаГраToolStripMenuItem.Click += new System.EventHandler(this.новаГраToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(657, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(43, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "ЗАГАДАНЕ ЧИСЛО";
            // 
            // labelpl1
            // 
            this.labelpl1.AutoSize = true;
            this.labelpl1.BackColor = System.Drawing.Color.Yellow;
            this.labelpl1.Location = new System.Drawing.Point(39, 299);
            this.labelpl1.Name = "labelpl1";
            this.labelpl1.Size = new System.Drawing.Size(85, 20);
            this.labelpl1.TabIndex = 4;
            this.labelpl1.Text = "Гравець 1";
            // 
            // labelpl2
            // 
            this.labelpl2.AutoSize = true;
            this.labelpl2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelpl2.Location = new System.Drawing.Point(653, 299);
            this.labelpl2.Name = "labelpl2";
            this.labelpl2.Size = new System.Drawing.Size(85, 20);
            this.labelpl2.TabIndex = 6;
            this.labelpl2.Text = "Гравець 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(43, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.Location = new System.Drawing.Point(657, 375);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(209, 258);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 218);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(541, 258);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 218);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Перевірити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelpl2);
            this.Controls.Add(this.labelpl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CowsAndBulls";
            this.Resize += new System.EventHandler(this.зДругомToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem початиГруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зДругомToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpl1;
        private System.Windows.Forms.Label labelpl2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem новаГраToolStripMenuItem;
        
    }
}

