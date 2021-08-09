using Eto.Drawing;
using Eto.Forms;
using LangPadData.Inspectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPad.Inspectors
{

    /// <summary>
    /// An inspector is a type of tool window/panel that contains
    /// info for an item that can be viewed/modified.
    /// </summary>
    /// 
    /// <typeparam name="ModelType">The model type.</typeparam>
    /// <typeparam name="ValueEnumType">The types of values on the model.</typeparam>
    public abstract class InspectorForm<ModelType, ValueEnumType> : Form
    {
        private ModelType model;

        /// <summary>
        /// Panel to show if there is no item selected to inspect.
        /// </summary>
        public Panel NoModelPanel = new Panel
        {
            Content = new Label
            {
                Text = "Nothing selected",
                TextAlignment = TextAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            },
            Padding = new Padding(10)
        };

        /// <summary>
        /// Panel to show if there is an item to inspect
        /// </summary>
        public Panel ModelPanel = new Panel { };

        /// <summary>
        /// If the value is being refreshed automatically, to avoid accidentally 
        /// triggering a ValueChanged event.
        /// </summary>
        public bool IsRefreshing { get; set; }

        /// <summary>
        /// To be fired when the user changes something on the inspector and the value is different.
        /// </summary>
        public event EventHandler<InspectorValueChangedEventArgs<ValueEnumType>> ValueChanged;

        /// <summary>
        /// To be fired when the model is changed.
        /// </summary>
        public event EventHandler<EventArgs> ModelChanged;

        /// <summary>
        /// When the user has clicked the "delete" button on the inspector.
        /// </summary>
        public event EventHandler<EventArgs> DeleteModel;

        /// <summary>
        /// The object that is being inspected.
        /// </summary>
        public ModelType Model
        {
            get => model;

            set
            {
                model = value;
                UpdatePanel();
                ModelChanged?.Invoke(this, new EventArgs());
                RefreshAll();
            }
        }

        /// <summary>
        /// If there is currently a model.
        /// </summary>
        public bool ModelExists => Model != null;

        /// <summary>
        /// Choose which panel to show based on if there is a model or not.
        /// </summary>
        private void UpdatePanel()
        {
            Content = ModelExists ? ModelPanel : NoModelPanel;
        }

        /// <summary>
        /// Reload a specific value on the inspector.
        /// </summary>
        /// 
        /// <param name="targetValue">The target value.</param>
        public abstract void RefreshValue(ValueEnumType targetValue);

        /// <summary>
        /// Reload the inspector completely.
        /// </summary>
        public virtual void RefreshAll()
        {
            foreach (ValueEnumType value in Enum.GetValues(typeof(ValueEnumType)))
                RefreshValue(value);
        }

        /// <summary>
        /// Fire InspectorValueChanged with EventArgs if the new value is different.
        /// </summary>
        /// 
        /// <typeparam name="ValueType">The type of the value being changed.</typeparam>
        /// <param name="targetValue">The value to change.</param>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        public virtual void UpdateValue<ValueType>(ValueEnumType targetValue, IComparable oldValue, IComparable newValue)
        {
            if (ValueChanged != null && oldValue != newValue && !IsRefreshing)
            {
                var args = new InspectorValueChangedEventArgs<ValueEnumType>()
                {
                    OldValue = oldValue,
                    NewValue = newValue,
                    TargetValue = targetValue
                };

                ValueChanged(this, args);
            }
        }

        /// <summary>
        /// Trigger the delete event when the user has decided to delete the model.
        /// </summary>
        public virtual void Delete()
        {
            DeleteModel?.Invoke(this, new EventArgs());
        }


        private bool hasSubscribed = false;
        /// <summary>
        /// Call instead of the standard Show() method.
        /// </summary>
        /// 
        /// <param name="parent">The form that this inspector is attached to.</param>
        public void Show(Form parent)
        {
            if (!hasSubscribed)
            {
                Closing += InspectorForm_Closing;
                hasSubscribed = true;
            }

            if (!Visible)
            {
                UpdatePanel();
                Owner = null;
                RefreshAll();
                Show();
                Owner = parent;
            }
        }

        /// <summary>
        /// For some reason, the Visible value is not returned correctly on Windows after a form is closed,
        /// so instead, inspectors are never *really* closed, just hidden.
        /// </summary>
        /// 
        /// <param name="sender">The sender.</param>
        /// <param name="e">The EventArgs.</param>
        private void InspectorForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}
