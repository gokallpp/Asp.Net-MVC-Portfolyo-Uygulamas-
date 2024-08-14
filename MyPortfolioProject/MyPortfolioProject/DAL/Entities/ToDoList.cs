namespace MyPortfolioProject.DAL.Entities
{
    public class ToDoList
    {
        public int ToDoListId { get; set; }
        public String Title { get; set; }
        public  String ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
