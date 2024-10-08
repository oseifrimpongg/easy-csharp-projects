namespace CLITaskTracker
{
    class UserTask
    {
        public int ID { get; set; }
        public  string?  Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedA { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserTask(int id, string description, Status status)
        {
            this.ID = id;
            this.Description = description;
            this.Status = status;
            this.CreatedA = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public UserTask() {}
    }

    enum Status
    {
        ToDo,
        InProgress,
        Completed
    }

}