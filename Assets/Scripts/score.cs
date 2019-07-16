
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        float x = 4962 + player.position.z;
        scoreText.text ="Score: "+x.ToString("0");
    }
}
