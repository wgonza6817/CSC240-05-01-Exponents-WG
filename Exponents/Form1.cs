using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: William Gonzalez
 * Date: 7-29-2025
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {// STORAGE
                int userNum, squareResult, cubeResult;
                // INPUT
                userNum = Convert.ToInt32(InputTextBox.Text);
                // PROCESS
                /* calculate the square of the number and add it to the output - 
                 * do this with a method call that allows you to pass the number
                 * and then receive the answer */
                squareResult = Square(userNum);
                OutputLabel.Visible = true;
                OutputLabel.Text = "Square result = " + squareResult.ToString();

                /* calculate the cube of the number and add it to the output - 
                 * do this by creating a methd as in the squaring example above */
                cubeResult = Cube(userNum);
                // OUTPUT
                // set the output to visible

                OutputLabel.Text += "\nCube result = " + cubeResult.ToString();
                // turn the Go button off
                GoButton.Enabled = false;
            }
            catch (Exception)
            {
                OutputLabel.Visible = true;
                OutputLabel.Text = "Invalid integer submitted" +
                                    "\nReset or reopen program";
                GoButton.Enabled = false;
            }
        }

        public int Square(int num)
        {
            // we will create this code in class
            int result;
            result = num * num;
            return result;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            int result;
            result = num * num * num;
            return result;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            InputTextBox.Text = "";
            OutputLabel.Text = "";
            // turn the output to invisible
            OutputLabel.Visible = false;
            // turn the Go button back on
            GoButton.Enabled = true;
        }
    }
}
