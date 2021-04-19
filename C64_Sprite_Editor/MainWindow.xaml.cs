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

namespace C64_Sprite_Editor
{
    public partial class MainWindow : Window
    {
        private List<int> matrixData = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSpriteMatrixMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.GetSpriteMatrixData();
            this.ShowSpriteMatrixData();
        }

        private void GetSpriteMatrixData()
        {
            this.matrixData.Clear();
            this.matrixData.AddRange(this.spriteMatrix.row0.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row1.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row2.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row3.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row4.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row5.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row6.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row7.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row8.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row9.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row10.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row11.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row12.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row13.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row14.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row15.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row16.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row17.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row18.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row19.GetBytes());
            this.matrixData.AddRange(this.spriteMatrix.row20.GetBytes());
        }

        private void ShowSpriteMatrixData()
        {
            this.dataTextBox.Text = "";
            string data = string.Empty;

            int linenumber = 10;
            data += linenumber.ToString() + " ";

            int counter = 0;
            foreach (int value in this.matrixData)
            {
                

                if (counter == 0)
                {
                    data += "data ";
                }

                data += value.ToString();
                counter++;

                if (counter == 11)
                {
                    data += "\n";
                    counter = 0;
                    linenumber = linenumber + 10;
                    data += linenumber.ToString() + " ";

                }
                else
                {
                    data += ", ";
                }

                
            }

            data = data.Trim();
            data = data.Trim(',');
            this.dataTextBox.Text = data;
        }
    }
}
