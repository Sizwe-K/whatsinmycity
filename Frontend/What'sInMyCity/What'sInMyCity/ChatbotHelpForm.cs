using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Text; 
using What_sInMyCity.Services;



namespace What_sInMyCity
{
    public partial class ChatbotHelpForm : Form
    {
        private const string systemPrompt =
            "You are a helpful, conversational travel assistant inside the #whatsinmycity platform. For now, assume the logged in user's name Melusi" +
            "You provide helpful information about local attractions and available transport services. Answers should be concise, and straight to the point." + "Do not send suggested follow up questons, like for e.g 'If you want, I can give you suggested places through a budget. No. Be conversational, but direct. Like a normal human'";

        public ChatbotHelpForm()
        {
            InitializeComponent();
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

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Connecting the chatgpt key via environment variable
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            // System 

            // check if the apiKey is null or empty
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Chat is not available. Check API key connection");
                return;
            }
            else
            {
                // Get the user message from the input textbox
                string userMessage = txtInput.Text;
                // Check if the user message is empty
                if (string.IsNullOrWhiteSpace(userMessage))
                {
                    MessageBox.Show("Please enter a message.");
                    return;
                }
                btnSubmit.Enabled = false; // Disabling the submit button to prevent multiple submissions

                
                try
                {
                    // Calling the openAIChat service to send a message and get a response
                    txtBoxOutput.Text = await OpenAIChatService.SendMessageAsync(
                        apiKey,
                        systemPrompt,
                        userMessage); // Send the text to ChatGPT and display the response

                    // Clear text input
                    txtInput.Clear();
                }
                catch (Exception ex)
                {
                    txtBoxOutput.Text = "Unable to connect to the chat service" + ex;
                }
                finally
                {
                    btnSubmit.Enabled = true; // Enabling the submit button again
                }

            }
        }
    }
}
