using System;
using System.Collections.Generic;

namespace TODO_list
{
    /// <summary>
    /// dentro de esta se encuentra toda la funcion principal de el codigo
    /// </summary>
    class TODOList
    {
        
        string screen = "";
        /// <summary>
        /// aqui se enlistan todas las tareas en general, sin importar si estas fueron finalizadas o no.
        /// </summary>
        List<ToDo> ToDoList = new List<ToDo>();
        /// <summary>
        /// en esta se agregan las tareas que se encuentran pendientes en el momento.
        /// </summary>
        List<ToDo> pendinglist = new List<ToDo>();
        /// <summary>
        /// al ser finalizada una de las tareas, se agregara a esta lista.
        /// </summary>
        List<ToDo> finishedlist = new List<ToDo>();

        public string ScreenMessage()
        {
            return this.screen;
        }

        /// <summary>
        /// Permite añadir una tarea nueva, la tarea debe estar pendiente para poder añadirla
        /// </summary>
        public void Add(ToDo Pending)
        {
            if(pending.TakePending() == false)
            {
                this.Todolist.Add(pending);
                this.message = "added succsesfully";
            }
            else
            {
                this.message = "once finished, tasks cannot be added again";
            } 
        }

        /// <summary>
        /// muestra en la pantalla todas las tareas que de mometo se encuentran pendientes, al igual que las tareas que ya fueron terminadas
        /// </summary>
        public void PrintList(List<ToDo> List)
        {
            this.Screen = "";
            
            if(List.Count == 0)
            {
                this.screen = "no task available at the moment";
            }
            else
            {
                foreach (var item in List)
                {
                    this.screen = this.screen + item.TakeDescrption() + ":"; 
                    if (item.TakePending() == false)
                    {
                        this.screen = this.screen + " Pending... ";
                    } 
                    else
                    {
                        this.screen = this.screen + " Finished... ";
                    }
                }
            }
        }
        
    }
}
