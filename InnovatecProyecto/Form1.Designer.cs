namespace InnovatecProyecto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMostrarArbol = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRecorrerPreorden = new System.Windows.Forms.Button();
            this.lbArbol = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsertarNodo = new System.Windows.Forms.Button();
            this.tbHijo = new System.Windows.Forms.TextBox();
            this.tbPadre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbGrafo = new System.Windows.Forms.ListBox();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.tbFin = new System.Windows.Forms.TextBox();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarConexiones = new System.Windows.Forms.Button();
            this.tbConsultar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.tbEdificio2 = new System.Windows.Forms.TextBox();
            this.tbEdificio1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvArbol);
            this.tabPage1.Controls.Add(this.btnMostrarArbol);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnRecorrerPreorden);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnInsertarNodo);
            this.tabPage1.Controls.Add(this.tbHijo);
            this.tabPage1.Controls.Add(this.tbPadre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbArbol);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Árbol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarArbol
            // 
            this.btnMostrarArbol.Location = new System.Drawing.Point(658, 320);
            this.btnMostrarArbol.Name = "btnMostrarArbol";
            this.btnMostrarArbol.Size = new System.Drawing.Size(91, 46);
            this.btnMostrarArbol.TabIndex = 11;
            this.btnMostrarArbol.Text = "Mostrar Árbol";
            this.btnMostrarArbol.UseVisualStyleBackColor = true;
            this.btnMostrarArbol.Click += new System.EventHandler(this.btnMostrarArbol_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(542, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Contar Nodos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRecorrerPreorden
            // 
            this.btnRecorrerPreorden.Location = new System.Drawing.Point(427, 320);
            this.btnRecorrerPreorden.Name = "btnRecorrerPreorden";
            this.btnRecorrerPreorden.Size = new System.Drawing.Size(91, 46);
            this.btnRecorrerPreorden.TabIndex = 9;
            this.btnRecorrerPreorden.Text = "Recorrer Preorden";
            this.btnRecorrerPreorden.UseVisualStyleBackColor = true;
            this.btnRecorrerPreorden.Click += new System.EventHandler(this.btnRecorrerPreorden_Click);
            // 
            // lbArbol
            // 
            this.lbArbol.FormattingEnabled = true;
            this.lbArbol.ItemHeight = 16;
            this.lbArbol.Location = new System.Drawing.Point(438, 26);
            this.lbArbol.Name = "lbArbol";
            this.lbArbol.Size = new System.Drawing.Size(301, 20);
            this.lbArbol.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar Nodo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInsertarNodo
            // 
            this.btnInsertarNodo.Location = new System.Drawing.Point(285, 115);
            this.btnInsertarNodo.Name = "btnInsertarNodo";
            this.btnInsertarNodo.Size = new System.Drawing.Size(116, 38);
            this.btnInsertarNodo.TabIndex = 4;
            this.btnInsertarNodo.Text = "Insertar nodo";
            this.btnInsertarNodo.UseVisualStyleBackColor = true;
            this.btnInsertarNodo.Click += new System.EventHandler(this.btnInsertarNodo_Click);
            // 
            // tbHijo
            // 
            this.tbHijo.Location = new System.Drawing.Point(152, 63);
            this.tbHijo.Name = "tbHijo";
            this.tbHijo.Size = new System.Drawing.Size(249, 22);
            this.tbHijo.TabIndex = 3;
            // 
            // tbPadre
            // 
            this.tbPadre.Location = new System.Drawing.Point(152, 26);
            this.tbPadre.Name = "tbPadre";
            this.tbPadre.Size = new System.Drawing.Size(249, 22);
            this.tbPadre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Hijo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Padre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbGrafo);
            this.tabPage2.Controls.Add(this.btnCalcularRuta);
            this.tabPage2.Controls.Add(this.tbFin);
            this.tabPage2.Controls.Add(this.tbInicio);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnMostrarConexiones);
            this.tabPage2.Controls.Add(this.tbConsultar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnAgregarArista);
            this.tabPage2.Controls.Add(this.tbDistancia);
            this.tabPage2.Controls.Add(this.tbEdificio2);
            this.tabPage2.Controls.Add(this.tbEdificio1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbGrafo
            // 
            this.lbGrafo.FormattingEnabled = true;
            this.lbGrafo.ItemHeight = 16;
            this.lbGrafo.Location = new System.Drawing.Point(425, 165);
            this.lbGrafo.Name = "lbGrafo";
            this.lbGrafo.Size = new System.Drawing.Size(294, 196);
            this.lbGrafo.TabIndex = 15;
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(525, 103);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(115, 41);
            this.btnCalcularRuta.TabIndex = 14;
            this.btnCalcularRuta.Text = "Calcular ruta más corta";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            this.btnCalcularRuta.Click += new System.EventHandler(this.btnCalcularRuta_Click);
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(488, 62);
            this.tbFin.Name = "tbFin";
            this.tbFin.Size = new System.Drawing.Size(152, 22);
            this.tbFin.TabIndex = 13;
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(488, 21);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(152, 22);
            this.tbInicio.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Inicio:";
            // 
            // btnMostrarConexiones
            // 
            this.btnMostrarConexiones.Location = new System.Drawing.Point(209, 273);
            this.btnMostrarConexiones.Name = "btnMostrarConexiones";
            this.btnMostrarConexiones.Size = new System.Drawing.Size(95, 47);
            this.btnMostrarConexiones.TabIndex = 9;
            this.btnMostrarConexiones.Text = "Mostrar Conexiones";
            this.btnMostrarConexiones.UseVisualStyleBackColor = true;
            this.btnMostrarConexiones.Click += new System.EventHandler(this.btnMostrarConexiones_Click);
            // 
            // tbConsultar
            // 
            this.tbConsultar.Location = new System.Drawing.Point(152, 234);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Size = new System.Drawing.Size(152, 22);
            this.tbConsultar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Edificio a consultar:";
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(151, 140);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(95, 47);
            this.btnAgregarArista.TabIndex = 6;
            this.btnAgregarArista.Text = "Agregar Arista";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click);
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(94, 99);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(152, 22);
            this.tbDistancia.TabIndex = 5;
            // 
            // tbEdificio2
            // 
            this.tbEdificio2.Location = new System.Drawing.Point(94, 62);
            this.tbEdificio2.Name = "tbEdificio2";
            this.tbEdificio2.Size = new System.Drawing.Size(152, 22);
            this.tbEdificio2.TabIndex = 4;
            // 
            // tbEdificio1
            // 
            this.tbEdificio1.Location = new System.Drawing.Point(94, 24);
            this.tbEdificio1.Name = "tbEdificio1";
            this.tbEdificio1.Size = new System.Drawing.Size(152, 22);
            this.tbEdificio1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Distancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Edificio 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edificio 1:";
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(438, 26);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(301, 274);
            this.tvArbol.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbArbol;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsertarNodo;
        private System.Windows.Forms.TextBox tbHijo;
        private System.Windows.Forms.TextBox tbPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarArbol;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRecorrerPreorden;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.TextBox tbEdificio2;
        private System.Windows.Forms.TextBox tbEdificio1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarConexiones;
        private System.Windows.Forms.TextBox tbConsultar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbGrafo;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.TextBox tbFin;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tvArbol;
    }
}

