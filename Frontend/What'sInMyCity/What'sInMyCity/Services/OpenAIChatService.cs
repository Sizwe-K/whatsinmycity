using OpenAI.Chat;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace What_sInMyCity.Services
{
    internal static class OpenAIChatService
    {
        internal static async Task<string> SendMessageAsync(
            string apiKey,
            string systemPrompt,
            string userMessage)
        {
            ChatClient chatClient = new ChatClient("gpt-5.1", apiKey);

            List<ChatMessage> messages = new List<ChatMessage>
            {
                new SystemChatMessage(systemPrompt),
                new UserChatMessage(userMessage)
            };

            ChatCompletion completion = await chatClient.CompleteChatAsync(messages);
            return completion.Content[0].Text;
        }
    }
}
