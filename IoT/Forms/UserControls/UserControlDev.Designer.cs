using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    partial class UserControlDev
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new Button();
            this.label1 = new Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = Color.DarkSlateBlue;
            this.buttonAdd.FlatStyle = FlatStyle.Flat;
            this.buttonAdd.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = Color.LightGray;
            this.buttonAdd.Location = new Point(99, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(301, 104);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Verdana", 19.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = Color.DarkSlateBlue;
            this.label1.Location = new Point(92, 87);
            this.label1.Name = "label1";
            this.label1.Size = new Size(205, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Device";
            // 
            // UserControlDev
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "UserControlDev";
            this.Size = new Size(1350, 577);
            this.Load += new EventHandler(this.UserControlDev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Label label1;
    }
}
