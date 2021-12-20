using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7WPF
{
    class MyCommands
    {
        public static RoutedCommand Color { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
            Color = new RoutedCommand("Color", typeof(MyCommands), inputs);
        }

    }
}
