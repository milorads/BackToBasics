using BackToBasics.Helpers;
using System.Text;

namespace BackToBasics.Topics.Data_Structures
{

    public class SingleLinkedList
    {
        private SingleLinkedItem _first;
        public bool IsEmpty
        {
            get
            {
                return _first == null;
            }
        }

        public SingleLinkedList()
        {
            _first = null;
        }

        public SingleLinkedItem Insert(string title)
        {
            // Creates a link, sets its link to the first item and then makes this the first item in the list.
            SingleLinkedItem link = new SingleLinkedItem(title);
            link.NextSingleLinkedItem = _first;
            _first = link;

            return link;
        }

        public SingleLinkedItem Delete()
        {
            // Gets the first item, and then this to be the one it is linked forward to
            SingleLinkedItem temp = _first;
            if (_first != null)
                _first = _first.NextSingleLinkedItem;

            return temp;
        }

        public override string ToString()
        {
            SingleLinkedItem currentLink = _first;
            StringBuilder builder = new StringBuilder();
            while (currentLink != null)
            {
                builder.Append(currentLink);
                currentLink = currentLink.NextSingleLinkedItem;
            }
            return builder.ToString();
        }
    }

}
