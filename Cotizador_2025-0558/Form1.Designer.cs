namespace Cotizador_2025_0558
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gbCotizador = new GroupBox();
            chkTemporadaAlta = new CheckBox();
            nudNoches = new NumericUpDown();
            txtTarifa = new TextBox();
            lblTarifa = new Label();
            lblNoches = new Label();
            txtHuesped = new TextBox();
            lblHuesped = new Label();
            gbTotales = new GroupBox();
            lblTotal = new Label();
            lblServicio = new Label();
            lblItbis = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            lblTot = new Label();
            lblServi = new Label();
            lblItb = new Label();
            lblDes = new Label();
            lblSub = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnCopiar = new Button();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(chkTemporadaAlta);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Location = new Point(34, 12);
            gbCotizador.Margin = new Padding(4, 3, 4, 3);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Padding = new Padding(4, 3, 4, 3);
            gbCotizador.Size = new Size(421, 271);
            gbCotizador.TabIndex = 1;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.ForeColor = Color.LimeGreen;
            chkTemporadaAlta.Location = new Point(111, 225);
            chkTemporadaAlta.Margin = new Padding(4, 3, 4, 3);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(221, 27);
            chkTemporadaAlta.TabIndex = 7;
            chkTemporadaAlta.Text = "Temporada alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(26, 121);
            nudNoches.Margin = new Padding(4, 3, 4, 3);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(188, 30);
            nudNoches.TabIndex = 6;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(26, 180);
            txtTarifa.Margin = new Padding(4, 3, 4, 3);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(368, 30);
            txtTarifa.TabIndex = 5;
            txtTarifa.TextChanged += textBox1_TextChanged;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(26, 154);
            lblTarifa.Margin = new Padding(4, 0, 4, 0);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(186, 23);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por noche USD:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 95);
            lblNoches.Margin = new Padding(4, 0, 4, 0);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(72, 23);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches:";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(26, 62);
            txtHuesped.Margin = new Padding(4, 3, 4, 3);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(368, 30);
            txtHuesped.TabIndex = 1;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(26, 36);
            lblHuesped.Margin = new Padding(4, 0, 4, 0);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(85, 23);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblItbis);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(lblTot);
            gbTotales.Controls.Add(lblServi);
            gbTotales.Controls.Add(lblItb);
            gbTotales.Controls.Add(lblDes);
            gbTotales.Controls.Add(lblSub);
            gbTotales.Location = new Point(34, 289);
            gbTotales.Margin = new Padding(4, 3, 4, 3);
            gbTotales.Name = "gbTotales";
            gbTotales.Padding = new Padding(4, 3, 4, 3);
            gbTotales.Size = new Size(421, 223);
            gbTotales.TabIndex = 8;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(196, 169);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 28);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(205, 140);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(45, 23);
            lblServicio.TabIndex = 9;
            lblServicio.Text = "0.00";
            lblServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(205, 107);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(45, 23);
            lblItbis.TabIndex = 8;
            lblItbis.Text = "0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(205, 74);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(45, 23);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(205, 41);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(45, 23);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.Location = new Point(26, 179);
            lblTot.Margin = new Padding(4, 0, 4, 0);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(94, 23);
            lblTot.TabIndex = 5;
            lblTot.Text = "Total USD:";
            // 
            // lblServi
            // 
            lblServi.AutoSize = true;
            lblServi.Location = new Point(26, 140);
            lblServi.Margin = new Padding(4, 0, 4, 0);
            lblServi.Name = "lblServi";
            lblServi.Size = new Size(119, 23);
            lblServi.TabIndex = 4;
            lblServi.Text = "Servicio 10%:";
            // 
            // lblItb
            // 
            lblItb.AutoSize = true;
            lblItb.Location = new Point(26, 107);
            lblItb.Margin = new Padding(4, 0, 4, 0);
            lblItb.Name = "lblItb";
            lblItb.Size = new Size(90, 23);
            lblItb.TabIndex = 3;
            lblItb.Text = "Itbis 18%:";
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Location = new Point(26, 74);
            lblDes.Margin = new Padding(4, 0, 4, 0);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(98, 23);
            lblDes.TabIndex = 2;
            lblDes.Text = "Descuento:";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(26, 41);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(84, 23);
            lblSub.TabIndex = 1;
            lblSub.Text = "Subtotal:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(34, 530);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 36);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(145, 530);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 36);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(256, 530);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(199, 36);
            btnCopiar.TabIndex = 11;
            btnCopiar.Text = "Copiar a WhatsApp";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 639);
            Controls.Add(btnCopiar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Villa Coral - Luzmairy E.R 2025-0558";
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbCotizador;
        private Label lblHuesped;
        private TextBox txtTarifa;
        private Label lblTarifa;
        private Label lblNoches;
        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private CheckBox chkTemporadaAlta;
        private GroupBox gbTotales;
        private Label lblTot;
        private Label lblServi;
        private Label lblItb;
        private Label lblDes;
        private Label lblSub;
        private Label lblSubtotal;
        private Label lblItbis;
        private Label lblDescuento;
        private Label lblTotal;
        private Label lblServicio;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCopiar;
    }
}
