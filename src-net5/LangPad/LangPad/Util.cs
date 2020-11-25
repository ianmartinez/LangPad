using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LangPad
{
    static class Util
    {
        /// <summary>
        /// Move an item of type T in a list from and old index to a new index.
        /// </summary>
        /// 
        /// <typeparam name="T">The type of item in the list.</typeparam>
        /// 
        /// <param name="list">The list to modify.</param>
        /// <param name="oldIndex">The old index.</param>
        /// <param name="newIndex">The new index.</param>
        public static void MoveItem<T>(IList list, int oldIndex, int newIndex)
        {
            T item = (T)list[oldIndex];
            list.RemoveAt(oldIndex);
            list.Insert(newIndex, item);
        }

        /// <summary>
        /// Get the number of words in a text.
        /// </summary>
        /// 
        /// <param name="text">The text to look through.</param>
        /// 
        /// <returns>The number of words.</returns>
        public static int WordCount(string text)
        {
            return text.Trim().Split(new[] { " ", "\t", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Signal to the user that an operation is being processed.
        /// </summary>
        /// 
        /// <param name="targetForm">The form that is the target of the operation.</param>
        public static void BeginOperation(Form targetForm)
        {
            targetForm.Cursor = Cursors.WaitCursor;
            targetForm.Enabled = false;
            targetForm.SuspendLayout();
        }

        /// <summary>
        /// Signal to the user that an operation has completed.
        /// </summary>
        /// 
        /// <param name="targetForm">The form that is the target of the operation.</param>
        public static void EndOperation(Form targetForm)
        {
            targetForm.Cursor = Cursors.Default;
            targetForm.Enabled = true;
            targetForm.ResumeLayout();
        }
    }
}
