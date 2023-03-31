using OpenAI_API.Chat;

namespace BucketListServer.Services;

public class ChatGPTService
{
    // https://github.com/OkGoDoIt/OpenAI-API-dotnet#Status
    //private const int MaxLengthMessage = 4096;

    // токен из личного кабинета
    private readonly string _apiKey = null!;

    private readonly OpenAI_API.OpenAIAPI _api = null!;
    private readonly Conversation _conversation = null!;

    public ChatGPTService()
    {
        _api = new OpenAI_API.OpenAIAPI(_apiKey);
        _conversation = _api.Chat.CreateConversation();
    }

    private async Task<string> GetAnswer(string message)
    {
        _conversation.AppendUserInput(message);
        var response = await _conversation.GetResponseFromChatbot();
        return response;
    }

    private bool ValidateUserMassage(string prompt)
    {
        /*
        if (string.IsNullOrWhiteSpace(message))
            return false;
        if (message.Length > MaxLengthMessage)
            return false;
            */
        return true;
    }
}