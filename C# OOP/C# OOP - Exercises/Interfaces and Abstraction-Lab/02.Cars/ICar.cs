﻿

namespace Cars
{
	using System;
	public interface ICar
	{
		
		public string Model { get; set; }
		public string Color { get; set; }
		public void Start();
		
		public void Stop();

	}
}