using Octokit;
//documentation I am using to make this:
//https://docs.github.com/en/rest?apiVersion=2022-11-28
//https://dotnet.microsoft.com/en-us/apps/aspnet/apis
//
namespace main
{
    public class main
    {
        //import Github API
        //https://octokitnet.readthedocs.io/en/latest/
        //https://dotnet.microsoft.com/en-us/apps/aspnet/apis
        var responses = new [] {"-r", "-u", "Q"}; //append new command here
        var app = WebApplication.Create();
        public void main() 
        {
            Console.Writeline("Welcome to the C# web application to search github!");
            Console.Writeline("Q to quit, -r (repo) to search repos, -u (user) to search users!");
            string response = Console.ReadLine(); 
        }
        public void Inputs()
        {
            main();
            try()
            {
                if(response == "Q")
                {
                    //close application
                }
                else if(response == "-r")
                {
                    //github search repo
                }
                else if(response == "-u")
                {
                    //github search users
                }
            }
            catch(response != responses)
            {
                Console.Writeline("Response not in commands!");
                main();
            }
        }
        app.Run();
    }
}
