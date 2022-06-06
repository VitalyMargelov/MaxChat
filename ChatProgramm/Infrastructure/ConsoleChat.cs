using System;
namespace ChatProgramm.Infrastructure
{
	public static class ConsoleChat
    {
        public static void DisplayLongMessages(Messages[] messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"{message.Author}: {message.Text}");
            }
        }

        public static void DisplayShortMessages(Messages[] messages)
        {

        }
    }
}

