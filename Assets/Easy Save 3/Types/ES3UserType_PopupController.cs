using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("isClosedPopups")]
	public class ES3UserType_PopupController : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PopupController() : base(typeof(Core.TutorialPopup)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.TutorialPopup)obj;
			
			writer.WritePrivateField("isClosedPopups", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.TutorialPopup)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "isClosedPopups":
					instance = (Core.TutorialPopup)reader.SetPrivateField("isClosedPopups", reader.Read<System.Boolean>(), instance);
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

		public ES3UserType_PopupControllerArray() : base(typeof(Core.TutorialPopup[]), ES3UserType_PopupController.Instance)
		{
			Instance = this;
		}
	}
}