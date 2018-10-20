using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform Player;
    public Text scoretext;
	// Update is called once per frame
	void Update () {
        scoretext.text = Player.position.z.ToString("0");
	}
}
