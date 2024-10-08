using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Formats.Asn1;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using CLITaskTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        List<UserTask> myUserTasks = LoadUserTasks();
        bool retryWithDefault = false;

        do
        {
            try
            {
                Console.WriteLine(args.Length);
                string tempArg0 = args[0];
                bool isStatus = Regex.IsMatch(args[0], @"^mark-(todo|in-progress|done)$");
                if (isStatus) args[0] = "True";

                switch (args[0])
                {
                    case "add":
                        AddUserTask(args[1]);
                        break;

                    case "list":
                        ListUserTasks((args[1]?.Length > 1) ? args[1] : "none");
                        retryWithDefault = false;
                        break;

                    case "delete":
                        DeleteUserTask(args[1]);
                        break;

                    case "update":
                        UpdateUserTask(args[1], args[2]);
                        break;

                    case "help":
                        DisplayHelpMessage();
                        break;

                    case "True":
                        UpdateStatus(tempArg0, args[1]);
                        break;

                    default:
                        DisplayHelpMessage();
                        break;
                }

            }
            catch (IndexOutOfRangeException)
            {
                args = new string[] { args[0], "none" };
                retryWithDefault = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        } while (retryWithDefault);

        void AddUserTask(string description)
        {
            int taskID = myUserTasks.Count + 1;
            Status currentStatus = Status.ToDo;

            UserTask newUserTask = new UserTask(taskID, description, currentStatus);
            myUserTasks.Add(newUserTask);

            Console.WriteLine($"Task added successfully (ID: {newUserTask.ID})");
            UpdateJSON();
        }

        void UpdateUserTask(string id, string description)
        {
            UserTask foundUserTask = myUserTasks.Find(userTask => userTask.ID == int.Parse(id)) ?? new UserTask();

            if (foundUserTask.Description == null)
            {
                Console.WriteLine($"You have no task with ID: {id}");
            }
            else
            {
                myUserTasks[int.Parse(id) - 1].Description = description;
                myUserTasks[int.Parse(id) - 1].UpdatedAt = DateTime.Now;
                UpdateJSON();
                Console.WriteLine($"Task updated successfully\n{foundUserTask.ID} {foundUserTask.Status} {foundUserTask.Description}");

            }
        }

        List<UserTask> LoadUserTasks()
        {
            try
            {
                string jsonData = File.ReadAllText("./myUserTasks.json");
                return JsonSerializer.Deserialize<List<UserTask>>(jsonData) ?? new List<UserTask>();
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                return new List<UserTask>();
            }
        }

        void ListUserTasks(string? filter = "none")
        {
            IEnumerable<UserTask> foundTasks;

            if (myUserTasks.Count == 0)
            {
                Console.WriteLine("You have no tasks!");
            }
            else
            {
                Console.WriteLine("All Tasks:\n\nID\tStatus\tDescription");
                switch (filter)
                {
                    case "todo":
                        foundTasks = myUserTasks.Where(userTask => userTask.Status == Status.ToDo);
                        break;

                    case "in-progress":
                        foundTasks = myUserTasks.Where(userTask => userTask.Status == Status.InProgress);
                        break;

                    case "done":
                        foundTasks = myUserTasks.Where(userTask => userTask.Status == Status.Completed);
                        break;

                    default:
                        foundTasks = myUserTasks;
                        break;
                }

                foundTasks.ToList().ForEach(foundTask => Console.WriteLine($"{foundTask.ID}\t{foundTask.Status}\t{foundTask.Description}"));
            }
        }

        void UpdateStatus(string status, string id)
        {

            UserTask foundUserTask = myUserTasks.Find(userTask => userTask.ID == int.Parse(id)) ?? new UserTask();

            if (foundUserTask.Description == null)
            {
                Console.WriteLine($"You have no task with ID: {id}");
            }
            else
            {
                switch (status)
                {
                    case "mark-in-progress":
                        myUserTasks[int.Parse(id) - 1].Status = Status.InProgress;
                        break;

                    case "mark-todo":
                        myUserTasks[int.Parse(id) - 1].Status = Status.ToDo;
                        break;

                    case "mark-done":
                        myUserTasks[int.Parse(id) - 1].Status = Status.Completed;
                        break;
                }

                myUserTasks[int.Parse(id) - 1].UpdatedAt = DateTime.Now;
                UpdateJSON();
                Console.WriteLine($"Task updated successfully\n{foundUserTask.ID} {foundUserTask.Status} {foundUserTask.Description}");

            }

        }

        void DeleteUserTask(string id)
        {
            UserTask foundUserTask = myUserTasks.Find(task => task.ID == int.Parse(id)) ?? new UserTask();

            if (foundUserTask.Description == null)
            {
                Console.WriteLine("Task not found");
            }
            else
            {
                Console.WriteLine($"Task with ID: {foundUserTask.ID} has been deleted");
                myUserTasks.Remove(foundUserTask);
            }

            UpdateJSON();
        }

        void UpdateJSON()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("./myUserTasks.json", JsonSerializer.Serialize(myUserTasks, options));
        }

        void DisplayHelpMessage()
        {
            Console.WriteLine("Usage: task-cli [options]\n");
            Console.WriteLine("Options:\n");

            // Add a task
            Console.WriteLine("add\t\t\tAdd a task".PadLeft(12));

            // List all task with options
            Console.WriteLine("list\t\t\tList all tasks".PadLeft(12));
            Console.WriteLine("list [option]\t\tList all [option] tasks".PadLeft(12));

            // Update task with options
            Console.WriteLine("update [id]\t\tUpdate a task with ID [id]".PadLeft(12));
            Console.WriteLine("mark-in-progress [id]\tMark a task with ID [id] as In-Progress".PadLeft(12));

            // Delete a task with id
            Console.WriteLine("delete [id]\t\tDelete a task with ID [id]".PadLeft(12));

            // Display list command options
            Console.WriteLine("\n[list] options: [todo, in-progress, todo]".PadLeft(12));
        }
    }
}