
namespace QuadraticEquation
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayAnswerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.RichTextBox();
            this.BTextBox = new System.Windows.Forms.RichTextBox();
            this.CTextBox = new System.Windows.Forms.RichTextBox();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X^2 +";
            // 
            // DisplayAnswerButton
            // 
            this.DisplayAnswerButton.Location = new System.Drawing.Point(16, 61);
            this.DisplayAnswerButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayAnswerButton.Name = "DisplayAnswerButton";
            this.DisplayAnswerButton.Size = new System.Drawing.Size(123, 42);
            this.DisplayAnswerButton.TabIndex = 1;
            this.DisplayAnswerButton.Text = "Display answer";
            this.DisplayAnswerButton.UseVisualStyleBackColor = true;
            this.DisplayAnswerButton.Click += new System.EventHandler(this.DisplayAnswerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "X +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "=0";
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATextBox.ForeColor = System.Drawing.Color.Navy;
            this.ATextBox.Location = new System.Drawing.Point(16, 16);
            this.ATextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(111, 37);
            this.ATextBox.TabIndex = 6;
            this.ATextBox.Text = "";
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTextBox.ForeColor = System.Drawing.Color.Navy;
            this.BTextBox.Location = new System.Drawing.Point(200, 16);
            this.BTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(111, 37);
            this.BTextBox.TabIndex = 7;
            this.BTextBox.Text = "";
            // 
            // CTextBox
            // 
            this.CTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTextBox.ForeColor = System.Drawing.Color.Navy;
            this.CTextBox.Location = new System.Drawing.Point(364, 16);
            this.CTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(111, 37);
            this.CTextBox.TabIndex = 8;
            this.CTextBox.Text = "";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AnswerTextBox.Location = new System.Drawing.Point(156, 61);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(132, 65);
            this.AnswerTextBox.TabIndex = 9;
            this.AnswerTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 236);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisplayAnswerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisplayAnswerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ATextBox;
        private System.Windows.Forms.RichTextBox BTextBox;
        private System.Windows.Forms.RichTextBox CTextBox;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
    }
}

