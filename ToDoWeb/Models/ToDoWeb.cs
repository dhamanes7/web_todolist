using System;

namespace ToDoWeb.Models
{
    public class ToDoWeb
    {

       
        public int id { get; set; }
        public string title { get; set; }
        public string isCompleted { get; set; }
        public string completedDate { get; set; }

        public ToDoWeb()
        {
            this.id = 0;
            this.title = "Error";
            this.isCompleted = "NA";
            this.completedDate = "NA";
        }

        public ToDoWeb(int id, string title, string isCompleted, string completedDate)
        {
            this.id = id;
            this.title = title;
            this.isCompleted = isCompleted;
            this.completedDate = completedDate;
        }
    }
}
