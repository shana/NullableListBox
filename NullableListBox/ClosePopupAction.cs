using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace NullableListBox
{
    public class ClosePopupAction : TargetedTriggerAction<Popup>
    {
        protected override void Invoke(object parameter)
        {
            Target.IsOpen = false;
        }
    }
}