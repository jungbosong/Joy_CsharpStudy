﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
	public class IronArmor : Item
	{
		public string Name { get; set; }
		public int DefensivePower { get; set; }
		public string Information { get; set; }
		public int AttackPower { get; set; }
		public int Price { get; set; }
		public bool I_Exist { get; set; }
		public bool equipped { get; set; }
		public string Sign { get; set; }
		public int EnhanceNum { get; set; }
		public int OriginAttackPower { get; }
		public int OriginDefensivePower { get; }
		public IronArmor(string Name, string Information)
		{
			this.Name = Name;
			DefensivePower = 5;
			this.Information = Information;
			AttackPower = 0;
			Price = 600;
			I_Exist = true;
			equipped = false;
			Sign = "";
			EnhanceNum = 0;
			OriginAttackPower = 0;
			OriginDefensivePower = 5;
		}
	}
}
