<Query Kind="Program">
  <NuGetReference>CsvHelper</NuGetReference>
  <Namespace>CsvHelper</Namespace>
  <Namespace>System.Text.Json</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

List<KeyValuePair<int, float>> Grades => new() {
	new(1, 0),
	new(2, 0),
	new(3, 0),
	new(4, 0),
	new(5, 0),
	new(6, 0),
	new(7, 0),
	new(8, 0),
	new(9, 0)
};

bool outputGrades = false;
string projectPath = @"C:\Users\jadki\OneDrive\Documents\All Docs\My Docs\School\Faculty\2022 SWE 3313 Fall 2022\Coffee Project\2_Requirements";

void Main() {
	Util.Cmd($"explorer {projectPath}");
	if(outputGrades) {
		WriteGrades();
		return;
	}
	
	GetTeamProjects();
}

List<Team> GetTeams()
{
	using (var reader = new StringReader(GetTeamsCsv()))
	using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
	{
		var csvTeams = csvReader.GetRecords<CsvTeam>();
		return csvTeams.Select(t => new Team(t)).ToList();
	}
}

void WriteGrades() {
	var teams = GetTeams();
	foreach (var grade in Grades) {
		teams.Single(t => t.Number == grade.Key).Grade = grade.Value;
	}
	
	var allStudents = teams.SelectMany(t => t.Students).OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();

	using (var writer = new StreamWriter(Path.Combine(projectPath, "grades.csv")))
	using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
	{
		csv.WriteRecords(allStudents);
	}
}

void GetTeamProjects()
{
	foreach (var team in GetTeams())
	{
		var path = Path.Combine(projectPath, $"Team {team.Number}");
		Directory.CreateDirectory(path);
		Directory.SetCurrentDirectory(path);
		File.WriteAllText(Path.Combine(path, $"team {team.Number}.txt"), team.ToString());
		Util.Cmd($"git clone {team.RepoUrl}");
	}
}

public class Team {
	public Team(CsvTeam csvTeam) {
		Number = csvTeam.Number;
		Name = csvTeam.TeamName;
		RepoUrl = csvTeam.RepoUrl;
		Students = csvTeam.Students;
	}
	
	public float Grade { get; set; }
	public int Number { get; init; }
	public string Name { get; init; }
	public string RepoUrl { get; init; }
	public List<Student> Students { get; init; }
	public override string ToString()
	{
		void AddHeading(StringBuilder sb, string heading, bool includeAchievedLine = true)
		{
			const string line = "-----------------------------------------";
			sb.AppendLine(line);
			sb.AppendLine(heading);
			if (includeAchievedLine)
			{
				sb.AppendLine();
				sb.AppendLine("Achieved: ");
			}
			sb.AppendLine(line);
			sb.AppendLine();
			sb.AppendLine();
			sb.AppendLine();
		}
		
		var sb = new StringBuilder();
		sb.AppendLine("Requirements Assignment");
		sb.AppendLine();
		sb.AppendLine($"Team {Number}");
		sb.AppendLine();
		sb.AppendLine($"- {Name}");
		sb.AppendLine($"- {RepoUrl}");
		sb.AppendLine("- Students");
		foreach (var student in Students)
		{
			sb.AppendLine($"  + {student}");
		}
		sb.AppendLine();
		AddHeading(sb, "Overall Grade: ", false);
		AddHeading(sb, "Professional Presentation, Max 10%");
		AddHeading(sb, "Well-Organized Requirements, Max 30%");
		AddHeading(sb, "Prioritization, Max 10%");
		AddHeading(sb, "Use Case Diagrams, Max 25%");
		AddHeading(sb, "Decision Tables, Max 25%");

		return sb.ToString();
	}
}

public class CsvTeam {
	public int Number => int.Parse(TeamNum[^1].ToString());
	public string TeamNum { get; set; }
	public string TeamName { get; set; }
	public string Student1 { get; set; }
	public string Student2 { get; set; }
	public string Student3 { get; set; }
	public string Student4 { get; set; }
	public string RepoUrl { get; set;}
	public List<Student> Students => (new List<Student> { 
		new Student(Student1),
		new Student(Student2),
		new Student(Student3),
		new Student(Student4)
	}).OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
}

public class Student {
	public Student(string name) {
		name = name.Trim();
		var pieces = name.Split(" ");
		FirstName = pieces[0];
		LastName = string.Join(' ', pieces [1..]);
	}
	
	public string LastName { get; init; }
	public string FirstName { get; init; }
	public float Grade { get; set; }
	public override string ToString() => $"{LastName}, {FirstName}";
}

string GetTeamsCsv() =>
	@"TeamNum,TeamName,Student1,Student2,Student3,Student4,RepoUrl
	Team 1,Team Blank,Joshua Poore,Sogand Aghazadeh,Miles Otunla,Geninia Honore,https://github.com/geniniah/swe_3313_fall_2022
	Team 2,Team MERC,Ethan Johnson,Merrick McPherson,Rakshak Gurung,Chris Flores-Santos,https://github.com/lildebbi3/swe_3313_fall_2022
	Team 3,Team Internship PLS,Tagan Williamson,Richard Thomas,Jacob Germana-McCray,Sarah Crosby,https://github.com/JGM01/FALL2022_SWE-3313_InternshipPLS
	Team 4,HIDE Coffee,Habeebah Muse,Duncan Stephan ,Evan Finelli,Ian Chorne,https://github.com/duncanstephan/swe_3313_fall_2022
	Team 5,Team SPAM,Joshua Whorton,Michael Eaton,Max Haviv,Sebastian Mielko,https://github.com/maxethan2/Team_Spam_Project_swe_3313_fall_2022
	Team 6,Coffee & Code,Elliot Larez,Michael Butler,Garrett Heffner,Sahan Reddy,https://github.com/kfajdsl/swe_3313_fall_2022_group_6/
	Team 7,Expresso Delivery,Adele Rousseau,Dove Ray,Trevor Green,Dion Green,https://github.com/undove/Espresso_Delivery_SWE_3313
	Team 8,The Grind,Jason Zhou,Kevin Lopez,Justin Hale,Kuehan Lee,https://github.com/jhale40/swe_3313_fall_2022.git
	Team 9,Café 404,Mason Sherrill,Emily Mack,Joel Juarez,Aly Hussein,https://github.com/alyhussein2001/swe_3313_fall_2022";