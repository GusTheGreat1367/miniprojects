using Octokit;
//This is my first time making a C# console application, further projects will be a seperate repo

//documentation I am using to make this:
//https://docs.github.com/en/rest?apiVersion=2022-11-28
//https://dotnet.microsoft.com/en-us/apps/aspnet/apis
// and my GOAT: https://octokitnet.readthedocs.io/en/latest/ 

//pls visit my website! https://gusthegreat1367.github.io

//I will add a tab for all my repos on my site soon
namespace GitSearch
{
    public class GitSearch
    {
        //import Github API
        var responses = new [] {"-r", "-u", "Q"}; //append new command here
        var app = WebApplication.Create();
        string response; 

        /*
        if(response == "GitSearch Enable")
            app.Run();
            main();
        */

        public void main() 
        {
            Console.WriteLine("""
              ____ _ _   ____                      _     
             / ___(_) |_/ ___|  ___  __ _ _ __ ___| |__  
            | |  _| | __\___ \ / _ \/ _` | '__/ __| '_ \ 
            | |_| | | |_ ___) |  __/ (_| | | | (__| | | |
             \____|_|\__|____/ \___|\__,_|_|  \___|_| |_|  """)
            Console.WriteLine("Welcome to the C# console application to search github!");
            Console.WriteLine("We only have a repo and user search now, mor fetures coming soon!");
            Console.WriteLine("Q to quit, -r (repo) to search repos, -u (user) to search users!");
        }
        public void Inputs()
        {
            Console.WriteLine("Enter a command: ");
            response = Console.ReadLine(); 
            foreach(var command in response)
            {
                try //URGENT, SWAP IT TO FIND IF THERE IS A Q, -r, OR -u INSTEAD OF THE METHOD NOW
                {
                    if(response == "Q") 
                    {
                        app.Exit();
                    }
                    else if(response == "-r")
                    {
                        var request = new SearchRepositoriesRequest(response);
                        var result = await githubClient.Search.SearchRepo(request);
                        Console.WriteLine(result);
                    
                    }
                    else if(response == "-u")
                    {
                        var request = new SearchUsersRequest(response)
                        var result = await githubClient.Search.SearchUsers(request);
                        Console.WriteLine(result);
                    }
                }
                catch(response != responses)
                {
                    Console.WriteLine("Response not in commands!");
                    // return "not in commands";
                }
                finally
                {
                    Inputs();
                }
            }
        }
    }
}
