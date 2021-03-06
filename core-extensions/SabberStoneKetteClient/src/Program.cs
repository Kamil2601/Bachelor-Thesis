#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;

namespace SabberStoneKettleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			KettleClientServer server;
			if (args.Length != 1)
			{
				//Console.WriteLine("Invalid arguments, run as: SabberStoneKettleClient.exe PORT");
				server = new KettleClientServer(new System.Net.IPEndPoint(System.Net.IPAddress.Any, 4444));
				server.Enter();
				//return;
			} else { 
				server = new KettleClientServer(new System.Net.IPEndPoint(System.Net.IPAddress.Any, int.Parse(args[0])));
				server.Enter();
			}
		}
	}
}
