// See https://aka.ms/new-console-template for more information
using System.Collections;
Dictionary<string, string> quizQuestion = new Dictionary<string, string>()
{
    {"Question 1: What is the capital city of Australia?","Canberra" },
    {"Question: Which planet is known as the \"Red Planet\"?","Mars" },
    {"Question: Who painted the famous artwork \"Mona Lisa\"?","Leonardo da Vinci" },
    {"Question: What is the largest organ in the human body?","Skin" },
    {"Question: Which country is known as the Land of the Rising Sun?","Japan" },
    {"Question: What is the chemical symbol for gold?","Au" },
    {"Question: Which mammal can fly without feathers?","Bat" },
    {"Question: Who wrote the play \"Romeo and Juliet\"?","William Shakespeare" }

};
Console.WriteLine("Welcome in my Quiz!");

foreach (var question in quizQuestion)
{
    Console.WriteLine(question.Key);
    Console.WriteLine("Your Answer:");
    string userAnswer = Console.ReadLine();
    
    if (userAnswer.Equals(question.Value, StringComparison.OrdinalIgnoreCase)){
        Console.WriteLine("Correct!");
    }
    else 
    {
        Console.WriteLine($"your answer is incorrect:: the correct answer is \"{question.Value}\"");
    }
    Console.WriteLine();
}

Console.WriteLine("quiz is completed. thank you for playing");