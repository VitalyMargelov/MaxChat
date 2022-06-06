using System;
namespace ChatProgramm
{
    public record Chat(Messages[] Message, User[] Users)
    {
        public Messages[] GetUserMessages(User user)
        {
            var filteredMessages = new List<Messages>();
            foreach (var message in Message)
            {
                if (message.Author == user)
                {
                    filteredMessages.Add(message);
                }
            }

            return filteredMessages.ToArray();
        }
    }

}

