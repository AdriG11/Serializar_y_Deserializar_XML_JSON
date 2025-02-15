﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializar_y_Deserializar_XML_JSON
{
    public partial class BankLibrary : Form
    {
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBoxIndices { Account, First, Last, Balance}

        public BankLibrary()
        {
            InitializeComponent();
        }

        private void BankLibrary_Load(object sender, EventArgs e)
        {

        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox) ?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length!= TextBoxCount)
            {
                throw (new ArgumentException($"There must be {TextBoxCount} strings in the array", nameof(values)));
            }
            else
            {
                accountTextBox.Text = values[(int) TextBoxIndices.Account] ;
                firstNameTextBox.Text = values[(int)TextBoxIndices.First] ;
                lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
                balanceTextBox.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        public string[] GetTextValues()
        {
            return new string[]
            {
                accountTextBox.Text,firstNameTextBox.Text,lastNameTextBox.Text,balanceTextBox.Text
            };
        }
    }
}
