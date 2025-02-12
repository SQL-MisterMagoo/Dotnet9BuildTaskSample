using System.Reflection;

Console.WriteLine("running");

try
{
	var assembly = Assembly.LoadFile("C:\\Users\\miste\\source\\repos\\SampleDotNet9App\\SampleApp\\bin\\Debug\\net9.0\\SampleDotNet9App.dll");

}
catch (Exception ex)
{

	Console.WriteLine(ex);
}
