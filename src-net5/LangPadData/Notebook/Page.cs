namespace LangPadData.Notebook
{
    /// <summary>
    /// A page in a notebook.
    /// </summary>
    public class Page
    {
        public Notebook ParentNotebook { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Notes { get; set; }
        public int Index
        {
            get => ParentNotebook.Pages.IndexOf(this);

            set
            {
                ParentNotebook.Pages.Remove(this);
                ParentNotebook.Pages.Insert(value, this);
            }
        }

        public Page(Notebook parent)
        {
            ParentNotebook = parent;
        }
    }
}
