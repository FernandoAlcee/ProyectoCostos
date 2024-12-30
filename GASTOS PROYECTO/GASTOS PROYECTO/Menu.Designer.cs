namespace GASTOS_PROYECTO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            ControldeGastoslbl = new Label();
            Id_Facturalbl = new Label();
            id_numeric = new NumericUpDown();
            No_Facturalbl = new Label();
            txt_nofactura = new TextBox();
            Fechalbl = new Label();
            Calendariotxt = new MonthCalendar();
            monto_lbl = new Label();
            montotxt = new TextBox();
            ingresar_btn = new Button();
            limpiar_btn = new Button();
            categorialbl = new Label();
            list_categoria = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)id_numeric).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ControldeGastoslbl
            // 
            ControldeGastoslbl.BackColor = Color.Ivory;
            ControldeGastoslbl.FlatStyle = FlatStyle.Flat;
            ControldeGastoslbl.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ControldeGastoslbl.ForeColor = SystemColors.ActiveCaptionText;
            ControldeGastoslbl.Location = new Point(353, 61);
            ControldeGastoslbl.Name = "ControldeGastoslbl";
            ControldeGastoslbl.Size = new Size(486, 47);
            ControldeGastoslbl.TabIndex = 1;
            ControldeGastoslbl.Text = "CONTROL DE GASTOS";
            // 
            // Id_Facturalbl
            // 
            Id_Facturalbl.BackColor = Color.Ivory;
            Id_Facturalbl.FlatStyle = FlatStyle.Flat;
            Id_Facturalbl.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id_Facturalbl.Location = new Point(353, 189);
            Id_Facturalbl.Name = "Id_Facturalbl";
            Id_Facturalbl.Size = new Size(211, 41);
            Id_Facturalbl.TabIndex = 2;
            Id_Facturalbl.Text = "ID Factura:";
            // 
            // id_numeric
            // 
            id_numeric.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id_numeric.AutoSize = true;
            id_numeric.Location = new Point(542, 202);
            id_numeric.Name = "id_numeric";
            id_numeric.Size = new Size(119, 27);
            id_numeric.TabIndex = 3;
            id_numeric.TextAlign = HorizontalAlignment.Center;
            // 
            // No_Facturalbl
            // 
            No_Facturalbl.BackColor = Color.Ivory;
            No_Facturalbl.FlatStyle = FlatStyle.Flat;
            No_Facturalbl.Font = new Font("MS Reference Sans Serif", 18F);
            No_Facturalbl.Location = new Point(353, 294);
            No_Facturalbl.Name = "No_Facturalbl";
            No_Facturalbl.Size = new Size(329, 41);
            No_Facturalbl.TabIndex = 4;
            No_Facturalbl.Text = "Numero de Factura:";
            // 
            // txt_nofactura
            // 
            txt_nofactura.Font = new Font("Segoe UI", 15F);
            txt_nofactura.Location = new Point(668, 303);
            txt_nofactura.Name = "txt_nofactura";
            txt_nofactura.Size = new Size(290, 41);
            txt_nofactura.TabIndex = 5;
            // 
            // Fechalbl
            // 
            Fechalbl.BackColor = Color.Ivory;
            Fechalbl.FlatStyle = FlatStyle.Flat;
            Fechalbl.Font = new Font("MS Reference Sans Serif", 18F);
            Fechalbl.Location = new Point(353, 516);
            Fechalbl.Name = "Fechalbl";
            Fechalbl.Size = new Size(135, 41);
            Fechalbl.TabIndex = 6;
            Fechalbl.Text = "Fecha:";
            // 
            // Calendariotxt
            // 
            Calendariotxt.Location = new Point(500, 516);
            Calendariotxt.Name = "Calendariotxt";
            Calendariotxt.TabIndex = 7;
            // 
            // monto_lbl
            // 
            monto_lbl.BackColor = Color.Ivory;
            monto_lbl.FlatStyle = FlatStyle.Flat;
            monto_lbl.Font = new Font("MS Reference Sans Serif", 18F);
            monto_lbl.Location = new Point(362, 771);
            monto_lbl.Name = "monto_lbl";
            monto_lbl.Size = new Size(126, 41);
            monto_lbl.TabIndex = 8;
            monto_lbl.Text = "Monto:";
            // 
            // montotxt
            // 
            montotxt.Font = new Font("Segoe UI", 15F);
            montotxt.Location = new Point(485, 771);
            montotxt.Name = "montotxt";
            montotxt.Size = new Size(290, 41);
            montotxt.TabIndex = 9;
            // 
            // ingresar_btn
            // 
            ingresar_btn.BackColor = Color.LimeGreen;
            ingresar_btn.ForeColor = SystemColors.InactiveCaptionText;
            ingresar_btn.Image = (Image)resources.GetObject("ingresar_btn.Image");
            ingresar_btn.Location = new Point(3, 833);
            ingresar_btn.Name = "ingresar_btn";
            ingresar_btn.Size = new Size(260, 65);
            ingresar_btn.TabIndex = 10;
            ingresar_btn.UseVisualStyleBackColor = false;
            // 
            // limpiar_btn
            // 
            limpiar_btn.BackColor = Color.Red;
            limpiar_btn.Image = (Image)resources.GetObject("limpiar_btn.Image");
            limpiar_btn.Location = new Point(3, 904);
            limpiar_btn.Name = "limpiar_btn";
            limpiar_btn.Size = new Size(260, 65);
            limpiar_btn.TabIndex = 11;
            limpiar_btn.UseVisualStyleBackColor = false;
            // 
            // categorialbl
            // 
            categorialbl.BackColor = Color.Ivory;
            categorialbl.FlatStyle = FlatStyle.Flat;
            categorialbl.Font = new Font("MS Reference Sans Serif", 18F);
            categorialbl.Location = new Point(353, 401);
            categorialbl.Name = "categorialbl";
            categorialbl.Size = new Size(191, 41);
            categorialbl.TabIndex = 12;
            categorialbl.Text = "Categoria:";
            // 
            // list_categoria
            // 
            list_categoria.FormattingEnabled = true;
            list_categoria.Items.AddRange(new object[] { "Gasolina", "Supermercado", "Otros" });
            list_categoria.Location = new Point(529, 413);
            list_categoria.Name = "list_categoria";
            list_categoria.Size = new Size(327, 28);
            list_categoria.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ingresar_btn);
            panel1.Controls.Add(limpiar_btn);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 1052);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.invoice_payment_business_marketing_management_icon_191146;
            pictureBox1.Location = new Point(60, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1884, 1055);
            Controls.Add(panel1);
            Controls.Add(list_categoria);
            Controls.Add(categorialbl);
            Controls.Add(montotxt);
            Controls.Add(monto_lbl);
            Controls.Add(Calendariotxt);
            Controls.Add(Fechalbl);
            Controls.Add(txt_nofactura);
            Controls.Add(No_Facturalbl);
            Controls.Add(id_numeric);
            Controls.Add(Id_Facturalbl);
            Controls.Add(ControldeGastoslbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Gastos";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)id_numeric).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ControldeGastoslbl;
        private Label Id_Facturalbl;
        private NumericUpDown id_numeric;
        private Label No_Facturalbl;
        private TextBox txt_nofactura;
        private Label Fechalbl;
        private MonthCalendar Calendariotxt;
        private Label monto_lbl;
        private TextBox montotxt;
        private Button ingresar_btn;
        private Button limpiar_btn;
        private Label categorialbl;
        private ComboBox list_categoria;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}