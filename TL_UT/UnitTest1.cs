using Bunit;
using System;
using Xunit;

namespace TL_UT
{
    public class UnitTest1
    {
        private TaskList.Class.TaskObject Expected = new TaskList.Class.TaskObject { TaskName = "test1", TaskDesc = "test de la task", isActive = false };

        [Fact]
        public void DisplayMainWindowTest()
        {

            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.Index>();

        }

        [Fact]
        public void DeleteTaskTest()
        {
            
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.Index>();
            cut.Instance.DeleteTask(Expected);
        }

        [Fact]
        public void OpenAddWindowTest()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.Index>();
            cut.Instance.OnOpenCreateModal();
        }

        [Fact]
        public void AddTaskTest()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.modals.CreateModal>();
            cut.Instance.ModalInstance = new Blazored.Modal.BlazoredModalInstance();
            cut.Instance.SubmitForm();
        }

        [Fact]
        public void OpenEditWindowTest()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.Index>();
            cut.Instance.OnOpenEditModal(Expected);
        }

        [Fact]
        public void EditTaskTest()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<TaskList.Pages.modals.EditModal>();
            cut.SetParametersAndRender(parameters => parameters.Add(p => p.Task, new TaskList.Class.TaskObject() { TaskDesc = "test1", TaskName = "test1", isActive = true }));
            cut.Instance.ModalInstance = new Blazored.Modal.BlazoredModalInstance();
         
            cut.Instance.SubmitForm();
        }
    }
}
