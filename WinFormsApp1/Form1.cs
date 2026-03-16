namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        GestorDeTareas gestor = new GestorDeTareas(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarLista()
        {
            listBox_tareas.Items.Clear();

            Tarea[] tareas = gestor.obtenerTareas();

            for (int i = 0; i < gestor.getNumTareas(); i++)
            {
                if (tareas[i] != null)
                    listBox_tareas.Items.Add(tareas[i]);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_añadir_Click(object sender, EventArgs e)
        {
            string titulo = textBox_nombre.Text;
            String descripcion = textBox_descripcion.Text;
            DateTime fecha = dateTimePicker_fecha.Value;

            gestor.crearTarea(titulo, descripcion, fecha, tipo);

            actualizarLista();
        }

        private void dateTimePicker_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_marcar_Click(object sender, EventArgs e)
        {
            if (listBox_tareas.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)listBox_tareas.SelectedItem;

                gestor.MarcarTareaCompletada(tareaSeleccionada.GetTitulo());

                actualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea");
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (listBox_tareas.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)listBox_tareas.SelectedItem;

                gestor.eliminarTarea(tareaSeleccionada.GetTitulo());

                actualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea");
            }
        }

        private void button_PrioridadAlta_Click(object sender, EventArgs e)
        {
            if (listBox_tareas.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)listBox_tareas.SelectedItem;

                gestor.MarcarPrioridadAlta(tareaSeleccionada.GetTitulo());

                actualizarLista();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
