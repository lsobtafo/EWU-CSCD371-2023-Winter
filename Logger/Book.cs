using System;
namespace Logger
{
	public record class Book(FullName AuthorName, string BookTitle,string ISBN)
	{
        public FullName Author { get; } = AuthorName;
        public string Bt { get; } = BookTitle ?? throw new ArgumentNullException(nameof(BookTitle));
        public string IS { get; } = ISBN ?? throw new ArgumentNullException(nameof(ISBN));
    }
}

