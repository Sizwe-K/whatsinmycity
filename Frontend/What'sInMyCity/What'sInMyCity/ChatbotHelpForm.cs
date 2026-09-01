using System;
using System.Collections.Generic;
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
using OpenAI.Chat;
using System.Drawing.Text; // Calling the openAI SDK



namespace What_sInMyCity
{
    public partial class ChatbotHelpForm : Form
    {
        private ChatClient chatClient;

        private const string systemPrompt =
            "You are a helpful travel assistant inside the #whatsinmycity platform. " +
            "You provide helpful information about local attractions and available transport services.";
        
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
                // Initialize the chat client with the API key
                chatClient = new ChatClient("gpt-5.1", apiKey);

        // Get the user message from the input textbox
             string userMessage = txtInput.Text;
                // Check if the user message is empty
                if (string.IsNullOrWhiteSpace(userMessage))
                {
                    MessageBox.Show("Please enter a message.");
                    return;
                }
                // Call the ChatGPT API to get a response
                string botResponse = OpenAI.GetResponse(userMessage, apiKey);
                // Display the bot response in the output textbox
                txtOutput.Text = botResponse;
            }

        }
    }
}
