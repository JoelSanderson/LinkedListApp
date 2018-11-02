using System;

namespace LinkedLists.Models
{
    public enum ListType { Checklist, ToDo, BestOf };
    public enum ListCategory { Entertainment, Food, Sport, Shopping, Technology, Outdoors };
    public enum ListPrivacy { Public, Private };

    public class Item
    {
        public string ListId { get; set; }
        public string ListTitle { get; set; }
        public ListType ListType { get; set; }
        public ListCategory ListCategory { get; set;  }
        public ListPrivacy ListPrivacy { get; set;  }
        public string ListData { get; set; }
        public int ListRating { get; set;  }
        public int ListAuthor { get; set;  }

        public Item( string listID, string listTitle, ListType listType, ListCategory listCategory, ListPrivacy listPrivacy, string listData, int listRating, int listAuthor)
        {
            ListId = listID;
            ListTitle = listTitle;
            ListType = listType;
            ListCategory = listCategory;
            ListPrivacy = listPrivacy;
            ListData = listData;
            ListRating = listRating;
            ListAuthor = listAuthor;
        }
    }
}
