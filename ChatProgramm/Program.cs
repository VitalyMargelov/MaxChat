using ChatProgramm;
using ChatProgramm.Infrastructure;

// infrastructure
var chatRepository = new ChatRepository();
var chat = chatRepository.LoadChat("");

// domain
var messagesOfFirstUser = chat.GetUserMessages(chat.Users[0]);

// infrastructure
ConsoleChat.DisplayMessages(messagesOfFirstUser);