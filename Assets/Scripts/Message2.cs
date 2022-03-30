using System;

[Serializable]
public class Message2
{
    public string sender;
    public string text;
    
    public Message2(string sender, string text)
    {
        this.sender = sender;
        this.text = text;
    }
}
