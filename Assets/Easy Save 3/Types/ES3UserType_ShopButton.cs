using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("ammountAds", "isSale")]
	public class ES3UserType_ShopButton : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_ShopButton() : base(typeof(Cor.ShopButton)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Cor.ShopButton)obj;
			
			writer.WritePrivateField("ammountAds", instance);
			writer.WritePrivateField("isSale", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Cor.ShopButton)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "ammountAds":
					instance = (Cor.ShopButton)reader.SetPrivateField("ammountAds", reader.Read<System.Int32>(), instance);
					break;
					case "isSale":
					instance = (Cor.ShopButton)reader.SetPrivateField("isSale", reader.Read<System.Boolean>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_ShopButtonArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_ShopButtonArray() : base(typeof(Cor.ShopButton[]), ES3UserType_ShopButton.Instance)
		{
			Instance = this;
		}
	}
}