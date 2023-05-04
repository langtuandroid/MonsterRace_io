#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Action`1<TMPro.TMP_TextInfo>
struct Action_1_tB93AB717F9D419A1BEC832FF76E74EAA32184CC1;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>
struct Dictionary_2_tABE19B9C5C52F1DE14F0D3287B2696E7D7419180;
// System.Func`2<System.Object,System.Boolean>
struct Func_2_tE1F0D41563EE092E5E5540B061449FDE88F1DC00;
// System.Func`2<TMPro.TextMeshProEffect,System.Boolean>
struct Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5;
// System.Func`3<System.Int32,System.String,TMPro.TMP_FontAsset>
struct Func_3_tC721DF8CDD07ED66A4833A19A2ED2302608C906C;
// System.Func`3<System.Int32,System.String,TMPro.TMP_SpriteAsset>
struct Func_3_t6F6D9932638EA1A5A45303C6626C818C25D164E5;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_tF95C9E01A913DD50575531C8305932628663D9E9;
// System.Collections.Generic.IEnumerable`1<TMPro.TextMeshProEffect>
struct IEnumerable_1_t96A1DAD475F035AD87E4082FD0F709B336B0A32B;
// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>
struct List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B;
// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween>
struct TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4;
// TMPro.TMP_TextProcessingStack`1<System.Int32>[]
struct TMP_TextProcessingStack_1U5BU5D_t08293E0BB072311BB96170F351D1083BCA97B9B2;
// System.ValueTuple`2<System.Int32,System.Int32>[]
struct ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
// System.Decimal[]
struct DecimalU5BU5D_t93BA0C88FA80728F73B792EE1A5199D0C060B615;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// TMPro.FontWeight[]
struct FontWeightU5BU5D_t2A406B5BAB0DD0F06E7F1773DB062E4AF98067BA;
// TMPro.HighlightState[]
struct HighlightStateU5BU5D_tA878A0AF1F4F52882ACD29515AADC277EE135622;
// TMPro.HorizontalAlignmentOptions[]
struct HorizontalAlignmentOptionsU5BU5D_t4D185662282BFB910D8B9A8199E91578E9422658;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// UnityEngine.Material[]
struct MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D;
// TMPro.MaterialReference[]
struct MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// TMPro.RichTextTagAttribute[]
struct RichTextTagAttributeU5BU5D_t5816316EFD8F59DBC30B9F88E15828C564E47B6D;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// TMPro.TMP_CharacterInfo[]
struct TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99;
// TMPro.TMP_ColorGradient[]
struct TMP_ColorGradientU5BU5D_t2F65E8C42F268DFF33BB1392D94BCF5B5087308A;
// TMPro.TMP_LineInfo[]
struct TMP_LineInfoU5BU5D_tE485ECF6A7A96441C72B53D75E7A5A5461A2CA0E;
// TMPro.TMP_LinkInfo[]
struct TMP_LinkInfoU5BU5D_tE11BE54A5923BD2148E716289F44EA465E06536E;
// TMPro.TMP_MeshInfo[]
struct TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7;
// TMPro.TMP_PageInfo[]
struct TMP_PageInfoU5BU5D_tE3DAAA8E2E9147F97C424A9034F677A516E8DAF9;
// TMPro.TMP_WordInfo[]
struct TMP_WordInfoU5BU5D_tD1759E5A84DCCCD42B718D79E953E72A432BB4DC;
// TMPro.TextMeshProEffect[]
struct TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B;
// System.UInt32[]
struct UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// UnityEngine.Vector4[]
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
// TMPro.WordWrapState[]
struct WordWrapStateU5BU5D_t473D59C9DBCC949CE72EF1EB471CBA152A6CEAC9;
// TMPro.TMP_Text/UnicodeChar[]
struct UnicodeCharU5BU5D_t67F27D09F8EB28D2C42DFF16FE60054F157012F5;
// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F;
// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA;
// UnityEngine.Canvas
struct Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26;
// UnityEngine.CanvasRenderer
struct CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// UnityEngine.Gradient
struct Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// TMPro.ITextPreprocessor
struct ITextPreprocessor_tDBB49C8B68D7B80E8D233B9D9666C43981EFAAB9;
// UnityEngine.UI.LayoutElement
struct LayoutElement_tB1F24CC11AF4AA87015C8D8EE06D22349C5BF40A;
// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.UI.RectMask2D
struct RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670;
// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// TMPro.TMP_Character
struct TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35;
// TMPro.TMP_ColorGradient
struct TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB;
// TMPro.TMP_FontAsset
struct TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160;
// TMPro.TMP_SpriteAnimator
struct TMP_SpriteAnimator_t2E0F016A61CA343E3222FF51E7CF0E53F9F256E4;
// TMPro.TMP_SpriteAsset
struct TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39;
// TMPro.TMP_Style
struct TMP_Style_tA9E5B1B35EBFE24EF980CEA03251B638282E120C;
// TMPro.TMP_StyleSheet
struct TMP_StyleSheet_t70C71699F5CB2D855C361DBB78A44C901236C859;
// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9;
// TMPro.TMP_TextElement
struct TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5;
// TMPro.TMP_TextInfo
struct TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D;
// TMPro.TextMeshProEffect
struct TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// UnityEngine.Events.UnityAction
struct UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7;
// UnityEngine.UI.VertexHelper
struct VertexHelper_tB905FCB02AE67CBEE5F265FE37A5938FC5D136FE;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent
struct CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8;
// TMPro.TextMeshProEffect/SharedState
struct SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE;
// TMPro.TextMeshProEffect/??
struct UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83;

IL2CPP_EXTERN_C RuntimeClass* ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Char_t521A6F19B456D956AF452D926C32709DC03D6B17_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisTMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_m0C4C5268B54C7097888C6B109527A680772EBCB5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_All_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m364D65C9D23F5FE9475B3739627C68C4026EAB06_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_mEE33B50B1F2C9BE2AD468D103BD8D2512B0B1663_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponents_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m6F2849BB4B7D923475AE120B415D422E261F0878_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TextMeshProEffect_UE8_m36BB0CE3513C5BA6264807C0624C4ED877252552_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UF6UF9_UF6U0FF_m8048DB4D12F3670CE07B928FE644171AA60CB1DF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477_RuntimeMethod_var;
struct Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7;
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2;
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3;

struct ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99;
struct TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7;
struct TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B;
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tC856938303BA10841299E8291D1DEE88023C558E 
{
};

// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>
struct List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.Text.StringBuilder
struct StringBuilder_t  : public RuntimeObject
{
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t* ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// TMPro.TextMeshProEffect/??
struct UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83  : public RuntimeObject
{
};

// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight>
struct TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	FontWeightU5BU5D_t2A406B5BAB0DD0F06E7F1773DB062E4AF98067BA* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions>
struct TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	HorizontalAlignmentOptionsU5BU5D_t4D185662282BFB910D8B9A8199E91578E9422658* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<System.Int32>
struct TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<System.Single>
struct TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	float ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient>
struct TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	TMP_ColorGradientU5BU5D_t2F65E8C42F268DFF33BB1392D94BCF5B5087308A* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// System.ValueTuple`2<System.Int32,System.Int32>
struct ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D 
{
	// T1 System.ValueTuple`2::Item1
	int32_t ___Item1_0;
	// T2 System.ValueTuple`2::Item2
	int32_t ___Item2_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17 
{
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// UnityEngine.Color32
struct Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Int32 UnityEngine.Color32::rgba
			int32_t ___rgba_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			int32_t ___rgba_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Byte UnityEngine.Color32::r
			uint8_t ___r_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint8_t ___r_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___g_2_OffsetPadding[1];
			// System.Byte UnityEngine.Color32::g
			uint8_t ___g_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___g_2_OffsetPadding_forAlignmentOnly[1];
			uint8_t ___g_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___b_3_OffsetPadding[2];
			// System.Byte UnityEngine.Color32::b
			uint8_t ___b_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___b_3_OffsetPadding_forAlignmentOnly[2];
			uint8_t ___b_3_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___a_4_OffsetPadding[3];
			// System.Byte UnityEngine.Color32::a
			uint8_t ___a_4;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___a_4_OffsetPadding_forAlignmentOnly[3];
			uint8_t ___a_4_forAlignmentOnly;
		};
	};
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B 
{
	// System.Int32 TMPro.MaterialReference::index
	int32_t ___index_0;
	// TMPro.TMP_FontAsset TMPro.MaterialReference::fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	// TMPro.TMP_SpriteAsset TMPro.MaterialReference::spriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	// UnityEngine.Material TMPro.MaterialReference::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	// System.Boolean TMPro.MaterialReference::isDefaultMaterial
	bool ___isDefaultMaterial_4;
	// System.Boolean TMPro.MaterialReference::isFallbackMaterial
	bool ___isFallbackMaterial_5;
	// UnityEngine.Material TMPro.MaterialReference::fallbackMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	// System.Single TMPro.MaterialReference::padding
	float ___padding_7;
	// System.Int32 TMPro.MaterialReference::referenceCount
	int32_t ___referenceCount_8;
};
// Native definition for P/Invoke marshalling of TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B_marshaled_pinvoke
{
	int32_t ___index_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	int32_t ___isDefaultMaterial_4;
	int32_t ___isFallbackMaterial_5;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	float ___padding_7;
	int32_t ___referenceCount_8;
};
// Native definition for COM marshalling of TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B_marshaled_com
{
	int32_t ___index_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	int32_t ___isDefaultMaterial_4;
	int32_t ___isFallbackMaterial_5;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	float ___padding_7;
	int32_t ___referenceCount_8;
};

// UnityEngine.Matrix4x4
struct Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 
{
	// System.Single UnityEngine.Matrix4x4::m00
	float ___m00_0;
	// System.Single UnityEngine.Matrix4x4::m10
	float ___m10_1;
	// System.Single UnityEngine.Matrix4x4::m20
	float ___m20_2;
	// System.Single UnityEngine.Matrix4x4::m30
	float ___m30_3;
	// System.Single UnityEngine.Matrix4x4::m01
	float ___m01_4;
	// System.Single UnityEngine.Matrix4x4::m11
	float ___m11_5;
	// System.Single UnityEngine.Matrix4x4::m21
	float ___m21_6;
	// System.Single UnityEngine.Matrix4x4::m31
	float ___m31_7;
	// System.Single UnityEngine.Matrix4x4::m02
	float ___m02_8;
	// System.Single UnityEngine.Matrix4x4::m12
	float ___m12_9;
	// System.Single UnityEngine.Matrix4x4::m22
	float ___m22_10;
	// System.Single UnityEngine.Matrix4x4::m32
	float ___m32_11;
	// System.Single UnityEngine.Matrix4x4::m03
	float ___m03_12;
	// System.Single UnityEngine.Matrix4x4::m13
	float ___m13_13;
	// System.Single UnityEngine.Matrix4x4::m23
	float ___m23_14;
	// System.Single UnityEngine.Matrix4x4::m33
	float ___m33_15;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// TMPro.TMP_FontStyleStack
struct TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC 
{
	// System.Byte TMPro.TMP_FontStyleStack::bold
	uint8_t ___bold_0;
	// System.Byte TMPro.TMP_FontStyleStack::italic
	uint8_t ___italic_1;
	// System.Byte TMPro.TMP_FontStyleStack::underline
	uint8_t ___underline_2;
	// System.Byte TMPro.TMP_FontStyleStack::strikethrough
	uint8_t ___strikethrough_3;
	// System.Byte TMPro.TMP_FontStyleStack::highlight
	uint8_t ___highlight_4;
	// System.Byte TMPro.TMP_FontStyleStack::superscript
	uint8_t ___superscript_5;
	// System.Byte TMPro.TMP_FontStyleStack::subscript
	uint8_t ___subscript_6;
	// System.Byte TMPro.TMP_FontStyleStack::uppercase
	uint8_t ___uppercase_7;
	// System.Byte TMPro.TMP_FontStyleStack::lowercase
	uint8_t ___lowercase_8;
	// System.Byte TMPro.TMP_FontStyleStack::smallcaps
	uint8_t ___smallcaps_9;
};

// TMPro.TMP_Offset
struct TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6 
{
	// System.Single TMPro.TMP_Offset::m_Left
	float ___m_Left_0;
	// System.Single TMPro.TMP_Offset::m_Right
	float ___m_Right_1;
	// System.Single TMPro.TMP_Offset::m_Top
	float ___m_Top_2;
	// System.Single TMPro.TMP_Offset::m_Bottom
	float ___m_Bottom_3;
};

// System.UInt16
struct UInt16_tF4C148C876015C212FD72652D0B6ED8CC247A455 
{
	// System.UInt16 System.UInt16::m_value
	uint16_t ___m_value_0;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 
{
	// TMPro.TMP_Character TMPro.TMP_Text/SpecialCharacter::character
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	// TMPro.TMP_FontAsset TMPro.TMP_Text/SpecialCharacter::fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	// UnityEngine.Material TMPro.TMP_Text/SpecialCharacter::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	// System.Int32 TMPro.TMP_Text/SpecialCharacter::materialIndex
	int32_t ___materialIndex_3;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777_marshaled_pinvoke
{
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	int32_t ___materialIndex_3;
};
// Native definition for COM marshalling of TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777_marshaled_com
{
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	int32_t ___materialIndex_3;
};

// TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361 
{
	// System.UInt32[] TMPro.TMP_Text/TextBackingContainer::m_Array
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___m_Array_0;
	// System.Int32 TMPro.TMP_Text/TextBackingContainer::m_Count
	int32_t ___m_Count_1;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361_marshaled_pinvoke
{
	Il2CppSafeArray/*NONE*/* ___m_Array_0;
	int32_t ___m_Count_1;
};
// Native definition for COM marshalling of TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361_marshaled_com
{
	Il2CppSafeArray/*NONE*/* ___m_Array_0;
	int32_t ___m_Count_1;
};

// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32>
struct TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>
struct TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// UnityEngine.Bounds
struct Bounds_t367E830C64BBF235ED8C3B2F8CF6254FDCAD39C3 
{
	// UnityEngine.Vector3 UnityEngine.Bounds::m_Center
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Center_0;
	// UnityEngine.Vector3 UnityEngine.Bounds::m_Extents
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Extents_1;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// TMPro.Extents
struct Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 
{
	// UnityEngine.Vector2 TMPro.Extents::min
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___min_2;
	// UnityEngine.Vector2 TMPro.Extents::max
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___max_3;
};

// UnityEngine.Gradient
struct Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Gradient::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Gradient
struct Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Gradient
struct Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// TMPro.HighlightState
struct HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B 
{
	// UnityEngine.Color32 TMPro.HighlightState::color
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_0;
	// TMPro.TMP_Offset TMPro.HighlightState::padding
	TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6 ___padding_1;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// Unity.Profiling.ProfilerMarker
struct ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD 
{
	// System.IntPtr Unity.Profiling.ProfilerMarker::m_Ptr
	intptr_t ___m_Ptr_0;
};

// TMPro.TMP_TextInfo
struct TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D  : public RuntimeObject
{
	// TMPro.TMP_Text TMPro.TMP_TextInfo::textComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___textComponent_2;
	// System.Int32 TMPro.TMP_TextInfo::characterCount
	int32_t ___characterCount_3;
	// System.Int32 TMPro.TMP_TextInfo::spriteCount
	int32_t ___spriteCount_4;
	// System.Int32 TMPro.TMP_TextInfo::spaceCount
	int32_t ___spaceCount_5;
	// System.Int32 TMPro.TMP_TextInfo::wordCount
	int32_t ___wordCount_6;
	// System.Int32 TMPro.TMP_TextInfo::linkCount
	int32_t ___linkCount_7;
	// System.Int32 TMPro.TMP_TextInfo::lineCount
	int32_t ___lineCount_8;
	// System.Int32 TMPro.TMP_TextInfo::pageCount
	int32_t ___pageCount_9;
	// System.Int32 TMPro.TMP_TextInfo::materialCount
	int32_t ___materialCount_10;
	// TMPro.TMP_CharacterInfo[] TMPro.TMP_TextInfo::characterInfo
	TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99* ___characterInfo_11;
	// TMPro.TMP_WordInfo[] TMPro.TMP_TextInfo::wordInfo
	TMP_WordInfoU5BU5D_tD1759E5A84DCCCD42B718D79E953E72A432BB4DC* ___wordInfo_12;
	// TMPro.TMP_LinkInfo[] TMPro.TMP_TextInfo::linkInfo
	TMP_LinkInfoU5BU5D_tE11BE54A5923BD2148E716289F44EA465E06536E* ___linkInfo_13;
	// TMPro.TMP_LineInfo[] TMPro.TMP_TextInfo::lineInfo
	TMP_LineInfoU5BU5D_tE485ECF6A7A96441C72B53D75E7A5A5461A2CA0E* ___lineInfo_14;
	// TMPro.TMP_PageInfo[] TMPro.TMP_TextInfo::pageInfo
	TMP_PageInfoU5BU5D_tE3DAAA8E2E9147F97C424A9034F677A516E8DAF9* ___pageInfo_15;
	// TMPro.TMP_MeshInfo[] TMPro.TMP_TextInfo::meshInfo
	TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* ___meshInfo_16;
	// TMPro.TMP_MeshInfo[] TMPro.TMP_TextInfo::m_CachedMeshInfo
	TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* ___m_CachedMeshInfo_17;
};

// TMPro.TMP_Vertex
struct TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A 
{
	// UnityEngine.Vector3 TMPro.TMP_Vertex::position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_0;
	// UnityEngine.Vector2 TMPro.TMP_Vertex::uv
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___uv_1;
	// UnityEngine.Vector2 TMPro.TMP_Vertex::uv2
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___uv2_2;
	// UnityEngine.Vector2 TMPro.TMP_Vertex::uv4
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___uv4_3;
	// UnityEngine.Color32 TMPro.TMP_Vertex::color
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_4;
};

// TMPro.VertexGradient
struct VertexGradient_t2C057B53C0EA6E987C2B7BAB0305E686DA1C9A8F 
{
	// UnityEngine.Color TMPro.VertexGradient::topLeft
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___topLeft_0;
	// UnityEngine.Color TMPro.VertexGradient::topRight
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___topRight_1;
	// UnityEngine.Color TMPro.VertexGradient::bottomLeft
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___bottomLeft_2;
	// UnityEngine.Color TMPro.VertexGradient::bottomRight
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___bottomRight_3;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>
struct TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	HighlightStateU5BU5D_tA878A0AF1F4F52882ACD29515AADC277EE135622* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// TMPro.TMP_CharacterInfo
struct TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 
{
	// System.Char TMPro.TMP_CharacterInfo::character
	Il2CppChar ___character_0;
	// System.Int32 TMPro.TMP_CharacterInfo::index
	int32_t ___index_1;
	// System.Int32 TMPro.TMP_CharacterInfo::stringLength
	int32_t ___stringLength_2;
	// TMPro.TMP_TextElementType TMPro.TMP_CharacterInfo::elementType
	int32_t ___elementType_3;
	// TMPro.TMP_TextElement TMPro.TMP_CharacterInfo::textElement
	TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5* ___textElement_4;
	// TMPro.TMP_FontAsset TMPro.TMP_CharacterInfo::fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_5;
	// TMPro.TMP_SpriteAsset TMPro.TMP_CharacterInfo::spriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_6;
	// System.Int32 TMPro.TMP_CharacterInfo::spriteIndex
	int32_t ___spriteIndex_7;
	// UnityEngine.Material TMPro.TMP_CharacterInfo::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_8;
	// System.Int32 TMPro.TMP_CharacterInfo::materialReferenceIndex
	int32_t ___materialReferenceIndex_9;
	// System.Boolean TMPro.TMP_CharacterInfo::isUsingAlternateTypeface
	bool ___isUsingAlternateTypeface_10;
	// System.Single TMPro.TMP_CharacterInfo::pointSize
	float ___pointSize_11;
	// System.Int32 TMPro.TMP_CharacterInfo::lineNumber
	int32_t ___lineNumber_12;
	// System.Int32 TMPro.TMP_CharacterInfo::pageNumber
	int32_t ___pageNumber_13;
	// System.Int32 TMPro.TMP_CharacterInfo::vertexIndex
	int32_t ___vertexIndex_14;
	// TMPro.TMP_Vertex TMPro.TMP_CharacterInfo::vertex_BL
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BL_15;
	// TMPro.TMP_Vertex TMPro.TMP_CharacterInfo::vertex_TL
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TL_16;
	// TMPro.TMP_Vertex TMPro.TMP_CharacterInfo::vertex_TR
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TR_17;
	// TMPro.TMP_Vertex TMPro.TMP_CharacterInfo::vertex_BR
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BR_18;
	// UnityEngine.Vector3 TMPro.TMP_CharacterInfo::topLeft
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topLeft_19;
	// UnityEngine.Vector3 TMPro.TMP_CharacterInfo::bottomLeft
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomLeft_20;
	// UnityEngine.Vector3 TMPro.TMP_CharacterInfo::topRight
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topRight_21;
	// UnityEngine.Vector3 TMPro.TMP_CharacterInfo::bottomRight
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomRight_22;
	// System.Single TMPro.TMP_CharacterInfo::origin
	float ___origin_23;
	// System.Single TMPro.TMP_CharacterInfo::xAdvance
	float ___xAdvance_24;
	// System.Single TMPro.TMP_CharacterInfo::ascender
	float ___ascender_25;
	// System.Single TMPro.TMP_CharacterInfo::baseLine
	float ___baseLine_26;
	// System.Single TMPro.TMP_CharacterInfo::descender
	float ___descender_27;
	// System.Single TMPro.TMP_CharacterInfo::adjustedAscender
	float ___adjustedAscender_28;
	// System.Single TMPro.TMP_CharacterInfo::adjustedDescender
	float ___adjustedDescender_29;
	// System.Single TMPro.TMP_CharacterInfo::aspectRatio
	float ___aspectRatio_30;
	// System.Single TMPro.TMP_CharacterInfo::scale
	float ___scale_31;
	// UnityEngine.Color32 TMPro.TMP_CharacterInfo::color
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_32;
	// UnityEngine.Color32 TMPro.TMP_CharacterInfo::underlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_33;
	// System.Int32 TMPro.TMP_CharacterInfo::underlineVertexIndex
	int32_t ___underlineVertexIndex_34;
	// UnityEngine.Color32 TMPro.TMP_CharacterInfo::strikethroughColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_35;
	// System.Int32 TMPro.TMP_CharacterInfo::strikethroughVertexIndex
	int32_t ___strikethroughVertexIndex_36;
	// UnityEngine.Color32 TMPro.TMP_CharacterInfo::highlightColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_37;
	// TMPro.HighlightState TMPro.TMP_CharacterInfo::highlightState
	HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B ___highlightState_38;
	// TMPro.FontStyles TMPro.TMP_CharacterInfo::style
	int32_t ___style_39;
	// System.Boolean TMPro.TMP_CharacterInfo::isVisible
	bool ___isVisible_40;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_CharacterInfo
struct TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8_marshaled_pinvoke
{
	uint8_t ___character_0;
	int32_t ___index_1;
	int32_t ___stringLength_2;
	int32_t ___elementType_3;
	TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5* ___textElement_4;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_5;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_6;
	int32_t ___spriteIndex_7;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_8;
	int32_t ___materialReferenceIndex_9;
	int32_t ___isUsingAlternateTypeface_10;
	float ___pointSize_11;
	int32_t ___lineNumber_12;
	int32_t ___pageNumber_13;
	int32_t ___vertexIndex_14;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BL_15;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TL_16;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TR_17;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BR_18;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topLeft_19;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomLeft_20;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topRight_21;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomRight_22;
	float ___origin_23;
	float ___xAdvance_24;
	float ___ascender_25;
	float ___baseLine_26;
	float ___descender_27;
	float ___adjustedAscender_28;
	float ___adjustedDescender_29;
	float ___aspectRatio_30;
	float ___scale_31;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_32;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_33;
	int32_t ___underlineVertexIndex_34;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_35;
	int32_t ___strikethroughVertexIndex_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_37;
	HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B ___highlightState_38;
	int32_t ___style_39;
	int32_t ___isVisible_40;
};
// Native definition for COM marshalling of TMPro.TMP_CharacterInfo
struct TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8_marshaled_com
{
	uint8_t ___character_0;
	int32_t ___index_1;
	int32_t ___stringLength_2;
	int32_t ___elementType_3;
	TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5* ___textElement_4;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_5;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_6;
	int32_t ___spriteIndex_7;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_8;
	int32_t ___materialReferenceIndex_9;
	int32_t ___isUsingAlternateTypeface_10;
	float ___pointSize_11;
	int32_t ___lineNumber_12;
	int32_t ___pageNumber_13;
	int32_t ___vertexIndex_14;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BL_15;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TL_16;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_TR_17;
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___vertex_BR_18;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topLeft_19;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomLeft_20;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___topRight_21;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___bottomRight_22;
	float ___origin_23;
	float ___xAdvance_24;
	float ___ascender_25;
	float ___baseLine_26;
	float ___descender_27;
	float ___adjustedAscender_28;
	float ___adjustedDescender_29;
	float ___aspectRatio_30;
	float ___scale_31;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_32;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_33;
	int32_t ___underlineVertexIndex_34;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_35;
	int32_t ___strikethroughVertexIndex_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_37;
	HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B ___highlightState_38;
	int32_t ___style_39;
	int32_t ___isVisible_40;
};

// TMPro.TMP_LineInfo
struct TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 
{
	// System.Int32 TMPro.TMP_LineInfo::controlCharacterCount
	int32_t ___controlCharacterCount_0;
	// System.Int32 TMPro.TMP_LineInfo::characterCount
	int32_t ___characterCount_1;
	// System.Int32 TMPro.TMP_LineInfo::visibleCharacterCount
	int32_t ___visibleCharacterCount_2;
	// System.Int32 TMPro.TMP_LineInfo::spaceCount
	int32_t ___spaceCount_3;
	// System.Int32 TMPro.TMP_LineInfo::wordCount
	int32_t ___wordCount_4;
	// System.Int32 TMPro.TMP_LineInfo::firstCharacterIndex
	int32_t ___firstCharacterIndex_5;
	// System.Int32 TMPro.TMP_LineInfo::firstVisibleCharacterIndex
	int32_t ___firstVisibleCharacterIndex_6;
	// System.Int32 TMPro.TMP_LineInfo::lastCharacterIndex
	int32_t ___lastCharacterIndex_7;
	// System.Int32 TMPro.TMP_LineInfo::lastVisibleCharacterIndex
	int32_t ___lastVisibleCharacterIndex_8;
	// System.Single TMPro.TMP_LineInfo::length
	float ___length_9;
	// System.Single TMPro.TMP_LineInfo::lineHeight
	float ___lineHeight_10;
	// System.Single TMPro.TMP_LineInfo::ascender
	float ___ascender_11;
	// System.Single TMPro.TMP_LineInfo::baseline
	float ___baseline_12;
	// System.Single TMPro.TMP_LineInfo::descender
	float ___descender_13;
	// System.Single TMPro.TMP_LineInfo::maxAdvance
	float ___maxAdvance_14;
	// System.Single TMPro.TMP_LineInfo::width
	float ___width_15;
	// System.Single TMPro.TMP_LineInfo::marginLeft
	float ___marginLeft_16;
	// System.Single TMPro.TMP_LineInfo::marginRight
	float ___marginRight_17;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_LineInfo::alignment
	int32_t ___alignment_18;
	// TMPro.Extents TMPro.TMP_LineInfo::lineExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___lineExtents_19;
};

// TMPro.TMP_MeshInfo
struct TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B 
{
	// UnityEngine.Mesh TMPro.TMP_MeshInfo::mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___mesh_4;
	// System.Int32 TMPro.TMP_MeshInfo::vertexCount
	int32_t ___vertexCount_5;
	// UnityEngine.Vector3[] TMPro.TMP_MeshInfo::vertices
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___vertices_6;
	// UnityEngine.Vector3[] TMPro.TMP_MeshInfo::normals
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___normals_7;
	// UnityEngine.Vector4[] TMPro.TMP_MeshInfo::tangents
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___tangents_8;
	// UnityEngine.Vector2[] TMPro.TMP_MeshInfo::uvs0
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uvs0_9;
	// UnityEngine.Vector2[] TMPro.TMP_MeshInfo::uvs2
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uvs2_10;
	// UnityEngine.Color32[] TMPro.TMP_MeshInfo::colors32
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___colors32_11;
	// System.Int32[] TMPro.TMP_MeshInfo::triangles
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___triangles_12;
	// UnityEngine.Material TMPro.TMP_MeshInfo::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_13;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_MeshInfo
struct TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B_marshaled_pinvoke
{
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___mesh_4;
	int32_t ___vertexCount_5;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___vertices_6;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___normals_7;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___tangents_8;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___uvs0_9;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___uvs2_10;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* ___colors32_11;
	Il2CppSafeArray/*NONE*/* ___triangles_12;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_13;
};
// Native definition for COM marshalling of TMPro.TMP_MeshInfo
struct TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B_marshaled_com
{
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___mesh_4;
	int32_t ___vertexCount_5;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___vertices_6;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___normals_7;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___tangents_8;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___uvs0_9;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___uvs2_10;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* ___colors32_11;
	Il2CppSafeArray/*NONE*/* ___triangles_12;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_13;
};

// System.Func`2<TMPro.TextMeshProEffect,System.Boolean>
struct Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5  : public MulticastDelegate_t
{
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A 
{
	// System.Int32 TMPro.WordWrapState::previous_WordBreak
	int32_t ___previous_WordBreak_0;
	// System.Int32 TMPro.WordWrapState::total_CharacterCount
	int32_t ___total_CharacterCount_1;
	// System.Int32 TMPro.WordWrapState::visible_CharacterCount
	int32_t ___visible_CharacterCount_2;
	// System.Int32 TMPro.WordWrapState::visible_SpriteCount
	int32_t ___visible_SpriteCount_3;
	// System.Int32 TMPro.WordWrapState::visible_LinkCount
	int32_t ___visible_LinkCount_4;
	// System.Int32 TMPro.WordWrapState::firstCharacterIndex
	int32_t ___firstCharacterIndex_5;
	// System.Int32 TMPro.WordWrapState::firstVisibleCharacterIndex
	int32_t ___firstVisibleCharacterIndex_6;
	// System.Int32 TMPro.WordWrapState::lastCharacterIndex
	int32_t ___lastCharacterIndex_7;
	// System.Int32 TMPro.WordWrapState::lastVisibleCharIndex
	int32_t ___lastVisibleCharIndex_8;
	// System.Int32 TMPro.WordWrapState::lineNumber
	int32_t ___lineNumber_9;
	// System.Single TMPro.WordWrapState::maxCapHeight
	float ___maxCapHeight_10;
	// System.Single TMPro.WordWrapState::maxAscender
	float ___maxAscender_11;
	// System.Single TMPro.WordWrapState::maxDescender
	float ___maxDescender_12;
	// System.Single TMPro.WordWrapState::startOfLineAscender
	float ___startOfLineAscender_13;
	// System.Single TMPro.WordWrapState::maxLineAscender
	float ___maxLineAscender_14;
	// System.Single TMPro.WordWrapState::maxLineDescender
	float ___maxLineDescender_15;
	// System.Single TMPro.WordWrapState::pageAscender
	float ___pageAscender_16;
	// TMPro.HorizontalAlignmentOptions TMPro.WordWrapState::horizontalAlignment
	int32_t ___horizontalAlignment_17;
	// System.Single TMPro.WordWrapState::marginLeft
	float ___marginLeft_18;
	// System.Single TMPro.WordWrapState::marginRight
	float ___marginRight_19;
	// System.Single TMPro.WordWrapState::xAdvance
	float ___xAdvance_20;
	// System.Single TMPro.WordWrapState::preferredWidth
	float ___preferredWidth_21;
	// System.Single TMPro.WordWrapState::preferredHeight
	float ___preferredHeight_22;
	// System.Single TMPro.WordWrapState::previousLineScale
	float ___previousLineScale_23;
	// System.Int32 TMPro.WordWrapState::wordCount
	int32_t ___wordCount_24;
	// TMPro.FontStyles TMPro.WordWrapState::fontStyle
	int32_t ___fontStyle_25;
	// System.Int32 TMPro.WordWrapState::italicAngle
	int32_t ___italicAngle_26;
	// System.Single TMPro.WordWrapState::fontScaleMultiplier
	float ___fontScaleMultiplier_27;
	// System.Single TMPro.WordWrapState::currentFontSize
	float ___currentFontSize_28;
	// System.Single TMPro.WordWrapState::baselineOffset
	float ___baselineOffset_29;
	// System.Single TMPro.WordWrapState::lineOffset
	float ___lineOffset_30;
	// System.Boolean TMPro.WordWrapState::isDrivenLineSpacing
	bool ___isDrivenLineSpacing_31;
	// System.Single TMPro.WordWrapState::glyphHorizontalAdvanceAdjustment
	float ___glyphHorizontalAdvanceAdjustment_32;
	// System.Single TMPro.WordWrapState::cSpace
	float ___cSpace_33;
	// System.Single TMPro.WordWrapState::mSpace
	float ___mSpace_34;
	// TMPro.TMP_TextInfo TMPro.WordWrapState::textInfo
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	// TMPro.TMP_LineInfo TMPro.WordWrapState::lineInfo
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	// UnityEngine.Color32 TMPro.WordWrapState::vertexColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	// UnityEngine.Color32 TMPro.WordWrapState::underlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	// UnityEngine.Color32 TMPro.WordWrapState::strikethroughColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	// UnityEngine.Color32 TMPro.WordWrapState::highlightColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	// TMPro.TMP_FontStyleStack TMPro.WordWrapState::basicStyleStack
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::italicAngleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::colorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::underlineColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::strikethroughColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::highlightColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> TMPro.WordWrapState::highlightStateStack
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> TMPro.WordWrapState::colorGradientStack
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::sizeStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::indentStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight> TMPro.WordWrapState::fontWeightStack
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::styleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::baselineStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::actionStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> TMPro.WordWrapState::materialReferenceStack
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions> TMPro.WordWrapState::lineJustificationStack
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	// System.Int32 TMPro.WordWrapState::spriteAnimationID
	int32_t ___spriteAnimationID_57;
	// TMPro.TMP_FontAsset TMPro.WordWrapState::currentFontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	// TMPro.TMP_SpriteAsset TMPro.WordWrapState::currentSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	// UnityEngine.Material TMPro.WordWrapState::currentMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	// System.Int32 TMPro.WordWrapState::currentMaterialIndex
	int32_t ___currentMaterialIndex_61;
	// TMPro.Extents TMPro.WordWrapState::meshExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	// System.Boolean TMPro.WordWrapState::tagNoParsing
	bool ___tagNoParsing_63;
	// System.Boolean TMPro.WordWrapState::isNonBreakingSpace
	bool ___isNonBreakingSpace_64;
};
// Native definition for P/Invoke marshalling of TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A_marshaled_pinvoke
{
	int32_t ___previous_WordBreak_0;
	int32_t ___total_CharacterCount_1;
	int32_t ___visible_CharacterCount_2;
	int32_t ___visible_SpriteCount_3;
	int32_t ___visible_LinkCount_4;
	int32_t ___firstCharacterIndex_5;
	int32_t ___firstVisibleCharacterIndex_6;
	int32_t ___lastCharacterIndex_7;
	int32_t ___lastVisibleCharIndex_8;
	int32_t ___lineNumber_9;
	float ___maxCapHeight_10;
	float ___maxAscender_11;
	float ___maxDescender_12;
	float ___startOfLineAscender_13;
	float ___maxLineAscender_14;
	float ___maxLineDescender_15;
	float ___pageAscender_16;
	int32_t ___horizontalAlignment_17;
	float ___marginLeft_18;
	float ___marginRight_19;
	float ___xAdvance_20;
	float ___preferredWidth_21;
	float ___preferredHeight_22;
	float ___previousLineScale_23;
	int32_t ___wordCount_24;
	int32_t ___fontStyle_25;
	int32_t ___italicAngle_26;
	float ___fontScaleMultiplier_27;
	float ___currentFontSize_28;
	float ___baselineOffset_29;
	float ___lineOffset_30;
	int32_t ___isDrivenLineSpacing_31;
	float ___glyphHorizontalAdvanceAdjustment_32;
	float ___cSpace_33;
	float ___mSpace_34;
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	int32_t ___spriteAnimationID_57;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	int32_t ___currentMaterialIndex_61;
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	int32_t ___tagNoParsing_63;
	int32_t ___isNonBreakingSpace_64;
};
// Native definition for COM marshalling of TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A_marshaled_com
{
	int32_t ___previous_WordBreak_0;
	int32_t ___total_CharacterCount_1;
	int32_t ___visible_CharacterCount_2;
	int32_t ___visible_SpriteCount_3;
	int32_t ___visible_LinkCount_4;
	int32_t ___firstCharacterIndex_5;
	int32_t ___firstVisibleCharacterIndex_6;
	int32_t ___lastCharacterIndex_7;
	int32_t ___lastVisibleCharIndex_8;
	int32_t ___lineNumber_9;
	float ___maxCapHeight_10;
	float ___maxAscender_11;
	float ___maxDescender_12;
	float ___startOfLineAscender_13;
	float ___maxLineAscender_14;
	float ___maxLineDescender_15;
	float ___pageAscender_16;
	int32_t ___horizontalAlignment_17;
	float ___marginLeft_18;
	float ___marginRight_19;
	float ___xAdvance_20;
	float ___preferredWidth_21;
	float ___preferredHeight_22;
	float ___previousLineScale_23;
	int32_t ___wordCount_24;
	int32_t ___fontStyle_25;
	int32_t ___italicAngle_26;
	float ___fontScaleMultiplier_27;
	float ___currentFontSize_28;
	float ___baselineOffset_29;
	float ___lineOffset_30;
	int32_t ___isDrivenLineSpacing_31;
	float ___glyphHorizontalAdvanceAdjustment_32;
	float ___cSpace_33;
	float ___mSpace_34;
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	int32_t ___spriteAnimationID_57;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	int32_t ___currentMaterialIndex_61;
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	int32_t ___tagNoParsing_63;
	int32_t ___isNonBreakingSpace_64;
};

// TMPro.TextMeshProEffect/??
struct UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E 
{
	// System.Single TMPro.TextMeshProEffect/??::??
	float ___UF2UF4_0;
	// TMPro.TMP_CharacterInfo TMPro.TextMeshProEffect/??::??
	TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___UF2UF6_1;
	// TMPro.TextMeshProEffect TMPro.TextMeshProEffect/??::??
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* ___UF2UF2_2;
};

// TMPro.TextMeshProEffect/??
struct UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8 
{
	// System.Single TMPro.TextMeshProEffect/??::??
	float ___UF6UAA_0;
	// TMPro.TMP_CharacterInfo TMPro.TextMeshProEffect/??::?o
	TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___UF2o_1;
	// TMPro.TextMeshProEffect TMPro.TextMeshProEffect/??::??
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* ___UF2U3BF_2;
};

// TMPro.TextMeshProEffect/??
struct UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F 
{
	// TMPro.TMP_CharacterInfo TMPro.TextMeshProEffect/??::??
	TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___UF6UFA_0;
	// TMPro.TextMeshProEffect TMPro.TextMeshProEffect/??::??
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* ___UF6UF1_1;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>
struct TMP_TextProcessingStack_1_t2DDA00FFC64AF6E3AFD475AB2086D16C34787E0F 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	WordWrapStateU5BU5D_t473D59C9DBCC949CE72EF1EB471CBA152A6CEAC9* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
	// System.Object System.ArgumentOutOfRangeException::_actualValue
	RuntimeObject* ____actualValue_19;
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// TMPro.TextMeshProEffect
struct TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// TMPro.TextMeshProEffect/EffectType TMPro.TextMeshProEffect::Type
	uint8_t ___Type_4;
	// System.Single TMPro.TextMeshProEffect::DurationInSeconds
	float ___DurationInSeconds_5;
	// System.Single TMPro.TextMeshProEffect::Amplitude
	float ___Amplitude_6;
	// System.Single TMPro.TextMeshProEffect::CharacterDurationRatio
	float ___CharacterDurationRatio_7;
	// System.Int32 TMPro.TextMeshProEffect::CharactersPerDuration
	int32_t ___CharactersPerDuration_8;
	// UnityEngine.Gradient TMPro.TextMeshProEffect::Gradient
	Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* ___Gradient_9;
	// TMPro.TextMeshProEffect/MixType TMPro.TextMeshProEffect::Mix
	uint8_t ___Mix_10;
	// System.Boolean TMPro.TextMeshProEffect::AutoPlay
	bool ___AutoPlay_11;
	// System.Boolean TMPro.TextMeshProEffect::Repeat
	bool ___Repeat_12;
	// System.String TMPro.TextMeshProEffect::ForWords
	String_t* ___ForWords_13;
	// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>> TMPro.TextMeshProEffect::??
	List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* ___UF6UE0_14;
	// System.Boolean TMPro.TextMeshProEffect::IsFinished
	bool ___IsFinished_15;
	// System.Single TMPro.TextMeshProEffect::??
	float ___UF6UE5_16;
	// TMPro.TMP_Text TMPro.TextMeshProEffect::??
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___UF6UE7_17;
	// TMPro.TextMeshProEffect/EffectType TMPro.TextMeshProEffect::??
	uint8_t ___UF6UEA_18;
	// System.Boolean TMPro.TextMeshProEffect::??
	bool ___UF6UEB_19;
	// System.Boolean TMPro.TextMeshProEffect::??
	bool ___UF6UE8_20;
	// System.Boolean TMPro.TextMeshProEffect::??
	bool ___UF6UEF_21;
	// System.Single TMPro.TextMeshProEffect::??
	float ___UF6UEE_22;
	// System.String TMPro.TextMeshProEffect::??
	String_t* ___UF6UEC_23;
	// System.UInt16 TMPro.TextMeshProEffect::??
	uint16_t ___UF6UC4_24;
	// System.Single[] TMPro.TextMeshProEffect::??
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___UF6UC5_25;
	// TMPro.TextMeshProEffect/SharedState TMPro.TextMeshProEffect::??
	SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* ___UF6UC9_26;
	// System.Single TMPro.TextMeshProEffect::??
	float ___UF6UE6_27;
	// TMPro.TMP_TextInfo TMPro.TextMeshProEffect::??
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___UF6UC6_28;
	// System.String TMPro.TextMeshProEffect::??
	String_t* ___UF6UFB_29;
};

// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// TMPro.TextMeshProEffect/SharedState
struct SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Boolean TMPro.TextMeshProEffect/SharedState::TextMeshIsUpdated
	bool ___TextMeshIsUpdated_4;
};

// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// UnityEngine.Material UnityEngine.UI.Graphic::m_Material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_Material_6;
	// UnityEngine.Color UnityEngine.UI.Graphic::m_Color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_Color_7;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipLayoutUpdate
	bool ___m_SkipLayoutUpdate_8;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipMaterialUpdate
	bool ___m_SkipMaterialUpdate_9;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTarget
	bool ___m_RaycastTarget_10;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTargetCache
	bool ___m_RaycastTargetCache_11;
	// UnityEngine.Vector4 UnityEngine.UI.Graphic::m_RaycastPadding
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_RaycastPadding_12;
	// UnityEngine.RectTransform UnityEngine.UI.Graphic::m_RectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_RectTransform_13;
	// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::m_CanvasRenderer
	CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* ___m_CanvasRenderer_14;
	// UnityEngine.Canvas UnityEngine.UI.Graphic::m_Canvas
	Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* ___m_Canvas_15;
	// System.Boolean UnityEngine.UI.Graphic::m_VertsDirty
	bool ___m_VertsDirty_16;
	// System.Boolean UnityEngine.UI.Graphic::m_MaterialDirty
	bool ___m_MaterialDirty_17;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyLayoutCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyLayoutCallback_18;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyVertsCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyVertsCallback_19;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyMaterialCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyMaterialCallback_20;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::m_CachedMesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_CachedMesh_23;
	// UnityEngine.Vector2[] UnityEngine.UI.Graphic::m_CachedUvs
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___m_CachedUvs_24;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> UnityEngine.UI.Graphic::m_ColorTweenRunner
	TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4* ___m_ColorTweenRunner_25;
	// System.Boolean UnityEngine.UI.Graphic::<useLegacyMeshGeneration>k__BackingField
	bool ___U3CuseLegacyMeshGenerationU3Ek__BackingField_26;
};

// UnityEngine.UI.MaskableGraphic
struct MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E  : public Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931
{
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculateStencil
	bool ___m_ShouldRecalculateStencil_27;
	// UnityEngine.Material UnityEngine.UI.MaskableGraphic::m_MaskMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_MaskMaterial_28;
	// UnityEngine.UI.RectMask2D UnityEngine.UI.MaskableGraphic::m_ParentMask
	RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670* ___m_ParentMask_29;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_Maskable
	bool ___m_Maskable_30;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IsMaskingGraphic
	bool ___m_IsMaskingGraphic_31;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IncludeForMasking
	bool ___m_IncludeForMasking_32;
	// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent UnityEngine.UI.MaskableGraphic::m_OnCullStateChanged
	CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8* ___m_OnCullStateChanged_33;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculate
	bool ___m_ShouldRecalculate_34;
	// System.Int32 UnityEngine.UI.MaskableGraphic::m_StencilValue
	int32_t ___m_StencilValue_35;
	// UnityEngine.Vector3[] UnityEngine.UI.MaskableGraphic::m_Corners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_Corners_36;
};

// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9  : public MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E
{
	// System.String TMPro.TMP_Text::m_text
	String_t* ___m_text_37;
	// System.Boolean TMPro.TMP_Text::m_IsTextBackingStringDirty
	bool ___m_IsTextBackingStringDirty_38;
	// TMPro.ITextPreprocessor TMPro.TMP_Text::m_TextPreprocessor
	RuntimeObject* ___m_TextPreprocessor_39;
	// System.Boolean TMPro.TMP_Text::m_isRightToLeft
	bool ___m_isRightToLeft_40;
	// TMPro.TMP_FontAsset TMPro.TMP_Text::m_fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___m_fontAsset_41;
	// TMPro.TMP_FontAsset TMPro.TMP_Text::m_currentFontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___m_currentFontAsset_42;
	// System.Boolean TMPro.TMP_Text::m_isSDFShader
	bool ___m_isSDFShader_43;
	// UnityEngine.Material TMPro.TMP_Text::m_sharedMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_sharedMaterial_44;
	// UnityEngine.Material TMPro.TMP_Text::m_currentMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_currentMaterial_45;
	// System.Int32 TMPro.TMP_Text::m_currentMaterialIndex
	int32_t ___m_currentMaterialIndex_49;
	// UnityEngine.Material[] TMPro.TMP_Text::m_fontSharedMaterials
	MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* ___m_fontSharedMaterials_50;
	// UnityEngine.Material TMPro.TMP_Text::m_fontMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_fontMaterial_51;
	// UnityEngine.Material[] TMPro.TMP_Text::m_fontMaterials
	MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* ___m_fontMaterials_52;
	// System.Boolean TMPro.TMP_Text::m_isMaterialDirty
	bool ___m_isMaterialDirty_53;
	// UnityEngine.Color32 TMPro.TMP_Text::m_fontColor32
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_fontColor32_54;
	// UnityEngine.Color TMPro.TMP_Text::m_fontColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_fontColor_55;
	// UnityEngine.Color32 TMPro.TMP_Text::m_underlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_underlineColor_57;
	// UnityEngine.Color32 TMPro.TMP_Text::m_strikethroughColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_strikethroughColor_58;
	// System.Boolean TMPro.TMP_Text::m_enableVertexGradient
	bool ___m_enableVertexGradient_59;
	// TMPro.ColorMode TMPro.TMP_Text::m_colorMode
	int32_t ___m_colorMode_60;
	// TMPro.VertexGradient TMPro.TMP_Text::m_fontColorGradient
	VertexGradient_t2C057B53C0EA6E987C2B7BAB0305E686DA1C9A8F ___m_fontColorGradient_61;
	// TMPro.TMP_ColorGradient TMPro.TMP_Text::m_fontColorGradientPreset
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_fontColorGradientPreset_62;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_spriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_spriteAsset_63;
	// System.Boolean TMPro.TMP_Text::m_tintAllSprites
	bool ___m_tintAllSprites_64;
	// System.Boolean TMPro.TMP_Text::m_tintSprite
	bool ___m_tintSprite_65;
	// UnityEngine.Color32 TMPro.TMP_Text::m_spriteColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_spriteColor_66;
	// TMPro.TMP_StyleSheet TMPro.TMP_Text::m_StyleSheet
	TMP_StyleSheet_t70C71699F5CB2D855C361DBB78A44C901236C859* ___m_StyleSheet_67;
	// TMPro.TMP_Style TMPro.TMP_Text::m_TextStyle
	TMP_Style_tA9E5B1B35EBFE24EF980CEA03251B638282E120C* ___m_TextStyle_68;
	// System.Int32 TMPro.TMP_Text::m_TextStyleHashCode
	int32_t ___m_TextStyleHashCode_69;
	// System.Boolean TMPro.TMP_Text::m_overrideHtmlColors
	bool ___m_overrideHtmlColors_70;
	// UnityEngine.Color32 TMPro.TMP_Text::m_faceColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_faceColor_71;
	// UnityEngine.Color32 TMPro.TMP_Text::m_outlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_outlineColor_72;
	// System.Single TMPro.TMP_Text::m_outlineWidth
	float ___m_outlineWidth_73;
	// System.Single TMPro.TMP_Text::m_fontSize
	float ___m_fontSize_74;
	// System.Single TMPro.TMP_Text::m_currentFontSize
	float ___m_currentFontSize_75;
	// System.Single TMPro.TMP_Text::m_fontSizeBase
	float ___m_fontSizeBase_76;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_sizeStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_sizeStack_77;
	// TMPro.FontWeight TMPro.TMP_Text::m_fontWeight
	int32_t ___m_fontWeight_78;
	// TMPro.FontWeight TMPro.TMP_Text::m_FontWeightInternal
	int32_t ___m_FontWeightInternal_79;
	// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight> TMPro.TMP_Text::m_FontWeightStack
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___m_FontWeightStack_80;
	// System.Boolean TMPro.TMP_Text::m_enableAutoSizing
	bool ___m_enableAutoSizing_81;
	// System.Single TMPro.TMP_Text::m_maxFontSize
	float ___m_maxFontSize_82;
	// System.Single TMPro.TMP_Text::m_minFontSize
	float ___m_minFontSize_83;
	// System.Int32 TMPro.TMP_Text::m_AutoSizeIterationCount
	int32_t ___m_AutoSizeIterationCount_84;
	// System.Int32 TMPro.TMP_Text::m_AutoSizeMaxIterationCount
	int32_t ___m_AutoSizeMaxIterationCount_85;
	// System.Boolean TMPro.TMP_Text::m_IsAutoSizePointSizeSet
	bool ___m_IsAutoSizePointSizeSet_86;
	// System.Single TMPro.TMP_Text::m_fontSizeMin
	float ___m_fontSizeMin_87;
	// System.Single TMPro.TMP_Text::m_fontSizeMax
	float ___m_fontSizeMax_88;
	// TMPro.FontStyles TMPro.TMP_Text::m_fontStyle
	int32_t ___m_fontStyle_89;
	// TMPro.FontStyles TMPro.TMP_Text::m_FontStyleInternal
	int32_t ___m_FontStyleInternal_90;
	// TMPro.TMP_FontStyleStack TMPro.TMP_Text::m_fontStyleStack
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___m_fontStyleStack_91;
	// System.Boolean TMPro.TMP_Text::m_isUsingBold
	bool ___m_isUsingBold_92;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_Text::m_HorizontalAlignment
	int32_t ___m_HorizontalAlignment_93;
	// TMPro.VerticalAlignmentOptions TMPro.TMP_Text::m_VerticalAlignment
	int32_t ___m_VerticalAlignment_94;
	// TMPro.TextAlignmentOptions TMPro.TMP_Text::m_textAlignment
	int32_t ___m_textAlignment_95;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_Text::m_lineJustification
	int32_t ___m_lineJustification_96;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions> TMPro.TMP_Text::m_lineJustificationStack
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___m_lineJustificationStack_97;
	// UnityEngine.Vector3[] TMPro.TMP_Text::m_textContainerLocalCorners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_textContainerLocalCorners_98;
	// System.Single TMPro.TMP_Text::m_characterSpacing
	float ___m_characterSpacing_99;
	// System.Single TMPro.TMP_Text::m_cSpacing
	float ___m_cSpacing_100;
	// System.Single TMPro.TMP_Text::m_monoSpacing
	float ___m_monoSpacing_101;
	// System.Single TMPro.TMP_Text::m_wordSpacing
	float ___m_wordSpacing_102;
	// System.Single TMPro.TMP_Text::m_lineSpacing
	float ___m_lineSpacing_103;
	// System.Single TMPro.TMP_Text::m_lineSpacingDelta
	float ___m_lineSpacingDelta_104;
	// System.Single TMPro.TMP_Text::m_lineHeight
	float ___m_lineHeight_105;
	// System.Boolean TMPro.TMP_Text::m_IsDrivenLineSpacing
	bool ___m_IsDrivenLineSpacing_106;
	// System.Single TMPro.TMP_Text::m_lineSpacingMax
	float ___m_lineSpacingMax_107;
	// System.Single TMPro.TMP_Text::m_paragraphSpacing
	float ___m_paragraphSpacing_108;
	// System.Single TMPro.TMP_Text::m_charWidthMaxAdj
	float ___m_charWidthMaxAdj_109;
	// System.Single TMPro.TMP_Text::m_charWidthAdjDelta
	float ___m_charWidthAdjDelta_110;
	// System.Boolean TMPro.TMP_Text::m_enableWordWrapping
	bool ___m_enableWordWrapping_111;
	// System.Boolean TMPro.TMP_Text::m_isCharacterWrappingEnabled
	bool ___m_isCharacterWrappingEnabled_112;
	// System.Boolean TMPro.TMP_Text::m_isNonBreakingSpace
	bool ___m_isNonBreakingSpace_113;
	// System.Boolean TMPro.TMP_Text::m_isIgnoringAlignment
	bool ___m_isIgnoringAlignment_114;
	// System.Single TMPro.TMP_Text::m_wordWrappingRatios
	float ___m_wordWrappingRatios_115;
	// TMPro.TextOverflowModes TMPro.TMP_Text::m_overflowMode
	int32_t ___m_overflowMode_116;
	// System.Int32 TMPro.TMP_Text::m_firstOverflowCharacterIndex
	int32_t ___m_firstOverflowCharacterIndex_117;
	// TMPro.TMP_Text TMPro.TMP_Text::m_linkedTextComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___m_linkedTextComponent_118;
	// TMPro.TMP_Text TMPro.TMP_Text::parentLinkedComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___parentLinkedComponent_119;
	// System.Boolean TMPro.TMP_Text::m_isTextTruncated
	bool ___m_isTextTruncated_120;
	// System.Boolean TMPro.TMP_Text::m_enableKerning
	bool ___m_enableKerning_121;
	// System.Single TMPro.TMP_Text::m_GlyphHorizontalAdvanceAdjustment
	float ___m_GlyphHorizontalAdvanceAdjustment_122;
	// System.Boolean TMPro.TMP_Text::m_enableExtraPadding
	bool ___m_enableExtraPadding_123;
	// System.Boolean TMPro.TMP_Text::checkPaddingRequired
	bool ___checkPaddingRequired_124;
	// System.Boolean TMPro.TMP_Text::m_isRichText
	bool ___m_isRichText_125;
	// System.Boolean TMPro.TMP_Text::m_parseCtrlCharacters
	bool ___m_parseCtrlCharacters_126;
	// System.Boolean TMPro.TMP_Text::m_isOverlay
	bool ___m_isOverlay_127;
	// System.Boolean TMPro.TMP_Text::m_isOrthographic
	bool ___m_isOrthographic_128;
	// System.Boolean TMPro.TMP_Text::m_isCullingEnabled
	bool ___m_isCullingEnabled_129;
	// System.Boolean TMPro.TMP_Text::m_isMaskingEnabled
	bool ___m_isMaskingEnabled_130;
	// System.Boolean TMPro.TMP_Text::isMaskUpdateRequired
	bool ___isMaskUpdateRequired_131;
	// System.Boolean TMPro.TMP_Text::m_ignoreCulling
	bool ___m_ignoreCulling_132;
	// TMPro.TextureMappingOptions TMPro.TMP_Text::m_horizontalMapping
	int32_t ___m_horizontalMapping_133;
	// TMPro.TextureMappingOptions TMPro.TMP_Text::m_verticalMapping
	int32_t ___m_verticalMapping_134;
	// System.Single TMPro.TMP_Text::m_uvLineOffset
	float ___m_uvLineOffset_135;
	// TMPro.TextRenderFlags TMPro.TMP_Text::m_renderMode
	int32_t ___m_renderMode_136;
	// TMPro.VertexSortingOrder TMPro.TMP_Text::m_geometrySortingOrder
	int32_t ___m_geometrySortingOrder_137;
	// System.Boolean TMPro.TMP_Text::m_IsTextObjectScaleStatic
	bool ___m_IsTextObjectScaleStatic_138;
	// System.Boolean TMPro.TMP_Text::m_VertexBufferAutoSizeReduction
	bool ___m_VertexBufferAutoSizeReduction_139;
	// System.Int32 TMPro.TMP_Text::m_firstVisibleCharacter
	int32_t ___m_firstVisibleCharacter_140;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleCharacters
	int32_t ___m_maxVisibleCharacters_141;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleWords
	int32_t ___m_maxVisibleWords_142;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleLines
	int32_t ___m_maxVisibleLines_143;
	// System.Boolean TMPro.TMP_Text::m_useMaxVisibleDescender
	bool ___m_useMaxVisibleDescender_144;
	// System.Int32 TMPro.TMP_Text::m_pageToDisplay
	int32_t ___m_pageToDisplay_145;
	// System.Boolean TMPro.TMP_Text::m_isNewPage
	bool ___m_isNewPage_146;
	// UnityEngine.Vector4 TMPro.TMP_Text::m_margin
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_margin_147;
	// System.Single TMPro.TMP_Text::m_marginLeft
	float ___m_marginLeft_148;
	// System.Single TMPro.TMP_Text::m_marginRight
	float ___m_marginRight_149;
	// System.Single TMPro.TMP_Text::m_marginWidth
	float ___m_marginWidth_150;
	// System.Single TMPro.TMP_Text::m_marginHeight
	float ___m_marginHeight_151;
	// System.Single TMPro.TMP_Text::m_width
	float ___m_width_152;
	// TMPro.TMP_TextInfo TMPro.TMP_Text::m_textInfo
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___m_textInfo_153;
	// System.Boolean TMPro.TMP_Text::m_havePropertiesChanged
	bool ___m_havePropertiesChanged_154;
	// System.Boolean TMPro.TMP_Text::m_isUsingLegacyAnimationComponent
	bool ___m_isUsingLegacyAnimationComponent_155;
	// UnityEngine.Transform TMPro.TMP_Text::m_transform
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_transform_156;
	// UnityEngine.RectTransform TMPro.TMP_Text::m_rectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_rectTransform_157;
	// UnityEngine.Vector2 TMPro.TMP_Text::m_PreviousRectTransformSize
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_PreviousRectTransformSize_158;
	// UnityEngine.Vector2 TMPro.TMP_Text::m_PreviousPivotPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_PreviousPivotPosition_159;
	// System.Boolean TMPro.TMP_Text::<autoSizeTextContainer>k__BackingField
	bool ___U3CautoSizeTextContainerU3Ek__BackingField_160;
	// System.Boolean TMPro.TMP_Text::m_autoSizeTextContainer
	bool ___m_autoSizeTextContainer_161;
	// UnityEngine.Mesh TMPro.TMP_Text::m_mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_mesh_162;
	// System.Boolean TMPro.TMP_Text::m_isVolumetricText
	bool ___m_isVolumetricText_163;
	// System.Action`1<TMPro.TMP_TextInfo> TMPro.TMP_Text::OnPreRenderText
	Action_1_tB93AB717F9D419A1BEC832FF76E74EAA32184CC1* ___OnPreRenderText_166;
	// TMPro.TMP_SpriteAnimator TMPro.TMP_Text::m_spriteAnimator
	TMP_SpriteAnimator_t2E0F016A61CA343E3222FF51E7CF0E53F9F256E4* ___m_spriteAnimator_167;
	// System.Single TMPro.TMP_Text::m_flexibleHeight
	float ___m_flexibleHeight_168;
	// System.Single TMPro.TMP_Text::m_flexibleWidth
	float ___m_flexibleWidth_169;
	// System.Single TMPro.TMP_Text::m_minWidth
	float ___m_minWidth_170;
	// System.Single TMPro.TMP_Text::m_minHeight
	float ___m_minHeight_171;
	// System.Single TMPro.TMP_Text::m_maxWidth
	float ___m_maxWidth_172;
	// System.Single TMPro.TMP_Text::m_maxHeight
	float ___m_maxHeight_173;
	// UnityEngine.UI.LayoutElement TMPro.TMP_Text::m_LayoutElement
	LayoutElement_tB1F24CC11AF4AA87015C8D8EE06D22349C5BF40A* ___m_LayoutElement_174;
	// System.Single TMPro.TMP_Text::m_preferredWidth
	float ___m_preferredWidth_175;
	// System.Single TMPro.TMP_Text::m_renderedWidth
	float ___m_renderedWidth_176;
	// System.Boolean TMPro.TMP_Text::m_isPreferredWidthDirty
	bool ___m_isPreferredWidthDirty_177;
	// System.Single TMPro.TMP_Text::m_preferredHeight
	float ___m_preferredHeight_178;
	// System.Single TMPro.TMP_Text::m_renderedHeight
	float ___m_renderedHeight_179;
	// System.Boolean TMPro.TMP_Text::m_isPreferredHeightDirty
	bool ___m_isPreferredHeightDirty_180;
	// System.Boolean TMPro.TMP_Text::m_isCalculatingPreferredValues
	bool ___m_isCalculatingPreferredValues_181;
	// System.Int32 TMPro.TMP_Text::m_layoutPriority
	int32_t ___m_layoutPriority_182;
	// System.Boolean TMPro.TMP_Text::m_isLayoutDirty
	bool ___m_isLayoutDirty_183;
	// System.Boolean TMPro.TMP_Text::m_isAwake
	bool ___m_isAwake_184;
	// System.Boolean TMPro.TMP_Text::m_isWaitingOnResourceLoad
	bool ___m_isWaitingOnResourceLoad_185;
	// TMPro.TMP_Text/TextInputSources TMPro.TMP_Text::m_inputSource
	int32_t ___m_inputSource_186;
	// System.Single TMPro.TMP_Text::m_fontScaleMultiplier
	float ___m_fontScaleMultiplier_187;
	// System.Single TMPro.TMP_Text::tag_LineIndent
	float ___tag_LineIndent_191;
	// System.Single TMPro.TMP_Text::tag_Indent
	float ___tag_Indent_192;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_indentStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_indentStack_193;
	// System.Boolean TMPro.TMP_Text::tag_NoParsing
	bool ___tag_NoParsing_194;
	// System.Boolean TMPro.TMP_Text::m_isParsingText
	bool ___m_isParsingText_195;
	// UnityEngine.Matrix4x4 TMPro.TMP_Text::m_FXMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ___m_FXMatrix_196;
	// System.Boolean TMPro.TMP_Text::m_isFXMatrixSet
	bool ___m_isFXMatrixSet_197;
	// TMPro.TMP_Text/UnicodeChar[] TMPro.TMP_Text::m_TextProcessingArray
	UnicodeCharU5BU5D_t67F27D09F8EB28D2C42DFF16FE60054F157012F5* ___m_TextProcessingArray_198;
	// System.Int32 TMPro.TMP_Text::m_InternalTextProcessingArraySize
	int32_t ___m_InternalTextProcessingArraySize_199;
	// TMPro.TMP_CharacterInfo[] TMPro.TMP_Text::m_internalCharacterInfo
	TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99* ___m_internalCharacterInfo_200;
	// System.Int32 TMPro.TMP_Text::m_totalCharacterCount
	int32_t ___m_totalCharacterCount_201;
	// System.Int32 TMPro.TMP_Text::m_characterCount
	int32_t ___m_characterCount_208;
	// System.Int32 TMPro.TMP_Text::m_firstCharacterOfLine
	int32_t ___m_firstCharacterOfLine_209;
	// System.Int32 TMPro.TMP_Text::m_firstVisibleCharacterOfLine
	int32_t ___m_firstVisibleCharacterOfLine_210;
	// System.Int32 TMPro.TMP_Text::m_lastCharacterOfLine
	int32_t ___m_lastCharacterOfLine_211;
	// System.Int32 TMPro.TMP_Text::m_lastVisibleCharacterOfLine
	int32_t ___m_lastVisibleCharacterOfLine_212;
	// System.Int32 TMPro.TMP_Text::m_lineNumber
	int32_t ___m_lineNumber_213;
	// System.Int32 TMPro.TMP_Text::m_lineVisibleCharacterCount
	int32_t ___m_lineVisibleCharacterCount_214;
	// System.Int32 TMPro.TMP_Text::m_pageNumber
	int32_t ___m_pageNumber_215;
	// System.Single TMPro.TMP_Text::m_PageAscender
	float ___m_PageAscender_216;
	// System.Single TMPro.TMP_Text::m_maxTextAscender
	float ___m_maxTextAscender_217;
	// System.Single TMPro.TMP_Text::m_maxCapHeight
	float ___m_maxCapHeight_218;
	// System.Single TMPro.TMP_Text::m_ElementAscender
	float ___m_ElementAscender_219;
	// System.Single TMPro.TMP_Text::m_ElementDescender
	float ___m_ElementDescender_220;
	// System.Single TMPro.TMP_Text::m_maxLineAscender
	float ___m_maxLineAscender_221;
	// System.Single TMPro.TMP_Text::m_maxLineDescender
	float ___m_maxLineDescender_222;
	// System.Single TMPro.TMP_Text::m_startOfLineAscender
	float ___m_startOfLineAscender_223;
	// System.Single TMPro.TMP_Text::m_startOfLineDescender
	float ___m_startOfLineDescender_224;
	// System.Single TMPro.TMP_Text::m_lineOffset
	float ___m_lineOffset_225;
	// TMPro.Extents TMPro.TMP_Text::m_meshExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___m_meshExtents_226;
	// UnityEngine.Color32 TMPro.TMP_Text::m_htmlColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_htmlColor_227;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_colorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_colorStack_228;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_underlineColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_underlineColorStack_229;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_strikethroughColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_strikethroughColorStack_230;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> TMPro.TMP_Text::m_HighlightStateStack
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___m_HighlightStateStack_231;
	// TMPro.TMP_ColorGradient TMPro.TMP_Text::m_colorGradientPreset
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_colorGradientPreset_232;
	// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> TMPro.TMP_Text::m_colorGradientStack
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___m_colorGradientStack_233;
	// System.Boolean TMPro.TMP_Text::m_colorGradientPresetIsTinted
	bool ___m_colorGradientPresetIsTinted_234;
	// System.Single TMPro.TMP_Text::m_tabSpacing
	float ___m_tabSpacing_235;
	// System.Single TMPro.TMP_Text::m_spacing
	float ___m_spacing_236;
	// TMPro.TMP_TextProcessingStack`1<System.Int32>[] TMPro.TMP_Text::m_TextStyleStacks
	TMP_TextProcessingStack_1U5BU5D_t08293E0BB072311BB96170F351D1083BCA97B9B2* ___m_TextStyleStacks_237;
	// System.Int32 TMPro.TMP_Text::m_TextStyleStackDepth
	int32_t ___m_TextStyleStackDepth_238;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.TMP_Text::m_ItalicAngleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___m_ItalicAngleStack_239;
	// System.Int32 TMPro.TMP_Text::m_ItalicAngle
	int32_t ___m_ItalicAngle_240;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.TMP_Text::m_actionStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___m_actionStack_241;
	// System.Single TMPro.TMP_Text::m_padding
	float ___m_padding_242;
	// System.Single TMPro.TMP_Text::m_baselineOffset
	float ___m_baselineOffset_243;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_baselineOffsetStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_baselineOffsetStack_244;
	// System.Single TMPro.TMP_Text::m_xAdvance
	float ___m_xAdvance_245;
	// TMPro.TMP_TextElementType TMPro.TMP_Text::m_textElementType
	int32_t ___m_textElementType_246;
	// TMPro.TMP_TextElement TMPro.TMP_Text::m_cached_TextElement
	TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5* ___m_cached_TextElement_247;
	// TMPro.TMP_Text/SpecialCharacter TMPro.TMP_Text::m_Ellipsis
	SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 ___m_Ellipsis_248;
	// TMPro.TMP_Text/SpecialCharacter TMPro.TMP_Text::m_Underline
	SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 ___m_Underline_249;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_defaultSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_defaultSpriteAsset_250;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_currentSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_currentSpriteAsset_251;
	// System.Int32 TMPro.TMP_Text::m_spriteCount
	int32_t ___m_spriteCount_252;
	// System.Int32 TMPro.TMP_Text::m_spriteIndex
	int32_t ___m_spriteIndex_253;
	// System.Int32 TMPro.TMP_Text::m_spriteAnimationID
	int32_t ___m_spriteAnimationID_254;
	// System.Boolean TMPro.TMP_Text::m_ignoreActiveState
	bool ___m_ignoreActiveState_257;
	// TMPro.TMP_Text/TextBackingContainer TMPro.TMP_Text::m_TextBackingArray
	TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361 ___m_TextBackingArray_258;
	// System.Decimal[] TMPro.TMP_Text::k_Power
	DecimalU5BU5D_t93BA0C88FA80728F73B792EE1A5199D0C060B615* ___k_Power_259;
};

// <Module>

// <Module>

// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>
struct List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.Text.StringBuilder

// System.Text.StringBuilder

// System.ValueType

// System.ValueType

// TMPro.TextMeshProEffect/??
struct UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_StaticFields
{
	// TMPro.TextMeshProEffect/?? TMPro.TextMeshProEffect/??::??
	UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* ___UF6U192_0;
	// System.Func`2<TMPro.TextMeshProEffect,System.Boolean> TMPro.TextMeshProEffect/??::??
	Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5* ___UF6UE1_1;
};

// TMPro.TextMeshProEffect/??

// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight>

// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight>

// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions>

// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions>

// TMPro.TMP_TextProcessingStack`1<System.Int32>

// TMPro.TMP_TextProcessingStack`1<System.Int32>

// TMPro.TMP_TextProcessingStack`1<System.Single>

// TMPro.TMP_TextProcessingStack`1<System.Single>

// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient>

// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient>

// System.ValueTuple`2<System.Int32,System.Int32>

// System.ValueTuple`2<System.Int32,System.Int32>

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Byte

// System.Byte

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17_StaticFields
{
	// System.Byte[] System.Char::s_categoryForLatin1
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___s_categoryForLatin1_3;
};

// System.Char

// UnityEngine.Color

// UnityEngine.Color

// UnityEngine.Color32

// UnityEngine.Color32

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// TMPro.MaterialReference

// TMPro.MaterialReference

// UnityEngine.Matrix4x4
struct Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6_StaticFields
{
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::zeroMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ___zeroMatrix_16;
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::identityMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ___identityMatrix_17;
};

// UnityEngine.Matrix4x4

// System.Single

// System.Single

// TMPro.TMP_FontStyleStack

// TMPro.TMP_FontStyleStack

// TMPro.TMP_Offset
struct TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6_StaticFields
{
	// TMPro.TMP_Offset TMPro.TMP_Offset::k_ZeroOffset
	TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6 ___k_ZeroOffset_4;
};

// TMPro.TMP_Offset

// System.UInt16

// System.UInt16

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector2

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// UnityEngine.Vector3

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields
{
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___negativeInfinityVector_8;
};

// UnityEngine.Vector4

// System.Void

// System.Void

// TMPro.TMP_Text/SpecialCharacter

// TMPro.TMP_Text/SpecialCharacter

// TMPro.TMP_Text/TextBackingContainer

// TMPro.TMP_Text/TextBackingContainer

// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32>

// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32>

// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>

// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>

// UnityEngine.Bounds

// UnityEngine.Bounds

// System.Delegate

// System.Delegate

// System.Exception
struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};

// System.Exception

// TMPro.Extents
struct Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8_StaticFields
{
	// TMPro.Extents TMPro.Extents::zero
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___zero_0;
	// TMPro.Extents TMPro.Extents::uninitialized
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___uninitialized_1;
};

// TMPro.Extents

// UnityEngine.Gradient

// UnityEngine.Gradient

// TMPro.HighlightState

// TMPro.HighlightState

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// Unity.Profiling.ProfilerMarker

// Unity.Profiling.ProfilerMarker

// TMPro.TMP_TextInfo
struct TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D_StaticFields
{
	// UnityEngine.Vector2 TMPro.TMP_TextInfo::k_InfinityVectorPositive
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_InfinityVectorPositive_0;
	// UnityEngine.Vector2 TMPro.TMP_TextInfo::k_InfinityVectorNegative
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_InfinityVectorNegative_1;
};

// TMPro.TMP_TextInfo

// TMPro.TMP_Vertex
struct TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A_StaticFields
{
	// TMPro.TMP_Vertex TMPro.TMP_Vertex::k_Zero
	TMP_Vertex_t0FD80AE2515219689310A8F619A265667B530E1A ___k_Zero_5;
};

// TMPro.TMP_Vertex

// TMPro.VertexGradient

// TMPro.VertexGradient

// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>

// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>

// UnityEngine.Component

// UnityEngine.Component

// UnityEngine.GameObject

// UnityEngine.GameObject

// UnityEngine.Mesh

// UnityEngine.Mesh

// System.MulticastDelegate

// System.MulticastDelegate

// System.SystemException

// System.SystemException

// TMPro.TMP_CharacterInfo

// TMPro.TMP_CharacterInfo

// TMPro.TMP_LineInfo

// TMPro.TMP_LineInfo

// TMPro.TMP_MeshInfo
struct TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B_StaticFields
{
	// UnityEngine.Color32 TMPro.TMP_MeshInfo::s_DefaultColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___s_DefaultColor_0;
	// UnityEngine.Vector3 TMPro.TMP_MeshInfo::s_DefaultNormal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___s_DefaultNormal_1;
	// UnityEngine.Vector4 TMPro.TMP_MeshInfo::s_DefaultTangent
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___s_DefaultTangent_2;
	// UnityEngine.Bounds TMPro.TMP_MeshInfo::s_DefaultBounds
	Bounds_t367E830C64BBF235ED8C3B2F8CF6254FDCAD39C3 ___s_DefaultBounds_3;
};

// TMPro.TMP_MeshInfo

// System.Func`2<TMPro.TextMeshProEffect,System.Boolean>

// System.Func`2<TMPro.TextMeshProEffect,System.Boolean>

// System.ArgumentException

// System.ArgumentException

// UnityEngine.Behaviour

// UnityEngine.Behaviour

// TMPro.WordWrapState

// TMPro.WordWrapState

// TMPro.TextMeshProEffect/??

// TMPro.TextMeshProEffect/??

// TMPro.TextMeshProEffect/??

// TMPro.TextMeshProEffect/??

// TMPro.TextMeshProEffect/??

// TMPro.TextMeshProEffect/??

// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>

// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>

// System.ArgumentOutOfRangeException

// System.ArgumentOutOfRangeException

// UnityEngine.MonoBehaviour

// UnityEngine.MonoBehaviour

// TMPro.TextMeshProEffect

// TMPro.TextMeshProEffect

// UnityEngine.EventSystems.UIBehaviour

// UnityEngine.EventSystems.UIBehaviour

// TMPro.TextMeshProEffect/SharedState

// TMPro.TextMeshProEffect/SharedState

// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931_StaticFields
{
	// UnityEngine.Material UnityEngine.UI.Graphic::s_DefaultUI
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___s_DefaultUI_4;
	// UnityEngine.Texture2D UnityEngine.UI.Graphic::s_WhiteTexture
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___s_WhiteTexture_5;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::s_Mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___s_Mesh_21;
	// UnityEngine.UI.VertexHelper UnityEngine.UI.Graphic::s_VertexHelper
	VertexHelper_tB905FCB02AE67CBEE5F265FE37A5938FC5D136FE* ___s_VertexHelper_22;
};

// UnityEngine.UI.Graphic

// UnityEngine.UI.MaskableGraphic

// UnityEngine.UI.MaskableGraphic

// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_StaticFields
{
	// TMPro.MaterialReference[] TMPro.TMP_Text::m_materialReferences
	MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2* ___m_materialReferences_46;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32> TMPro.TMP_Text::m_materialReferenceIndexLookup
	Dictionary_2_tABE19B9C5C52F1DE14F0D3287B2696E7D7419180* ___m_materialReferenceIndexLookup_47;
	// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> TMPro.TMP_Text::m_materialReferenceStack
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___m_materialReferenceStack_48;
	// UnityEngine.Color32 TMPro.TMP_Text::s_colorWhite
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___s_colorWhite_56;
	// System.Func`3<System.Int32,System.String,TMPro.TMP_FontAsset> TMPro.TMP_Text::OnFontAssetRequest
	Func_3_tC721DF8CDD07ED66A4833A19A2ED2302608C906C* ___OnFontAssetRequest_164;
	// System.Func`3<System.Int32,System.String,TMPro.TMP_SpriteAsset> TMPro.TMP_Text::OnSpriteAssetRequest
	Func_3_t6F6D9932638EA1A5A45303C6626C818C25D164E5* ___OnSpriteAssetRequest_165;
	// System.Char[] TMPro.TMP_Text::m_htmlTag
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_htmlTag_188;
	// TMPro.RichTextTagAttribute[] TMPro.TMP_Text::m_xmlAttribute
	RichTextTagAttributeU5BU5D_t5816316EFD8F59DBC30B9F88E15828C564E47B6D* ___m_xmlAttribute_189;
	// System.Single[] TMPro.TMP_Text::m_attributeParameterValues
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___m_attributeParameterValues_190;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedWordWrapState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedWordWrapState_202;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedLineState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedLineState_203;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedEllipsisState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedEllipsisState_204;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedLastValidState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedLastValidState_205;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedSoftLineBreakState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedSoftLineBreakState_206;
	// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState> TMPro.TMP_Text::m_EllipsisInsertionCandidateStack
	TMP_TextProcessingStack_1_t2DDA00FFC64AF6E3AFD475AB2086D16C34787E0F ___m_EllipsisInsertionCandidateStack_207;
	// Unity.Profiling.ProfilerMarker TMPro.TMP_Text::k_ParseTextMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_ParseTextMarker_255;
	// Unity.Profiling.ProfilerMarker TMPro.TMP_Text::k_InsertNewLineMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_InsertNewLineMarker_256;
	// UnityEngine.Vector2 TMPro.TMP_Text::k_LargePositiveVector2
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_LargePositiveVector2_260;
	// UnityEngine.Vector2 TMPro.TMP_Text::k_LargeNegativeVector2
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_LargeNegativeVector2_261;
	// System.Single TMPro.TMP_Text::k_LargePositiveFloat
	float ___k_LargePositiveFloat_262;
	// System.Single TMPro.TMP_Text::k_LargeNegativeFloat
	float ___k_LargeNegativeFloat_263;
	// System.Int32 TMPro.TMP_Text::k_LargePositiveInt
	int32_t ___k_LargePositiveInt_264;
	// System.Int32 TMPro.TMP_Text::k_LargeNegativeInt
	int32_t ___k_LargeNegativeInt_265;
};

// TMPro.TMP_Text
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// TMPro.TextMeshProEffect[]
struct TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B  : public RuntimeArray
{
	ALIGN_FIELD (8) TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* m_Items[1];

	inline TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// TMPro.TMP_MeshInfo[]
struct TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7  : public RuntimeArray
{
	ALIGN_FIELD (8) TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B m_Items[1];

	inline TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___mesh_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___vertices_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___normals_7), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___tangents_8), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___uvs0_9), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___uvs2_10), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___colors32_11), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___triangles_12), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___material_13), (void*)NULL);
		#endif
	}
	inline TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TMP_MeshInfo_t320C52212E9D672EBB5F5C18C3E0700AA33DD76B value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___mesh_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___vertices_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___normals_7), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___tangents_8), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___uvs0_9), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___uvs2_10), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___colors32_11), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___triangles_12), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___material_13), (void*)NULL);
		#endif
	}
};
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259  : public RuntimeArray
{
	ALIGN_FIELD (8) Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B m_Items[1];

	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 m_Items[1];

	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		m_Items[index] = value;
	}
};
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C  : public RuntimeArray
{
	ALIGN_FIELD (8) float m_Items[1];

	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// TMPro.TMP_CharacterInfo[]
struct TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99  : public RuntimeArray
{
	ALIGN_FIELD (8) TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 m_Items[1];

	inline TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___textElement_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___fontAsset_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___spriteAsset_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___material_8), (void*)NULL);
		#endif
	}
	inline TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___textElement_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___fontAsset_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___spriteAsset_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___material_8), (void*)NULL);
		#endif
	}
};
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB  : public RuntimeArray
{
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};
// System.ValueTuple`2<System.Int32,System.Int32>[]
struct ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263  : public RuntimeArray
{
	ALIGN_FIELD (8) ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D m_Items[1];

