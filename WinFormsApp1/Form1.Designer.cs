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
            textBox_descripcion.Size = new Size(284, 123);
            textBox_descripcion.TabIndex = 2;
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.Location = new Point(123, 270);
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
            toolStrip1.Size = new Size(907, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // dateTimePicker_fecha
            // 
            dateTimePicker_fecha.Location = new Point(123, 293);
            dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            dateTimePicker_fecha.Size = new Size(284, 27);
            dateTimePicker_fecha.TabIndex = 4;
            dateTimePicker_fecha.ValueChanged += dateTimePicker_fecha_ValueChanged;
            // 
            // button_añadir
            // 
            button_añadir.Location = new Point(175, 358);
            button_añadir.Name = "button_añadir";
            button_añadir.Size = new Size(139, 44);
            button_añadir.TabIndex = 4;
            button_añadir.Text = "Añadir";
            button_añadir.UseVisualStyleBackColor = true;
            button_añadir.Click += button_añadir_Click;
            // 
            // button_marcar
            // 
            button_marcar.Location = new Point(472, 408);
            button_marcar.Name = "button_marcar";
            button_marcar.Size = new Size(133, 39);
            button_marcar.TabIndex = 6;
            button_marcar.Text = "Marcar completa";
            button_marcar.UseVisualStyleBackColor = true;
            button_marcar.Click += button_marcar_Click;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(611, 408);
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
            button_PrioridadAlta.Location = new Point(750, 408);
            button_PrioridadAlta.Name = "button_PrioridadAlta";
            button_PrioridadAlta.Size = new Size(109, 42);
            button_PrioridadAlta.TabIndex = 9;
            button_PrioridadAlta.Text = "Prioridad Alta";
            button_PrioridadAlta.UseVisualStyleBackColor = true;
            button_PrioridadAlta.Click += button_PrioridadAlta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 474);
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
    }
}
