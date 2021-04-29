using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskList.Class;

namespace TaskList.Pages.modals
{
    public partial class EditModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        [Parameter] public TaskObject Task { get; set; }
        //private string TaskName { get; set; }
        //private string TaskDesc { get; set; }
        //private bool isActive { get; set; }
        void SubmitForm()
        {
            //Task = new TaskObject() { TaskDesc = TaskDesc, TaskName = TaskName,isActive= isActive };
            ModalInstance.CloseAsync(ModalResult.Ok(Task));
        }
    }
}
