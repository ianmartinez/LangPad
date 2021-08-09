using Eto.Drawing;
using Eto.Forms;
using LangPadData.Inspectors;
using LangPadData.Notebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPad.Inspectors
{
    public enum PageInspectorValue
    {
        Title,
        Index,
        Notes
    }

    public class PageInspector : InspectorForm<Page, PageInspectorValue>
    {
        TableLayout pageLayout;
        TextBox titleTextBox;
        TextArea notesTextArea;
        NumericStepper indexStepper;
        Button deletePageButton;
        private bool hasSubscribed;

        public PageInspector()
        {
            UpdateTitle();
            MinimumSize = new Size(250, 375);
            Size = MinimumSize;

            ModelChanged += PageInspector_ModelChanged;

            titleTextBox = new TextBox();
            titleTextBox.TextChanged += OnTitleChanged;

            indexStepper = new NumericStepper
            {
                MinValue = 0,
                MaxValue = 1
            };
            indexStepper.ValueChanged += OnIndexChanged;

            notesTextArea = new TextArea();
            notesTextArea.TextChanged += OnNotesChanged;

            deletePageButton = new Button
            {
                Text = "Delete Page"
            };
            deletePageButton.Click += OnDelete;

            pageLayout = new TableLayout()
            {
                Padding = new Padding(10), // padding around cells
                Spacing = new Size(5, 5), // spacing between each cell
                Rows =
                    {
                        new TableRow(new StackLayout {
                            Orientation = Orientation.Vertical,
                            HorizontalContentAlignment = HorizontalAlignment.Center,
                            VerticalContentAlignment = VerticalAlignment.Center,
                            Items = { deletePageButton }
                        }),
                        new TableRow(new Label { Text = "Title:", VerticalAlignment = VerticalAlignment.Bottom }),
                        new TableRow(new TableCell(titleTextBox, true)),
                        new TableRow(new Label { Text = "Index:", VerticalAlignment = VerticalAlignment.Bottom }),
                        new TableRow(new TableCell(indexStepper, true)),
                        new TableRow(new Label { Text = "Notes:", VerticalAlignment = VerticalAlignment.Bottom }),
                        new TableRow(new TableCell(notesTextArea, true))
                    }
            };

            ModelPanel.Content = pageLayout;
        }

        private void PageInspector_ModelChanged(object sender, EventArgs e)
        {
            UpdateTitle();

            if (ModelExists)
            {
                if (Height < 300)
                    Height = 300;

                // Add event handler if it doesn't already exist
                if (!hasSubscribed)
                    Model.ParentNotebook.ValueChanged += ParentNotebook_ValueChanged;

                hasSubscribed = true;
            }
        }

        private void ParentNotebook_ValueChanged(object sender, InspectorValueChangedEventArgs<NotebookInspectorValue> e)
        {
            if (!IsRefreshing)
            {
                switch (e.TargetValue)
                {
                    case NotebookInspectorValue.PageCount:
                        indexStepper.MaxValue = (int)e.NewValue - 1;
                        break;
                }
            }
        }

        public override void RefreshValue(PageInspectorValue targetValue)
        {
            if (ModelExists)
            {
                IsRefreshing = true;

                switch (targetValue)
                {
                    case PageInspectorValue.Title:
                        titleTextBox.Text = Model.Title;
                        UpdateTitle();
                        break;
                    case PageInspectorValue.Index:
                        indexStepper.Value = Model.Index;
                        indexStepper.MaxValue = Model.ParentNotebook.Pages.Count - 1;
                        break;
                    case PageInspectorValue.Notes:
                        notesTextArea.Text = Model.Notes;
                        break;
                }

                IsRefreshing = false;
            }
        }

        private void UpdateTitle()
        {
            Title = (ModelExists) ? titleTextBox.Text + " - Info" : "Page Info";
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (ModelExists)
            {
                var deleteWarning =
                    MessageBox.Show(string.Format("Are you sure you want to delete the page '{0}'? This cannot be undone.", Model.Title),
                        MessageBoxButtons.YesNo, MessageBoxType.Warning, MessageBoxDefaultButton.No);

                if (deleteWarning == DialogResult.Yes)
                {
                    Delete();
                }
            }
        }

        private void OnTitleChanged(object sender, EventArgs e)
        {
            if (ModelExists)
            {
                UpdateTitle();
                UpdateValue<string>(PageInspectorValue.Title, Model.Title, titleTextBox.Text);
            }
        }

        private void OnIndexChanged(object sender, EventArgs e)
        {
            if (ModelExists && Model.Index != -1) // It can temporarily be -1 while it is being moved
            {
                UpdateValue<int>(PageInspectorValue.Index, Model.Index, indexStepper.Value);
            }
        }

        private void OnNotesChanged(object sender, EventArgs e)
        {
            if (ModelExists)
            {
                UpdateValue<string>(PageInspectorValue.Notes, Model.Notes, notesTextArea.Text);
            }
        }
    }
}
