using System;
namespace ChatProgramm
{
	public class ChatRepository
	{
		public Chat LoadChat(string pathToChat, User[] users)
        {
			var chatText = File.ReadAllText("");
			var rawMessages = chatText.Split("%{{MESSAGE}}");
			var messages = new List<Messages>();
            foreach (var rawMessage in rawMessages)
            {
				var messageAttributes = rawMessage.Split("-:-");
				var user = FindUserByNickname(users, messageAttributes[0]);
				var message = new Messages(messageAttributes[1], user, new Like[0]);
				messages.Add(message);
            }

			// CHAT
			Chat mainChat = new Chat(messages.ToArray(), users);
			return mainChat;
        }

		private User FindUserByNickname(User[] users, string nickname)
		{
			// todo: implement proper search
			return users[0];
		}
	}
	
}

