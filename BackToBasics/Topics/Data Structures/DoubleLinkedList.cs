using System.Text;
using BackToBasics.Helpers;

namespace BackToBasics.Topics.Data_Structures
{
    public class DoubleLinkedList
    {
        private DoubleLinkedItem _first;
        public bool IsEmpty => _first == null;

        public DoubleLinkedList()
        {
            _first = null;
        }

        public DoubleLinkedItem Insert(string title)
        {
            // Creates a link, sets its link to the first item and then makes this the first item in the list.
            DoubleLinkedItem link = new DoubleLinkedItem(title);
            link.NextLink = _first;
            if (_first != null)
                _first.PreviousLink = link;
            _first = link;
            return link;
        }

        public DoubleLinkedItem Delete()
        {
            // Gets the first item, and sets it to be the one it is linked to
            DoubleLinkedItem temp = _first;
            if (_first != null)
            {
                _first = _first.NextLink;
                if (_first != null)
                    _first.PreviousLink = null;
            }
            return temp;
        }

        public override string ToString()
        {
            DoubleLinkedItem currentLink = _first;
            StringBuilder builder = new StringBuilder();
            while (currentLink != null)
            {
                builder.Append(currentLink);
                currentLink = currentLink.NextLink;
            }
            return builder.ToString();
        }

        ///// New operations
        public void InsertAfter(DoubleLinkedItem link, string title)
        {
            if (link == null || string.IsNullOrEmpty(title))
                return;
            DoubleLinkedItem newLink = new DoubleLinkedItem(title);
            newLink.PreviousLink = link;
            // Update the 'after' link's next reference, so its previous points to the new one
            if (link.NextLink != null)
                link.NextLink.PreviousLink = newLink;
            // Steal the next link of the node, and set the after so it links to our new one
            newLink.NextLink = link.NextLink;
            link.NextLink = newLink;
        }
    }
}
