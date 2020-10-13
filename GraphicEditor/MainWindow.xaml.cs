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

namespace GraphicEditor
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LineDraw_Click(object sender, RoutedEventArgs e)
        {
            LineXY lineXY = new LineXY();
            lineXY.ShowDialog();

            Line myLine = new Line
            {
                Stroke = Brushes.Black,
                X1 = lineXY.x1,
                X2 = lineXY.x2,
                Y1 = lineXY.y1,
                Y2 = lineXY.y2,
                StrokeThickness = 2
            };
            myLine.MouseDown += MyLine_MauseDown;
            myLine.MouseUp += MyLine_MauseUp;
            CanvasPaint.Children.Add(myLine);
        }
        Point point = new Point();
        private void MyLine_MauseUp(object sender, MouseButtonEventArgs e)
        {
            point = e.GetPosition(this);
        }
        private void MyLine_MauseDown(object sender, MouseButtonEventArgs e)
        {
            Point newPoint = new Point();
            newPoint = e.GetPosition(this); 
            Canvas.SetLeft((UIElement)sender, newPoint.X);
            Canvas.SetBottom((UIElement)sender, newPoint.Y);

        }
        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            // Get the x and y coordinates of the mouse pointer.
            System.Windows.Point position = e.GetPosition(this);
            double pX = position.X;
            double pY = position.Y;

            // Sets the Height/Width of the circle to the mouse coordinates.
            if(EditLine_Button)
            {
                myLine
                CanvasPaint.myLine.Width = pX;
                ellipse.Height = pY;
            }
           
        }
        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {
            LineXY lineXY = new LineXY();
            lineXY.ShowDialog();
            Rectangle myRectangle = new Rectangle
            {
                Height = lineXY.x1 + lineXY.y1,
                Width = lineXY.x2 + lineXY.y2,
                Stroke = Brushes.Black,
                StrokeThickness = 2,

            };
            Canvas.SetLeft(myRectangle, lineXY.x1);
            Canvas.SetBottom(myRectangle, lineXY.y1);
            CanvasPaint.Children.Add(myRectangle);
        }
        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            CircleR circleR = new CircleR();
            circleR.ShowDialog();

            Ellipse myEllipse = new Ellipse
            {
                Height = circleR.r * 2,
                Width = circleR.r * 2,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
            };
            Canvas.SetLeft(myEllipse, circleR.x1);
            Canvas.SetBottom(myEllipse, circleR.x2);
            CanvasPaint.Children.Add(myEllipse);
        }
       

        



    }
}
