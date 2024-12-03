
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnEliminarSucesor = new System.Windows.Forms.Button();
            this.btnRecorrerNiveles = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnContarHojas = new System.Windows.Forms.Button();
            this.btnContarNodos = new System.Windows.Forms.Button();
            this.btnEsCompleto = new System.Windows.Forms.Button();
            this.btnEsLleno = new System.Windows.Forms.Button();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.cmbOrdenacion = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 244);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(1026, 370);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(579, 9);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(579, 59);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(138, 104);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 40);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(234, 146);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(318, 146);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(249, 116);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(238, 84);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(318, 116);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(318, 84);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(138, 149);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 34);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(440, 12);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(75, 23);
            this.btnPodar.TabIndex = 18;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(402, 70);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(147, 27);
            this.btnEliminarPredecesor.TabIndex = 19;
            this.btnEliminarPredecesor.Text = "Eliminar Predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnEliminarSucesor
            // 
            this.btnEliminarSucesor.Location = new System.Drawing.Point(402, 104);
            this.btnEliminarSucesor.Name = "btnEliminarSucesor";
            this.btnEliminarSucesor.Size = new System.Drawing.Size(142, 23);
            this.btnEliminarSucesor.TabIndex = 20;
            this.btnEliminarSucesor.Text = "Eliminar Sucesor";
            this.btnEliminarSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarSucesor.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // btnRecorrerNiveles
            // 
            this.btnRecorrerNiveles.Location = new System.Drawing.Point(402, 133);
            this.btnRecorrerNiveles.Name = "btnRecorrerNiveles";
            this.btnRecorrerNiveles.Size = new System.Drawing.Size(142, 27);
            this.btnRecorrerNiveles.TabIndex = 21;
            this.btnRecorrerNiveles.Text = "Recorrer Niveles";
            this.btnRecorrerNiveles.UseVisualStyleBackColor = true;
            this.btnRecorrerNiveles.Click += new System.EventHandler(this.btnRecorrerNiveles_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(430, 41);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(94, 23);
            this.btnAltura.TabIndex = 22;
            this.btnAltura.Text = "Ver Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnContarHojas
            // 
            this.btnContarHojas.Location = new System.Drawing.Point(402, 166);
            this.btnContarHojas.Name = "btnContarHojas";
            this.btnContarHojas.Size = new System.Drawing.Size(142, 23);
            this.btnContarHojas.TabIndex = 23;
            this.btnContarHojas.Text = "Contar Hojas";
            this.btnContarHojas.UseVisualStyleBackColor = true;
            this.btnContarHojas.Click += new System.EventHandler(this.btnContarHojas_Click);
            // 
            // btnContarNodos
            // 
            this.btnContarNodos.Location = new System.Drawing.Point(402, 195);
            this.btnContarNodos.Name = "btnContarNodos";
            this.btnContarNodos.Size = new System.Drawing.Size(142, 23);
            this.btnContarNodos.TabIndex = 24;
            this.btnContarNodos.Text = "Contar Nodos";
            this.btnContarNodos.UseVisualStyleBackColor = true;
            this.btnContarNodos.Click += new System.EventHandler(this.btnContarNodos_Click);
            // 
            // btnEsCompleto
            // 
            this.btnEsCompleto.Location = new System.Drawing.Point(559, 112);
            this.btnEsCompleto.Name = "btnEsCompleto";
            this.btnEsCompleto.Size = new System.Drawing.Size(114, 32);
            this.btnEsCompleto.TabIndex = 25;
            this.btnEsCompleto.Text = "¿Es Completo?";
            this.btnEsCompleto.UseVisualStyleBackColor = true;
            this.btnEsCompleto.Click += new System.EventHandler(this.btnEsCompleto_Click);
            // 
            // btnEsLleno
            // 
            this.btnEsLleno.Location = new System.Drawing.Point(559, 154);
            this.btnEsLleno.Name = "btnEsLleno";
            this.btnEsLleno.Size = new System.Drawing.Size(114, 35);
            this.btnEsLleno.TabIndex = 25;
            this.btnEsLleno.Text = "¿Es Lleno?";
            this.btnEsLleno.UseVisualStyleBackColor = true;
            this.btnEsLleno.Click += new System.EventHandler(this.btnEsLleno_Click);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Location = new System.Drawing.Point(799, 59);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cmbBusqueda.TabIndex = 26;
            this.cmbBusqueda.Text = "Busqueda";
            // 
            // cmbOrdenacion
            // 
            this.cmbOrdenacion.FormattingEnabled = true;
            this.cmbOrdenacion.Location = new System.Drawing.Point(799, 116);
            this.cmbOrdenacion.Name = "cmbOrdenacion";
            this.cmbOrdenacion.Size = new System.Drawing.Size(121, 24);
            this.cmbOrdenacion.TabIndex = 27;
            this.cmbOrdenacion.Text = "Ordenacion";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(939, 84);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(83, 26);
            this.btnEjecutar.TabIndex = 28;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 620);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbOrdenacion);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnEsLleno);
            this.Controls.Add(this.btnEsCompleto);
            this.Controls.Add(this.btnContarNodos);
            this.Controls.Add(this.btnContarHojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRecorrerNiveles);
            this.Controls.Add(this.btnEliminarSucesor);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnEliminarSucesor;
        private System.Windows.Forms.Button btnRecorrerNiveles;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnContarHojas;
        private System.Windows.Forms.Button btnContarNodos;
        private System.Windows.Forms.Button btnEsCompleto;
        private System.Windows.Forms.Button btnEsLleno;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.ComboBox cmbOrdenacion;
        private System.Windows.Forms.Button btnEjecutar;
    }
}