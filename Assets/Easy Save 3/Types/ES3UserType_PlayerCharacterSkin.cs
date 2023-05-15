using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("_headType", "_armsType", "_bodyType", "_legsType")]
	public class ES3UserType_PlayerCharacterSkin : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PlayerCharacterSkin() : base(typeof(Core.PlayerCharacterSkin)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (Core.PlayerCharacterSkin)obj;
			
			writer.WritePrivateField("_headType", instance);
			writer.WritePrivateField("_armsType", instance);
			writer.WritePrivateField("_bodyType", instance);
			writer.WritePrivateField("_legsType", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (Core.PlayerCharacterSkin)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "_headType":
					instance = (Core.PlayerCharacterSkin)reader.SetPrivateField("_headType", reader.Read<Core.CharacterMonsterType>(), instance);
					break;
					case "_armsType":
					instance = (Core.PlayerCharacterSkin)reader.SetPrivateField("_armsType", reader.Read<Core.CharacterMonsterType>(), instance);
					break;
					case "_bodyType":
					instance = (Core.PlayerCharacterSkin)reader.SetPrivateField("_bodyType", reader.Read<Core.CharacterMonsterType>(), instance);
					break;
					case "_legsType":
					instance = (Core.PlayerCharacterSkin)reader.SetPrivateField("_legsType", reader.Read<Core.CharacterMonsterType>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_PlayerCharacterSkinArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_PlayerCharacterSkinArray() : base(typeof(Core.PlayerCharacterSkin[]), ES3UserType_PlayerCharacterSkin.Instance)
		{
			Instance = this;
		}
	}
}