
namespace Informing
{
    partial class CreateNewTypeOfIncident
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNameOfTypeOfIncident = new System.Windows.Forms.TextBox();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBneedInc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название";
            // 
            // tBNameOfTypeOfIncident
            // 
            this.tBNameOfTypeOfIncident.Location = new System.Drawing.Point(49, 29);
            this.tBNameOfTypeOfIncident.Name = "tBNameOfTypeOfIncident";
            this.tBNameOfTypeOfIncident.Size = new System.Drawing.Size(189, 20);
            this.tBNameOfTypeOfIncident.TabIndex = 2;
            // 
            // tBCode
            // 
            this.tBCode.Location = new System.Drawing.Point(49, 78);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(189, 20);
            this.tBCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите код (например, \"real\")";
            // 
            // tBMessage
            // 
            this.tBMessage.Location = new System.Drawing.Point(49, 127);
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(189, 20);
            this.tBMessage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите сообщение (например, \"inc\")";
            // 
            // tBneedInc
            // 
            this.tBneedInc.Location = new System.Drawing.Point(49, 180);
            this.tBneedInc.Name = "tBneedInc";
            this.tBneedInc.Size = new System.Drawing.Size(189, 20);
            this.tBneedInc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите значение типа needInc (\"true\" или \"false\")";
            // 
            // CreateNewTypeOfIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 264);
            this.Controls.Add(this.tBneedInc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameOfTypeOfIncident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CreateNewTypeOfIncident";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новый тип инцидента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNameOfTypeOfIncident;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBneedInc;
        private System.Windows.Forms.Label label4;
    }
}