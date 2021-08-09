using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPadData.Inspectors
{
    /// <summary>
    /// The EventArgs for a value change on a inspector.
    /// </summary>
    /// 
    /// <typeparam name="ValueEnumType">The type of the value being changed.</typeparam>
    public class InspectorValueChangedEventArgs<ValueEnumType> : EventArgs
    {
        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public ValueEnumType TargetValue { get; set; }
    }
}
