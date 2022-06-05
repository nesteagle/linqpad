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
	// Call asynchronous network methods in a try/catch block to handle exceptions.
	try
	{
		HttpResponseMessage response = await client.GetAsync("http://www.microsoft.com/");
		response.EnsureSuccessStatusCode();
		string responseBody = await response.Content.ReadAsStringAsync();
		// Above three lines can be replaced with new helper method below
		// string responseBody = await client.GetStringAsync(uri);

		Console.WriteLine(responseBody);
	}
	catch (HttpRequestException e)
	{
		Console.WriteLine("\nException Caught!");
		Console.WriteLine("Message :{0} ", e.Message);
	}
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