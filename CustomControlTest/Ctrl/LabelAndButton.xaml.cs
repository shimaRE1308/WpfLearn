using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControlTest.Ctrl
{
    /// <summary>
    /// LabelAndButton.xaml の相互作用ロジック
    /// </summary>
    public partial class LabelAndButton : UserControl
    {
        public LabelAndButton()
        {
            InitializeComponent();
        }

        private static readonly DependencyProperty TextProp = DependencyProperty.Register("Text", typeof(string), typeof(LabelAndButton));

        public string Text
        {
            get { return (string)GetValue(TextProp); }
            set { SetValue(TextProp, value); }
        }

        private static readonly DependencyProperty ButtonLabelProp = DependencyProperty.Register("BtnLabel", typeof(string), typeof(LabelAndButton));

        public string BtnLabel
        {
            get { return (string)GetValue(ButtonLabelProp); }
            set { SetValue(ButtonLabelProp, value); }
        }


        private static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("BtnClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LabelAndButton));

        public event RoutedEventHandler BtnClick
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(LabelAndButton.ClickEvent);
            RaiseEvent(newEventArgs);
        }
    }
}