	inline ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D value)
	{
		m_Items[index] = value;
	}
};


// T UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.GameObject::GetComponents<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* GameObject_GetComponents_TisRuntimeObject_m1654344F5C897CA86F9AB51530972086BDB05948_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Object,System.Boolean>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_m13C0A7F33154D861E2A041B52E88461832DA1697_gshared (Func_2_tE1F0D41563EE092E5E5540B061449FDE88F1DC00* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Boolean System.Linq.Enumerable::All<System.Object>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerable_All_TisRuntimeObject_m57CDB9DB99F9E77214B47367D213B06AC3ED97FF_gshared (RuntimeObject* ___0_source, Func_2_tE1F0D41563EE092E5E5540B061449FDE88F1DC00* ___1_predicate, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_gshared (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::Clear()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method) ;
// System.Void System.ValueTuple`2<System.Int32,System.Int32>::.ctor(T1,T2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477_gshared (ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D* __this, int32_t ___0_item1, int32_t ___1_item2, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9_gshared (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method) ;

// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<TMPro.TextMeshProEffect/SharedState>()
inline SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<TMPro.TextMeshProEffect/SharedState>()
inline SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* GameObject_AddComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_mEE33B50B1F2C9BE2AD468D103BD8D2512B0B1663 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// System.Void UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_hideFlags_mACB8BFC903FB3B01BBD427753E791BF28B5E33D4 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<TMPro.TMP_Text>()
inline TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* Component_GetComponent_TisTMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_m0C4C5268B54C7097888C6B109527A680772EBCB5 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Void TMPro.TextMeshProEffect::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_Play_mF87CBD9D4DAC8AC81C85E4F401F297E19827C32D (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.GameObject::GetComponents<TMPro.TextMeshProEffect>()
inline TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* GameObject_GetComponents_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m6F2849BB4B7D923475AE120B415D422E261F0878 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponents_TisRuntimeObject_m1654344F5C897CA86F9AB51530972086BDB05948_gshared)(__this, method);
}
// System.Void System.Func`2<TMPro.TextMeshProEffect,System.Boolean>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m40F3FE5B0E6EFBCC5A306B98AFF29B503D92F15D (Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m13C0A7F33154D861E2A041B52E88461832DA1697_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Boolean System.Linq.Enumerable::All<TMPro.TextMeshProEffect>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
inline bool Enumerable_All_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m364D65C9D23F5FE9475B3739627C68C4026EAB06 (RuntimeObject* ___0_source, Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5* ___1_predicate, const RuntimeMethod* method)
{
	return ((  bool (*) (RuntimeObject*, Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5*, const RuntimeMethod*))Enumerable_All_TisRuntimeObject_m57CDB9DB99F9E77214B47367D213B06AC3ED97FF_gshared)(___0_source, ___1_predicate, method);
}
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_obj, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_Apply_mEB8E65D2B3214F442684E4502A23FFC8366F5CDD (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) ;
// TMPro.TextMeshProEffect/SharedState TMPro.TextMeshProEffect::get_SharedStateProp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* TextMeshProEffect_get_SharedStateProp_m11DDC85C2838989F54D82649CF017C7C0ACB6012 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) ;
// TMPro.TMP_TextInfo TMPro.TMP_Text::get_textInfo()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* TMP_Text_get_textInfo_mA24C606B8EA51436E4AA3B9D6DCDFA7A8995E10E_inline (TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* __this, const RuntimeMethod* method) ;
// TMPro.TMP_MeshInfo[] TMPro.TMP_TextInfo::CopyMeshInfoVertexData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* TMP_TextInfo_CopyMeshInfoVertexData_mF66E2F8821470E68D95FEB53D456CFA86241C0CA (TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_realtimeSinceStartup_m73B3CB73175D79A44333D59BB70F9EDE55EC9510 (const RuntimeMethod* method) ;
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_m8C940F3CFC42866709D7CA931B3D77B4BE94BCB6 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::?()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UEB_mA24132689F737695A1C418669C75138980767B75 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) ;
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Random::get_value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_get_value_m2CEA87FADF5222EF9E13D32695F15E2BA282E24B (const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Lerp(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___0_a, float ___1_b, float ___2_t, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::get_Count()
inline int32_t List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, const RuntimeMethod*))List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_gshared_inline)(__this, method);
}
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478 (String_t* ___0_value, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::get_Item(System.Int32)
inline ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, int32_t, const RuntimeMethod*))List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_gshared)(__this, ___0_index, method);
}
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_TextInfo,TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Color32[],UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single,System.Single,System.UInt16)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UE8_m36BB0CE3513C5BA6264807C0624C4ED877252552 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___0_UEF, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___1_UEE, int32_t ___2_UEC, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___3_UC4, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___4_UC5, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___5_UC9, float ___6_UE6, float ___7_UC6, uint16_t ___8_UFB, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_vertices(UnityEngine.Vector3[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0_value, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::Clear()
inline void List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, const RuntimeMethod*))List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_gshared_inline)(__this, method);
}
// System.Boolean System.String::IsNullOrWhiteSpace(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrWhiteSpace_m42E1F3B2C358068D645E46F01CF1834DC77A5A10 (String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void System.Text.StringBuilder::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m2619CA8D2C3476DF1A302D9D941498BB1C6164C5 (StringBuilder_t* __this, int32_t ___0_capacity, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1 (StringBuilder_t* __this, Il2CppChar ___0_value, const RuntimeMethod* method) ;
// TMPro.FontStyles TMPro.TMP_Text::get_fontStyle()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t TMP_Text_get_fontStyle_mC34CC5EBEDD43CE93BA911CCC4D33F9697838586_inline (TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* __this, const RuntimeMethod* method) ;
// System.String[] System.String::Split(System.Char[],System.StringSplitOptions)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* String_Split_m6811F7CF4DE7C68019D76E9DC6D17B2293BA8B12 (String_t* __this, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___0_separator, int32_t ___1_options, const RuntimeMethod* method) ;
// System.Int32 System.String::IndexOf(System.String,System.Int32,System.StringComparison)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_IndexOf_m2DFDE7BD37585BDBCD6F688B4E4A93304235A0B8 (String_t* __this, String_t* ___0_value, int32_t ___1_startIndex, int32_t ___2_comparisonType, const RuntimeMethod* method) ;
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3 (String_t* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Boolean System.Char::IsWhiteSpace(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Char_IsWhiteSpace_m02AEC6EA19513CAFC6882CFCA54C45794D2B5924 (Il2CppChar ___0_c, const RuntimeMethod* method) ;
// System.Void System.ValueTuple`2<System.Int32,System.Int32>::.ctor(T1,T2)
inline void ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477 (ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D* __this, int32_t ___0_item1, int32_t ___1_item2, const RuntimeMethod* method)
{
	((  void (*) (ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D*, int32_t, int32_t, const RuntimeMethod*))ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477_gshared)(__this, ___0_item1, ___1_item2, method);
}
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::Add(T)
inline void List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D, const RuntimeMethod*))List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_gshared_inline)(__this, ___0_item, method);
}
// System.Single TMPro.TextMeshProEffect::?(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TextMeshProEffect_UF9_mF372AB28E16BA995D7EE64FCCCD4B80A3E193858 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U0FF, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Color32[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UAA_m615F811C0D51CF8D387EDEB06DD8E0D2A63BD9AD (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFo, int32_t ___1_U3BFU3BF, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___2_U3BFU43E, float ___3_U3BFUF4, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUF6_m2097289ED738EA0B4CF752B207C3CF0F20CFC07B (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUF2, int32_t ___1_U3BFUF3, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUD6, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUBA, float ___4_U3BFUC7, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUE7_mE15CF2C46D29469C4A9B6174B3AB24E3AC046323 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUEA, int32_t ___1_U3BFUEB, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUE8, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUEF, float ___4_U3BFUEE, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUEC_mE5C089F1B453D8712DF8A219AF4627F7F21A5B07 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUC4, int32_t ___1_U3BFUC5, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUC9, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUE6, float ___4_U3BFUC6, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UDC_m53AFDAA8871565E28B0C8E0FA8A81BB7E06C4B08 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U192, int32_t ___1_UE1, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_UED, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_UFA, float ___4_UF1, int32_t ___5_UD1, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUFC_m24314052E077146749A2780BF3EF5BC70280E541 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUE9, int32_t ___1_U3BFUE2, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUE4, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUE0, float ___4_U3BFUE5, const RuntimeMethod* method) ;
// System.Void System.ArgumentOutOfRangeException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentOutOfRangeException__ctor_mB596C51BFA864B65C2CED275458FAE90F7CD29C9 (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Abs(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Abs_mD945EDDEA0D62D21BFDBAB7B1C0F18DFF1CEC905_inline (int32_t ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUF9, int32_t ___1_U3BFU0FF, UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F* ___2_U3BFUDC, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Gradient::Evaluate(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Gradient_Evaluate_m332A32F48EA3F884CB55D74131DF8064F29F9C32 (Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* __this, float ___0_time, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color32::op_Implicit(UnityEngine.Color32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___0_c, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::op_Multiply(UnityEngine.Color,UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Color32 UnityEngine.Color32::op_Implicit(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_c, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::op_Addition(UnityEngine.Color,UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Addition_mA7A51CACA49ED8D23D3D9CA3A0092D32F657E053_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUE1, UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8* ___1_U3BFUED, const RuntimeMethod* method) ;
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUF1, UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E* ___1_U3BFUD1, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Lerp(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::LerpUnclamped(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) ;
// System.Void UnityEngine.Gradient::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Gradient__ctor_m5EC470BB063D4831774C7CDA5D471EBEB5CE7B54 (Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>>::.ctor()
inline void List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9 (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, const RuntimeMethod*))List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9_gshared)(__this, method);
}
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Behaviour::get_enabled()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Behaviour_get_enabled_mAAC9F15E9EBF552217A5AE2681589CC0BFA300C1 (Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void TMPro.TextMeshProEffect/??::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UF6UF9__ctor_m62D51FB2F396C85163C885F7663DB8639FB09A4C (UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color32::.ctor(System.Byte,System.Byte,System.Byte,System.Byte)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___0_r, uint8_t ___1_g, uint8_t ___2_b, uint8_t ___3_a, const RuntimeMethod* method) ;
// System.Void System.Array::Clear(System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB (RuntimeArray* ___0_array, int32_t ___1_index, int32_t ___2_length, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32,System.Int32>> TMPro.TextMeshProEffect::get_Intervals()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* TextMeshProEffect_get_Intervals_m67B4CBDB16587586D9EDFA0F830EA7522831BC43 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	{
		// public List<(int from, int to)> Intervals => ??;
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_0 = __this->___UF6UE0_14;
		return L_0;
	}
}
// TMPro.TextMeshProEffect/SharedState TMPro.TextMeshProEffect::get_SharedStateProp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* TextMeshProEffect_get_SharedStateProp_m11DDC85C2838989F54D82649CF017C7C0ACB6012 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_mEE33B50B1F2C9BE2AD468D103BD8D2512B0B1663_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (?? != null)
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_0 = __this->___UF6UC9_26;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		// return ??;
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_2 = __this->___UF6UC9_26;
		return L_2;
	}

