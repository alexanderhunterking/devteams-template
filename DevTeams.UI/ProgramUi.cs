using DevTeams.Data.Entities;
using DevTeams.Repository.DeveloperRepository;
using DevTeams.Repository.DeveloperTeamRepository;
using static System.Console;

    public class ProgramUi
    {
        private readonly DevRepository _devRepo = new DevRepository();
        private readonly DevTeamRepository _devTeamRepo = new DevTeamRepository();
        private bool IsRunning = true;
        public void RunApplication()
        {
            Run();
        }

    private void Run()
    {
        while (IsRunning)
        {
            WriteLine("Welcome to Dev-teams\n"+
            "Please make a slection\n"+
            "1. Add Developer\n"+
            "2. get all developer\n");

            var userInput = int.Parse(ReadLine());

            switch (userInput)
            {
                case 1:
                AddDeveloper();
                break;
                case 2:
               GetAllDevelopers();
                break;
                case 0:
                CloseApplication();
                break;
            }
        }
    }

    private bool CloseApplication()
    {
        return false;
    }

    private void GetAllDevelopers()
    {

    }

    private void AddDeveloper()
    {

    }

    private void Seed()
    {
        Developer devA = new Developer("John","Joe",false);
        Developer devb = new Developer("George","jimmy",false);

    }
}
