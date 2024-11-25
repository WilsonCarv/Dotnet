
namespace concepts_review.ObjectOriented
{
    public class Post
    {
        private static int _currentPostId = 0;
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string Text { get; set; }
        public Post(string title, string text)
        {
            Id = this.GetNextId();
            Title = title;
            Text = text;

        }
        protected int GetNextId()
        {
            return _currentPostId++;
        }
        public void Update(string title,string text)
        {
            this.Title = title;
            this.Text = text;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} -  by {2}", this.Id, this.Title, this.Text);
        }
    }
}