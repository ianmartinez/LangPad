using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPadData.Inspectors
{
    public interface IInspectable<ValueEnumType>
    {
        // To be fired when something has changed on the object being inspected
        public event EventHandler<InspectorValueChangedEventArgs<ValueEnumType>> ValueChanged;
    }
}
