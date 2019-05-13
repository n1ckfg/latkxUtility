using UnityEngine;
using System.Collections;
using UnityEditor;

public class DebugProperties : MonoBehaviour {

	public enum ObjectType { PARTICLE_SYSTEM };
	public ObjectType objectType = ObjectType.PARTICLE_SYSTEM;

	void Start() {
		debugProperties(gameObject, objectType);
	}
	
	public void debugProperties(GameObject _g, ObjectType _ot) {
		if (_ot == ObjectType.PARTICLE_SYSTEM) {
			SerializedObject so = new SerializedObject(_g.GetComponent<ParticleSystem>());
			SerializedProperty it = so.GetIterator();
			while (it.Next(true)) Debug.Log (it.propertyPath);
		}
	}

}
