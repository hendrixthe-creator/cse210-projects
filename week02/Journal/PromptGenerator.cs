using System;
using System.Collections.Generic;
public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "What made you smile today ?",
        "What did you learn today ?",
        "What is something you want to improve ?",
        "Who helped you today ?",
        "What was your biggest challenge today ?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    // your random prompt code ();

}