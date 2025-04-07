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

namespace TK
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int Grade(string first, string second, string third, string fourth)
        {
            try
            {
                int ifirst = Int32.Parse(first);
                int isecond = Int32.Parse(second);
                int ithird = Int32.Parse(third);
                int ifourth = Int32.Parse(fourth);

                if (ifirst <= 10 && ifirst >= 0 && isecond <= 50 && isecond >= 0 && ithird <= 30 && ithird >= 0 && ifourth <= 10 && ifourth >= 0)
                {
                    int sum = ifirst + isecond + ithird + ifourth;
                    if (sum > 69)
                    {
                        return 5;
                    }
                    else if(sum > 39)
                    {
                        return 4;
                    }
                    else if(sum > 19)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch {
                return -1;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ans = Grade(first_txt.Text, second_txt.Text, third_txt.Text, fourth_txt.Text);
            if (ans != -1)
            {
                MessageBox.Show("Оценка - " + ans);
            }
            else {
                MessageBox.Show("Введены некорректные значения!");
            }
        }
    }
}
