namespace graficcontrol
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
            this.button1 = new System.Windows.Forms.Button();
            this.controlgrafica2 = new graficcontrol.controlgrafica();
            this.controlgrafica1 = new graficcontrol.controlgrafica();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Elipsa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlgrafica2
            // 
            this.controlgrafica2.BackColor = System.Drawing.Color.White;
            this.controlgrafica2.Location = new System.Drawing.Point(12, 214);
            this.controlgrafica2.Name = "controlgrafica2";
            this.controlgrafica2.Size = new System.Drawing.Size(570, 206);
            this.controlgrafica2.TabIndex = 2;
            // 
            // controlgrafica1
            // 
            this.controlgrafica1.BackColor = System.Drawing.Color.White;
            this.controlgrafica1.Location = new System.Drawing.Point(12, 1);
            this.controlgrafica1.Name = "controlgrafica1";
            this.controlgrafica1.Size = new System.Drawing.Size(570, 207);
            this.controlgrafica1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.controlgrafica2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlgrafica1);
            this.Name = "Form1";
            this.Text = "controlgrafica";
            this.ResumeLayout(false);

        }

        #endregion

        private controlgrafica controlgrafica1;
        private System.Windows.Forms.Button button1;
        private controlgrafica controlgrafica2;
    }
}

