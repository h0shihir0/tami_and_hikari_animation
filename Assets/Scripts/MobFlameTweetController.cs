using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MobFlameTweetController : MonoBehaviour
{
    public Text replyTweet;
    public Text name_obj;
    public Text username;

    // Start is called before the first frame update
    void Start()
    {
        string name = System.Guid.NewGuid().ToString("N").Substring(0, 5).ToUpper().ToString();
        string uname = System.Guid.NewGuid().ToString("N").Substring(0, 7);
      //  string rep = System.Guid.NewGuid().ToString("N").Substring(0, 15).ToUpper().ToString();

      //  replyTweet.text = rep;
        name_obj.text = name;
        username.text = "@" + uname;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
