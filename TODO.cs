using System;
using System.Collections.Generic;

namespace PR3_TODO_List
{
    class TODO
    {
        /// <summary>
        /// es una lista de tareas incompletas
        /// </summary>
        public List<Tasck> todo = new List<Tasck>();
        /// <summary>
        /// es una lista de tareas completas
        /// </summary>
        public List<Tasck> done = new List<Tasck>();
        Tasck tasck = new Tasck();
        
        public void AddTasck(string name, string deetails){
            todo.Add(tasck);
            this.tasck.name = name;
            this.tasck.deetail = deetails;
        }
        // cambia el estado de la tarea entre complleta (1) e incompleta (0)
        public void ChangeTackStatus(int tasckSelected, int tasckStatus){
            // System.Console.WriteLine("Cual es la tarea");
            // tasckSelected = Convert.ToInt32(Console.ReadLine());
            // todo[tasckSelected].Done(tasckStatus) = Convert.ToString(Console.ReadLine());
            todo[tasckSelected].Done(tasckStatus);
            if (tasckStatus == 1)
            {
                done.Add(todo[tasckSelected]);
                // todo.Remove(todo[tasckSelected]);
            }
            else{
                // todo.Add(todo[tasckSelected]);
                // done.Remove(todo[tasckSelected]);
            }
        }

        public void PrintCompleetedTascks(){
            foreach (var item in done)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public void PrintIncompleetTadcks(){
            foreach (var item in todo)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public void PrintAll(){
            PrintCompleetedTascks();
            PrintIncompleetTadcks();
        }

        public void DeleteCompletedTasck(int tasckSelected){
            done.Remove(done[tasckSelected]);
        }
        public void DeleteIncompletedTasck(int tasckSelected){
            todo.Remove(todo[tasckSelected]);
        }
    }
}
