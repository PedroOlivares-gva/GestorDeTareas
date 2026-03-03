using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    internal class Tarea
    {
        private string titulo;

        public string GetTitulo()
        {
            return this.titulo;
        }

        private string descripcion;
        private bool completada;
        private DateTime fecha;

        public Tarea(string titulo, string descripcion, DateTime fecha) { 
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.completada = false;
        this.fecha = fecha;
        }

        public void MarcarCompletada()
        {
            completada = true;
        }

        public override string ToString()
        {
            return titulo + " | " + fecha.ToShortDateString() + " | Completada: " + completada;
        }



    }
}
