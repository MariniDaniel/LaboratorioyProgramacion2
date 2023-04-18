namespace Registro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpDetalleUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rbBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.lboxPais = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkCSharp = new System.Windows.Forms.CheckBox();
            this.chekJava = new System.Windows.Forms.CheckBox();
            this.grpDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalleUsuario
            // 
            this.grpDetalleUsuario.Controls.Add(this.numEdad);
            this.grpDetalleUsuario.Controls.Add(this.txtDireccion);
            this.grpDetalleUsuario.Controls.Add(this.txtNombre);
            this.grpDetalleUsuario.Controls.Add(this.lblEdad);
            this.grpDetalleUsuario.Controls.Add(this.lblDireccion);
            this.grpDetalleUsuario.Controls.Add(this.lblNombre);
            this.grpDetalleUsuario.Location = new System.Drawing.Point(12, 12);
            this.grpDetalleUsuario.Name = "grpDetalleUsuario";
            this.grpDetalleUsuario.Size = new System.Drawing.Size(454, 235);
            this.grpDetalleUsuario.TabIndex = 0;
            this.grpDetalleUsuario.TabStop = false;
            this.grpDetalleUsuario.Text = "Detalles del Usuario";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(196, 173);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(246, 27);
            this.numEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(196, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(246, 27);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(40, 173);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(46, 20);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(40, 116);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rbBinario);
            this.grpGenero.Controls.Add(this.rbFemenino);
            this.grpGenero.Controls.Add(this.rbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(497, 22);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(250, 225);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rbBinario
            // 
            this.rbBinario.AutoSize = true;
            this.rbBinario.Location = new System.Drawing.Point(39, 166);
            this.rbBinario.Name = "rbBinario";
            this.rbBinario.Size = new System.Drawing.Size(101, 24);
            this.rbBinario.TabIndex = 2;
            this.rbBinario.TabStop = true;
            this.rbBinario.Text = "No Binario";
            this.rbBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(39, 106);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(95, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(39, 49);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(97, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chekJava);
            this.grpCursos.Controls.Add(this.checkCSharp);
            this.grpCursos.Controls.Add(this.checkC);
            this.grpCursos.Location = new System.Drawing.Point(497, 253);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(250, 193);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // lboxPais
            // 
            this.lboxPais.FormattingEnabled = true;
            this.lboxPais.ItemHeight = 20;
            this.lboxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lboxPais.Location = new System.Drawing.Point(12, 302);
            this.lboxPais.Name = "lboxPais";
            this.lboxPais.Size = new System.Drawing.Size(454, 144);
            this.lboxPais.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIngresar.Location = new System.Drawing.Point(280, 452);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(186, 58);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(33, 49);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(40, 24);
            this.checkC.TabIndex = 0;
            this.checkC.Text = "C";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // checkCSharp
            // 
            this.checkCSharp.AutoSize = true;
            this.checkCSharp.Location = new System.Drawing.Point(33, 92);
            this.checkCSharp.Name = "checkCSharp";
            this.checkCSharp.Size = new System.Drawing.Size(49, 24);
            this.checkCSharp.TabIndex = 1;
            this.checkCSharp.Text = "C#";
            this.checkCSharp.UseVisualStyleBackColor = true;
            // 
            // chekJava
            // 
            this.chekJava.AutoSize = true;
            this.chekJava.Location = new System.Drawing.Point(33, 136);
            this.chekJava.Name = "chekJava";
            this.chekJava.Size = new System.Drawing.Size(63, 24);
            this.chekJava.TabIndex = 2;
            this.chekJava.Text = "JAVA";
            this.chekJava.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 519);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxPais);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDetalleUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDetalleUsuario.ResumeLayout(false);
            this.grpDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpDetalleUsuario;
        private NumericUpDown numEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblNombre;
        private BindingSource bindingSource1;
        private GroupBox grpGenero;
        private RadioButton rbBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private GroupBox grpCursos;
        private ListBox lboxPais;
        private Label label1;
        private Button btnIngresar;
        private CheckBox chekJava;
        private CheckBox checkCSharp;
        private CheckBox checkC;
    }
}