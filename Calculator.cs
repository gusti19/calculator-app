class calculator
// Gusti Padaka 22.11.5020 Informatika 08
// 15 03 2023
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));

		Console.WriteLine("\nTekan sembarang KEY untuk keluar");
		Console.ReadKey();
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Penambahan(int a, int b)
	{
		return a - b;
	}
}