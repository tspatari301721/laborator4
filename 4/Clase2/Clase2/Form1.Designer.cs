
namespace ClaseElev
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
            this.btAlex = new System.Windows.Forms.Button();
            this.btElena = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAlex
            // 
            this.btAlex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlex.Location = new System.Drawing.Point(133, 60);
            this.btAlex.Name = "btAlex";
            this.btAlex.Size = new System.Drawing.Size(123, 61);
            this.btAlex.TabIndex = 0;
            this.btAlex.Text = "Alex";
            this.btAlex.UseVisualStyleBackColor = true;
            this.btAlex.Click += new System.EventHandler(this.btAlex_Click);
            // 
            // btElena
            // 
            this.btElena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElena.Location = new System.Drawing.Point(133, 186);
            this.btElena.Name = "btElena";
            this.btElena.Size = new System.Drawing.Size(123, 61);
            this.btElena.TabIndex = 0;
            this.btElena.Text = "Elena";
            this.btElena.UseVisualStyleBackColor = true;
            this.btElena.Click += new System.EventHandler(this.btElena_Click);
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Location = new System.Drawing.Point(133, 318);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(123, 61);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "Schimba !";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 425);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btElena);
            this.Controls.Add(this.btAlex);
            this.Name = "Form1";
            this.Text = "Schimb";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlex;
        private System.Windows.Forms.Button btElena;
        private System.Windows.Forms.Button btChange;
    }
}

