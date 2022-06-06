using System;
namespace ChatProgramm
{
    public record Messages(string Text, User Author, Like[] Likes);
}

