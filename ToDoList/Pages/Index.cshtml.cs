using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<string> Tasks { get; set; } = new List<string>();

    [BindProperty]
    public string TaskName { get; set; }

    [BindProperty]
    public string EditedTask { get; set; }

    public void OnPost()
    {
        if (!string.IsNullOrWhiteSpace(TaskName))
        {
            Tasks.Add(TaskName);
            TaskName = ""; // Clear the input field
        }
    }

    public void EditTask(string task)
    {
        EditedTask = task;
        Tasks.Remove(task);
    }

    public void DeleteTask(string task)
    {
        Tasks.Remove(task);
    }
}