IL_0015:
	{
		// ?? = GetComponent<SharedState>();
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_3;
		L_3 = Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406(__this, Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406_RuntimeMethod_var);
		__this->___UF6UC9_26 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC9_26), (void*)L_3);
		// if (?? == null)
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_4 = __this->___UF6UC9_26;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_4, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_5)
		{
			goto IL_004d;
		}
	}
	{
		// ?? = base.gameObject.AddComponent<SharedState>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6;
		L_6 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		NullCheck(L_6);
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_7;
		L_7 = GameObject_AddComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_mEE33B50B1F2C9BE2AD468D103BD8D2512B0B1663(L_6, GameObject_AddComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_mEE33B50B1F2C9BE2AD468D103BD8D2512B0B1663_RuntimeMethod_var);
		__this->___UF6UC9_26 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC9_26), (void*)L_7);
		// ??.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_8 = __this->___UF6UC9_26;
		NullCheck(L_8);
		Object_set_hideFlags_mACB8BFC903FB3B01BBD427753E791BF28B5E33D4(L_8, ((int32_t)30), NULL);
	}

IL_004d:
	{
		// return ??;
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_9 = __this->___UF6UC9_26;
		return L_9;
	}
}
// System.Void TMPro.TextMeshProEffect::CopyTo(TMPro.TextMeshProEffect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_CopyTo_mAD6C574F6E9DD1D1D94BBC44B755531F93E8C120 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* ___0_effect, const RuntimeMethod* method) 
{
	{
		// effect.Type = Type;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_0 = ___0_effect;
		uint8_t L_1 = __this->___Type_4;
		NullCheck(L_0);
		L_0->___Type_4 = L_1;
		// effect.DurationInSeconds = DurationInSeconds;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_2 = ___0_effect;
		float L_3 = __this->___DurationInSeconds_5;
		NullCheck(L_2);
		L_2->___DurationInSeconds_5 = L_3;
		// effect.Amplitude = Amplitude;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_4 = ___0_effect;
		float L_5 = __this->___Amplitude_6;
		NullCheck(L_4);
		L_4->___Amplitude_6 = L_5;
		// effect.CharacterDurationRatio = CharacterDurationRatio;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_6 = ___0_effect;
		float L_7 = __this->___CharacterDurationRatio_7;
		NullCheck(L_6);
		L_6->___CharacterDurationRatio_7 = L_7;
		// effect.CharactersPerDuration = CharactersPerDuration;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_8 = ___0_effect;
		int32_t L_9 = __this->___CharactersPerDuration_8;
		NullCheck(L_8);
		L_8->___CharactersPerDuration_8 = L_9;
		// effect.Gradient = Gradient;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_10 = ___0_effect;
		Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* L_11 = __this->___Gradient_9;
		NullCheck(L_10);
		L_10->___Gradient_9 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&L_10->___Gradient_9), (void*)L_11);
		// effect.Mix = Mix;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_12 = ___0_effect;
		uint8_t L_13 = __this->___Mix_10;
		NullCheck(L_12);
		L_12->___Mix_10 = L_13;
		// effect.AutoPlay = AutoPlay;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_14 = ___0_effect;
		bool L_15 = __this->___AutoPlay_11;
		NullCheck(L_14);
		L_14->___AutoPlay_11 = L_15;
		// effect.Repeat = Repeat;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_16 = ___0_effect;
		bool L_17 = __this->___Repeat_12;
		NullCheck(L_16);
		L_16->___Repeat_12 = L_17;
		// effect.ForWords = ForWords;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_18 = ___0_effect;
		String_t* L_19 = __this->___ForWords_13;
		NullCheck(L_18);
		L_18->___ForWords_13 = L_19;
		Il2CppCodeGenWriteBarrier((void**)(&L_18->___ForWords_13), (void*)L_19);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_Apply_mEB8E65D2B3214F442684E4502A23FFC8366F5CDD (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisTMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_m0C4C5268B54C7097888C6B109527A680772EBCB5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* G_B3_0 = NULL;
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* G_B1_0 = NULL;
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* G_B2_0 = NULL;
	int32_t G_B4_0 = 0;
	TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* G_B4_1 = NULL;
	{
		// ?? = GetComponent<TMP_Text>();
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_0;
		L_0 = Component_GetComponent_TisTMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_m0C4C5268B54C7097888C6B109527A680772EBCB5(__this, Component_GetComponent_TisTMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_m0C4C5268B54C7097888C6B109527A680772EBCB5_RuntimeMethod_var);
		__this->___UF6UE7_17 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UE7_17), (void*)L_0);
		// ?? = Type;
		uint8_t L_1 = __this->___Type_4;
		__this->___UF6UEA_18 = L_1;
		// ?? = (?? == EffectType.Unfold || ?? == EffectType.Grow || ?? == EffectType.Bounce);
		uint8_t L_2 = __this->___UF6UEA_18;
		G_B1_0 = __this;
		if ((((int32_t)L_2) == ((int32_t)2)))
		{
			G_B3_0 = __this;
			goto IL_0036;
		}
	}
	{
		uint8_t L_3 = __this->___UF6UEA_18;
		G_B2_0 = G_B1_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			G_B3_0 = G_B1_0;
			goto IL_0036;
		}
	}
	{
		uint8_t L_4 = __this->___UF6UEA_18;
		G_B4_0 = ((((int32_t)L_4) == ((int32_t)5))? 1 : 0);
		G_B4_1 = G_B2_0;
		goto IL_0037;
	}

