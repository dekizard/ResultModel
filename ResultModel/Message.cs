﻿namespace ResultModel
{
    public class Message
    {
        public string Text { get; set; }
        public MessageType Type { get; set; } = MessageType.Error;
    }
}
