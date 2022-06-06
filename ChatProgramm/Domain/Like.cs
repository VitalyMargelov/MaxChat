﻿using System;
using ChatProgramm;

namespace ChatProgramm
{
	public record Like(User User)
	{
        public static void LikeItBy(Messages Message, User User)
        {
            var (pathToText, name) = Message;
            Console.WriteLine($"{name.Nickname}: {File.ReadAllText(pathToText)} <-- liked by: {User.Nickname}");
            // ???
            // Почему не могу ичпользовать функцию ShowMessage из файла Messages.cs:
            // Console.WriteLine($"{Message.ShowMessage} <-- liked by: {User.Nickname}");
            // ???
        }


        public static void ShowLikesByUser(Like[] likes, User user)
        {
            foreach (var like in likes)
            {
                var (origMessage, likeAuthor) = like;
                if (likeAuthor == user)
                {
                    Console.WriteLine($"{origMessage.ShowMessage()}");
                }
            }
        }
    }
}

