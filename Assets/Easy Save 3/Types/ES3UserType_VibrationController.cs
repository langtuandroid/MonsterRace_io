using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("isOffVibration")]
	public class ES3UserType_VibrationController : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_VibrationController() : base(typeof(Cor.VibrationManager)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Cor.VibrationManager)obj;
			
			writer.WritePrivateField("isOffVibration", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Cor.VibrationManager)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "isOffVibration":
					instance = (Cor.VibrationManager)reader.SetPrivateField("isOffVibration", reader.Read<System.Boolean>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_VibrationControllerArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_VibrationControllerArray() : base(typeof(Cor.VibrationManager[]), ES3UserType_VibrationController.Instance)
		{
			Instance = this;
		}
	}
}