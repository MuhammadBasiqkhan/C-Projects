namespace Parking_Management_System
{
    partial class Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press What you Wnat ";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.LemonChiffon;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(397, 241);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(203, 59);
            this.price.TabIndex = 2;
            this.price.Text = "Vehicle Price";
            this.price.UseVisualStyleBackColor = false;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.LemonChiffon;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(397, 333);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(203, 59);
            this.data.TabIndex = 3;
            this.data.Text = "Vehicle Data";
            this.data.UseVisualStyleBackColor = false;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LemonChiffon;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(397, 432);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(203, 59);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LemonChiffon;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 516);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 59);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vehicle Entry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::Parking_Management_System.Properties.Resources.system;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.data);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Services_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button price;
        private System.Windows.Forms.Button data;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
    }
}