using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("moneyRewardVictory", "moneyRewardFailed")]
	public class ES3UserType_LevelRewards : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_LevelRewards() : base(typeof(Core.LevelRewards)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.LevelRewards)obj;
			
			writer.WritePrivateField("moneyRewardVictory", instance);
			writer.WritePrivateField("moneyRewardFailed", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.LevelRewards)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "moneyRewardVictory":
					instance = (Core.LevelRewards)reader.SetPrivateField("moneyRewardVictory", reader.Read<System.Int32>(), instance);
					break;
					case "moneyRewardFailed":
					instance = (Core.LevelRewards)reader.SetPrivateField("moneyRewardFailed", reader.Read<System.Int32>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_LevelRewardsArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_LevelRewardsArray() : base(typeof(Core.LevelRewards[]), ES3UserType_LevelRewards.Instance)
		{
			Instance = this;
		}
	}
}