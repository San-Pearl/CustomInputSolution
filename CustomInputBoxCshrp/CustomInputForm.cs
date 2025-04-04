using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomInputBoxCshrp
{
    
    public partial class CustomInputForm : Form
    {
        private string configPath = "config.xml";

        public string InputText { get; set; }

        public CustomInputForm()
        {
            InitializeComponent();
        }

        public CustomInputForm(string title, string prompt, string defStr = "")
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblPrompt.Text = prompt;
            txtInput.Text = defStr;
        }


    }


}
