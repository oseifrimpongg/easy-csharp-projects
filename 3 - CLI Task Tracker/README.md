Here's a structure for your README file based on your task tracker project:

---

# CLI Task Tracker

## Description

This is a command-line interface (CLI) task tracker built in C#. It allows users to manage tasks by adding, updating, deleting, and marking them with statuses such as "to-do," "in-progress," and "completed." Tasks are stored in a JSON file for persistence across sessions.

## Features

- **Add Tasks**: Add new tasks with a description.
- **List Tasks**: List all tasks or filter them by status (to-do, in-progress, completed).
- **Update Tasks**: Update the description of a task by its ID.
- **Delete Tasks**: Delete a task by its ID.
- **Mark Task Status**: Mark a task as "to-do," "in-progress," or "completed."
- **Persistent Storage**: Stores tasks in a JSON file to retain data across sessions.

## Usage

### How to Run

#### Compile and Run Using .NET CLI:

1. Ensure you have the .NET SDK installed.
2. Open a terminal and navigate to the directory containing the `Program.cs` file.
3. Use the following commands to compile and run the application:

```bash
dotnet new console -o CLITaskTracker
cp Program.cs CLITaskTracker
cd CLITaskTracker
dotnet run add "New Task Description"
```

#### Compile and Run Using Visual Studio:

1. Open Visual Studio and select **File > Open > Project/Solution**.
2. Navigate to the directory containing the `Program.cs` file and open it.
3. Build and run the project by pressing `F5` or using the **Start** button.

### Commands

- **Add a Task**:

  ```bash
  dotnet run add "Task description"
  ```

- **List All Tasks**:

  ```bash
  dotnet run list
  ```

- **List Tasks by Status** (todo, in-progress, done):

  ```bash
  dotnet run list todo
  ```

- **Update a Task's Description**:

  ```bash
  dotnet run update <taskID> "New Description"
  ```

- **Delete a Task**:

  ```bash
  dotnet run delete <taskID>
  ```

- **Mark a Task's Status** (mark as todo, in-progress, done):

  ```bash
  dotnet run mark-todo <taskID>
  dotnet run mark-in-progress <taskID>
  dotnet run mark-done <taskID>
  ```

- **Help**:
  ```bash
  dotnet run help
  ```

## Example

Here’s an example interaction:

```bash
CLI Task Tracker

> dotnet run add "Complete the C-sharp project"
Task added successfully (ID: 1)

> dotnet run list
All Tasks:

ID    Status      Description
1     ToDo        Complete the C-sharp project

> dotnet run mark-in-progress 1
Task updated successfully
```

## Prerequisite Knowledge

- **C# Basics**: Familiarity with C# syntax, including classes, methods, and enums.
- **JSON Handling**: Knowledge of reading/writing JSON files.
- **Command-Line**: Understanding of CLI arguments and terminal commands.

## Limitations

- **Task Ordering**: The current implementation does not handle custom ordering of tasks.
- **Command Error Handling**: If arguments are missing, it defaults to basic behavior.
- **Limited Filters**: Only basic status filters (to-do, in-progress, completed) are available.

## Contribution

Contributions are welcome! Please fork the repository and submit a pull request with your changes. Make sure to follow the coding standards and include tests if applicable.

## Contact

- **LinkedIn**: [linkedin.com/in/oseifrimpongg](https://www.linkedin.com/in/oseifrimpongg)
- **X**: [x.com/oseifrimpongg](https://x.com/oseifrimpongg)

## Troubleshooting

- **Common Issues**: If you encounter issues, ensure the .NET SDK is installed correctly and that all necessary files are in place.

## Acknowledgments

- **C# Fundamentals for Beginners**: [YouTube Link](https://www.youtube.com/watch?v=0QUgvfuKvWU)
- **C# Programming for Absolute Beginners**: [YouTube Link](https://www.youtube.com/watch?v=ALXpVlPYqYE)
- **Roadmap.sh: CLI Task Tracker Project**: [Link](https://roadmap.sh/projects/task-tracker)

---

