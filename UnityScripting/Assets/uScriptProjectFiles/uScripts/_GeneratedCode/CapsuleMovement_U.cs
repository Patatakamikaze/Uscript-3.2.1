//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class CapsuleMovement_U : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.Vector3 Direcciones = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_11_System_Single = (float) 0;
   System.Single local_13_System_Single = (float) 0;
   UnityEngine.Vector3 local_14_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Single Speed = (float) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_24 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_1 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_XMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_XMax_1 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_YMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_YMax_1 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampZ_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_ZMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_ZMax_1 = (float) 1;
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Result_1;
   bool logic_uScriptAct_ClampVector3_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2;
   bool logic_uScriptAct_GetDeltaTime_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_3 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_3 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_3;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_3;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_4 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_4 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_4;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_4 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_5 = new Vector3( );
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_24 || false == m_RegisteredForEvents )
      {
         owner_Connection_24 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4.SetParent(g);
      owner_Connection_24 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Relay_OnUpdate_0()
   {
      if (true == CheckDebugBreak("e873af9f-ce3d-4abe-91c5-b7b88f487231", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("e873af9f-ce3d-4abe-91c5-b7b88f487231", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("e873af9f-ce3d-4abe-91c5-b7b88f487231", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e0b53188-6ac6-4186-8244-cb6291a16019", "Clamp_Vector3", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_1 = Direcciones;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.In(logic_uScriptAct_ClampVector3_Target_1, logic_uScriptAct_ClampVector3_ClampX_1, logic_uScriptAct_ClampVector3_XMin_1, logic_uScriptAct_ClampVector3_XMax_1, logic_uScriptAct_ClampVector3_ClampY_1, logic_uScriptAct_ClampVector3_YMin_1, logic_uScriptAct_ClampVector3_YMax_1, logic_uScriptAct_ClampVector3_ClampZ_1, logic_uScriptAct_ClampVector3_ZMin_1, logic_uScriptAct_ClampVector3_ZMax_1, out logic_uScriptAct_ClampVector3_Result_1);
         Direcciones = logic_uScriptAct_ClampVector3_Result_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7bad2d16-4c63-4dc2-ac6b-370a58106c58", "Get_Delta_Time", Relay_In_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_2, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2);
         local_11_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_2;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ba5c3121-2a1b-4ea5-92df-a62ca66ce3ca", "Multiply_Float", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_3 = Speed;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_3 = local_11_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.In(logic_uScriptAct_MultiplyFloat_v2_A_3, logic_uScriptAct_MultiplyFloat_v2_B_3, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_3, out logic_uScriptAct_MultiplyFloat_v2_IntResult_3);
         local_13_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4b62394c-3c7e-4749-913f-8f0ad2924420", "Multiply_Vector3_With_Float", Relay_In_4)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_4 = Direcciones;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_4 = local_13_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_4, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_4, out logic_uScriptAct_MultiplyVector3WithFloat_Result_4);
         local_14_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_4;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4.Out;
         
         if ( test_0 == true )
         {
            Relay_Translate_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c3934c64-cf5b-4ec0-92cb-79b1523870c6", "UnityEngine_Transform", Relay_Translate_5)) return; 
         {
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_5 = local_14_UnityEngine_Vector3;
               
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_24.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_5);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:11", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "0a51ffe9-50f6-4e6e-8c22-97ab4a22f66f", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:Speed", Speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "eb6d2aca-acb5-4fd8-b859-dfb25593f061", Speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:13", local_13_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "43da78ee-d8b2-4eb2-8798-8be0a1d9ee47", local_13_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:14", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "84985dc6-748c-46ab-9907-72b368dfd751", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:Direcciones", Direcciones);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "6738cc9e-4a3c-474f-8fd3-67d7e82669e2", Direcciones);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
