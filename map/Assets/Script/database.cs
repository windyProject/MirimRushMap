using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;


public class database : MonoBehaviour { 

    private static database Instance;
    public DatabaseReference reference;


    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mirimrush.firebaseio.com/");

        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
