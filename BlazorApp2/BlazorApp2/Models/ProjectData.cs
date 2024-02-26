namespace BlazorApp2.Models
{
    public struct TextOnlyProjectData { 
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ProjectData
    {
        public static readonly Dictionary<string, List<Skill>> projectsToSkills = new Dictionary<string, List<Skill>>
        {
            { "3WayMerge", new List<Skill> { Skill.Java, Skill.DebuggingCode, Skill.SoftwareTesting, Skill.Algorithms, Skill.AsymtoticNotation, Skill.DataStructures, Skill.DataAnalysis } },
            { "SpaceWar", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.GameDevelopment, Skill.SoftwareTesting, Skill.Algorithms, Skill.AsymtoticNotation, Skill.DataStructures, Skill.NetworkEngineering, Skill.Json, Skill.XML, Skill.dotNetFramework } },
            { "NetworkedSpreadsheet", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.SoftwareTesting, Skill.Algorithms, Skill.DataStructures, Skill.NetworkEngineering, Skill.Json, Skill.CollabrativeProblemSolving, Skill.Communication, Skill.Teamwork, Skill.ProjectPlanning, Skill.C, Skill.MySQL, Skill.dotNetFramework } },
            { "ExploringCallStack", new List<Skill> { Skill.MIPS, Skill.DebuggingCode, Skill.DataStructures } },
            { "AlgorithExplorationMajorityVote", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.Algorithms, Skill.AsymtoticNotation } },
            { "ChessDatabase", new List<Skill> { Skill.MySQL, Skill.DataAnalysis, Skill.CSharp, Skill.LINQ, Skill.DebuggingCode, Skill.Algorithms, Skill.AsymtoticNotation, Skill.dotNetFramework } },
            { "PeerToPeerNetworking", new List<Skill> { Skill.NetworkEngineering, Skill.Python, Skill.DataStructures, Skill.Algorithms } },
            { "RandomForestDecisionTrees", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.DataAnalysis } },
            { "ModelsOfComputation", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.Communication } },
            { "LowLevelOptimization", new List<Skill> { Skill.C, Skill.Algorithms, Skill.DataStructures, Skill.DebuggingCode } },
            { "AlphaBetaPruning", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.Teamwork, Skill.CasualGames, Skill.GameDevelopment } },
            { "HackTheU", new List<Skill> { Skill.React, Skill.ProblemSolving, Skill.Teamwork, Skill.Algorithms, Skill.Leadership, Skill.GameDevelopment } },
            { "WestonScienceScholars", new List<Skill> { Skill.Teamwork, Skill.DataStructures, Skill.ProblemSolving, Skill.FullStackDevelopment } },
            { "VideogameAnalysis", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "GameExecutionFlowchart", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "FalterGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "CharacterConcepting", new List<Skill> { Skill.GameDevelopment } },
            { "PawtectionGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Lua, Skill.XML, Skill.CasualGames, Skill.Teamwork, Skill.ProjectPlanning } },
            { "TurnCloakGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Cplusplus, Skill.Teamwork } },
            { "SnowyDiorama", new List<Skill> { Skill.GameDevelopment, Skill.Cplusplus } },
            { "SingularityTurnTracker", new List<Skill> { Skill.Lua, Skill.Modding, Skill.XML } },
            { "AmoebasAndMore", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.DataStructures, Skill.Communication, Skill.Teamwork } },
            { "GameCraft", new List<Skill> { Skill.GameDesign, Skill.GameDevelopment, Skill.Communication, Skill.CSharp, Skill.Unity } },
            { "IDTech", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.GameDevelopment, Skill.Java, Skill.dotNetFramework } },
            { "MarbleDrop", new List<Skill> { Skill.GameDevelopment, Skill.CasualGames } }
        };
    }
}
