using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AppMaster : MonoBehaviour {

	public string port_num ="127.0.0.1";
	
	public void Register(){
		
		InputField id = GameObject.Find("Canvas/IdField").GetComponent<InputField> ();
		InputField name = GameObject.Find("Canvas/NameField").GetComponent<InputField> ();
		DataBaseComunication DBC = GetComponent<DataBaseComunication> ();

		int id_num = int.Parse(id.text);
		
		DBC.RegisterPOST(port_num,id_num,name.text); 
		
	}

	public void Reder(){
		
		InputField id = GameObject.Find("Canvas/IdField").GetComponent<InputField> ();
		DataBaseComunication DBC = GetComponent<DataBaseComunication> ();
		
		int id_num = int.Parse(id.text);
		
		DBC.RederPOST(port_num,id_num); 
		
	}

	public void Message(string text){
		Text name = GameObject.Find("Canvas/Name").GetComponent<Text>();
		name.text = text;
	}
	
	
}
