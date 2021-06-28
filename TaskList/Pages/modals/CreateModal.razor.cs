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
    public partial class CreateModal
    {
        [CascadingParameter] public BlazoredModalInstance ModalInstance { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }

        public void SubmitForm()
        {
            ModalInstance.CloseAsync(ModalResult.Ok(new TaskObject() { TaskDesc = TaskDesc, TaskName = TaskName, isActive = true }));
        }
    }
}
