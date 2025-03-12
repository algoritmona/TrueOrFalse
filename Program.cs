using System;

namespace TrueOrFalse {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to 'True or False?'\n");
            //string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);
            string[] questions = { "The Great Wall of China is visible from space.", "Water boils at a lower temperature at higher altitudes.", "Sharks are mammals.", "Bananas grow on trees.", "Lightning never strikes the same place twice.", "The Eiffel Tower can grow taller in the summer.", "Goldfish have a three-second memory span." };
            bool[] answers = { false, true, false, false, false, true, false };
            bool[] responses = new bool[answers.Length];

            if (questions.Length != answers.Length) {
                Console.WriteLine("WARNING!");
            }

            int askingIndex = 0;
            foreach (string question in questions) {
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                string input = Console.ReadLine();
                input = input.ToLower();
                bool isBool;
                if (input == "true" || input == "false") {
                    isBool = true;
                }
                else {
                    isBool = false;
                }
                while (isBool != true) {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    Console.WriteLine(question);
                    Console.WriteLine("True or False?");
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "true" || input == "false") {
                        isBool = true;
                    }
                    else {
                        isBool = false;
                    }
                }
                bool inputBool = (input == "true");
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            foreach (bool response in responses) {
                Console.WriteLine(response);
            }
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers) {
                bool aux = responses[scoringIndex];
                Console.WriteLine($"Input: {aux} | Answer: {answer} ");
                scoringIndex++;

                if (aux == answer) {
                    score++;
                }
            }
            Console.WriteLine($"You got {score} out of {answers.Length} correct!");

        }
    }
}
