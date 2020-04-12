using System;
using System.IO;
using System.Text;

namespace _9_4HTML
{
    class Header
    {
        public const string open = "<h1>";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }


}

class UnorderedList
{
    public const string open = "<ul>";
    public const string close = "</ul>";

    public string CreateListItem(string text)
    {
        string open = "<li>\n";
        string close = "</li>\n";

        string listItem = String.Concat(open, text, close, "\n");
        return listItem;
    }

    public StringBuilder CreateList(string[] listItems)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append(open);
        foreach (string item in listItems)
        {
            sb.Append(item);
        }
        sb.Append(close);

        return sb;
    }

}

