using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace com.papaphi.homecdu
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            String[] astrLinesOfText = new String[15];
            String outputText = "{\n  \"Target\": \"Display\",\n  \"Data\": [";
            char cColor = 'g' ; //default to green color for now.

            #region Load text from input into array
            astrLinesOfText[1] = textBoxLine1.Text;
            astrLinesOfText[2] = textBoxLine2.Text;
            astrLinesOfText[3] = textBoxLine3.Text;
            astrLinesOfText[4] = textBoxLine4.Text;
            astrLinesOfText[5] = textBoxLine5.Text;
            astrLinesOfText[6] = textBoxLine6.Text;
            astrLinesOfText[7] = textBoxLine7.Text;
            astrLinesOfText[8] = textBoxLine8.Text;
            astrLinesOfText[9] = textBoxLine9.Text;
            astrLinesOfText[10] = textBoxLine10.Text;
            astrLinesOfText[11] = textBoxLine11.Text;
            astrLinesOfText[12] = textBoxLine12.Text;
            astrLinesOfText[13] = textBoxLine13.Text;
            astrLinesOfText[14] = textBoxLine14.Text;
            #endregion

            for(int i = 1; i < 15; i++)
            {
                astrLinesOfText[i] = astrLinesOfText[i].PadRight(24);
                foreach(char c in astrLinesOfText[i])
                {
                    if (c == ' ')
                        outputText = outputText + "[],\n";
                    else
                        outputText = outputText + "[\"" + c + "\",\"" + cColor + "\",0],\n";
                }
            }
            outputText = outputText + "] \n }";

            textBoxOutput.Text = outputText;








    }
    }
}
