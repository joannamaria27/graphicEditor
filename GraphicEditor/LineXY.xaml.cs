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
using System.Windows.Shapes;

namespace GraphicEditor
{
    /// <summary>
    /// Logika interakcji dla klasy LineXY.xaml
    /// </summary>
    public partial class LineXY : Window
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public LineXY()
        {
            InitializeComponent();
        }

        private void Zatwierdz(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            if (!int.TryParse(txtX1.Text, out x1))
                x1 = 0;
            if (!int.TryParse(txtX2.Text, out x2))
                x2 = 0;
            if (!int.TryParse(txtY1.Text, out y1))
                y1 = 0;
            if (!int.TryParse(txtY2.Text, out y2))
                y2 = 0;
        }
        private void Anuluj(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
