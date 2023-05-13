namespace CurrencyAPP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertcurrency = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 18;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "USD",
            "TRY",
            "EUR",
            "GBP",
            "CHF",
            "CNY",
            "JPY",
            "SAR",
            "NOK",
            "DKK",
            "AUD",
            "CAD",
            "SEK",
            "KWD",
            "IRR",
            "RUB",
            "AFN",
            "AOA",
            "ARS",
            "ALL",
            "AWG",
            "AZN",
            "AED",
            "BSD",
            "BHD",
            "BDT",
            "BBD",
            "BYR",
            "BZD",
            "BMD",
            "BTN",
            "BOB",
            "BAM",
            "BWP",
            "BRL",
            "BND",
            "BGN",
            "BIF",
            "XAF",
            "CVE",
            "GIP",
            "DZD",
            "DJF",
            "CZK",
            "SCR",
            "SLL",
            "SGD",
            "SBD",
            "SOS",
            "LKR",
            "SDG",
            "SRD",
            "SYP",
            "SZL",
            "RSD",
            "CLP",
            "TJS",
            "TZS",
            "THB",
            "TWD",
            "TOP",
            "TTD",
            "TND",
            "TMT",
            "UGX",
            "UAH",
            "OMR",
            "UYU",
            "JOD",
            "VUV",
            "VEF",
            "VND",
            "YER",
            "NZD",
            "ZMW",
            "ZWL"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(12, 72);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 18;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "USD",
            "TRY",
            "EUR",
            "GBP",
            "CHF",
            "CNY",
            "JPY",
            "SAR",
            "NOK",
            "DKK",
            "AUD",
            "CAD",
            "SEK",
            "KWD",
            "IRR",
            "RUB",
            "AFN",
            "AOA",
            "ARS",
            "ALL",
            "AWG",
            "AZN",
            "AED",
            "BSD",
            "BHD",
            "BDT",
            "BBD",
            "BYR",
            "BZD",
            "BMD",
            "BTN",
            "BOB",
            "BAM",
            "BWP",
            "BRL",
            "BND",
            "BGN",
            "BIF",
            "XAF",
            "CVE",
            "GIP",
            "DZD",
            "DJF",
            "CZK",
            "SCR",
            "SLL",
            "SGD",
            "SBD",
            "SOS",
            "LKR",
            "SDG",
            "SRD",
            "SYP",
            "SZL",
            "RSD",
            "CLP",
            "TJS",
            "TZS",
            "THB",
            "TWD",
            "TOP",
            "TTD",
            "TND",
            "TMT",
            "UGX",
            "UAH",
            "OMR",
            "UYU",
            "JOD",
            "VUV",
            "VEF",
            "VND",
            "YER",
            "NZD",
            "ZMW",
            "ZWL"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(175, 72);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox2.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(354, 72);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Amount";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(626, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 3;
            this.label1.Visible = false;
            // 
            // convertcurrency
            // 
            this.convertcurrency.BorderRadius = 18;
            this.convertcurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.convertcurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.convertcurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.convertcurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.convertcurrency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.convertcurrency.ForeColor = System.Drawing.Color.White;
            this.convertcurrency.Location = new System.Drawing.Point(12, 133);
            this.convertcurrency.Name = "convertcurrency";
            this.convertcurrency.Size = new System.Drawing.Size(79, 45);
            this.convertcurrency.TabIndex = 4;
            this.convertcurrency.Text = "Convert";
            this.convertcurrency.Click += new System.EventHandler(this.convertcurrency_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertcurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 449);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button convertcurrency;
    }
}

