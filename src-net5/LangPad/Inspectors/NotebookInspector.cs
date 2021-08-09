using LangPadData.Notebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPad.Inspectors
{
    public class NotebookInspector : InspectorForm<Notebook, NotebookInspectorValue>
    {
        public NotebookInspector()
        {
        }

        public override void RefreshValue(NotebookInspectorValue targetValue)
        {
            throw new NotImplementedException();
        }
    }
}
