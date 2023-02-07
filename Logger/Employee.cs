using System;
namespace Logger
{
	public record class Employee(FullName FullName, int Salary, string Position)
    {
        public int Sal { get; } = Salary;
        public string Pos { get; } = Position ?? throw new ArgumentNullException(nameof(Position));
    }
}

