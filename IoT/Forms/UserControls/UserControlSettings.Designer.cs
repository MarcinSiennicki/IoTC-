using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    partial class UserControlSettings
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
            this.SuspendLayout();
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightGray;
            this.Name = "UserControlSettings";
            this.Size = new Size(1300, 150);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
