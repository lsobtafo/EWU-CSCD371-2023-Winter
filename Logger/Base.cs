using System;
namespace Logger
{
	//Abstract base class
	public abstract class Base :IEntity
	{
		
            public Guid Id { get; init; } = Guid.NewGuid();

			public abstract string Name { get; }
	}
}

