<Query Kind="Program">
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//void Main()
//{
//	//Console.WriteLine(AisBigger(123,23));
//	//Animal a = new Animal();
//	//a.Dump();
//}
// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
static readonly HttpClient client = new HttpClient();

static async Task Main()
{
Console.WriteLine("reading documentations");
}

int Add(int a, int b){
	return a+b;
}

bool AisBigger(int a, int b)
{
	if (a > b)
	{
		return true;
	}
	return false;
}

public class Animal
{
	public int legs=0;
	
}