using System;
namespace Logger
{
	public record class FullName(String FirstName, string LastName, string? MiddleName)
	{
        public string First { get; } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
        public string Last { get; } = FirstName ?? throw new ArgumentNullException(nameof(LastName));
        public string Middle { get; } = FirstName ?? throw new ArgumentNullException(nameof(MiddleName));

    }
}

