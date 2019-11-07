//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Rotacion_U : uScriptLogic
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
   public UnityEngine.Vector3 Axes = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_16_System_Single = (float) 0;
   System.Single local_17_System_Single = (float) 0;
   UnityEngine.Vector3 local_23_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_25_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_26_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Transform local_36_UnityEngine_Transform = default(UnityEngine.Transform);
   public System.Single scaleUnits = (float) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_38 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_1 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_XMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_XMax_1 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_1 = (bool) false;
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
   //pointer to script instanced logic node
   uScriptAct_GetScaleFromTransform logic_uScriptAct_GetScaleFromTransform_uScriptAct_GetScaleFromTransform_5 = new uScriptAct_GetScaleFromTransform( );
   UnityEngine.Transform logic_uScriptAct_GetScaleFromTransform_target_5 = default(UnityEngine.Transform);
   System.Boolean logic_uScriptAct_GetScaleFromTransform_getLossy_5 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetScaleFromTransform_scale_5;
   System.Single logic_uScriptAct_GetScaleFromTransform_xScale_5;
   System.Single logic_uScriptAct_GetScaleFromTransform_yScale_5;
   System.Single logic_uScriptAct_GetScaleFromTransform_zScale_5;
   bool logic_uScriptAct_GetScaleFromTransform_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_AddVector3_v2 logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6 = new uScriptAct_AddVector3_v2( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_A_6 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_B_6 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_Result_6;
   bool logic_uScriptAct_AddVector3_v2_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_7 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_7 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_7 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_7 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_38 || false == m_RegisteredForEvents )
      {
         owner_Connection_38 = parentGameObject;
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
      logic_uScriptAct_GetScaleFromTransform_uScriptAct_GetScaleFromTransform_5.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_7.SetParent(g);
      owner_Connection_38 = parentGameObject;
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
      if (true == CheckDebugBreak("85273963-4469-480d-9a49-5e17569f37c9", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("85273963-4469-480d-9a49-5e17569f37c9", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("85273963-4469-480d-9a49-5e17569f37c9", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0314750e-d165-40a2-8f9d-b6d5acc8250b", "Clamp_Vector3", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_1 = Axes;
               
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
         Axes = logic_uScriptAct_ClampVector3_Result_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("84e595e6-1bc6-49e6-88fd-bfce27ac1a3f", "Get_Delta_Time", Relay_In_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_2, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2);
         local_17_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_2;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("68e8e5a5-f5c7-4e21-a600-6e83f6e7a226", "Multiply_Float", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_3 = scaleUnits;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_3 = local_17_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.In(logic_uScriptAct_MultiplyFloat_v2_A_3, logic_uScriptAct_MultiplyFloat_v2_B_3, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_3, out logic_uScriptAct_MultiplyFloat_v2_IntResult_3);
         local_16_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e5c0324b-6871-4589-9888-a3f46b133b4e", "Multiply_Vector3_With_Float", Relay_In_4)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_4 = Axes;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_4 = local_16_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_4, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_4, out logic_uScriptAct_MultiplyVector3WithFloat_Result_4);
         local_26_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_4;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("768eb145-376c-4031-b7bd-38c044dfb26f", "Get_Scale_From_Transform", Relay_In_5)) return; 
         {
            {
               logic_uScriptAct_GetScaleFromTransform_target_5 = local_36_UnityEngine_Transform;
               
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
         logic_uScriptAct_GetScaleFromTransform_uScriptAct_GetScaleFromTransform_5.In(logic_uScriptAct_GetScaleFromTransform_target_5, logic_uScriptAct_GetScaleFromTransform_getLossy_5, out logic_uScriptAct_GetScaleFromTransform_scale_5, out logic_uScriptAct_GetScaleFromTransform_xScale_5, out logic_uScriptAct_GetScaleFromTransform_yScale_5, out logic_uScriptAct_GetScaleFromTransform_zScale_5);
         local_23_UnityEngine_Vector3 = logic_uScriptAct_GetScaleFromTransform_scale_5;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetScaleFromTransform_uScriptAct_GetScaleFromTransform_5.Out;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Get Scale From Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3af0cabf-f9a1-43b7-8837-66554e334fec", "Add_Vector3", Relay_In_6)) return; 
         {
            {
               logic_uScriptAct_AddVector3_v2_A_6 = local_26_UnityEngine_Vector3;
               
            }
            {
               logic_uScriptAct_AddVector3_v2_B_6 = local_23_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.In(logic_uScriptAct_AddVector3_v2_A_6, logic_uScriptAct_AddVector3_v2_B_6, out logic_uScriptAct_AddVector3_v2_Result_6);
         local_25_UnityEngine_Vector3 = logic_uScriptAct_AddVector3_v2_Result_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Add Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16cf3295-5304-4d03-ad40-18de93f5b83f", "Set_Scale", Relay_In_7)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_SetGameObjectScale_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_7, index + 1);
               }
               logic_uScriptAct_SetGameObjectScale_Target_7[ index++ ] = owner_Connection_38;
               
            }
            {
               logic_uScriptAct_SetGameObjectScale_Scale_7 = local_25_UnityEngine_Vector3;
               
            }
         }
         logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_7.In(logic_uScriptAct_SetGameObjectScale_Target_7, logic_uScriptAct_SetGameObjectScale_Scale_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Rotacion_U.uscript at Set Scale.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:scaleUnits", scaleUnits);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3aca7033-447b-4d0d-98e8-87ca41a56d31", scaleUnits);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:16", local_16_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f986e568-8a6f-4a4f-a999-0d4f6ee0a96a", local_16_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:17", local_17_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "0dbc7521-72e3-4d4d-a1ab-644724e1d758", local_17_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:23", local_23_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5d1d0125-398e-4a9c-9ab4-f5bc7eb3fe5c", local_23_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:Axes", Axes);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b784cf37-6539-48ee-bc9b-f6f29c4c5394", Axes);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:25", local_25_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5340efab-59c7-4cda-b160-40d4b53590a9", local_25_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:26", local_26_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b06a2480-9477-4521-ac69-184479433dbd", local_26_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Rotacion_U.uscript:36", local_36_UnityEngine_Transform);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b7f42382-7e43-4572-82cc-1eb222575765", local_36_UnityEngine_Transform);
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
