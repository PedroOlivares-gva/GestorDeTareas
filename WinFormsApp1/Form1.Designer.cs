namespace WinFormsApp1
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
            label_nombre = new Label();
            textBox_nombre = new TextBox();
            label_descripcion = new Label();
            textBox_descripcion = new TextBox();
            label_fecha = new Label();
            toolStrip1 = new ToolStrip();
            dateTimePicker_fecha = new DateTimePicker();
            button_añadir = new Button();
            button_marcar = new Button();
            button_eliminar = new Button();
            listBox_tareas = new ListBox();
            button_PrioridadAlta = new Button();
            label_tipo = new Label();
            comboBox_tipo = new ComboBox();
            label_textoContador = new Label();
            label_contadorTareas = new Label();
            button_limpiar = new Button();
            SuspendLayout();
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Location = new Point(123, 26);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(67, 20);
            label_nombre.TabIndex = 0;
            label_nombre.Text = "Nombre:";
            label_nombre.Click += label1_Click;
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(123, 58);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(284, 27);
            textBox_nombre.TabIndex = 1;
            textBox_nombre.TextChanged += textBox1_TextChanged;
            // 
            // label_descripcion
            // 
            label_descripcion.AutoSize = true;
            label_descripcion.Location = new Point(123, 103);
            label_descripcion.Name = "label_descripcion";
            label_descripcion.Size = new Size(90, 20);
            label_descripcion.TabIndex = 2;
            label_descripcion.Text = "Descripción:";
            // 
            // textBox_descripcion
            // 
            textBox_descripcion.Location = new Point(123, 135);
            textBox_descripcion.Multiline = true;
            textBox_descripcion.Name = "textBox_descripcion";
            textBox_descripcion.Size = new Size(284, 84);
            textBox_descripcion.TabIndex = 2;
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.Location = new Point(123, 335);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(50, 20);
            label_fecha.TabIndex = 4;
            label_fecha.Text = "Fecha:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(938, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // dateTimePicker_fecha
            // 
            dateTimePicker_fecha.Location = new Point(123, 358);
            dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            dateTimePicker_fecha.Size = new Size(284, 27);
            dateTimePicker_fecha.TabIndex = 4;
            dateTimePicker_fecha.ValueChanged += dateTimePicker_fecha_ValueChanged;
            // 
            // button_añadir
            // 
            button_añadir.Location = new Point(175, 403);
            button_añadir.Name = "button_añadir";
            button_añadir.Size = new Size(139, 44);
            button_añadir.TabIndex = 4;
            button_añadir.Text = "Añadir";
            button_añadir.UseVisualStyleBackColor = true;
            button_añadir.Click += button_añadir_Click;
            // 
            // button_marcar
            // 
            button_marcar.Location = new Point(413, 408);
            button_marcar.Name = "button_marcar";
            button_marcar.Size = new Size(133, 39);
            button_marcar.TabIndex = 6;
            button_marcar.Text = "Marcar completa";
            button_marcar.UseVisualStyleBackColor = true;
            button_marcar.Click += button_marcar_Click;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(552, 406);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(133, 39);
            button_eliminar.TabIndex = 7;
            button_eliminar.Text = "Eliminar";
            button_eliminar.UseVisualStyleBackColor = true;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // listBox_tareas
            // 
            listBox_tareas.AccessibleName = "";
            listBox_tareas.FormattingEnabled = true;
            listBox_tareas.Location = new Point(472, 43);
            listBox_tareas.Name = "listBox_tareas";
            listBox_tareas.Size = new Size(375, 324);
            listBox_tareas.TabIndex = 8;
            // 
            // button_PrioridadAlta
            // 
            button_PrioridadAlta.Location = new Point(691, 405);
            button_PrioridadAlta.Name = "button_PrioridadAlta";
            button_PrioridadAlta.Size = new Size(109, 42);
            button_PrioridadAlta.TabIndex = 9;
            button_PrioridadAlta.Text = "Prioridad Alta";
            button_PrioridadAlta.UseVisualStyleBackColor = true;
            button_PrioridadAlta.Click += button_PrioridadAlta_Click;
            // 
            // label_tipo
            // 
            label_tipo.AutoSize = true;
            label_tipo.Location = new Point(123, 234);
            label_tipo.Name = "label_tipo";
            label_tipo.Size = new Size(101, 20);
            label_tipo.TabIndex = 10;
            label_tipo.Text = "Tipo de tarea:";
            label_tipo.Click += label1_Click_1;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Items.AddRange(new object[] { "Trabajo", "Personal", "Estudios" });
            comboBox_tipo.Location = new Point(123, 268);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(151, 28);
            comboBox_tipo.TabIndex = 11;
            comboBox_tipo.SelectedIndexChanged += comboBox_tipo_SelectedIndexChanged;
            // 
            // label_textoContador
            // 
            label_textoContador.AutoSize = true;
            label_textoContador.Location = new Point(472, 20);
            label_textoContador.Name = "label_textoContador";
            label_textoContador.Size = new Size(74, 20);
            label_textoContador.TabIndex = 12;
            label_textoContador.Text = "Contador:";
            label_textoContador.Click += label1_Click_2;
            // 
            // label_contadorTareas
            // 
            label_contadorTareas.AutoSize = true;
            label_contadorTareas.Location = new Point(543, 20);
            label_contadorTareas.Name = "label_contadorTareas";
            label_contadorTareas.Size = new Size(17, 20);
            label_contadorTareas.TabIndex = 13;
            label_contadorTareas.Text = "0";
            label_contadorTareas.Click += label_contadorTareas_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Location = new Point(801, 405);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(125, 42);
            button_limpiar.TabIndex = 14;
            button_limpiar.Text = "Limpiar campos";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 474);
            Controls.Add(button_limpiar);
            Controls.Add(label_contadorTareas);
            Controls.Add(label_textoContador);
            Controls.Add(comboBox_tipo);
            Controls.Add(label_tipo);
            Controls.Add(button_PrioridadAlta);
            Controls.Add(listBox_tareas);
            Controls.Add(button_eliminar);
            Controls.Add(button_marcar);
            Controls.Add(button_añadir);
            Controls.Add(dateTimePicker_fecha);
            Controls.Add(toolStrip1);
            Controls.Add(label_fecha);
            Controls.Add(textBox_descripcion);
            Controls.Add(label_descripcion);
            Controls.Add(textBox_nombre);
            Controls.Add(label_nombre);
            Name = "Form1";
            Text = "Gestor de tareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nombre;
        private TextBox textBox_nombre;
        private Label label_descripcion;
        private TextBox textBox_descripcion;
        private Label label_fecha;
        private ToolStrip toolStrip1;
        private DateTimePicker dateTimePicker_fecha;
        private Button button_añadir;
        private Button button_marcar;
        private Button button_eliminar;
        private ListBox listBox_tareas;
        private Button button_PrioridadAlta;
        private Label label_tipo;
        private ComboBox comboBox_tipo;
        private Label label_textoContador;
        private Label label_contadorTareas;
        private Button button_limpiar;
    }
}
