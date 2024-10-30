using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace pr_22._103k_Cherkova_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] strList = TextBoxInput.Text.Split(' ');
                string newStrList = " ";
                for (int i = 0; i < strList.Length; i++)
                {
                    for (int j = 0; j < strList[i].Length; j++)
                    {
                        if (j == 0 || j == strList[i].Length - 1)
                        {
                            char firstChar = char.ToUpper(strList[i][0]);
                            char lastChar = char.ToUpper(strList[i][strList[i].Length - 1]);
                            newStrList += strList;
                        }
                    }
                    newStrList += strList[i];
                }

                TextBoxOutput.Text = newStrList;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nВведено не верное значение!");
            }
        }
    }
}
