namespace Osterhout_WFCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_radio = new System.Windows.Forms.RadioButton();
            this.sub_radio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.divide_radio = new System.Windows.Forms.RadioButton();
            this.mult_radio = new System.Windows.Forms.RadioButton();
            this.simpleCalc_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calc_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 0;
            // 
            // add_radio
            // 
            this.add_radio.AutoSize = true;
            this.add_radio.BackColor = System.Drawing.Color.Transparent;
            this.add_radio.Location = new System.Drawing.Point(211, 235);
            this.add_radio.Name = "add_radio";
            this.add_radio.Size = new System.Drawing.Size(44, 17);
            this.add_radio.TabIndex = 1;
            this.add_radio.TabStop = true;
            this.add_radio.Text = "Add";
            this.add_radio.UseVisualStyleBackColor = false;
            // 
            // sub_radio
            // 
            this.sub_radio.AutoSize = true;
            this.sub_radio.BackColor = System.Drawing.Color.Transparent;
            this.sub_radio.Location = new System.Drawing.Point(261, 235);
            this.sub_radio.Name = "sub_radio";
            this.sub_radio.Size = new System.Drawing.Size(65, 17);
            this.sub_radio.TabIndex = 2;
            this.sub_radio.TabStop = true;
            this.sub_radio.Text = "Subtract";
            this.sub_radio.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 3;
            // 
            // divide_radio
            // 
            this.divide_radio.AutoSize = true;
            this.divide_radio.BackColor = System.Drawing.Color.Transparent;
            this.divide_radio.Location = new System.Drawing.Point(403, 235);
            this.divide_radio.Name = "divide_radio";
            this.divide_radio.Size = new System.Drawing.Size(55, 17);
            this.divide_radio.TabIndex = 4;
            this.divide_radio.TabStop = true;
            this.divide_radio.Text = "Divide";
            this.divide_radio.UseVisualStyleBackColor = false;
            // 
            // mult_radio
            // 
            this.mult_radio.AutoSize = true;
            this.mult_radio.BackColor = System.Drawing.Color.Transparent;
            this.mult_radio.Location = new System.Drawing.Point(332, 235);
            this.mult_radio.Name = "mult_radio";
            this.mult_radio.Size = new System.Drawing.Size(60, 17);
            this.mult_radio.TabIndex = 5;
            this.mult_radio.TabStop = true;
            this.mult_radio.Text = "Multiply";
            this.mult_radio.UseVisualStyleBackColor = false;
            // 
            // simpleCalc_lbl
            // 
            this.simpleCalc_lbl.AutoSize = true;
            this.simpleCalc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.simpleCalc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleCalc_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.simpleCalc_lbl.Location = new System.Drawing.Point(141, 9);
            this.simpleCalc_lbl.Name = "simpleCalc_lbl";
            this.simpleCalc_lbl.Size = new System.Drawing.Size(334, 46);
            this.simpleCalc_lbl.TabIndex = 6;
            this.simpleCalc_lbl.Text = "Simple Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value 2";
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(195, 268);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(75, 23);
            this.calc_btn.TabIndex = 9;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(276, 268);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(357, 268);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 23);
            this.clr_btn.TabIndex = 11;
            this.clr_btn.Text = "Close";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Location = new System.Drawing.Point(519, 347);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(75, 23);
            this.help_btn.TabIndex = 12;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 382);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleCalc_lbl);
            this.Controls.Add(this.mult_radio);
            this.Controls.Add(this.divide_radio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sub_radio);
            this.Controls.Add(this.add_radio);
            this.Controls.Add(this.textBox1);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton add_radio;
        private System.Windows.Forms.RadioButton sub_radio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton divide_radio;
        private System.Windows.Forms.RadioButton mult_radio;
        private System.Windows.Forms.Label simpleCalc_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button help_btn;
    }
}

