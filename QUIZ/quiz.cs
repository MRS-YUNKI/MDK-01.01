using System.Net.Quic;
using System.Runtime.CompilerServices;

class quiz
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество игроков: ");
        int number_of_players = int.Parse(Console.ReadLine());

        List<Person> players = new List<Person>();

        for (int i = 0; i < number_of_players; i++)
        {
            Console.Write($"Введите имя игрока №{i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Введите возраст игрока №{i + 1}: ");
            int age = int.Parse(Console.ReadLine());
            players.Add(new Person(name, age));
        }

        List<Question> questions = GenerateQuestions();
        Shuffle(questions);

        foreach (var player in players)
        {
            Console.WriteLine($"\n{player.Name}, Ваша очередь отвечать.");

            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                Console.WriteLine($"1. {question.Answer1}.");
                Console.WriteLine($"2. {question.Answer2}.");
                Console.WriteLine($"3. {question.Answer3}.");
                Console.WriteLine($"4. {question.Answer4}.");

                Console.Write("Выберите ответ (от 1 до 4): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == question.Correct_answer)
                {
                    player.AddCorrectAnswers();
                    Console.WriteLine("Ответ верный!\n");
                }
                else
                {
                    Console.WriteLine("Ответ неверный!\n");
                }
            }
        }
        Console.WriteLine("\nИтоги викторины:");
        Person winner = null;

        foreach (var player in players)
        {
            player.GetPersonInfo();
            if (winner == null || winner.Amount < player.Amount)
            {
                winner = player;
            }
        }
        if (winner != null)
        {
            Console.WriteLine($"\nПобедителем викторины стал(-а) {winner.Name} с {winner.Amount} правильными ответами!");
        }
    }

    static List<Question> GenerateQuestions()
    {
        return new List<Question>
        {
            new Question("К какому роду относится панда белого цвета с черными лапами, ушами и участками вокруг глаз?", "Средняя панда", "Малая панда", "Белая панда", "Большая панда", 4),
            new Question("Что в японском ресторане называется 'осибори'?", "Палочки для еды", "Тарелка для суши", "Соевый соус", "Влажное полотенце", 4),
            new Question("Как называется логически верная ситуация, которая не может существовать в реальности?", "Парадокс", "Апория", "Антиномия", "Гипербола", 2),
            new Question("Какой цветок из списка не голубого цвета?", "Василек", "Незабудка", "Лютик", "Цикорий", 3),
            new Question("Какое растение из списка является плотоядным?", "Володушка", "Росянка", "Мытник", "Астрагал", 2)
        };
    }

    static void Shuffle<Question>(List<Question> questions)
    {
        Random random = new Random();
        int n = questions.Count;
        while (n > 1)
        {
            int k = random.Next(n--);
            Question value = questions[n];
            questions[n] = questions[k];
            questions[k] = value;
        }
    }
}

class Question
{
    public string Text {  get; set; }
    public string Answer1 { get; set; }
    public string Answer2 { get; set; }
    public string Answer3 { get; set; }
    public string Answer4 { get; set; }
    public int Correct_answer { get; set; }

    public Question(string text, string answer1, string answer2, string answer3, string answer4, int correct_answer)
    {
        Text = text;
        Answer1 = answer1;
        Answer2 = answer2;
        Answer3 = answer3;
        Answer4 = answer4;
        Correct_answer = correct_answer;
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Amount { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Amount = 0;
    }

    public void AddCorrectAnswers()
    {
        Amount++;
    }

    public void GetPersonInfo()
    {
        Console.WriteLine($"Имя: {Name}.\nВозраст: {Age}.\nКоличество правильных ответов: {Amount}.");
    }
}