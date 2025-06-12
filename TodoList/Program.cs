namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<string>();

            while (true)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");

                var userChoice = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userChoice))
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                switch (userChoice.Trim().ToUpper())
                {
                    case "S":
                        PrintSelectedOption("See all TODOs.");
                        if (todos.Count == 0)
                        {
                            Console.WriteLine("No TODOs have been added yet.");
                        }
                        else
                        {
                            for (int i = 0; i < todos.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todos[i]}");
                            }
                        }
                        break;
                    case "A":
                        PrintSelectedOption("Add a TODO.");
                        while (true)
                        {
                            Console.WriteLine("Enter the TODO description:");
                            var description = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(description))
                            {
                                Console.WriteLine("The description cannot be empty.");
                                continue;
                            }

                            if (todos.Contains(description))
                            {
                                Console.WriteLine("The description must be unique.");
                                continue;
                            }

                            todos.Add(description);
                            Console.WriteLine($"TODO successfully added: {description}");
                            break;
                        }
                        break;
                    case "R":
                        PrintSelectedOption("Remove a TODO.");
                        if (todos.Count == 0)
                        {
                            Console.WriteLine("No TODOs have been added yet.");
                            break;
                        }
                        while (true)
                        {
                            Console.WriteLine("Select the index of the TODO you want to remove:");
                            for (int i = 0; i < todos.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todos[i]}");
                            }

                            var indexInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(indexInput))
                            {
                                Console.WriteLine("Selected index cannot be empty.");
                                continue;
                            }

                            if (!int.TryParse(indexInput, out int index) || index < 1 || index > todos.Count)
                            {
                                Console.WriteLine("The given index is not valid.");
                                continue;
                            }

                            string removedTodo = todos[index - 1];
                            todos.RemoveAt(index - 1);
                            Console.WriteLine($"TODO removed: {removedTodo}");
                            break;
                        }
                        break;
                    case "E":
                        PrintSelectedOption("Exit");
                        return;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }

            void PrintSelectedOption(string selectedOption)
            {
                Console.WriteLine($"You selected: {selectedOption}");
            }
        }
    }
}

