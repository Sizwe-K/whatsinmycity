using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_sInMyCity
{
    public partial class ChatbotHelpForm : Form
    {
        
        public ChatbotHelpForm()
        {
            InitializeComponent();

            // load the Gemini API key from the environment variable
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");

            // check if the API key is null or empty
            if (apiKey == null || apiKey == "")
            {
                // display an error message
                MessageBox.Show("Chat is currently offline");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // Get the user message from the input textbox
            string userMessage = txtInput.Text; 
        }
    }
}
