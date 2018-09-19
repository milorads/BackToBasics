namespace BackToBasics.Helpers
{
    public class SingleLinkedItem
    {
        public string Title { get; set; }
        public SingleLinkedItem NextSingleLinkedItem { get; set; }

        public SingleLinkedItem(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
