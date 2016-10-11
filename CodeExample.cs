using UnityEngine;
using System;

public class CodeExample : MonoBehaviour {

    #region FIELDS
    //Exsposing private field to the Unity editor
    [SerializeField]
    private GameObject canvas;
    //Used for the lazy instantiations
    private string password;
    
    #endregion

    #region PROPERTIES
    //Simple Properties creation
    public int Foo { get; set; }
    //Exsposing private field used by the editor example
    public GameObject Canvas { get {return this.canvas;} }
    //Lazy instantiation example
    private string Password
    {
        get
        {
            if (this.password == null)
            { this.password = this.GeneratePassword(); }
            return this.password;
        }
    }
    #endregion

    #region MONOBHEAVIOR
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    #endregion

    #region PUBLIC METHODS
    //Insert here your pubblic methods
    #endregion

    #region PRIVATE METHODS
    private string GeneratePassword()
    {
        return Constants.Secrets.password;
    }
    #endregion
}
