namespace BackToBasics.Helpers
{
    public class DoubleLinkedItem
    {
        public string Title { get; set; }
        public DoubleLinkedItem PreviousLink { get; set; }
        public DoubleLinkedItem NextLink { get; set; }

        public DoubleLinkedItem(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