IL_0036:
	{
		G_B4_0 = 1;
		G_B4_1 = G_B3_0;
	}

IL_0037:
	{
		NullCheck(G_B4_1);
		G_B4_1->___UF6UEB_19 = (bool)G_B4_0;
		// ?? = (?? == EffectType.Sketch);
		uint8_t L_5 = __this->___UF6UEA_18;
		__this->___UF6UE8_20 = (bool)((((int32_t)L_5) == ((int32_t)4))? 1 : 0);
		// ?? = false;
		__this->___UF6UEF_21 = (bool)0;
		// ?? = -1f;
		__this->___UF6UEE_22 = (-1.0f);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_OnEnable_m24EF72DC51C03695497214D0120A32E147998834 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	{
		// if (AutoPlay)
		bool L_0 = __this->___AutoPlay_11;
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// Play();
		TextMeshProEffect_Play_mF87CBD9D4DAC8AC81C85E4F401F297E19827C32D(__this, NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::OnDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_OnDestroy_mDB136E7B60B6244D6767FE2B7669AF103772D814 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_All_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m364D65C9D23F5FE9475B3739627C68C4026EAB06_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponents_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m6F2849BB4B7D923475AE120B415D422E261F0878_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UF6UF9_UF6U0FF_m8048DB4D12F3670CE07B928FE644171AA60CB1DF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* V_0 = NULL;
	{
		// ?? = GetComponent<SharedState>();
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_0;
		L_0 = Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406(__this, Component_GetComponent_TisSharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE_m4092614FA2AA99C85D04527FCC17EF21A0C08406_RuntimeMethod_var);
		__this->___UF6UC9_26 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC9_26), (void*)L_0);
		// if (!(?? == null))
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_1 = __this->___UF6UC9_26;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_1, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_2)
		{
			goto IL_004d;
		}
	}
	{
		// TextMeshProEffect[] components = base.gameObject.GetComponents<TextMeshProEffect>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3;
		L_3 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		NullCheck(L_3);
		TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* L_4;
		L_4 = GameObject_GetComponents_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m6F2849BB4B7D923475AE120B415D422E261F0878(L_3, GameObject_GetComponents_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m6F2849BB4B7D923475AE120B415D422E261F0878_RuntimeMethod_var);
		V_0 = L_4;
		// if (components.Length == 0 || components.All(??.??.??))
		TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* L_5 = V_0;
		NullCheck(L_5);
		if (!(((RuntimeArray*)L_5)->max_length))
		{
			goto IL_0042;
		}
	}
	{
		TextMeshProEffectU5BU5D_t929A43881612349E07C8DBD84F6FD877E0E4026B* L_6 = V_0;
		il2cpp_codegen_runtime_class_init_inline(UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var);
		UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* L_7 = ((UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_StaticFields*)il2cpp_codegen_static_fields_for(UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var))->___UF6U192_0;
		Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5* L_8 = (Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5*)il2cpp_codegen_object_new(Func_2_t6ECEBF744E9D153C081B11A346BF473515D00EC5_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		Func_2__ctor_m40F3FE5B0E6EFBCC5A306B98AFF29B503D92F15D(L_8, L_7, (intptr_t)((void*)UF6UF9_UF6U0FF_m8048DB4D12F3670CE07B928FE644171AA60CB1DF_RuntimeMethod_var), NULL);
		bool L_9;
		L_9 = Enumerable_All_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m364D65C9D23F5FE9475B3739627C68C4026EAB06((RuntimeObject*)L_6, L_8, Enumerable_All_TisTextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C_m364D65C9D23F5FE9475B3739627C68C4026EAB06_RuntimeMethod_var);
		if (!L_9)
		{
			goto IL_004d;
		}
	}

IL_0042:
	{
		// UnityEngine.Object.Destroy(??);
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_10 = __this->___UF6UC9_26;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_10, NULL);
	}

IL_004d:
	{
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::OnValidate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_OnValidate_m8E056448CF2A9B18D709C2EBEF5564DA861585C7 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	{
		// if (AutoPlay)
		bool L_0 = __this->___AutoPlay_11;
		if (!L_0)
		{
			goto IL_000f;
		}
	}
	{
		// Play();
		TextMeshProEffect_Play_mF87CBD9D4DAC8AC81C85E4F401F297E19827C32D(__this, NULL);
		return;
	}

IL_000f:
	{
		// Apply();
		TextMeshProEffect_Apply_mEB8E65D2B3214F442684E4502A23FFC8366F5CDD(__this, NULL);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::LateUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_LateUpdate_mC045A90AF4928E31C3BA0CE87A8A3117ADD7379B (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* V_0 = NULL;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D V_10;
	memset((&V_10), 0, sizeof(V_10));
	int32_t V_11 = 0;
	TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 V_12;
	memset((&V_12), 0, sizeof(V_12));
	bool V_13 = false;
	int32_t V_14 = 0;
	ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D V_15;
	memset((&V_15), 0, sizeof(V_15));
	float V_16 = 0.0f;
	float V_17 = 0.0f;
	int32_t V_18 = 0;
	int32_t V_19 = 0;
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_20 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_21 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_22 = NULL;
	int32_t V_23 = 0;
	{
		// if ((UnityEngine.Object)(object)?? == null || DurationInSeconds <= 0f || !??)
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_0 = __this->___UF6UE7_17;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(((Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)CastclassClass((RuntimeObject*)L_0, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var)), (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_1)
		{
			goto IL_0028;
		}
	}
	{
		float L_2 = __this->___DurationInSeconds_5;
		if ((((float)L_2) <= ((float)(0.0f))))
		{
			goto IL_0028;
		}
	}
	{
		bool L_3 = __this->___UF6UEF_21;
		if (L_3)
		{
			goto IL_0029;
		}
	}

IL_0028:
	{
		// return;
		return;
	}

IL_0029:
	{
		// if (Repeat && IsFinished)
		bool L_4 = __this->___Repeat_12;
		if (!L_4)
		{
			goto IL_003f;
		}
	}
	{
		bool L_5 = __this->___IsFinished_15;
		if (!L_5)
		{
			goto IL_003f;
		}
	}
	{
		// Play();
		TextMeshProEffect_Play_mF87CBD9D4DAC8AC81C85E4F401F297E19827C32D(__this, NULL);
	}

IL_003f:
	{
		// if (!SharedStateProp.TextMeshIsUpdated)
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_6;
		L_6 = TextMeshProEffect_get_SharedStateProp_m11DDC85C2838989F54D82649CF017C7C0ACB6012(__this, NULL);
		NullCheck(L_6);
		bool L_7 = L_6->___TextMeshIsUpdated_4;
		if (L_7)
		{
			goto IL_0065;
		}
	}
	{
		// ??.ForceMeshUpdate();
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_8 = __this->___UF6UE7_17;
		NullCheck(L_8);
		VirtualActionInvoker2< bool, bool >::Invoke(106 /* System.Void TMPro.TMP_Text::ForceMeshUpdate(System.Boolean,System.Boolean) */, L_8, (bool)0, (bool)0);
		// SharedStateProp.TextMeshIsUpdated = true;
		SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* L_9;
		L_9 = TextMeshProEffect_get_SharedStateProp_m11DDC85C2838989F54D82649CF017C7C0ACB6012(__this, NULL);
		NullCheck(L_9);
		L_9->___TextMeshIsUpdated_4 = (bool)1;
	}

IL_0065:
	{
		// ?? = ??.textInfo;
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_10 = __this->___UF6UE7_17;
		NullCheck(L_10);
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_11;
		L_11 = TMP_Text_get_textInfo_mA24C606B8EA51436E4AA3B9D6DCDFA7A8995E10E_inline(L_10, NULL);
		__this->___UF6UC6_28 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC6_28), (void*)L_11);
		// TMP_MeshInfo[] array = ??.CopyMeshInfoVertexData();
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_12 = __this->___UF6UC6_28;
		NullCheck(L_12);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_13;
		L_13 = TMP_TextInfo_CopyMeshInfoVertexData_mF66E2F8821470E68D95FEB53D456CFA86241C0CA(L_12, NULL);
		V_0 = L_13;
		// int characterCount = ??.characterCount;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_14 = __this->___UF6UC6_28;
		NullCheck(L_14);
		int32_t L_15 = L_14->___characterCount_3;
		V_1 = L_15;
		// if (characterCount == 0)
		int32_t L_16 = V_1;
		if (L_16)
		{
			goto IL_0099;
		}
	}
	{
		// IsFinished = true;
		__this->___IsFinished_15 = (bool)1;
		// return;
		return;
	}

IL_0099:
	{
		// float num = Time.realtimeSinceStartup - ??;
		float L_17;
		L_17 = Time_get_realtimeSinceStartup_m73B3CB73175D79A44333D59BB70F9EDE55EC9510(NULL);
		float L_18 = __this->___UF6UE5_16;
		V_2 = ((float)il2cpp_codegen_subtract(L_17, L_18));
		// if (?? != ??.text || ForWords != ??)
		String_t* L_19 = __this->___UF6UEC_23;
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_20 = __this->___UF6UE7_17;
		NullCheck(L_20);
		String_t* L_21;
		L_21 = VirtualFuncInvoker0< String_t* >::Invoke(65 /* System.String TMPro.TMP_Text::get_text() */, L_20);
		bool L_22;
		L_22 = String_op_Inequality_m8C940F3CFC42866709D7CA931B3D77B4BE94BCB6(L_19, L_21, NULL);
		if (L_22)
		{
			goto IL_00d1;
		}
	}
	{
		String_t* L_23 = __this->___ForWords_13;
		String_t* L_24 = __this->___UF6UFB_29;
		bool L_25;
		L_25 = String_op_Inequality_m8C940F3CFC42866709D7CA931B3D77B4BE94BCB6(L_23, L_24, NULL);
		if (!L_25)
		{
			goto IL_00ff;
		}
	}

IL_00d1:
	{
		// ?? = -1f;
		__this->___UF6UEE_22 = (-1.0f);
		// ?? = ??.text;
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_26 = __this->___UF6UE7_17;
		NullCheck(L_26);
		String_t* L_27;
		L_27 = VirtualFuncInvoker0< String_t* >::Invoke(65 /* System.String TMPro.TMP_Text::get_text() */, L_26);
		__this->___UF6UEC_23 = L_27;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UEC_23), (void*)L_27);
		// ?? = ForWords;
		String_t* L_28 = __this->___ForWords_13;
		__this->___UF6UFB_29 = L_28;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UFB_29), (void*)L_28);
		// ?();
		TextMeshProEffect_UEB_mA24132689F737695A1C418669C75138980767B75(__this, NULL);
	}

IL_00ff:
	{
		// if (CharactersPerDuration > 0)
		int32_t L_29 = __this->___CharactersPerDuration_8;
		if ((((int32_t)L_29) <= ((int32_t)0)))
		{
			goto IL_012b;
		}
	}
	{
		// ?? = DurationInSeconds * (float)??.Length / (float)CharactersPerDuration;
		float L_30 = __this->___DurationInSeconds_5;
		String_t* L_31 = __this->___UF6UEC_23;
		NullCheck(L_31);
		int32_t L_32;
		L_32 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_31, NULL);
		int32_t L_33 = __this->___CharactersPerDuration_8;
		__this->___UF6UE6_27 = ((float)(((float)il2cpp_codegen_multiply(L_30, ((float)L_32)))/((float)L_33)));
		goto IL_0137;
	}

IL_012b:
	{
		// ?? = DurationInSeconds;
		float L_34 = __this->___DurationInSeconds_5;
		__this->___UF6UE6_27 = L_34;
	}

IL_0137:
	{
		// if (?? && num >= ??)
		bool L_35 = __this->___UF6UE8_20;
		if (!L_35)
		{
			goto IL_01a5;
		}
	}
	{
		float L_36 = V_2;
		float L_37 = __this->___UF6UEE_22;
		if ((!(((float)L_36) >= ((float)L_37))))
		{
			goto IL_01a5;
		}
	}
	{
		// ?? = num + ??;
		float L_38 = V_2;
		float L_39 = __this->___UF6UE6_27;
		__this->___UF6UEE_22 = ((float)il2cpp_codegen_add(L_38, L_39));
		// ??++;
		uint16_t L_40 = __this->___UF6UC4_24;
		__this->___UF6UC4_24 = (uint16_t)((int32_t)(uint16_t)((int32_t)il2cpp_codegen_add((int32_t)L_40, 1)));
		// if (??.Length < characterCount * 2)
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_41 = __this->___UF6UC5_25;
		NullCheck(L_41);
		int32_t L_42 = V_1;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_41)->max_length))) >= ((int32_t)((int32_t)il2cpp_codegen_multiply(L_42, 2)))))
		{
			goto IL_0180;
		}
	}
	{
		// ?? = new float[characterCount * 2];
		int32_t L_43 = V_1;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_44 = (SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)SZArrayNew(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_43, 2)));
		__this->___UF6UC5_25 = L_44;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC5_25), (void*)L_44);
	}

IL_0180:
	{
		// for (int i = 0; i < ??.Length; i++)
		V_8 = 0;
		goto IL_0199;
	}

IL_0185:
	{
		// ??[i] = UnityEngine.Random.value;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_45 = __this->___UF6UC5_25;
		int32_t L_46 = V_8;
		float L_47;
		L_47 = Random_get_value_m2CEA87FADF5222EF9E13D32695F15E2BA282E24B(NULL);
		NullCheck(L_45);
		(L_45)->SetAt(static_cast<il2cpp_array_size_t>(L_46), (float)L_47);
		// for (int i = 0; i < ??.Length; i++)
		int32_t L_48 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_48, 1));
	}

IL_0199:
	{
		// for (int i = 0; i < ??.Length; i++)
		int32_t L_49 = V_8;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_50 = __this->___UF6UC5_25;
		NullCheck(L_50);
		if ((((int32_t)L_49) < ((int32_t)((int32_t)(((RuntimeArray*)L_50)->max_length)))))
		{
			goto IL_0185;
		}
	}

IL_01a5:
	{
		// if (?? && num > ??)
		bool L_51 = __this->___UF6UEB_19;
		if (!L_51)
		{
			goto IL_01c4;
		}
	}
	{
		float L_52 = V_2;
		float L_53 = __this->___UF6UE6_27;
		if ((!(((float)L_52) > ((float)L_53))))
		{
			goto IL_01c4;
		}
	}
	{
		// num = ??;
		float L_54 = __this->___UF6UE6_27;
		V_2 = L_54;
		// IsFinished = true;
		__this->___IsFinished_15 = (bool)1;
	}

IL_01c4:
	{
		// float num2 = num / ??;
		float L_55 = V_2;
		float L_56 = __this->___UF6UE6_27;
		V_3 = ((float)(L_55/L_56));
		// if (!??)
		bool L_57 = __this->___UF6UEB_19;
		if (L_57)
		{
			goto IL_01dd;
		}
	}
	{
		// num2 %= 1f;
		float L_58 = V_3;
		V_3 = (fmodf(L_58, (1.0f)));
	}

IL_01dd:
	{
		// float characterDurationRatio = CharacterDurationRatio;
		float L_59 = __this->___CharacterDurationRatio_7;
		V_4 = L_59;
		// float num3 = Mathf.Lerp(1f / (float)characterCount, 1f, characterDurationRatio);
		int32_t L_60 = V_1;
		float L_61 = V_4;
		float L_62;
		L_62 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(((float)((1.0f)/((float)L_60))), (1.0f), L_61, NULL);
		V_5 = L_62;
		// int num4 = 0;
		V_6 = 0;
		// int num5 = characterCount;
		int32_t L_63 = V_1;
		V_7 = L_63;
		// if (??.Count > 0 || !string.IsNullOrEmpty(ForWords))
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_64 = __this->___UF6UE0_14;
		NullCheck(L_64);
		int32_t L_65;
		L_65 = List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_inline(L_64, List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var);
		if ((((int32_t)L_65) > ((int32_t)0)))
		{
			goto IL_021c;
		}
	}
	{
		String_t* L_66 = __this->___ForWords_13;
		bool L_67;
		L_67 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_66, NULL);
		if (L_67)
		{
			goto IL_025e;
		}
	}

IL_021c:
	{
		// num5 = 0;
		V_7 = 0;
		// for (int j = 0; j < ??.Count; j++)
		V_9 = 0;
		goto IL_024f;
	}

IL_0224:
	{
		// (int, int) tuple = ??[j];
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_68 = __this->___UF6UE0_14;
		int32_t L_69 = V_9;
		NullCheck(L_68);
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_70;
		L_70 = List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA(L_68, L_69, List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_RuntimeMethod_var);
		V_10 = L_70;
		// num5 += tuple.Item2 - tuple.Item1 + 1;
		int32_t L_71 = V_7;
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_72 = V_10;
		int32_t L_73 = L_72.___Item2_1;
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_74 = V_10;
		int32_t L_75 = L_74.___Item1_0;
		V_7 = ((int32_t)il2cpp_codegen_add(L_71, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_73, L_75)), 1))));
		// for (int j = 0; j < ??.Count; j++)
		int32_t L_76 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_76, 1));
	}

IL_024f:
	{
		// for (int j = 0; j < ??.Count; j++)
		int32_t L_77 = V_9;
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_78 = __this->___UF6UE0_14;
		NullCheck(L_78);
		int32_t L_79;
		L_79 = List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_inline(L_78, List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var);
		if ((((int32_t)L_77) < ((int32_t)L_79)))
		{
			goto IL_0224;
		}
	}

IL_025e:
	{
		// for (int k = 0; k < characterCount; k++)
		V_11 = 0;
		goto IL_0398;
	}

IL_0266:
	{
		// if (??.Count > 0 || !string.IsNullOrEmpty(ForWords))
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_80 = __this->___UF6UE0_14;
		NullCheck(L_80);
		int32_t L_81;
		L_81 = List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_inline(L_80, List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var);
		if ((((int32_t)L_81) > ((int32_t)0)))
		{
			goto IL_0281;
		}
	}
	{
		String_t* L_82 = __this->___ForWords_13;
		bool L_83;
		L_83 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_82, NULL);
		if (L_83)
		{
			goto IL_02cd;
		}
	}

