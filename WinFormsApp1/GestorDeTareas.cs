using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GestorDeTareas
    {
        private Tarea[] tareas;
        private int capacidad;
        private int numTareas;

        public GestorDeTareas(int capacidad)
        {
            tareas = new Tarea[capacidad];
            this.capacidad = capacidad;
            numTareas = 0;
        }

        public void crearTarea(string nombre, string descripcion, DateTime fecha, string tipo)
        {
            if (numTareas < capacidad)
            {
                tareas[numTareas++] = new Tarea(nombre, descripcion, fecha, tipo);
            }
            else
            {
                MessageBox.Show("No se pueden añadir más tareas");
            }
        }

        public Tarea[] obtenerTareas()
        {
            return tareas;
        }

        public int getNumTareas()
        {
            return numTareas;
        }

        public void eliminarTarea(string nombre)
        {
            for (int i = 0; i < numTareas; i++)
            {
                if (tareas[i].GetTitulo().Equals(nombre))
                {
                    tareas[i] = tareas[numTareas - 1];
                    tareas[numTareas - 1] = null;
                    numTareas--;
                    MessageBox.Show("Tarea eliminada");
                    return;
                }
            }

            MessageBox.Show("No se encontró la tarea");
        }



        public void MarcarTareaCompletada(string nombre)
        {
            for (int i = 0; i < numTareas; i++)
            {
                if (tareas[i].GetTitulo().Equals(nombre))
                {
                    tareas[i].MarcarCompletada();
                    MessageBox.Show("Tarea completada");
                    return;
                }
            }

            MessageBox.Show("No se encontró la tarea");
        }



        public void MarcarPrioridadAlta(string nombre)
        {
            for (int i = 0; i < numTareas; i++)
            {
                if (tareas[i].GetTitulo().Equals(nombre))
                {
                    Tarea primera = tareas[i];

                    for (int j = i; j > 0; j--)
                    {
                        tareas[j] = tareas[j - 1];
                    }

                    tareas[0] = primera;

                    return;
                }
            }
        }

    }

    

        

}

