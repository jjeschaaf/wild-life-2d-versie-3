using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace wpf_1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            KeyDown += Window1_KeyDown;
        }

        private void Window1_KeyDown(object sender, KeyEventArgs e)
        {
            double x = Canvas.GetLeft(Player);
            double y = Canvas.GetTop(Player);

            if (e.Key == Key.Left)
            {
                Canvas.SetLeft(Player, x - 10);
            }

            if (e.Key == Key.Right)
            {
                Canvas.SetLeft(Player, x + 10);
            }

            if (e.Key == Key.Up)
            {
                Canvas.SetTop(Player, y - 10);
            }

            if (e.Key == Key.Down)
            {
                Canvas.SetTop(Player, y + 10);
            }
        }
    }
}