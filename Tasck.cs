using System;

namespace PR3_TODO_List
{
    class Tasck
    {
        public string name;
        public string deetail;
        public bool complition = false;
        // sirve para comparar si la tarea ya fue realisada
        public void Done(int selection){
            switch (selection)
            {
                case 0: complition = false;
                break;
                case 1: complition = true;
                break;
                default:
                    System.Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