IL_0281:
	{
		// bool flag = false;
		V_13 = (bool)0;
		// for (int l = 0; l < ??.Count; l++)
		V_14 = 0;
		goto IL_02b7;
	}

IL_0289:
	{
		// (int, int) tuple2 = ??[l];
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_84 = __this->___UF6UE0_14;
		int32_t L_85 = V_14;
		NullCheck(L_84);
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_86;
		L_86 = List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA(L_84, L_85, List_1_get_Item_m49B096B0EDF4027F896A4B5C57F32CD48F09A3EA_RuntimeMethod_var);
		V_15 = L_86;
		// if (k >= tuple2.Item1 && k <= tuple2.Item2)
		int32_t L_87 = V_11;
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_88 = V_15;
		int32_t L_89 = L_88.___Item1_0;
		if ((((int32_t)L_87) < ((int32_t)L_89)))
		{
			goto IL_02b1;
		}
	}
	{
		int32_t L_90 = V_11;
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_91 = V_15;
		int32_t L_92 = L_91.___Item2_1;
		if ((((int32_t)L_90) > ((int32_t)L_92)))
		{
			goto IL_02b1;
		}
	}
	{
		// flag = true;
		V_13 = (bool)1;
	}

IL_02b1:
	{
		// for (int l = 0; l < ??.Count; l++)
		int32_t L_93 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_93, 1));
	}

IL_02b7:
	{
		// for (int l = 0; l < ??.Count; l++)
		int32_t L_94 = V_14;
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_95 = __this->___UF6UE0_14;
		NullCheck(L_95);
		int32_t L_96;
		L_96 = List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_inline(L_95, List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_RuntimeMethod_var);
		if ((((int32_t)L_94) < ((int32_t)L_96)))
		{
			goto IL_0289;
		}
	}
	{
		// if (!flag)
		bool L_97 = V_13;
		if (!L_97)
		{
			goto IL_0392;
		}
	}

IL_02cd:
	{
		// TMP_CharacterInfo ? = ??.characterInfo[k];
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_98 = __this->___UF6UC6_28;
		NullCheck(L_98);
		TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99* L_99 = L_98->___characterInfo_11;
		int32_t L_100 = V_11;
		NullCheck(L_99);
		int32_t L_101 = L_100;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_102 = (L_99)->GetAt(static_cast<il2cpp_array_size_t>(L_101));
		V_12 = L_102;
		// if (?.isVisible)
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_103 = V_12;
		bool L_104 = L_103.___isVisible_40;
		if (!L_104)
		{
			goto IL_0392;
		}
	}
	{
		// float num6 = Mathf.Lerp((float)num4 * 1f / (float)num5, 0f, characterDurationRatio);
		int32_t L_105 = V_6;
		int32_t L_106 = V_7;
		float L_107 = V_4;
		float L_108;
		L_108 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(((float)(((float)il2cpp_codegen_multiply(((float)L_105), (1.0f)))/((float)L_106))), (0.0f), L_107, NULL);
		V_16 = L_108;
		// float value = (num2 - num6) / num3;
		float L_109 = V_3;
		float L_110 = V_16;
		float L_111 = V_5;
		V_17 = ((float)(((float)il2cpp_codegen_subtract(L_109, L_110))/L_111));
		// value = Mathf.Clamp01(value);
		float L_112 = V_17;
		float L_113;
		L_113 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_112, NULL);
		V_17 = L_113;
		// int materialReferenceIndex = ?.materialReferenceIndex;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_114 = V_12;
		int32_t L_115 = L_114.___materialReferenceIndex_9;
		V_18 = L_115;
		// int vertexIndex = ?.vertexIndex;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_116 = V_12;
		int32_t L_117 = L_116.___vertexIndex_14;
		V_19 = L_117;
		// Color32[] colors = ??.meshInfo[materialReferenceIndex].colors32;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_118 = __this->___UF6UC6_28;
		NullCheck(L_118);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_119 = L_118->___meshInfo_16;
		int32_t L_120 = V_18;
		NullCheck(L_119);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_121 = ((L_119)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_120)))->___colors32_11;
		V_20 = L_121;
		// Vector3[] vertices = array[materialReferenceIndex].vertices;
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_122 = V_0;
		int32_t L_123 = V_18;
		NullCheck(L_122);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_124 = ((L_122)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_123)))->___vertices_6;
		V_21 = L_124;
		// Vector3[] vertices2 = ??.meshInfo[materialReferenceIndex].vertices;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_125 = __this->___UF6UC6_28;
		NullCheck(L_125);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_126 = L_125->___meshInfo_16;
		int32_t L_127 = V_18;
		NullCheck(L_126);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_128 = ((L_126)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_127)))->___vertices_6;
		V_22 = L_128;
		// ?(??, ?, vertexIndex, colors, vertices2, vertices, num2, value, ??);
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_129 = __this->___UF6UC6_28;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_130 = V_12;
		int32_t L_131 = V_19;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_132 = V_20;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_133 = V_22;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_134 = V_21;
		float L_135 = V_3;
		float L_136 = V_17;
		uint16_t L_137 = __this->___UF6UC4_24;
		TextMeshProEffect_UE8_m36BB0CE3513C5BA6264807C0624C4ED877252552(__this, L_129, L_130, L_131, L_132, L_133, L_134, L_135, L_136, L_137, NULL);
		// num4++;
		int32_t L_138 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_138, 1));
	}

IL_0392:
	{
		// for (int k = 0; k < characterCount; k++)
		int32_t L_139 = V_11;
		V_11 = ((int32_t)il2cpp_codegen_add(L_139, 1));
	}

IL_0398:
	{
		// for (int k = 0; k < characterCount; k++)
		int32_t L_140 = V_11;
		int32_t L_141 = V_1;
		if ((((int32_t)L_140) < ((int32_t)L_141)))
		{
			goto IL_0266;
		}
	}
	{
		// for (int m = 0; m < ??.meshInfo.Length; m++)
		V_23 = 0;
		goto IL_0411;
	}

IL_03a5:
	{
		// if (m < ??.materialCount)
		int32_t L_142 = V_23;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_143 = __this->___UF6UC6_28;
		NullCheck(L_143);
		int32_t L_144 = L_143->___materialCount_10;
		if ((((int32_t)L_142) >= ((int32_t)L_144)))
		{
			goto IL_040b;
		}
	}
	{
		// ??.meshInfo[m].mesh.vertices = ??.meshInfo[m].vertices;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_145 = __this->___UF6UC6_28;
		NullCheck(L_145);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_146 = L_145->___meshInfo_16;
		int32_t L_147 = V_23;
		NullCheck(L_146);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_148 = ((L_146)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_147)))->___mesh_4;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_149 = __this->___UF6UC6_28;
		NullCheck(L_149);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_150 = L_149->___meshInfo_16;
		int32_t L_151 = V_23;
		NullCheck(L_150);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_152 = ((L_150)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_151)))->___vertices_6;
		NullCheck(L_148);
		Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C(L_148, L_152, NULL);
		// ??.UpdateGeometry(??.meshInfo[m].mesh, m);
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_153 = __this->___UF6UE7_17;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_154 = __this->___UF6UC6_28;
		NullCheck(L_154);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_155 = L_154->___meshInfo_16;
		int32_t L_156 = V_23;
		NullCheck(L_155);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_157 = ((L_155)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_156)))->___mesh_4;
		int32_t L_158 = V_23;
		NullCheck(L_153);
		VirtualActionInvoker2< Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*, int32_t >::Invoke(107 /* System.Void TMPro.TMP_Text::UpdateGeometry(UnityEngine.Mesh,System.Int32) */, L_153, L_157, L_158);
	}

IL_040b:
	{
		// for (int m = 0; m < ??.meshInfo.Length; m++)
		int32_t L_159 = V_23;
		V_23 = ((int32_t)il2cpp_codegen_add(L_159, 1));
	}

IL_0411:
	{
		// for (int m = 0; m < ??.meshInfo.Length; m++)
		int32_t L_160 = V_23;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_161 = __this->___UF6UC6_28;
		NullCheck(L_161);
		TMP_MeshInfoU5BU5D_t3549EA3B9F542558E0DB1EDFAB98C612FE4231D7* L_162 = L_161->___meshInfo_16;
		NullCheck(L_162);
		if ((((int32_t)L_160) < ((int32_t)((int32_t)(((RuntimeArray*)L_162)->max_length)))))
		{
			goto IL_03a5;
		}
	}
	{
		// ??.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_163 = __this->___UF6UE7_17;
		NullCheck(L_163);
		VirtualActionInvoker1< int32_t >::Invoke(108 /* System.Void TMPro.TMP_Text::UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags) */, L_163, ((int32_t)16));
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::?()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UEB_mA24132689F737695A1C418669C75138980767B75 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_t521A6F19B456D956AF452D926C32709DC03D6B17_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t* V_0 = NULL;
	bool V_1 = false;
	String_t* V_2 = NULL;
	int32_t V_3 = 0;
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_4 = NULL;
	int32_t V_5 = 0;
	String_t* V_6 = NULL;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t G_B10_0 = 0;
	String_t* G_B10_1 = NULL;
	String_t* G_B10_2 = NULL;
	int32_t G_B9_0 = 0;
	String_t* G_B9_1 = NULL;
	String_t* G_B9_2 = NULL;
	int32_t G_B11_0 = 0;
	int32_t G_B11_1 = 0;
	String_t* G_B11_2 = NULL;
	String_t* G_B11_3 = NULL;
	{
		// ??.Clear();
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_0 = __this->___UF6UE0_14;
		NullCheck(L_0);
		List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_inline(L_0, List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_RuntimeMethod_var);
		// if (string.IsNullOrWhiteSpace(ForWords) || ?? == null)
		String_t* L_1 = __this->___ForWords_13;
		bool L_2;
		L_2 = String_IsNullOrWhiteSpace_m42E1F3B2C358068D645E46F01CF1834DC77A5A10(L_1, NULL);
		if (L_2)
		{
			goto IL_0020;
		}
	}
	{
		String_t* L_3 = __this->___UF6UEC_23;
		if (L_3)
		{
			goto IL_0021;
		}
	}

IL_0020:
	{
		// return;
		return;
	}

IL_0021:
	{
		// StringBuilder stringBuilder = new StringBuilder(??.characterCount);
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_4 = __this->___UF6UC6_28;
		NullCheck(L_4);
		int32_t L_5 = L_4->___characterCount_3;
		StringBuilder_t* L_6 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		StringBuilder__ctor_m2619CA8D2C3476DF1A302D9D941498BB1C6164C5(L_6, L_5, NULL);
		V_0 = L_6;
		// for (int i = 0; i < ??.characterCount; i++)
		V_3 = 0;
		goto IL_0057;
	}

IL_0036:
	{
		// stringBuilder.Append(??.characterInfo[i].character);
		StringBuilder_t* L_7 = V_0;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_8 = __this->___UF6UC6_28;
		NullCheck(L_8);
		TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99* L_9 = L_8->___characterInfo_11;
		int32_t L_10 = V_3;
		NullCheck(L_9);
		Il2CppChar L_11 = ((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10)))->___character_0;
		NullCheck(L_7);
		StringBuilder_t* L_12;
		L_12 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_7, L_11, NULL);
		// for (int i = 0; i < ??.characterCount; i++)
		int32_t L_13 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_0057:
	{
		// for (int i = 0; i < ??.characterCount; i++)
		int32_t L_14 = V_3;
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_15 = __this->___UF6UC6_28;
		NullCheck(L_15);
		int32_t L_16 = L_15->___characterCount_3;
		if ((((int32_t)L_14) < ((int32_t)L_16)))
		{
			goto IL_0036;
		}
	}
	{
		// bool flag = (??.fontStyle & (FontStyles.LowerCase | FontStyles.UpperCase | FontStyles.SmallCaps)) != 0;
		TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* L_17 = __this->___UF6UE7_17;
		NullCheck(L_17);
		int32_t L_18;
		L_18 = TMP_Text_get_fontStyle_mC34CC5EBEDD43CE93BA911CCC4D33F9697838586_inline(L_17, NULL);
		V_1 = (bool)((!(((uint32_t)((int32_t)((int32_t)L_18&((int32_t)56)))) <= ((uint32_t)0)))? 1 : 0);
		// string text = stringBuilder.ToString();
		StringBuilder_t* L_19 = V_0;
		NullCheck(L_19);
		String_t* L_20;
		L_20 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_19);
		V_2 = L_20;
		// string[] array = ForWords.Split(new char[2]
		// {
		//     '\t',
		//     ' '
		// }, StringSplitOptions.RemoveEmptyEntries);
		String_t* L_21 = __this->___ForWords_13;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_22 = (CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*)(CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*)SZArrayNew(CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var, (uint32_t)2);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_23 = L_22;
		NullCheck(L_23);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppChar)((int32_t)9));
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_24 = L_23;
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(1), (Il2CppChar)((int32_t)32));
		NullCheck(L_21);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_25;
		L_25 = String_Split_m6811F7CF4DE7C68019D76E9DC6D17B2293BA8B12(L_21, L_24, 1, NULL);
		// foreach (string text2 in array2)
		V_4 = L_25;
		V_5 = 0;
		goto IL_0133;
	}

IL_00a4:
	{
		// foreach (string text2 in array2)
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_26 = V_4;
		int32_t L_27 = V_5;
		NullCheck(L_26);
		int32_t L_28 = L_27;
		String_t* L_29 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		V_6 = L_29;
		// int startIndex = 0;
		V_7 = 0;
	}

IL_00ae:
	{
		// startIndex = text.IndexOf(text2, startIndex, flag ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
		String_t* L_30 = V_2;
		String_t* L_31 = V_6;
		int32_t L_32 = V_7;
		bool L_33 = V_1;
		G_B9_0 = L_32;
		G_B9_1 = L_31;
		G_B9_2 = L_30;
		if (L_33)
		{
			G_B10_0 = L_32;
			G_B10_1 = L_31;
			G_B10_2 = L_30;
			goto IL_00b9;
		}
	}
	{
		G_B11_0 = 4;
		G_B11_1 = G_B9_0;
		G_B11_2 = G_B9_1;
		G_B11_3 = G_B9_2;
		goto IL_00ba;
	}

IL_00b9:
	{
		G_B11_0 = 5;
		G_B11_1 = G_B10_0;
		G_B11_2 = G_B10_1;
		G_B11_3 = G_B10_2;
	}

IL_00ba:
	{
		NullCheck(G_B11_3);
		int32_t L_34;
		L_34 = String_IndexOf_m2DFDE7BD37585BDBCD6F688B4E4A93304235A0B8(G_B11_3, G_B11_2, G_B11_1, G_B11_0, NULL);
		V_7 = L_34;
		// if (startIndex == -1)
		int32_t L_35 = V_7;
		if ((((int32_t)L_35) == ((int32_t)(-1))))
		{
			goto IL_012d;
		}
	}
	{
		// if (startIndex <= 0 || char.IsWhiteSpace(text[startIndex - 1]))
		int32_t L_36 = V_7;
		if ((((int32_t)L_36) <= ((int32_t)0)))
		{
			goto IL_00dc;
		}
	}
	{
		String_t* L_37 = V_2;
		int32_t L_38 = V_7;
		NullCheck(L_37);
		Il2CppChar L_39;
		L_39 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_37, ((int32_t)il2cpp_codegen_subtract(L_38, 1)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Char_t521A6F19B456D956AF452D926C32709DC03D6B17_il2cpp_TypeInfo_var);
		bool L_40;
		L_40 = Char_IsWhiteSpace_m02AEC6EA19513CAFC6882CFCA54C45794D2B5924(L_39, NULL);
		if (!L_40)
		{
			goto IL_011f;
		}
	}

IL_00dc:
	{
		// int num = startIndex + text2.Length;
		int32_t L_41 = V_7;
		String_t* L_42 = V_6;
		NullCheck(L_42);
		int32_t L_43;
		L_43 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_42, NULL);
		V_8 = ((int32_t)il2cpp_codegen_add(L_41, L_43));
		// if (num >= text.Length || char.IsWhiteSpace(text[num]))
		int32_t L_44 = V_8;
		String_t* L_45 = V_2;
		NullCheck(L_45);
		int32_t L_46;
		L_46 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_45, NULL);
		if ((((int32_t)L_44) >= ((int32_t)L_46)))
		{
			goto IL_0101;
		}
	}
	{
		String_t* L_47 = V_2;
		int32_t L_48 = V_8;
		NullCheck(L_47);
		Il2CppChar L_49;
		L_49 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_47, L_48, NULL);
		il2cpp_codegen_runtime_class_init_inline(Char_t521A6F19B456D956AF452D926C32709DC03D6B17_il2cpp_TypeInfo_var);
		bool L_50;
		L_50 = Char_IsWhiteSpace_m02AEC6EA19513CAFC6882CFCA54C45794D2B5924(L_49, NULL);
		if (!L_50)
		{
			goto IL_011f;
		}
	}

IL_0101:
	{
		// ??.Add((startIndex, startIndex + text2.Length - 1));
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_51 = __this->___UF6UE0_14;
		int32_t L_52 = V_7;
		int32_t L_53 = V_7;
		String_t* L_54 = V_6;
		NullCheck(L_54);
		int32_t L_55;
		L_55 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_54, NULL);
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_56;
		memset((&L_56), 0, sizeof(L_56));
		ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477((&L_56), L_52, ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_53, L_55)), 1)), /*hidden argument*/ValueTuple_2__ctor_mF5D8FB18DBF2C4B2F879F8E8E12D8FB8FCDB5477_RuntimeMethod_var);
		NullCheck(L_51);
		List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_inline(L_51, L_56, List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_RuntimeMethod_var);
	}

IL_011f:
	{
		// startIndex += text2.Length;
		int32_t L_57 = V_7;
		String_t* L_58 = V_6;
		NullCheck(L_58);
		int32_t L_59;
		L_59 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_58, NULL);
		V_7 = ((int32_t)il2cpp_codegen_add(L_57, L_59));
		// while (true)
		goto IL_00ae;
	}

IL_012d:
	{
		int32_t L_60 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_60, 1));
	}

IL_0133:
	{
		// foreach (string text2 in array2)
		int32_t L_61 = V_5;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_62 = V_4;
		NullCheck(L_62);
		if ((((int32_t)L_61) < ((int32_t)((int32_t)(((RuntimeArray*)L_62)->max_length)))))
		{
			goto IL_00a4;
		}
	}
	{
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_TextInfo,TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Color32[],UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single,System.Single,System.UInt16)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UE8_m36BB0CE3513C5BA6264807C0624C4ED877252552 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___0_UEF, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___1_UEE, int32_t ___2_UEC, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___3_UC4, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___4_UC5, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___5_UC9, float ___6_UE6, float ___7_UC6, uint16_t ___8_UFB, const RuntimeMethod* method) 
{
	uint8_t V_0 = 0;
	{
		// if (??)
		bool L_0 = __this->___UF6UE8_20;
		if (!L_0)
		{
			goto IL_0027;
		}
	}
	{
		// ?(?, ?, ?, ?(?? + ?.index));
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_1 = ___1_UEE;
		int32_t L_2 = ___2_UEC;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_3 = ___3_UC4;
		uint16_t L_4 = __this->___UF6UC4_24;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_5 = ___1_UEE;
		int32_t L_6 = L_5.___index_1;
		float L_7;
		L_7 = TextMeshProEffect_UF9_mF372AB28E16BA995D7EE64FCCCD4B80A3E193858(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_4, L_6)), NULL);
		TextMeshProEffect_UAA_m615F811C0D51CF8D387EDEB06DD8E0D2A63BD9AD(__this, L_1, L_2, L_3, L_7, NULL);
		goto IL_0033;
	}

IL_0027:
	{
		// ?(?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_8 = ___1_UEE;
		int32_t L_9 = ___2_UEC;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_10 = ___3_UC4;
		float L_11 = ___7_UC6;
		TextMeshProEffect_UAA_m615F811C0D51CF8D387EDEB06DD8E0D2A63BD9AD(__this, L_8, L_9, L_10, L_11, NULL);
	}

IL_0033:
	{
		// switch (Type)
		uint8_t L_12 = __this->___Type_4;
		V_0 = L_12;
		uint8_t L_13 = V_0;
		switch (L_13)
		{
			case 0:
			{
				goto IL_005a;
			}
			case 1:
			{
				goto IL_0069;
			}
			case 2:
			{
				goto IL_0078;
			}
			case 3:
			{
				goto IL_0087;
			}
			case 4:
			{
				goto IL_00a4;
			}
			case 5:
			{
				goto IL_00b5;
			}
		}
	}
	{
		goto IL_00c4;
	}

IL_005a:
	{
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_14 = ___1_UEE;
		int32_t L_15 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_16 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_17 = ___5_UC9;
		float L_18 = ___6_UE6;
		TextMeshProEffect_U3BFUF6_m2097289ED738EA0B4CF752B207C3CF0F20CFC07B(__this, L_14, L_15, L_16, L_17, L_18, NULL);
		// break;
		return;
	}

IL_0069:
	{
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_19 = ___1_UEE;
		int32_t L_20 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ___5_UC9;
		float L_23 = ___7_UC6;
		TextMeshProEffect_U3BFUE7_mE15CF2C46D29469C4A9B6174B3AB24E3AC046323(__this, L_19, L_20, L_21, L_22, L_23, NULL);
		// break;
		return;
	}

IL_0078:
	{
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_24 = ___1_UEE;
		int32_t L_25 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_26 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_27 = ___5_UC9;
		float L_28 = ___7_UC6;
		TextMeshProEffect_U3BFUEC_mE5C089F1B453D8712DF8A219AF4627F7F21A5B07(__this, L_24, L_25, L_26, L_27, L_28, NULL);
		// break;
		return;
	}

IL_0087:
	{
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_29 = ___1_UEE;
		int32_t L_30 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_32 = ___5_UC9;
		float L_33 = ___7_UC6;
		TextMeshProEffect_U3BFUEC_mE5C089F1B453D8712DF8A219AF4627F7F21A5B07(__this, L_29, L_30, L_31, L_32, L_33, NULL);
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_34 = ___1_UEE;
		int32_t L_35 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_36 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_37 = ___4_UC5;
		float L_38 = ___6_UE6;
		TextMeshProEffect_U3BFUF6_m2097289ED738EA0B4CF752B207C3CF0F20CFC07B(__this, L_34, L_35, L_36, L_37, L_38, NULL);
		// break;
		return;
	}

IL_00a4:
	{
		// ?(?, ?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_39 = ___1_UEE;
		int32_t L_40 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_41 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_42 = ___5_UC9;
		float L_43 = ___7_UC6;
		uint16_t L_44 = ___8_UFB;
		TextMeshProEffect_UDC_m53AFDAA8871565E28B0C8E0FA8A81BB7E06C4B08(__this, L_39, L_40, L_41, L_42, L_43, L_44, NULL);
		// break;
		return;
	}

IL_00b5:
	{
		// ??(?, ?, ?, ?, ?);
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_45 = ___1_UEE;
		int32_t L_46 = ___2_UEC;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_47 = ___4_UC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_48 = ___5_UC9;
		float L_49 = ___7_UC6;
		TextMeshProEffect_U3BFUFC_m24314052E077146749A2780BF3EF5BC70280E541(__this, L_45, L_46, L_47, L_48, L_49, NULL);
		// break;
		return;
	}

