namespace BlazorApp2.Models
{
    public struct TextOnlyProjectData { 
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }

    public struct ImgProjectData
    {
        public string DisplayName { get; set; }
        public string DisplayImg { get; set; }
        public string Caption { get; set; }
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
            { "Pawtection", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Lua, Skill.XML, Skill.CasualGames, Skill.Teamwork, Skill.ProjectPlanning } },
            { "TurnCloakGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Cplusplus, Skill.Teamwork } },
            { "SnowyDiorama", new List<Skill> { Skill.GameDevelopment, Skill.Cplusplus } },
            { "SingularityTurnTracker", new List<Skill> { Skill.Lua, Skill.Modding, Skill.XML } },
            { "AmoebasAndMore", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.DataStructures, Skill.Communication, Skill.Teamwork } },
            { "GameCraft", new List<Skill> { Skill.GameDesign, Skill.GameDevelopment, Skill.Communication, Skill.CSharp, Skill.Unity } },
            { "IDTech", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.GameDevelopment, Skill.Java, Skill.dotNetFramework } },
            { "MarbleDrop", new List<Skill> { Skill.GameDevelopment, Skill.CasualGames } }
        };


        public static readonly Dictionary<string, ImgProjectData> ImgProjectsToDescriptions = new Dictionary<string, ImgProjectData>
        {
            { "Pawtection", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection2", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection3", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection4", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection5", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection6", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection7", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } },
            { "Pawtection8", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw Your Way Through A Heart-Wrenching Puzzle Game of Limited Space and Moral Dilemmas" } }
        };
        public static readonly Dictionary<string, TextOnlyProjectData> textProjectsToDescriptions = new Dictionary<string, TextOnlyProjectData>
        {
            { "3WayMerge", new TextOnlyProjectData{DisplayName = "3-way merge", Description="Delved into sorting algorithms by creating two nonrecursive merge-sort versions and assessing their mean efficiency across numerous isolated tests. Applied the traditional technique of merging two sorted lists, alongside a unique method merging three lists concurrently." } },
            { "SpaceWar", new TextOnlyProjectData{DisplayName = "Space Wars", Description= "Applied a model-view controller design pattern through pair programming to recreate Space Wars, a multiplayer networked game that flexibly configures its server using XML. through this project, I gained hands-on experience in networking, sockets, Tcp, and the effective use of delegates."} },
            { "NetworkedSpreadsheet", new TextOnlyProjectData{DisplayName = "Networked Spreadsheet", Description=  "Refactored old code with a team of 4 to upgrade an existing spreadsheet with network functionality. Engineered a multi-threaded server in C++ and SQL lite, negotiated a network communication protocol and implemented a dependency graph on the server side.  Created automated tests for project polish and support for saving to a CSV format."} },
            { "ExploringCallStack", new TextOnlyProjectData{DisplayName = "Exploring Call Stack", Description= "Explored the complexities of the call stack's low-level operations by reconstructing it in Mips assembly. Utilized the project to trace the stack pointer during recursion and method returns." } },
            { "AlgorithExplorationMajorityVote", new TextOnlyProjectData{ DisplayName = "Majority Vote", Description= "Took on the implementation of the Majority Vote algorithm, participating in a friendly competition with peers to optimize runtime. Working on this project gave me a new appreciation of algorithms, efficient computation and resource utilization." } },
            { "ChessDatabase", new TextOnlyProjectData{ DisplayName = "Chess Database", Description= "Engineered a chess data parsing solution, consolidating information into a well-organized relational database structure, and implemented a user-friendly interface with versatile Linq queries to enhance the user experience and enable efficient data exploration." } },
            { "PeerToPeerNetworking", new TextOnlyProjectData{ DisplayName = "P2P Networking", Description= "Enhanced my understanding of networking principles with a hands-on project, creating a P2P filesharing system. This involved independently formulating a networking protocol and constructing server and client applications to facilitate file exchange, including support for exchanging multiple files across a single connection."} },
            { "RandomForestDecisionTrees", new TextOnlyProjectData{DisplayName = "Decision Trees", Description= "Initiated a decision tree project and expanded its capabilities by introducing random forest, bagging, and boosting techniques. This strategic enhancement was aimed at fine-tuning efficiency and accuracy."} },
            { "ModelsOfComputation", new TextOnlyProjectData{DisplayName = "Models of Computation", Description=  "Engaged in the study of Models of Computation, comprehending the theoretical foundations for Definite finite state machines and how they can be tools for simplifying and improving computational efficiency and redefining how we understand problems" } },
            { "LowLevelOptimization", new TextOnlyProjectData{DisplayName = "Low Level Optimization", Description=  "" } },
            { "AlphaBetaPruning", new TextOnlyProjectData{DisplayName = "Alpha Beta Pruning", Description=  "" } },
            { "HackTheU", new TextOnlyProjectData{DisplayName = "Hack The U", Description=  ""  } },
            { "WestonScienceScholars", new TextOnlyProjectData{DisplayName = "Weston Science Scholars", Description=  ""  } },
            { "SingularityTurnTracker", new TextOnlyProjectData{DisplayName = "Singularity Turn Tracker", Description=  ""  } },
            { "GameCraft", new TextOnlyProjectData{DisplayName = "Game Craft", Description=  ""  } },
            { "IDTech", new TextOnlyProjectData{DisplayName = "ID Tech", Description=  ""  } }
        };
    }


}
