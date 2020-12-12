using System;

namespace TODO list
{
    /// <summary>
    /// la clase que define el hecho de que son tareas por realizar.
    /// </summary>
    class Todo
    {
        /// <summary>
        /// Descripción de la tarea
        /// </summary>
        public string description;

        /// <summary>
        /// controla y modifica la tarea cuando esta sigue estando pendiente o si esta ya fue hecha.
        /// </summary>
        public bool estate;

        public override string ToString()
        {
            return description;
        }


    }
}