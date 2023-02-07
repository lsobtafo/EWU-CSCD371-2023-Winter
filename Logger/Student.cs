using System;
namespace Logger
{
	public record class Student(FullName FullName, string AcademicStanding, string Major)
	{
        public string AS { get; } = AcademicStanding ?? throw new ArgumentNullException(nameof(AcademicStanding));
        public string Maj { get; } = Major ?? throw new ArgumentNullException(nameof(Major));
    }
}

