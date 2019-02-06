using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT.Forms
{
    partial class UserControlCost
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        //void  loadDeviceToList()
        //{
        //    string connString = "Data Source = (LocalDB)\\ MSSQLLocalDB; AttachDbFilename = D:\\source\\repos\\IoT\\IoT\\CustDatabase.mdf ; Integrated Security = True";
        //    string Query = "SELECT * from Device WHERE Login='"+Program.GlobalCorrectlogin+"' ;";
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = connString;
        //    SqlCommand command = new SqlCommand(Query, conn);
        //    SqlDataReader reader;
        //    try
        //    {
        //        conn.Open();
        //        reader = command.ExecuteReader();


        //        while (reader.Read())
        //        {
                   
        //            listBox1.Items.Add(reader.GetString(1));
                    


        //        }




        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
          



        }
        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.comboBoxTime = new System.Windows.Forms.ComboBox();
    //        this.labelPrize = new System.Windows.Forms.Label();
    //        this.textBoxPrice = new System.Windows.Forms.TextBox();
    //        this.listBox1 = new System.Windows.Forms.ListBox();
    //        this.listBox2 = new System.Windows.Forms.ListBox();
    //        this.label1 = new System.Windows.Forms.Label();
    //        this.label2 = new System.Windows.Forms.Label();
    //        this.buttonCalculate = new System.Windows.Forms.Button();
    //        this.label3 = new System.Windows.Forms.Label();
    //        this.SuspendLayout();
    //        // 
    //        // comboBoxTime
    //        // 
    //        this.comboBoxTime.Font = new System.Drawing.Font("Verdana", 16.8F);
    //        this.comboBoxTime.FormattingEnabled = true;
    //        this.comboBoxTime.Location = new System.Drawing.Point(12, 57);
    //        this.comboBoxTime.Name = "comboBoxTime";
    //        this.comboBoxTime.Items.AddRange(new object[] {
    //        "Month",
    //        "Quarter",
    //        "Year"});
    //        this.comboBoxTime.Size = new System.Drawing.Size(252, 42);
    //        this.comboBoxTime.TabIndex = 0;
    //        // 
    //        // labelPrize
    //        // 
    //        this.labelPrize.AutoSize = true;
    //        this.labelPrize.Font = new System.Drawing.Font("Verdana", 20.2F);
    //        this.labelPrize.ForeColor = System.Drawing.Color.DarkSlateBlue;
    //        this.labelPrize.Location = new System.Drawing.Point(313, 10);
    //        this.labelPrize.Name = "labelPrize";
    //        this.labelPrize.Size = new System.Drawing.Size(261, 41);
    //        this.labelPrize.TabIndex = 1;
    //        this.labelPrize.Text = "Price [zl/kWh]";
    //        // 
    //        // textBoxPrice
    //        // 
    //        this.textBoxPrice.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
    //        this.textBoxPrice.Location = new System.Drawing.Point(320, 59);
    //        this.textBoxPrice.Name = "textBoxPrice";
    //        this.textBoxPrice.Size = new System.Drawing.Size(266, 40);
    //        this.textBoxPrice.TabIndex = 2;
    //        // 
    //        // listBox1
    //        // 
    //        this.listBox1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
    //        this.listBox1.FormattingEnabled = true;
    //        this.listBox1.ItemHeight = 32;
    //        this.listBox1.Location = new System.Drawing.Point(619, 59);
    //        this.listBox1.Name = "listBox1";
    //        this.listBox1.Size = new System.Drawing.Size(138, 292);
    //        this.listBox1.TabIndex = 3;
    //        // 
    //        // listBox2
    //        // 
    //        this.listBox2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
    //        this.listBox2.FormattingEnabled = true;
    //        this.listBox2.ItemHeight = 32;
    //        this.listBox2.Location = new System.Drawing.Point(797, 59);
    //        this.listBox2.Name = "listBox2";
    //        this.listBox2.Size = new System.Drawing.Size(120, 292);
    //        this.listBox2.TabIndex = 4;
    //        // 
    //        // label1
    //        // 
    //        this.label1.AutoSize = true;
    //        this.label1.Font = new System.Drawing.Font("Verdana", 20.2F);
    //        this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
    //        this.label1.Location = new System.Drawing.Point(626, 15);
    //        this.label1.Name = "label1";
    //        this.label1.Size = new System.Drawing.Size(131, 41);
    //        this.label1.TabIndex = 5;
    //        this.label1.Text = "Device";
    //        // 
    //        // label2
    //        // 
    //        this.label2.AutoSize = true;
    //        this.label2.Font = new System.Drawing.Font("Verdana", 20.2F);
    //        this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
    //        this.label2.Location = new System.Drawing.Point(813, 15);
    //        this.label2.Name = "label2";
    //        this.label2.Size = new System.Drawing.Size(94, 41);
    //        this.label2.TabIndex = 6;
    //        this.label2.Text = "Cost";
    //        // 
    //        // buttonCalculate
    //        // 
    //        this.buttonCalculate.BackColor = System.Drawing.Color.DarkSlateBlue;
    //        this.buttonCalculate.FlatAppearance.BorderSize = 0;
    //        this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    //        this.buttonCalculate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
    //        this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ControlLight;
    //        this.buttonCalculate.Location = new System.Drawing.Point(320, 138);
    //        this.buttonCalculate.Name = "buttonCalculate";
    //        this.buttonCalculate.Size = new System.Drawing.Size(266, 49);
    //        this.buttonCalculate.TabIndex = 12;
    //        this.buttonCalculate.Text = "Calculate";
    //        this.buttonCalculate.UseVisualStyleBackColor = false;
    //        this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
    //        // 
    //        // label3
    //        // 
    //        this.label3.AutoSize = true;
    //        this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
    //        this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
    //        this.label3.Location = new System.Drawing.Point(42, 15);
    //        this.label3.Name = "label3";
    //        this.label3.Size = new System.Drawing.Size(124, 41);
    //        this.label3.TabIndex = 13;
    //        this.label3.Text = "Period";
    //        // 
    //        // UserControlCost
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.AutoSize = true;
    //        this.BackColor = System.Drawing.Color.LightGray;
    //        this.Controls.Add(this.label3);
    //        this.Controls.Add(this.buttonCalculate);
    //        this.Controls.Add(this.label2);
    //        this.Controls.Add(this.label1);
    //        this.Controls.Add(this.listBox2);
    //        this.Controls.Add(this.listBox1);
    //        this.Controls.Add(this.textBoxPrice);
    //        this.Controls.Add(this.labelPrize);
    //        this.Controls.Add(this.comboBoxTime);
    //        this.Name = "UserControlCost";
    //        this.Size = new System.Drawing.Size(1300, 570);
    //        this.ResumeLayout(false);
    //        this.PerformLayout();

     }

      #endregion

    //    private System.Windows.Forms.ComboBox comboBoxTime;
    //    private System.Windows.Forms.Label labelPrize;
    //    private System.Windows.Forms.TextBox textBoxPrice;
    //    private System.Windows.Forms.ListBox listBox1;
    //    private System.Windows.Forms.ListBox listBox2;
    //    private System.Windows.Forms.Label label1;
    //    private System.Windows.Forms.Label label2;
    //    private System.Windows.Forms.Button buttonCalculate;
    //    private Label label3;
    

