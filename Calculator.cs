class Calkukalor
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekamn Sembarang key untuk keluar");
		Console.Readkey();
	
	}
	
	static int penambahan(int a, int b)
	{
		return a+b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}