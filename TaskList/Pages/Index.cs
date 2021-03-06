//using Blazored.Modal;
//using Blazored.Modal.Services;
//using Microsoft.AspNetCore.Components;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TaskList.Class;
//using TaskList.Pages.modals;

//namespace TaskList.Pages
//{
//    public partial class Index
//    {
//        private List<TaskObject> tasks = new List<TaskObject>();
//        [CascadingParameter] public IModalService Modal { get; set; }
//        protected override void OnInitialized()
//        {
//            tasks = new List<TaskObject>() { new TaskObject { TaskName = "tache 1", TaskDesc = "Description de la premiere tache", isActive = true }, new TaskObject { TaskName = "tache 2", TaskDesc = "Description de la seconde tache", isActive = true }, new TaskObject { TaskName = "tache 3", TaskDesc = "Description de la troisieme tache", isActive = true } };
//        }

//        public async Task DeleteTask(TaskObject task)
//        {
//            tasks.Remove(task);
//        }

//        public async Task OnOpenCreateModal()
//        {
//            var taskModal = Modal.Show<CreateModal>("Créer une tâche");
//            var result = await taskModal.Result;

//            if (result.Cancelled)
//            {
//                Console.WriteLine("Modal was cancelled");
//            }
//            else
//            {
//                tasks.Add((TaskObject)result.Data);
//            }
//        }

//        public async Task OnOpenEditModal(TaskObject task)
//        {
//            var parameters = new ModalParameters();
//            parameters.Add(nameof(EditModal.Task), task);
//            var taskModal = Modal.Show<EditModal>("Editer une tâche", parameters);
//            var result = await taskModal.Result;
//        }
//    }
//}
