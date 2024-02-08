using Blazorise;

namespace BlazorApp2.Models
{
    public enum Skill
    {
        None = 0,
        CSharp,
        Unity,
        Lua,
        DevelopmentTools,
        SoftwareTesting,
        GameDesign,
        XML,
        MobileGames,
        Json,
        TestDrivenDevelopment,
        AgileDevelopment,
        Git,
        NetworkEngineering,
        Firebase,
        SolutionArchitecture,
        GameDevelopment,
        CSS,
        DebuggingCode,
        Communication,
        CollabrativeProblemSolving,
        FullStackDevelopment,
        DataAnalysis,
        Leadership,
        ProcessImprovement,
        Java,
        CasualGames,
        Cplusplus,
        VBA,
        MIPS,
        Teamwork,
        Python,
        ProjectPlanning,
        DataStructures,
        AsymtoticNotation,
        Algorithms,
        C,
        dotNetFramework,
        MySQL,
        LINQ,
        Modding,
        CustomerService,
        MicrosoftExchange,
        MicrosoftOffice,
        MicrosoftExcel,
        ProblemSolving,
        React,
        Blazor
    }
    public static class SkillModel
    {
        //maybe map to logos in future?
        public static Dictionary<Skill, String> SkillsToDisplayString = new Dictionary<Skill, string> {
            { Skill.None, "Error skill is none"},
            { Skill.CSharp, "C#"},
            { Skill.Unity, "Unity"},
            { Skill.Lua, "Lua"},
            { Skill.DevelopmentTools, "Development Tools"},
            { Skill.SoftwareTesting, "Software Testing"},
            { Skill.GameDesign, "Game Design"},
            { Skill.XML, "XML"},
            { Skill.MobileGames, "Mobile Games"},
            { Skill.Json, "JSON"},
            { Skill.TestDrivenDevelopment, "Test Driven Development"},
            { Skill.AgileDevelopment, "Agile Development"},
            { Skill.Git, "Git"},
            { Skill.NetworkEngineering, "Network Engineering"},
            { Skill.Firebase, "Firebase"},
            { Skill.SolutionArchitecture, "Solution Architecture"},
            { Skill.GameDevelopment, "Game Development"},
            { Skill.CSS, "CSS"},
            { Skill.DebuggingCode, "Debugging Code"},
            { Skill.Communication, "Communication"},
            { Skill.CollabrativeProblemSolving, "Collaborative Problem Solving"},
            { Skill.FullStackDevelopment, "Full Stack Development"},
            { Skill.DataAnalysis, "Data Analysis"},
            { Skill.Leadership, "Leadership"},
            { Skill.ProcessImprovement, "Process Improvement"},
            { Skill.Java, "Java"},
            { Skill.CasualGames, "Casual Games"},
            { Skill.Cplusplus, "C++"},
            { Skill.VBA, "VBA"},
            { Skill.MIPS, "MIPS"},
            { Skill.Teamwork, "Teamwork"},
            { Skill.Python, "Python"},
            { Skill.ProjectPlanning, "Project Planning"},
            { Skill.DataStructures, "Data Structures"},
            { Skill.AsymtoticNotation, "Asymptotic Notation"},
            { Skill.Algorithms, "Algorithms"},
            { Skill.C, "C"},
            { Skill.dotNetFramework, ".NET Framework"},
            { Skill.MySQL, "MySQL"},
            { Skill.LINQ, "LINQ"},
            { Skill.Modding, "Modding"},
            { Skill.CustomerService, "Customer Service"},
            { Skill.MicrosoftExchange, "Microsoft Exchange"},
            { Skill.MicrosoftOffice, "Microsoft Office"},
            { Skill.MicrosoftExcel, "Microsoft Excel"},
            { Skill.ProblemSolving, "Problem Solving"},
            { Skill.React, "React"},
            { Skill.Blazor, "Blazor"}
        };

        public static Dictionary<string, List<Skill>> SkillsByCategory = new Dictionary<string, List<Skill>>
        {
            { "Programming Languages And Tools", new List<Skill> { Skill.CSharp, Skill.Lua, Skill.Java, Skill.Cplusplus, 
                Skill.VBA, Skill.MIPS, Skill.Python, Skill.CSS, Skill.C,Skill.MySQL, Skill.LINQ, Skill.XML, Skill.Json, 
                Skill.Git, Skill.Firebase, Skill.React, Skill.dotNetFramework, Skill.MicrosoftExchange } },
            { "Game Development", new List<Skill> { Skill.Unity, Skill.GameDesign, Skill.MobileGames, 
                Skill.GameDevelopment, Skill.CasualGames, Skill.Modding } },
            { "Software Engineering Practices", new List<Skill> { Skill.DataAnalysis,Skill.NetworkEngineering, Skill.SoftwareTesting, 
                Skill.TestDrivenDevelopment, Skill.AgileDevelopment, Skill.SolutionArchitecture, Skill.DataStructures, 
                Skill.AsymtoticNotation, Skill.Algorithms,Skill.DevelopmentTools,Skill.DebuggingCode } },
            { "Project Management and Planning", new List<Skill> { Skill.Communication, Skill.ProblemSolving, 
                Skill.CollabrativeProblemSolving, Skill.ProjectPlanning, Skill.Teamwork, Skill.Leadership, 
                Skill.ProcessImprovement } },
        };

        public static string GetDisplayStringForSkill( Skill skill){
            if (!SkillsToDisplayString.ContainsKey(skill)) 
            {
                return "Error skill not found";
            }
            return SkillsToDisplayString[skill];
        }
    }
}
