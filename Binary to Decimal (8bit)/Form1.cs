using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_to_Decimal__8bit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //wir haben hier neun integer variable deklariert.
            int iNumber1, iNumber2, iNumber3, iNumber4, iNumber5, iNumber6, iNumber7, iNumber8,iConverted;

             //und dann mit dem int.Parse methode konvertieren in integer
            iNumber1 = int.Parse(txt1.Text);
            iNumber2 = int.Parse(txt2.Text);
            iNumber3 = int.Parse(txt3.Text);
            iNumber4 = int.Parse(txt4.Text);

            iNumber5 = int.Parse(txt5.Text);
            iNumber6 = int.Parse(txt6.Text);
            iNumber7 = int.Parse(txt7.Text);
            iNumber8 = int.Parse(txt8.Text);

            //dann habe ich benutzt die algoridoms binär in dezimal
            iConverted = iNumber1 * 128 + iNumber2 * 64 + iNumber3 * 32 + iNumber4 * 16 + iNumber5 * 8 + iNumber6 * 4 + iNumber7 * 2 + iNumber8 * 1;
            
            txtResOutput.Text = iConverted.ToString(); //print die werte von int variable 'iConverted' in txtResOutput field als string

        }

        private void btnExit_Click(object sender, EventArgs e)
        {       //nachdem btnExit klicken , ausgang die fenster
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   //nachdem btnClear klicken , löschen die werte von volgende field
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
            txtResOutput.Clear();
            txtDezInput.Clear();
        }

        private void btnDez2Bin_Click(object sender, EventArgs e)
        {
            int dez, k, i;                              //wir haben hier drei integer variable deklariert.
            string str = "", bin = "";                  //wir haben hier zwei string variable deklariert.

                                                        //eine input genommen als string,
            dez = int.Parse(txtDezInput.Text);          //und dann mit dem int.Parse methode konvertieren in integer

            while (dez >= 1)                            // Dividiere solange, solange die 'dez' Zahl größer oder gleich als 1
            {
                k = dez / 2;                            //k wird als Ganzzahl dividiert
                str = str + (dez % 2).ToString();       //in str variable rest wird 0 oder 1 gespeichert
                dez = k;

            }
            for ( i = str.Length - 1; i >= 0; i--)      //mit dem For loop decrement die str.Length ,solange i größer oder gleiche als 0
            {
                bin = bin + str[i];                     
            }
            txtResOutput.Text = bin;                     //print die werte von 'bin' variable in txtResOutput field.


        }
    }
}
