namespace Serialization
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(42, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 20);
            this.name.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(42, 170);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(124, 20);
            this.ID.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(42, 112);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(124, 20);
            this.Age.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Number";
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(38, 240);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(128, 39);
            this.SaveData.TabIndex = 6;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadLast
            // 
            this.LoadLast.Location = new System.Drawing.Point(196, 240);
            this.LoadLast.Name = "LoadLast";
            this.LoadLast.Size = new System.Drawing.Size(125, 38);
            this.LoadLast.TabIndex = 7;
            this.LoadLast.Text = "Load";
            this.LoadLast.UseVisualStyleBackColor = true;
            this.LoadLast.Click += new System.EventHandler(this.LoadLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 355);
            this.Controls.Add(this.LoadLast);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadLast;
    }
}