IL_00c4:
	{
		// throw new ArgumentOutOfRangeException();
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_50 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_50);
		ArgumentOutOfRangeException__ctor_mB596C51BFA864B65C2CED275458FAE90F7CD29C9(L_50, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_50, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TextMeshProEffect_UE8_m36BB0CE3513C5BA6264807C0624C4ED877252552_RuntimeMethod_var)));
	}
}
// System.Single TMPro.TextMeshProEffect::?(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TextMeshProEffect_UF9_mF372AB28E16BA995D7EE64FCCCD4B80A3E193858 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U0FF, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// int num = Mathf.Abs(? % ??.Length);
		int32_t L_0 = ___0_U0FF;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_1 = __this->___UF6UC5_25;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Mathf_Abs_mD945EDDEA0D62D21BFDBAB7B1C0F18DFF1CEC905_inline(((int32_t)(L_0%((int32_t)(((RuntimeArray*)L_1)->max_length)))), NULL);
		V_0 = L_2;
		// return ??[num];
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_3 = __this->___UF6UC5_25;
		int32_t L_4 = V_0;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		float L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		return L_6;
	}
}
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UDC_m53AFDAA8871565E28B0C8E0FA8A81BB7E06C4B08 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U192, int32_t ___1_UE1, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_UED, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_UFA, float ___4_UF1, int32_t ___5_UD1, const RuntimeMethod* method) 
{
	UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// ?? ?? = default(??);
		il2cpp_codegen_initobj((&V_0), sizeof(UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F));
		// ??.?? = ?;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_0 = ___0_U192;
		(&V_0)->___UF6UFA_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF6UFA_0))->___textElement_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF6UFA_0))->___fontAsset_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF6UFA_0))->___spriteAsset_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF6UFA_0))->___material_8), (void*)NULL);
		#endif
		// ??.?? = this;
		(&V_0)->___UF6UF1_1 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___UF6UF1_1), (void*)__this);
		// ?[?] = ?[?] - ??(?, ?, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_1 = ___2_UED;
		int32_t L_2 = ___1_UE1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_3 = ___3_UFA;
		int32_t L_4 = ___1_UE1;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		int32_t L_7 = ___1_UE1;
		int32_t L_8 = ___5_UD1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00(__this, L_7, L_8, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_6, L_9, NULL);
		NullCheck(L_1);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(L_2), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_10);
		// ?[? + 1] = ?[? + 1] - ??(? + 1, ?, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_11 = ___2_UED;
		int32_t L_12 = ___1_UE1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ___3_UFA;
		int32_t L_14 = ___1_UE1;
		NullCheck(L_13);
		int32_t L_15 = ((int32_t)il2cpp_codegen_add(L_14, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		int32_t L_17 = ___1_UE1;
		int32_t L_18 = ___5_UD1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00(__this, ((int32_t)il2cpp_codegen_add(L_17, 1)), L_18, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_16, L_19, NULL);
		NullCheck(L_11);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_12, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_20);
		// ?[? + 2] = ?[? + 2] - ??(? + 2, ?, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = ___2_UED;
		int32_t L_22 = ___1_UE1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_23 = ___3_UFA;
		int32_t L_24 = ___1_UE1;
		NullCheck(L_23);
		int32_t L_25 = ((int32_t)il2cpp_codegen_add(L_24, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		int32_t L_27 = ___1_UE1;
		int32_t L_28 = ___5_UD1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		L_29 = TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00(__this, ((int32_t)il2cpp_codegen_add(L_27, 2)), L_28, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_26, L_29, NULL);
		NullCheck(L_21);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_22, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_30);
		// ?[? + 3] = ?[? + 3] - ??(? + 3, ?, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = ___2_UED;
		int32_t L_32 = ___1_UE1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_33 = ___3_UFA;
		int32_t L_34 = ___1_UE1;
		NullCheck(L_33);
		int32_t L_35 = ((int32_t)il2cpp_codegen_add(L_34, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36 = (L_33)->GetAt(static_cast<il2cpp_array_size_t>(L_35));
		int32_t L_37 = ___1_UE1;
		int32_t L_38 = ___5_UD1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00(__this, ((int32_t)il2cpp_codegen_add(L_37, 3)), L_38, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40;
		L_40 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_36, L_39, NULL);
		NullCheck(L_31);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_32, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_40);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::?(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Color32[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_UAA_m615F811C0D51CF8D387EDEB06DD8E0D2A63BD9AD (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFo, int32_t ___1_U3BFU3BF, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___2_U3BFU43E, float ___3_U3BFUF4, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		// Color b = Gradient.Evaluate(??);
		Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* L_0 = __this->___Gradient_9;
		float L_1 = ___3_U3BFUF4;
		NullCheck(L_0);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2;
		L_2 = Gradient_Evaluate_m332A32F48EA3F884CB55D74131DF8064F29F9C32(L_0, L_1, NULL);
		V_0 = L_2;
		// if (Mix == MixType.Multiply)
		uint8_t L_3 = __this->___Mix_10;
		if (L_3)
		{
			goto IL_00a8;
		}
	}
	{
		// ref Color32 reference = ref ??[??];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_4 = ___2_U3BFU43E;
		int32_t L_5 = ___1_U3BFU3BF;
		NullCheck(L_4);
		// reference *= b;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* L_6 = ((L_4)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_5)));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_7 = (*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_6);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8;
		L_8 = Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline(L_7, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_9 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_10;
		L_10 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_8, L_9, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		L_11 = Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline(L_10, NULL);
		*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_6 = L_11;
		// ref Color32 reference2 = ref ??[?? + 1];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_12 = ___2_U3BFU43E;
		int32_t L_13 = ___1_U3BFU3BF;
		NullCheck(L_12);
		// reference2 *= b;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* L_14 = ((L_12)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_13, 1)))));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_15 = (*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_14);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16;
		L_16 = Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline(L_15, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_18;
		L_18 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_16, L_17, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_19;
		L_19 = Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline(L_18, NULL);
		*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_14 = L_19;
		// ref Color32 reference3 = ref ??[?? + 2];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_20 = ___2_U3BFU43E;
		int32_t L_21 = ___1_U3BFU3BF;
		NullCheck(L_20);
		// reference3 *= b;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* L_22 = ((L_20)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_21, 2)))));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_23 = (*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_22);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24;
		L_24 = Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline(L_23, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_25 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_26;
		L_26 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_24, L_25, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_27;
		L_27 = Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline(L_26, NULL);
		*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_22 = L_27;
		// ref Color32 reference4 = ref ??[?? + 3];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_28 = ___2_U3BFU43E;
		int32_t L_29 = ___1_U3BFU3BF;
		NullCheck(L_28);
		// reference4 *= b;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* L_30 = ((L_28)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_29, 3)))));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_31 = (*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_30);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_32;
		L_32 = Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline(L_31, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_33 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_34;
		L_34 = Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline(L_32, L_33, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_35;
		L_35 = Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline(L_34, NULL);
		*(Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B*)L_30 = L_35;
		return;
	}

IL_00a8:
	{
		// for (int i = 0; i < 4; i++)
		V_1 = 0;
		goto IL_00e5;
	}

IL_00ac:
	{
		// Color c = ??[?? + i] + b;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_36 = ___2_U3BFU43E;
		int32_t L_37 = ___1_U3BFU3BF;
		int32_t L_38 = V_1;
		NullCheck(L_36);
		int32_t L_39 = ((int32_t)il2cpp_codegen_add(L_37, L_38));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_40 = (L_36)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_41;
		L_41 = Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline(L_40, NULL);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_42 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_43;
		L_43 = Color_op_Addition_mA7A51CACA49ED8D23D3D9CA3A0092D32F657E053_inline(L_41, L_42, NULL);
		V_2 = L_43;
		// c.a *= b.a;
		float* L_44 = (&(&V_2)->___a_3);
		float* L_45 = L_44;
		float L_46 = *((float*)L_45);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_47 = V_0;
		float L_48 = L_47.___a_3;
		*((float*)L_45) = (float)((float)il2cpp_codegen_multiply(L_46, L_48));
		// ??[?? + i] = c;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_49 = ___2_U3BFU43E;
		int32_t L_50 = ___1_U3BFU3BF;
		int32_t L_51 = V_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_52 = V_2;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_53;
		L_53 = Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline(L_52, NULL);
		NullCheck(L_49);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_50, L_51))), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_53);
		// for (int i = 0; i < 4; i++)
		int32_t L_54 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_54, 1));
	}

IL_00e5:
	{
		// for (int i = 0; i < 4; i++)
		int32_t L_55 = V_1;
		if ((((int32_t)L_55) < ((int32_t)4)))
		{
			goto IL_00ac;
		}
	}
	{
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUF6_m2097289ED738EA0B4CF752B207C3CF0F20CFC07B (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUF2, int32_t ___1_U3BFUF3, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUD6, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUBA, float ___4_U3BFUC7, const RuntimeMethod* method) 
{
	UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// ?? ?? = default(??);
		il2cpp_codegen_initobj((&V_0), sizeof(UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8));
		// ??.?? = ??;
		float L_0 = ___4_U3BFUC7;
		(&V_0)->___UF6UAA_0 = L_0;
		// ??.?o = ??;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_1 = ___0_U3BFUF2;
		(&V_0)->___UF2o_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2o_1))->___textElement_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2o_1))->___fontAsset_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2o_1))->___spriteAsset_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2o_1))->___material_8), (void*)NULL);
		#endif
		// ??.?? = this;
		(&V_0)->___UF2U3BF_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___UF2U3BF_2), (void*)__this);
		// ??[??] = ??[??] - ??(??, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = ___2_U3BFUD6;
		int32_t L_3 = ___1_U3BFUF3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = ___3_U3BFUBA;
		int32_t L_5 = ___1_U3BFUF3;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		int32_t L_8 = ___1_U3BFUF3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1(__this, L_8, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_7, L_9, NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_10);
		// ??[?? + 1] = ??[?? + 1] - ??(?? + 1, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_11 = ___2_U3BFUD6;
		int32_t L_12 = ___1_U3BFUF3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ___3_U3BFUBA;
		int32_t L_14 = ___1_U3BFUF3;
		NullCheck(L_13);
		int32_t L_15 = ((int32_t)il2cpp_codegen_add(L_14, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		int32_t L_17 = ___1_U3BFUF3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1(__this, ((int32_t)il2cpp_codegen_add(L_17, 1)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_16, L_18, NULL);
		NullCheck(L_11);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_12, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_19);
		// ??[?? + 2] = ??[?? + 2] - ??(?? + 2, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_20 = ___2_U3BFUD6;
		int32_t L_21 = ___1_U3BFUF3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ___3_U3BFUBA;
		int32_t L_23 = ___1_U3BFUF3;
		NullCheck(L_22);
		int32_t L_24 = ((int32_t)il2cpp_codegen_add(L_23, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		int32_t L_26 = ___1_U3BFUF3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1(__this, ((int32_t)il2cpp_codegen_add(L_26, 2)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_25, L_27, NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_21, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_28);
		// ??[?? + 3] = ??[?? + 3] - ??(?? + 3, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = ___2_U3BFUD6;
		int32_t L_30 = ___1_U3BFUF3;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = ___3_U3BFUBA;
		int32_t L_32 = ___1_U3BFUF3;
		NullCheck(L_31);
		int32_t L_33 = ((int32_t)il2cpp_codegen_add(L_32, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		int32_t L_35 = ___1_U3BFUF3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1(__this, ((int32_t)il2cpp_codegen_add(L_35, 3)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_34, L_36, NULL);
		NullCheck(L_29);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_30, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_37);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUFC_m24314052E077146749A2780BF3EF5BC70280E541 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUE9, int32_t ___1_U3BFUE2, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUE4, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUE0, float ___4_U3BFUE5, const RuntimeMethod* method) 
{
	UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// ?? ?? = default(??);
		il2cpp_codegen_initobj((&V_0), sizeof(UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E));
		// ??.?? = ??;
		float L_0 = ___4_U3BFUE5;
		(&V_0)->___UF2UF4_0 = L_0;
		// ??.?? = ??;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 L_1 = ___0_U3BFUE9;
		(&V_0)->___UF2UF6_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2UF6_1))->___textElement_4), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2UF6_1))->___fontAsset_5), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2UF6_1))->___spriteAsset_6), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&(&V_0)->___UF2UF6_1))->___material_8), (void*)NULL);
		#endif
		// ??.?? = this;
		(&V_0)->___UF2UF2_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&(&V_0)->___UF2UF2_2), (void*)__this);
		// ??[??] = ??[??] - ??(??, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = ___2_U3BFUE4;
		int32_t L_3 = ___1_U3BFUE2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = ___3_U3BFUE0;
		int32_t L_5 = ___1_U3BFUE2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		int32_t L_8 = ___1_U3BFUE2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39(__this, L_8, (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_7, L_9, NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_10);
		// ??[?? + 1] = ??[?? + 1] - ??(?? + 1, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_11 = ___2_U3BFUE4;
		int32_t L_12 = ___1_U3BFUE2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_13 = ___3_U3BFUE0;
		int32_t L_14 = ___1_U3BFUE2;
		NullCheck(L_13);
		int32_t L_15 = ((int32_t)il2cpp_codegen_add(L_14, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		int32_t L_17 = ___1_U3BFUE2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39(__this, ((int32_t)il2cpp_codegen_add(L_17, 1)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_16, L_18, NULL);
		NullCheck(L_11);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_12, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_19);
		// ??[?? + 2] = ??[?? + 2] - ??(?? + 2, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_20 = ___2_U3BFUE4;
		int32_t L_21 = ___1_U3BFUE2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_22 = ___3_U3BFUE0;
		int32_t L_23 = ___1_U3BFUE2;
		NullCheck(L_22);
		int32_t L_24 = ((int32_t)il2cpp_codegen_add(L_23, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		int32_t L_26 = ___1_U3BFUE2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39(__this, ((int32_t)il2cpp_codegen_add(L_26, 2)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_25, L_27, NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_21, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_28);
		// ??[?? + 3] = ??[?? + 3] - ??(?? + 3, ref ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = ___2_U3BFUE4;
		int32_t L_30 = ___1_U3BFUE2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = ___3_U3BFUE0;
		int32_t L_32 = ___1_U3BFUE2;
		NullCheck(L_31);
		int32_t L_33 = ((int32_t)il2cpp_codegen_add(L_32, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		int32_t L_35 = ___1_U3BFUE2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36;
		L_36 = TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39(__this, ((int32_t)il2cpp_codegen_add(L_35, 3)), (&V_0), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_34, L_36, NULL);
		NullCheck(L_29);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_30, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_37);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUE7_mE15CF2C46D29469C4A9B6174B3AB24E3AC046323 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUEA, int32_t ___1_U3BFUEB, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUE8, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUEF, float ___4_U3BFUEE, const RuntimeMethod* method) 
{
	{
		// ??[??] = ??[??];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_0 = ___2_U3BFUE8;
		int32_t L_1 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = ___3_U3BFUEF;
		int32_t L_3 = ___1_U3BFUEB;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		NullCheck(L_0);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(L_1), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_5);
		// ??[?? + 3] = ??[?? + 3];
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = ___2_U3BFUE8;
		int32_t L_7 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_8 = ___3_U3BFUEF;
		int32_t L_9 = ___1_U3BFUEB;
		NullCheck(L_8);
		int32_t L_10 = ((int32_t)il2cpp_codegen_add(L_9, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_7, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_11);
		// ??[?? + 1] = Vector3.Lerp(??[??], ??[?? + 1], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_12 = ___2_U3BFUE8;
		int32_t L_13 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_14 = ___3_U3BFUEF;
		int32_t L_15 = ___1_U3BFUEB;
		NullCheck(L_14);
		int32_t L_16 = L_15;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_18 = ___3_U3BFUEF;
		int32_t L_19 = ___1_U3BFUEB;
		NullCheck(L_18);
		int32_t L_20 = ((int32_t)il2cpp_codegen_add(L_19, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		float L_22 = ___4_U3BFUEE;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		L_23 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_17, L_21, L_22, NULL);
		NullCheck(L_12);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_13, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_23);
		// ??[?? + 2] = Vector3.Lerp(??[?? + 3], ??[?? + 2], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_24 = ___2_U3BFUE8;
		int32_t L_25 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_26 = ___3_U3BFUEF;
		int32_t L_27 = ___1_U3BFUEB;
		NullCheck(L_26);
		int32_t L_28 = ((int32_t)il2cpp_codegen_add(L_27, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_30 = ___3_U3BFUEF;
		int32_t L_31 = ___1_U3BFUEB;
		NullCheck(L_30);
		int32_t L_32 = ((int32_t)il2cpp_codegen_add(L_31, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = (L_30)->GetAt(static_cast<il2cpp_array_size_t>(L_32));
		float L_34 = ___4_U3BFUEE;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35;
		L_35 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_29, L_33, L_34, NULL);
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_25, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_35);
		// ??[??] = Vector3.LerpUnclamped(??[??], ??[??], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_36 = ___2_U3BFUE8;
		int32_t L_37 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = ___3_U3BFUEF;
		int32_t L_39 = ___1_U3BFUEB;
		NullCheck(L_38);
		int32_t L_40 = L_39;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_40));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_42 = ___2_U3BFUE8;
		int32_t L_43 = ___1_U3BFUEB;
		NullCheck(L_42);
		int32_t L_44 = L_43;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45 = (L_42)->GetAt(static_cast<il2cpp_array_size_t>(L_44));
		float L_46 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_47;
		L_47 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_41, L_45, L_46, NULL);
		NullCheck(L_36);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(L_37), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_47);
		// ??[?? + 1] = Vector3.LerpUnclamped(??[?? + 1], ??[?? + 1], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_48 = ___2_U3BFUE8;
		int32_t L_49 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = ___3_U3BFUEF;
		int32_t L_51 = ___1_U3BFUEB;
		NullCheck(L_50);
		int32_t L_52 = ((int32_t)il2cpp_codegen_add(L_51, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_52));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_54 = ___2_U3BFUE8;
		int32_t L_55 = ___1_U3BFUEB;
		NullCheck(L_54);
		int32_t L_56 = ((int32_t)il2cpp_codegen_add(L_55, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57 = (L_54)->GetAt(static_cast<il2cpp_array_size_t>(L_56));
		float L_58 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59;
		L_59 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_53, L_57, L_58, NULL);
		NullCheck(L_48);
		(L_48)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_49, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_59);
		// ??[?? + 2] = Vector3.LerpUnclamped(??[?? + 2], ??[?? + 2], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_60 = ___2_U3BFUE8;
		int32_t L_61 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_62 = ___3_U3BFUEF;
		int32_t L_63 = ___1_U3BFUEB;
		NullCheck(L_62);
		int32_t L_64 = ((int32_t)il2cpp_codegen_add(L_63, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_66 = ___2_U3BFUE8;
		int32_t L_67 = ___1_U3BFUEB;
		NullCheck(L_66);
		int32_t L_68 = ((int32_t)il2cpp_codegen_add(L_67, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69 = (L_66)->GetAt(static_cast<il2cpp_array_size_t>(L_68));
		float L_70 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_71;
		L_71 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_65, L_69, L_70, NULL);
		NullCheck(L_60);
		(L_60)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_61, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_71);
		// ??[?? + 3] = Vector3.LerpUnclamped(??[?? + 3], ??[?? + 3], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_72 = ___2_U3BFUE8;
		int32_t L_73 = ___1_U3BFUEB;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_74 = ___3_U3BFUEF;
		int32_t L_75 = ___1_U3BFUEB;
		NullCheck(L_74);
		int32_t L_76 = ((int32_t)il2cpp_codegen_add(L_75, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_77 = (L_74)->GetAt(static_cast<il2cpp_array_size_t>(L_76));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_78 = ___2_U3BFUE8;
		int32_t L_79 = ___1_U3BFUEB;
		NullCheck(L_78);
		int32_t L_80 = ((int32_t)il2cpp_codegen_add(L_79, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_81 = (L_78)->GetAt(static_cast<il2cpp_array_size_t>(L_80));
		float L_82 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_83;
		L_83 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_77, L_81, L_82, NULL);
		NullCheck(L_72);
		(L_72)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_73, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_83);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::??(TMPro.TMP_CharacterInfo,System.Int32,UnityEngine.Vector3[],UnityEngine.Vector3[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_U3BFUEC_mE5C089F1B453D8712DF8A219AF4627F7F21A5B07 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8 ___0_U3BFUC4, int32_t ___1_U3BFUC5, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2_U3BFUC9, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___3_U3BFUE6, float ___4_U3BFUC6, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// Vector3 a = (??[??] + ??[?? + 1]) * 0.5f;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_0 = ___3_U3BFUE6;
		int32_t L_1 = ___1_U3BFUC5;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = ___3_U3BFUE6;
		int32_t L_5 = ___1_U3BFUC5;
		NullCheck(L_4);
		int32_t L_6 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_3, L_7, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_8, (0.5f), NULL);
		V_0 = L_9;
		// Vector3 a2 = (??[?? + 3] + ??[?? + 2]) * 0.5f;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_10 = ___3_U3BFUE6;
		int32_t L_11 = ___1_U3BFUC5;
		NullCheck(L_10);
		int32_t L_12 = ((int32_t)il2cpp_codegen_add(L_11, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_14 = ___3_U3BFUE6;
		int32_t L_15 = ___1_U3BFUC5;
		NullCheck(L_14);
		int32_t L_16 = ((int32_t)il2cpp_codegen_add(L_15, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_13, L_17, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_18, (0.5f), NULL);
		V_1 = L_19;
		// ??[??] = Vector3.Lerp(a, ??[??], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_20 = ___2_U3BFUC9;
		int32_t L_21 = ___1_U3BFUC5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_23 = ___3_U3BFUE6;
		int32_t L_24 = ___1_U3BFUC5;
		NullCheck(L_23);
		int32_t L_25 = L_24;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		float L_27 = ___4_U3BFUC6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28;
		L_28 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_22, L_26, L_27, NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_28);
		// ??[?? + 3] = Vector3.Lerp(a2, ??[?? + 3], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = ___2_U3BFUC9;
		int32_t L_30 = ___1_U3BFUC5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_32 = ___3_U3BFUE6;
		int32_t L_33 = ___1_U3BFUC5;
		NullCheck(L_32);
		int32_t L_34 = ((int32_t)il2cpp_codegen_add(L_33, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_34));
		float L_36 = ___4_U3BFUC6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_31, L_35, L_36, NULL);
		NullCheck(L_29);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_30, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_37);
		// ??[?? + 1] = Vector3.Lerp(a, ??[?? + 1], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = ___2_U3BFUC9;
		int32_t L_39 = ___1_U3BFUC5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_40 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_41 = ___3_U3BFUE6;
		int32_t L_42 = ___1_U3BFUC5;
		NullCheck(L_41);
		int32_t L_43 = ((int32_t)il2cpp_codegen_add(L_42, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_43));
		float L_45 = ___4_U3BFUC6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_46;
		L_46 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_40, L_44, L_45, NULL);
		NullCheck(L_38);
		(L_38)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_39, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_46);
		// ??[?? + 2] = Vector3.Lerp(a2, ??[?? + 2], ??);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_47 = ___2_U3BFUC9;
		int32_t L_48 = ___1_U3BFUC5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = ___3_U3BFUE6;
		int32_t L_51 = ___1_U3BFUC5;
		NullCheck(L_50);
		int32_t L_52 = ((int32_t)il2cpp_codegen_add(L_51, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_52));
		float L_54 = ___4_U3BFUC6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55;
		L_55 = Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline(L_49, L_53, L_54, NULL);
		NullCheck(L_47);
		(L_47)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_48, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_55);
		// ??[??] = Vector3.LerpUnclamped(??[??], ??[??], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_56 = ___2_U3BFUC9;
		int32_t L_57 = ___1_U3BFUC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_58 = ___3_U3BFUE6;
		int32_t L_59 = ___1_U3BFUC5;
		NullCheck(L_58);
		int32_t L_60 = L_59;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61 = (L_58)->GetAt(static_cast<il2cpp_array_size_t>(L_60));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_62 = ___2_U3BFUC9;
		int32_t L_63 = ___1_U3BFUC5;
		NullCheck(L_62);
		int32_t L_64 = L_63;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		float L_66 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67;
		L_67 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_61, L_65, L_66, NULL);
		NullCheck(L_56);
		(L_56)->SetAt(static_cast<il2cpp_array_size_t>(L_57), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_67);
		// ??[?? + 1] = Vector3.LerpUnclamped(??[?? + 1], ??[?? + 1], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_68 = ___2_U3BFUC9;
		int32_t L_69 = ___1_U3BFUC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_70 = ___3_U3BFUE6;
		int32_t L_71 = ___1_U3BFUC5;
		NullCheck(L_70);
		int32_t L_72 = ((int32_t)il2cpp_codegen_add(L_71, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_73 = (L_70)->GetAt(static_cast<il2cpp_array_size_t>(L_72));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_74 = ___2_U3BFUC9;
		int32_t L_75 = ___1_U3BFUC5;
		NullCheck(L_74);
		int32_t L_76 = ((int32_t)il2cpp_codegen_add(L_75, 1));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_77 = (L_74)->GetAt(static_cast<il2cpp_array_size_t>(L_76));
		float L_78 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_79;
		L_79 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_73, L_77, L_78, NULL);
		NullCheck(L_68);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_69, 1))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_79);
		// ??[?? + 2] = Vector3.LerpUnclamped(??[?? + 2], ??[?? + 2], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_80 = ___2_U3BFUC9;
		int32_t L_81 = ___1_U3BFUC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_82 = ___3_U3BFUE6;
		int32_t L_83 = ___1_U3BFUC5;
		NullCheck(L_82);
		int32_t L_84 = ((int32_t)il2cpp_codegen_add(L_83, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_85 = (L_82)->GetAt(static_cast<il2cpp_array_size_t>(L_84));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_86 = ___2_U3BFUC9;
		int32_t L_87 = ___1_U3BFUC5;
		NullCheck(L_86);
		int32_t L_88 = ((int32_t)il2cpp_codegen_add(L_87, 2));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_89 = (L_86)->GetAt(static_cast<il2cpp_array_size_t>(L_88));
		float L_90 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_91;
		L_91 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_85, L_89, L_90, NULL);
		NullCheck(L_80);
		(L_80)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_81, 2))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_91);
		// ??[?? + 3] = Vector3.LerpUnclamped(??[?? + 3], ??[?? + 3], Amplitude);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_92 = ___2_U3BFUC9;
		int32_t L_93 = ___1_U3BFUC5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_94 = ___3_U3BFUE6;
		int32_t L_95 = ___1_U3BFUC5;
		NullCheck(L_94);
		int32_t L_96 = ((int32_t)il2cpp_codegen_add(L_95, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_97 = (L_94)->GetAt(static_cast<il2cpp_array_size_t>(L_96));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_98 = ___2_U3BFUC9;
		int32_t L_99 = ___1_U3BFUC5;
		NullCheck(L_98);
		int32_t L_100 = ((int32_t)il2cpp_codegen_add(L_99, 3));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_101 = (L_98)->GetAt(static_cast<il2cpp_array_size_t>(L_100));
		float L_102 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_103;
		L_103 = Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline(L_97, L_101, L_102, NULL);
		NullCheck(L_92);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_93, 3))), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_103);
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_Play_mF87CBD9D4DAC8AC81C85E4F401F297E19827C32D (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	{
		// Apply();
		TextMeshProEffect_Apply_mEB8E65D2B3214F442684E4502A23FFC8366F5CDD(__this, NULL);
		// IsFinished = false;
		__this->___IsFinished_15 = (bool)0;
		// ?? = Time.realtimeSinceStartup;
		float L_0;
		L_0 = Time_get_realtimeSinceStartup_m73B3CB73175D79A44333D59BB70F9EDE55EC9510(NULL);
		__this->___UF6UE5_16 = L_0;
		// ?? = true;
		__this->___UF6UEF_21 = (bool)1;
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect::Finish()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect_Finish_m519EF3465BA6B38269F433966658640ED3E02F81 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	{
		// ?? = float.MinValue;
		__this->___UF6UE5_16 = (-(std::numeric_limits<float>::max)());
		// }
		return;
	}
}
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFUFB_mCE92CA0DA6AD1387B901B60BB9B83B1EF9518B00 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUF9, int32_t ___1_U3BFU0FF, UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F* ___2_U3BFUDC, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		// float num = ??.??.pointSize * 0.1f * Amplitude;
		UF6UED_tBBF18EEAB4A65FFB7788BB158D9A588893F97B1F* L_0 = ___2_U3BFUDC;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8* L_1 = (&L_0->___UF6UFA_0);
		float L_2 = L_1->___pointSize_11;
		float L_3 = __this->___Amplitude_6;
		V_0 = ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_2, (0.100000001f))), L_3));
		// float num2 = ?(?? << ??);
		int32_t L_4 = ___0_U3BFUF9;
		int32_t L_5 = ___1_U3BFU0FF;
		float L_6;
		L_6 = TextMeshProEffect_UF9_mF372AB28E16BA995D7EE64FCCCD4B80A3E193858(__this, ((int32_t)(L_4<<((int32_t)(L_5&((int32_t)31))))), NULL);
		// float num3 = ?(?? << ?? >> 5);
		int32_t L_7 = ___0_U3BFUF9;
		int32_t L_8 = ___1_U3BFU0FF;
		float L_9;
		L_9 = TextMeshProEffect_UF9_mF372AB28E16BA995D7EE64FCCCD4B80A3E193858(__this, ((int32_t)(((int32_t)(L_7<<((int32_t)(L_8&((int32_t)31)))))>>5)), NULL);
		V_1 = L_9;
		// return new Vector3(num2 * num, num3 * num, 0f);
		float L_10 = V_0;
		float L_11 = V_1;
		float L_12 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		memset((&L_13), 0, sizeof(L_13));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_13), ((float)il2cpp_codegen_multiply(L_6, L_10)), ((float)il2cpp_codegen_multiply(L_11, L_12)), (0.0f), /*hidden argument*/NULL);
		return L_13;
	}
}
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFU192_m2D8BE6F06D7A8C30F5483C06B7900432083162B1 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUE1, UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8* ___1_U3BFUED, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		// float f = (float)Math.PI * -2f * ??.?? + (float)(?? / 4) * 0.3f;
		UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8* L_0 = ___1_U3BFUED;
		float L_1 = L_0->___UF6UAA_0;
		int32_t L_2 = ___0_U3BFUE1;
		V_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply((-6.28318548f), L_1)), ((float)il2cpp_codegen_multiply(((float)((int32_t)(L_2/4))), (0.300000012f)))));
		// return new Vector3(0f, Mathf.Cos(f) * ??.?o.pointSize * 0.3f * Amplitude, 0f);
		float L_3 = V_0;
		float L_4;
		L_4 = cosf(L_3);
		UF6UD1_t731EDACD212C371A9170D477F33C007087D5E7A8* L_5 = ___1_U3BFUED;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8* L_6 = (&L_5->___UF2o_1);
		float L_7 = L_6->___pointSize_11;
		float L_8 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), (0.0f), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_4, L_7)), (0.300000012f))), L_8)), (0.0f), /*hidden argument*/NULL);
		return L_9;
	}
}
// UnityEngine.Vector3 TMPro.TextMeshProEffect::??(System.Int32,TMPro.TextMeshProEffect/??&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TextMeshProEffect_U3BFUFA_m8D501C2D81BCD2D1FD92946774F0E53B2D361A39 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, int32_t ___0_U3BFUF1, UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E* ___1_U3BFUD1, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		// float f = (float)Math.PI * -2f * ??.??;
		UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E* L_0 = ___1_U3BFUD1;
		float L_1 = L_0->___UF2UF4_0;
		V_0 = ((float)il2cpp_codegen_multiply((-6.28318548f), L_1));
		// return new Vector3(0f, Mathf.Cos(f) * ??.??.pointSize * 0.3f * Amplitude, 0f);
		float L_2 = V_0;
		float L_3;
		L_3 = cosf(L_2);
		UF2U43E_t344352BFDF955317A6E2781700FB20A7F411753E* L_4 = ___1_U3BFUD1;
		TMP_CharacterInfo_t8B8FF32D6AACE251F2E7835AA5BC6608D535D9F8* L_5 = (&L_4->___UF2UF6_1);
		float L_6 = L_5->___pointSize_11;
		float L_7 = __this->___Amplitude_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_8), (0.0f), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_3, L_6)), (0.300000012f))), L_7)), (0.0f), /*hidden argument*/NULL);
		return L_8;
	}
}
// System.Void TMPro.TextMeshProEffect::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextMeshProEffect__ctor_mE1827C5B0402562D4F368925E086405D15DCF541 (TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public float DurationInSeconds = 0.5f;
		__this->___DurationInSeconds_5 = (0.5f);
		// public float Amplitude = 1f;
		__this->___Amplitude_6 = (1.0f);
		// public Gradient Gradient = new Gradient();
		Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E* L_0 = (Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E*)il2cpp_codegen_object_new(Gradient_tA7FEBE2FDB4929FFF6C997134841046F713DAC1E_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Gradient__ctor_m5EC470BB063D4831774C7CDA5D471EBEB5CE7B54(L_0, NULL);
		__this->___Gradient_9 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Gradient_9), (void*)L_0);
		// public bool AutoPlay = true;
		__this->___AutoPlay_11 = (bool)1;
		// private readonly List<(int from, int to)> ?? = new List<(int, int)>();
		List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* L_1 = (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*)il2cpp_codegen_object_new(List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9(L_1, List_1__ctor_mB54BAEB6C21AF5571605F1F9EE491ACCD8D645E9_RuntimeMethod_var);
		__this->___UF6UE0_14 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UE0_14), (void*)L_1);
		// private float[] ?? = new float[10];
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_2 = (SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)SZArrayNew(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)10));
		__this->___UF6UC5_25 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UF6UC5_25), (void*)L_2);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void TMPro.TextMeshProEffect/SharedState::LateUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SharedState_LateUpdate_mE460538666F74CD11EC3363F70F77171F8D84F58 (SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* __this, const RuntimeMethod* method) 
{
	{
		// TextMeshIsUpdated = false;
		__this->___TextMeshIsUpdated_4 = (bool)0;
		// }
		return;
	}
}
// System.Void TMPro.TextMeshProEffect/SharedState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SharedState__ctor_m927A18A3E72BDA300EAC613BFA98DD336078DF76 (SharedState_t5660B9E98BB9BF3A6553E051578C88BE73869FCE* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean TMPro.TextMeshProEffect/??::??(TMPro.TextMeshProEffect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool UF6UF9_UF6U0FF_m8048DB4D12F3670CE07B928FE644171AA60CB1DF (UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* __this, TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* ___0_UF6UDC, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return ?? == null || !??.enabled;
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_0 = ___0_UF6UDC;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_1)
		{
			goto IL_0013;
		}
	}
	{
		TextMeshProEffect_t8B0C14C68309821BB6ABDBB120FB3AF27224A30C* L_2 = ___0_UF6UDC;
		NullCheck(L_2);
		bool L_3;
		L_3 = Behaviour_get_enabled_mAAC9F15E9EBF552217A5AE2681589CC0BFA300C1(L_2, NULL);
		return (bool)((((int32_t)L_3) == ((int32_t)0))? 1 : 0);
	}

