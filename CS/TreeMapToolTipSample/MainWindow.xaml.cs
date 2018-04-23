using DevExpress.Xpf.TreeMap;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeMapToolTipSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    [ContentProperty("Position")]
    public class PositionWrapper {
        public string PositionName { get; set; }
        public ToolTipPosition Position { get; set; }
    }

    public class OpenModeWrapper {
        public string OpenModeName { get; set; }
        public ToolTipOpenMode OpenMode { get; set; }
    }
}
