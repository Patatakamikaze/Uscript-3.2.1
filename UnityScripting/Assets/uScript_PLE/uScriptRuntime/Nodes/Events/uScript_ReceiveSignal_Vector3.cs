//Created with Detox Studios uScript, contains code copyright by Detox Studios.
using UnityEngine;

[NodePath("Events/Signals")]

[FriendlyName("Receive Signal (Vector3)", "Receives a signal from a Send Signal node  with a Vector3 variable and continues execution.")]
public class uScript_ReceiveSignal_Vector3 : uScriptEvent
{
	public delegate void uScriptEventHandler(object Sender, ReceiveCustomSignalEventArgs args);
	
	public class ReceiveCustomSignalEventArgs : System.EventArgs
	{
		private GameObject m_Sender;
		private Vector3 m_SignalData;
		private string m_Signal;
		
		[FriendlyName("Sender", "The GameObject that sent this signal (if available).")]
		public GameObject Sender { get { return m_Sender; } }
		
		[FriendlyName("Signal Data", "The Vector3 variable that was sent with this signal.")]
		public Vector3 SignalData { get { return m_SignalData; } }
		
		[FriendlyName("Signal", "The name of the signal.")]
		[SocketState(true, false)]
		public string signalName{ get { return m_Signal; } }
		
		public ReceiveCustomSignalEventArgs(GameObject Sender, Vector3 SignalData, string signalName)
		{
			m_Signal = signalName;
			m_SignalData = SignalData;
			m_Sender = Sender;
		}
	}
	
	[FriendlyName("Receive Signal")]
	public event uScriptEventHandler OnReceiveCustomSignal;
	
	public void OnIncomingSignal(GameObject objectToSignal, GameObject Sender, Vector3 SignalData, string signalName )
	{
		if (objectToSignal.gameObject == gameObject)
			OnReceiveCustomSignal(this, new ReceiveCustomSignalEventArgs(Sender, SignalData, signalName) );
	}
}