IL_0013:
	{
		return (bool)1;
	}
}
// System.Void TMPro.TextMeshProEffect/??::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UF6UF9__ctor_m62D51FB2F396C85163C885F7663DB8639FB09A4C (UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void TMPro.TextMeshProEffect/??::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UF6UF9__cctor_m83BCC566308ACC97104D23167557B9DCE33399FD (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public static readonly ?? ?? = new ??();
		UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83* L_0 = (UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83*)il2cpp_codegen_object_new(UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		UF6UF9__ctor_m62D51FB2F396C85163C885F7663DB8639FB09A4C(L_0, NULL);
		((UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_StaticFields*)il2cpp_codegen_static_fields_for(UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var))->___UF6U192_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_StaticFields*)il2cpp_codegen_static_fields_for(UF6UF9_tF5137E76C20FBF1A5313BA9C22E0362707ADDF83_il2cpp_TypeInfo_var))->___UF6U192_0), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* TMP_Text_get_textInfo_mA24C606B8EA51436E4AA3B9D6DCDFA7A8995E10E_inline (TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_textInfo; }
		TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* L_0 = __this->___m_textInfo_153;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____stringLength_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___0_a, float ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = ___0_a;
		float L_1 = ___1_b;
		float L_2 = ___0_a;
		float L_3 = ___2_t;
		float L_4;
		L_4 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_3, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_0, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_1, L_2)), L_4))));
		goto IL_0010;
	}

IL_0010:
	{
		float L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	{
		float L_0 = ___0_value;
		V_0 = (bool)((((float)L_0) < ((float)(0.0f)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (0.0f);
		goto IL_002d;
	}

IL_0015:
	{
		float L_2 = ___0_value;
		V_2 = (bool)((((float)L_2) > ((float)(1.0f)))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0029;
		}
	}
	{
		V_1 = (1.0f);
		goto IL_002d;
	}

IL_0029:
	{
		float L_4 = ___0_value;
		V_1 = L_4;
		goto IL_002d;
	}

IL_002d:
	{
		float L_5 = V_1;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t TMP_Text_get_fontStyle_mC34CC5EBEDD43CE93BA911CCC4D33F9697838586_inline (TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_fontStyle; }
		int32_t L_0 = __this->___m_fontStyle_89;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Abs_mD945EDDEA0D62D21BFDBAB7B1C0F18DFF1CEC905_inline (int32_t ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		int32_t L_1;
		L_1 = il2cpp_codegen_abs(L_0);
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_subtract(L_1, L_3)), ((float)il2cpp_codegen_subtract(L_5, L_7)), ((float)il2cpp_codegen_subtract(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color32_op_Implicit_m47CBB138122B400E0B1F4BFD7C30A6C2C00FCA3E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___0_c, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_0 = ___0_c;
		uint8_t L_1 = L_0.___r_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_2 = ___0_c;
		uint8_t L_3 = L_2.___g_2;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_4 = ___0_c;
		uint8_t L_5 = L_4.___b_3;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_6 = ___0_c;
		uint8_t L_7 = L_6.___a_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8;
		memset((&L_8), 0, sizeof(L_8));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_8), ((float)(((float)L_1)/(255.0f))), ((float)(((float)L_3)/(255.0f))), ((float)(((float)L_5)/(255.0f))), ((float)(((float)L_7)/(255.0f))), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_003d;
	}

IL_003d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Multiply_mD0296202733CB2D5342FB7C82B48AEDA63036758_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_a;
		float L_1 = L_0.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___1_b;
		float L_3 = L_2.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_a;
		float L_5 = L_4.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___1_b;
		float L_7 = L_6.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8 = ___0_a;
		float L_9 = L_8.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_10 = ___1_b;
		float L_11 = L_10.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12 = ___0_a;
		float L_13 = L_12.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_14 = ___1_b;
		float L_15 = L_14.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16;
		memset((&L_16), 0, sizeof(L_16));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_16), ((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)), ((float)il2cpp_codegen_multiply(L_9, L_11)), ((float)il2cpp_codegen_multiply(L_13, L_15)), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_003d;
	}

IL_003d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17 = V_0;
		return L_17;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B Color32_op_Implicit_m79AF5E0BDE9CE041CAC4D89CBFA66E71C6DD1B70_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_c, const RuntimeMethod* method) 
{
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_c;
		float L_1 = L_0.___r_0;
		float L_2;
		L_2 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_1, NULL);
		float L_3;
		L_3 = bankers_roundf(((float)il2cpp_codegen_multiply(L_2, (255.0f))));
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_c;
		float L_5 = L_4.___g_1;
		float L_6;
		L_6 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_5, NULL);
		float L_7;
		L_7 = bankers_roundf(((float)il2cpp_codegen_multiply(L_6, (255.0f))));
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8 = ___0_c;
		float L_9 = L_8.___b_2;
		float L_10;
		L_10 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_9, NULL);
		float L_11;
		L_11 = bankers_roundf(((float)il2cpp_codegen_multiply(L_10, (255.0f))));
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12 = ___0_c;
		float L_13 = L_12.___a_3;
		float L_14;
		L_14 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_13, NULL);
		float L_15;
		L_15 = bankers_roundf(((float)il2cpp_codegen_multiply(L_14, (255.0f))));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_16;
		memset((&L_16), 0, sizeof(L_16));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_16), (uint8_t)il2cpp_codegen_cast_floating_point<uint8_t, int32_t, float>(L_3), (uint8_t)il2cpp_codegen_cast_floating_point<uint8_t, int32_t, float>(L_7), (uint8_t)il2cpp_codegen_cast_floating_point<uint8_t, int32_t, float>(L_11), (uint8_t)il2cpp_codegen_cast_floating_point<uint8_t, int32_t, float>(L_15), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_0065;
	}

IL_0065:
	{
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_17 = V_0;
		return L_17;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_op_Addition_mA7A51CACA49ED8D23D3D9CA3A0092D32F657E053_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_a, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_b, const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_a;
		float L_1 = L_0.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___1_b;
		float L_3 = L_2.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_a;
		float L_5 = L_4.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___1_b;
		float L_7 = L_6.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8 = ___0_a;
		float L_9 = L_8.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_10 = ___1_b;
		float L_11 = L_10.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12 = ___0_a;
		float L_13 = L_12.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_14 = ___1_b;
		float L_15 = L_14.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16;
		memset((&L_16), 0, sizeof(L_16));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_16), ((float)il2cpp_codegen_add(L_1, L_3)), ((float)il2cpp_codegen_add(L_5, L_7)), ((float)il2cpp_codegen_add(L_9, L_11)), ((float)il2cpp_codegen_add(L_13, L_15)), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_003d;
	}

IL_003d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17 = V_0;
		return L_17;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Lerp_m3A906D0530A94FAABB94F0F905E84D99BE85C3F8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		float L_0 = ___2_t;
		float L_1;
		L_1 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_0, NULL);
		___2_t = L_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_a;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___1_b;
		float L_5 = L_4.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___x_2;
		float L_8 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ___0_a;
		float L_10 = L_9.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = ___1_b;
		float L_12 = L_11.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = ___0_a;
		float L_14 = L_13.___y_3;
		float L_15 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___0_a;
		float L_17 = L_16.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___1_b;
		float L_19 = L_18.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ___0_a;
		float L_21 = L_20.___z_4;
		float L_22 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_23;
		memset((&L_23), 0, sizeof(L_23));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_23), ((float)il2cpp_codegen_add(L_3, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_5, L_7)), L_8)))), ((float)il2cpp_codegen_add(L_10, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_12, L_14)), L_15)))), ((float)il2cpp_codegen_add(L_17, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_19, L_21)), L_22)))), /*hidden argument*/NULL);
		V_0 = L_23;
		goto IL_0053;
	}

IL_0053:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = V_0;
		return L_24;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_LerpUnclamped_m4109A459C1DB823310A10B8B1E80CB6877418347_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, float ___2_t, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___x_2;
		float L_6 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = ___0_a;
		float L_8 = L_7.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ___1_b;
		float L_10 = L_9.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = ___0_a;
		float L_12 = L_11.___y_3;
		float L_13 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = ___0_a;
		float L_15 = L_14.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___1_b;
		float L_17 = L_16.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___0_a;
		float L_19 = L_18.___z_4;
		float L_20 = ___2_t;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		memset((&L_21), 0, sizeof(L_21));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_21), ((float)il2cpp_codegen_add(L_1, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_3, L_5)), L_6)))), ((float)il2cpp_codegen_add(L_8, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_10, L_12)), L_13)))), ((float)il2cpp_codegen_add(L_15, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_17, L_19)), L_20)))), /*hidden argument*/NULL);
		V_0 = L_21;
		goto IL_004b;
	}

IL_004b:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = V_0;
		return L_22;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_add(L_1, L_3)), ((float)il2cpp_codegen_add(L_5, L_7)), ((float)il2cpp_codegen_add(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		float L_2 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_a;
		float L_4 = L_3.___y_3;
		float L_5 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___z_4;
		float L_8 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)il2cpp_codegen_multiply(L_1, L_2)), ((float)il2cpp_codegen_multiply(L_4, L_5)), ((float)il2cpp_codegen_multiply(L_7, L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_2 = L_0;
		float L_1 = ___1_y;
		__this->___y_3 = L_1;
		float L_2 = ___2_z;
		__this->___z_4 = L_2;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mD59506A0DF49A92D8862E98EACA11F6870187CDB_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m6B00F2764CE9DE9D9254C2602D4BA0E5F6C06C52_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		if (!false)
		{
			goto IL_0035;
		}
	}
	{
		int32_t L_1 = (int32_t)__this->____size_2;
		V_0 = L_1;
		__this->____size_2 = 0;
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* L_3 = (ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263*)__this->____items_1;
		int32_t L_4 = V_0;
		Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB((RuntimeArray*)L_3, 0, L_4, NULL);
		return;
	}

IL_0035:
	{
		__this->____size_2 = 0;
	}

IL_003c:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m2E37700A346C3FA428A05659760617E96F0AA82A_gshared_inline (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B* __this, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D ___0_item, const RuntimeMethod* method) 
{
	ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* L_1 = (ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ValueTuple_2U5BU5D_t421388B3AA488C3C898278B339E982A32C074263* L_6 = V_0;
		int32_t L_7 = V_1;
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D)L_8);
		return;
	}

IL_0034:
	{
		ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D L_9 = ___0_item;
		((  void (*) (List_1_t524AA52218730C1F34ECD6B5431C1EF28C50E95B*, ValueTuple_2_t973F7AB0EF5DD3619E518A966941F10D8098F52D, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_r;
		__this->___r_0 = L_0;
		float L_1 = ___1_g;
		__this->___g_1 = L_1;
		float L_2 = ___2_b;
		__this->___b_2 = L_2;
		float L_3 = ___3_a;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___0_r, uint8_t ___1_g, uint8_t ___2_b, uint8_t ___3_a, const RuntimeMethod* method) 
{
	{
		__this->___rgba_0 = 0;
		uint8_t L_0 = ___0_r;
		__this->___r_1 = L_0;
		uint8_t L_1 = ___1_g;
		__this->___g_2 = L_1;
		uint8_t L_2 = ___2_b;
		__this->___b_3 = L_2;
		uint8_t L_3 = ___3_a;
		__this->___a_4 = L_3;
		return;
	}
}
