namespace Cayley_Tree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextDepth = new System.Windows.Forms.TextBox();
            this.TextLength = new System.Windows.Forms.TextBox();
            this.TextPer1 = new System.Windows.Forms.TextBox();
            this.TextPer2 = new System.Windows.Forms.TextBox();
            this.TextTh1 = new System.Windows.Forms.TextBox();
            this.TextTh2 = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "画笔颜色";
            // 
            // TextDepth
            // 
            this.TextDepth.Location = new System.Drawing.Point(202, 43);
            this.TextDepth.Name = "TextDepth";
            this.TextDepth.Size = new System.Drawing.Size(140, 28);
            this.TextDepth.TabIndex = 7;
            this.TextDepth.TextChanged += new System.EventHandler(this.TextDepth_TextChanged);
            // 
            // TextLength
            // 
            this.TextLength.Location = new System.Drawing.Point(202, 146);
            this.TextLength.Name = "TextLength";
            this.TextLength.Size = new System.Drawing.Size(140, 28);
            this.TextLength.TabIndex = 8;
            this.TextLength.TextChanged += new System.EventHandler(this.TextLength_TextChanged);
            // 
            // TextPer1
            // 
            this.TextPer1.Location = new System.Drawing.Point(556, 89);
            this.TextPer1.Name = "TextPer1";
            this.TextPer1.Size = new System.Drawing.Size(140, 28);
            this.TextPer1.TabIndex = 9;
            this.TextPer1.TextChanged += new System.EventHandler(this.TextPer1_TextChanged);
            // 
            // TextPer2
            // 
            this.TextPer2.Location = new System.Drawing.Point(556, 156);
            this.TextPer2.Name = "TextPer2";
            this.TextPer2.Size = new System.Drawing.Size(140, 28);
            this.TextPer2.TabIndex = 10;
            this.TextPer2.TextChanged += new System.EventHandler(this.TextPer2_TextChanged);
            // 
            // TextTh1
            // 
            this.TextTh1.Location = new System.Drawing.Point(556, 234);
            this.TextTh1.Name = "TextTh1";
            this.TextTh1.Size = new System.Drawing.Size(140, 28);
            this.TextTh1.TabIndex = 11;
            this.TextTh1.TextChanged += new System.EventHandler(this.TextTh1_TextChanged);
            // 
            // TextTh2
            // 
            this.TextTh2.Location = new System.Drawing.Point(556, 312);
            this.TextTh2.Name = "TextTh2";
            this.TextTh2.Size = new System.Drawing.Size(140, 28);
            this.TextTh2.TabIndex = 12;
            this.TextTh2.TextChanged += new System.EventHandler(this.TextTh2_TextChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownHeight = 300;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.IntegralHeight = false;
            this.comboBoxColor.Location = new System.Drawing.Point(202, 234);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(140, 26);
            this.comboBoxColor.TabIndex = 13;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(202, 328);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(123, 37);
            this.button.TabIndex = 14;
            this.button.Text = "绘制";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.TextTh2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxColor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextDepth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextLength);
            this.panel1.Controls.Add(this.TextPer1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextPer2);
            this.panel1.Controls.Add(this.TextTh1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 406);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextDepth;
        private System.Windows.Forms.TextBox TextLength;
        private System.Windows.Forms.TextBox TextPer1;
        private System.Windows.Forms.TextBox TextPer2;
        private System.Windows.Forms.TextBox TextTh1;
        private System.Windows.Forms.TextBox TextTh2;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel1;
    }
}

