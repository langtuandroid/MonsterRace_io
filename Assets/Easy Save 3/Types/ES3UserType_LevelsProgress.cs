using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("indexProgress")]
	public class ES3UserType_LevelsProgress : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_LevelsProgress() : base(typeof(Core.RoadMap)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.RoadMap)obj;
			
			writer.WritePrivateField("indexProgress", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.RoadMap)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "indexProgress":
					instance = (Core.RoadMap)reader.SetPrivateField("indexProgress", reader.Read<System.Int32>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_LevelsProgressArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_LevelsProgressArray() : base(typeof(Core.RoadMap[]), ES3UserType_LevelsProgress.Instance)
		{
			Instance = this;
		}
	}
}