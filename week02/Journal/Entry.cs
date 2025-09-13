public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Mood { get; set; }

    public Entry(string prompt, string response, string mood)
    {
        Prompt = prompt;
        Response = response;
        Mood = mood;
        Date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public override string ToString()
    {
        return $"Date: {Date}\nMood: {Mood}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{Mood}\",\"{Prompt.Replace("\"", "\"\"")}\",\"{Response.Replace("\"", "\"\"")}\"";
    }

    public static Entry FromCsv(string line)
    {
        var parts = line.Split("\",\"");
        if (parts.Length == 4)
        {
            string date = parts[0].Trim('"');
            string mood = parts[1];
            string prompt = parts[2];
            string response = parts[3].Trim('"');
            return new Entry(prompt, response, mood) { Date = date };
        }
        return null;
    }
}
