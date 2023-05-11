using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("isClosedPopups")]
	public class ES3UserType_PopupController : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PopupController() : base(typeof(Cor.TutorialPopup)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Cor.TutorialPopup)obj;
			
			writer.WritePrivateField("isClosedPopups", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Cor.TutorialPopup)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "isClosedPopups":
					instance = (Cor.TutorialPopup)reader.SetPrivateField("isClosedPopups", reader.Read<System.Boolean>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_PopupControllerArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_PopupControllerArray() : base(typeof(Cor.TutorialPopup[]), ES3UserType_PopupController.Instance)
		{
			Instance = this;
		}
	}
}