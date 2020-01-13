using System;


namespace ConsoleApp2
{
    class Program
    {

		

		static void Main(string[] args)
		{
			bool over = false;
			Random rand = new Random();
			int secretNumber = rand.Next(101);

			Console.WriteLine("Bienvenue dans le jeu de Plus ou Moins !");
			Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus) .");

			while (!over)
			{
				string inputString = Console.ReadLine();
				int inputNumber = Int32.Parse(inputString);

				if (inputNumber < 0 & inputNumber > 100)
				{
					Console.WriteLine("Erreur, CHoisissez un nombre entre 0 et 100 !");
				} 
				else if (inputNumber == secretNumber)
				{
					over = true;
					Console.WriteLine("Jeu terminé");
				}
				else if (inputNumber < secretNumber) 
				{
					Console.WriteLine("CHoisissez un numéro plus grand que " + inputNumber);
				}
				else if (inputNumber > secretNumber)
				{
					Console.WriteLine("Choisissez un numéro plus petit que " + inputNumber);
				}
			}

		}
	}
}
