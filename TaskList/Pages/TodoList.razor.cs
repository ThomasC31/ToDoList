using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskList.Class;

namespace TaskList.Pages
{
    public partial class TodoList
    {
        private List<TaskObject> tasks = new List<TaskObject>();

        protected override void OnInitialized()
        {
            tasks = new List<TaskObject>() { new TaskObject { TaskName = "tache 1", TaskDesc = "Description de la premiere tache", isActive = true }, new TaskObject { TaskName = "tache 2", TaskDesc = "Description de la seconde tache", isActive = true }, new TaskObject { TaskName = "tache 3", TaskDesc = "Description de la troisieme tache", isActive = true } };
        }
    }
}
