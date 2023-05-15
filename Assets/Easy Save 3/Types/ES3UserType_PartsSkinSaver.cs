using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("partsID")]
	public class ES3UserType_PartsSkinSaver : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PartsSkinSaver() : base(typeof(Core.PartsSkinSaver)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.PartsSkinSaver)obj;
			
			writer.WritePrivateField("partsID", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.PartsSkinSaver)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "partsID":
					instance = (Core.PartsSkinSaver)reader.SetPrivateField("partsID", reader.Read<System.Collections.Generic.List<System.String>>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_PartsSkinSaverArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_PartsSkinSaverArray() : base(typeof(Core.PartsSkinSaver[]), ES3UserType_PartsSkinSaver.Instance)
		{
			Instance = this;
		}
	}
}