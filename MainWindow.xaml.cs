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

namespace Kleinste_Gemene_Veelvoud
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

        int inputflag = 0;
        long Number1 = 0;
        long Number2 = 0;
        //int[] prime = { 199, 197, 193, 191, 181, 179, 173, 167, 157, 151, 149, 139, 137, 131, 127, 113, 107, 103, 101, 97, 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2 };


        private void Bereken(object sender, RoutedEventArgs e)
        {
            inputflag = 0; 
            try
            {
                Number1 = Int32.Parse(input1.Text);
                Number2 = Int32.Parse(input2.Text);
            }
            catch (Exception)
            {
                Number1 = 0;
                Number2 = 0;
                inputflag = 1;
            }

            if (inputflag == 1)
            {
                MessageBox.Show("Voer alleen een heel getal in", "Fout");
            }
            else
            {
                long difider = Number1;
                int counter = 0;

                while (difider % Number2 != 0 || counter > 100)
                {
                    difider = difider + Number1;
                }


                if (counter > 100)
                {
                    output.Content = "De getallen hebben geen gemene veelvoud";
                }
                else
                {
                    output.Content = "Het kleinste gemene veelvoud van ";
                    output2.Content = Number1 + " en " + Number2 + " = " + difider;
                }
            }

        }
    }
}
