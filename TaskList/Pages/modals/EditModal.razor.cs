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
        [CascadingParameter] public BlazoredModalInstance ModalInstance { get; set; }
        [Parameter] public TaskObject Task { get; set; }

        public void SubmitForm()
        {
            ModalInstance.CloseAsync(ModalResult.Ok(Task));
        }
    }
}
