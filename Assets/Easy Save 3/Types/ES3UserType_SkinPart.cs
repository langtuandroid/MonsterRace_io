using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("ammountRW", "isRewardPart", "isMoneyPart")]
	public class ES3UserType_SkinPart : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_SkinPart() : base(typeof(Cor.SkinPart)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Cor.SkinPart)obj;
			
			writer.WritePrivateField("ammountRW", instance);
			writer.WritePrivateField("isRewardPart", instance);
			writer.WritePrivateField("isMoneyPart", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Cor.SkinPart)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "ammountRW":
					instance = (Cor.SkinPart)reader.SetPrivateField("ammountRW", reader.Read<System.Int32>(), instance);
					break;
					case "isRewardPart":
					instance = (Cor.SkinPart)reader.SetPrivateField("isRewardPart", reader.Read<System.Boolean>(), instance);
					break;
					case "isMoneyPart":
					instance = (Cor.SkinPart)reader.SetPrivateField("isMoneyPart", reader.Read<System.Boolean>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_SkinPartArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_SkinPartArray() : base(typeof(Cor.SkinPart[]), ES3UserType_SkinPart.Instance)
		{
			Instance = this;
		}
	}
}