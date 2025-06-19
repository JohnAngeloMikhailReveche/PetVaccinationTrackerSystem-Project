using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetVaccinationTrackerSystem_Project.Classes
{
    // Manager Class
    public static class FormManager
    {
        private static readonly Stack<Form> _formStack = new();

        public static void SwitchForm(Form current, Form next)
        {
            _formStack.Push(current); // Saves the current form to the stack
            next.FormClosed += (s, e) =>
            {
                if (_formStack.Count > 0)
                {
                    Form prevForm = _formStack.Pop();
                    if (!prevForm.IsDisposed)
                    {
                        prevForm.Show(); // Show the previous form when the next form is closed
                    }
                }
            };

            next.Show();
            current.Hide();
        }

    }
}
