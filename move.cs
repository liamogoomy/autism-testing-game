using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    bool canmove = true;
    bool canmovey = false;
    public float speed = 0.04f;
    float directionx = 1.0f;
    float directiony = 1.0f;
    public int step;
    public int stepy;
    int nextoptionset = 0;
    int optionchosen;
    int count;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject option5;
    public GameObject option6;
    public GameObject option7;
    public GameObject option8;
    public GameObject option9;
    public GameObject option10;
    public GameObject option11;
    public GameObject option12;
    public GameObject option13;
    public GameObject option14;
    public GameObject option15;
    public GameObject option16;
    public GameObject mcamera;
    public GameObject scenariotext1;
    public GameObject scenariotext2;
    public GameObject scenariotext3;
    public GameObject scenariotext4;
    public GameObject pointsword;
    public GameObject pointsdisplay;
    public GameObject textbackground;
    public GameObject cars;
    public GameObject teacher;
    public GameObject teachertextbox; 
    public Text pointcount;
    public int points;
    bool option1choosen;
    bool option2choosen;
    bool option3choosen;
    bool option4choosen;
    bool option5choosen;
    bool option6choosen;
    bool option7choosen;
    bool option8choosen;
    bool option9choosen;
    bool option10choosen;
    bool option11choosen;
    bool option12choosen;
    bool option13choosen;
    bool option14choosen;
    bool option15choosen;
    bool option16choosen;
    bool wrongpick1;
    bool wrongpick2;
    bool wrongpick4;
    bool wrongpick6;
    bool wrongpick7;
    bool wrongpick8;
    bool wrongpick9;
    bool wrongpick10;
    bool wrongpick11;
    bool wrongpick13;
    bool wrongpick15;
    bool wrongpick16;
    bool teachertalk;
    bool startcount;
    bool talk;
    bool moveback;
    public int scenario = 1;
    public bool carstop = false;
    // Start is called before the first frame update
    void Start()
    {
        canmove = true;
    }

    // Update is called once per frame
    void Update()
    {
        option1choosen = mcamera.gameObject.GetComponent<option1click>().clickedon;
        option2choosen = mcamera.gameObject.GetComponent<option2click>().clickedon;
        option3choosen = mcamera.gameObject.GetComponent<option3click>().clickedon;
        option4choosen = mcamera.gameObject.GetComponent<option4click>().clickedon;
        option5choosen = mcamera.gameObject.GetComponent<option5click>().clickedon;
        option6choosen = mcamera.gameObject.GetComponent<option6click>().clickedon;
        option7choosen = mcamera.gameObject.GetComponent<option7click>().clickedon;
        option8choosen = mcamera.gameObject.GetComponent<option8click>().clickedon;
        option9choosen = mcamera.gameObject.GetComponent<option9click>().clickedon;
        option10choosen = mcamera.gameObject.GetComponent<option10click>().clickedon;
        option11choosen = mcamera.gameObject.GetComponent<option11click>().clickedon;
        option12choosen = mcamera.gameObject.GetComponent<option12click>().clickedon;
        option13choosen = mcamera.gameObject.GetComponent<option13click>().clickedon;
        option14choosen = mcamera.gameObject.GetComponent<option14click>().clickedon;
        option15choosen = mcamera.gameObject.GetComponent<option15click>().clickedon;
        option16choosen = mcamera.gameObject.GetComponent<option16click>().clickedon;
        teachertalk = teacher.gameObject.GetComponent<teachermove>().inplace;
        if (canmove)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.x += speed * directionx; // sets position.x to position.x + speed * direction
            transform.localPosition = position;
            step += 1;
        }
        else if (canmovey)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.y += speed * directiony; // sets position.x to position.x + speed * direction
            transform.localPosition = position;
            stepy += 1;
        }
        if (step == 500)
        {
            if (scenario == 1)
            {
                canmove = false;
                scenariotext1.gameObject.SetActive(true);
                textbackground.gameObject.SetActive(true);
                option1.gameObject.SetActive(true);
                option2.gameObject.SetActive(true);
                option3.gameObject.SetActive(true);
                option4.gameObject.SetActive(true);
            }
            else if (scenario == 2)
            {
                canmove = false;
                scenariotext2.gameObject.SetActive(true);
                textbackground.gameObject.SetActive(true);
                option5.gameObject.SetActive(true);
                option6.gameObject.SetActive(true);
                option7.gameObject.SetActive(true);
                option8.gameObject.SetActive(true);
            }
            else if (scenario == 5)
            {
                canmove = false;
                scenariotext3.gameObject.SetActive(true);
                textbackground.gameObject.SetActive(true);
                option9.gameObject.SetActive(true);
                option10.gameObject.SetActive(true);
                option11.gameObject.SetActive(true);
                option12.gameObject.SetActive(true);
            }
            else if (scenario == 6)
            {
                canmove = false;
                canmovey = true;
                scenario = 7;
                cars.gameObject.SetActive(false);
                directiony = -1.0f;
            }
            if (scenario == 8)
            {
                canmove = false;
                scenariotext4.gameObject.SetActive(true);
                textbackground.gameObject.SetActive(true);
                option13.gameObject.SetActive(true);
                option14.gameObject.SetActive(true);
                option15.gameObject.SetActive(true);
                option16.gameObject.SetActive(true);
            }
        }
        else if (step == 450 && scenario == 3)
        {
            canmove = false;
            cars.gameObject.SetActive(false);
            canmovey = true;
            scenario = 4;
            step = 0;
        }
        if (teachertalk && !talk)
        {
            teachertextbox.gameObject.SetActive(true);
            startcount = true;
            talk = true;
        }
        if (startcount)
        {
            count = count + 1;
        }
        if (count == 100 && !moveback)
        {
            canmove = true;
            directionx = -1.0f;
            step = 0;
            startcount = false;
            teachertextbox.gameObject.SetActive(false);
            count = 0;
            moveback = true;
        }
        if (stepy == 1000)
        {
            canmovey = false;
            canmove = true;
            if (scenario == 4)
            {
                scenario = 5;
            }
            if (scenario == 7)
            {
                scenario = 8;
                directionx = 1.0f;
                cars.gameObject.SetActive(true);
                canmove = true;
            }
            step = 0;
            stepy = 0;
            cars.gameObject.SetActive(true);
        }
        if (option1choosen && scenario == 1 && !wrongpick1)
        {
            points += 10;
            option1.gameObject.SetActive(false);
            wrongpick1 = true;
        }
        if (option2choosen && scenario == 1 && !wrongpick2)
        {
            points += 10;
            option2.gameObject.SetActive(false);
            wrongpick2 = true;
        }
        if (option3choosen && scenario == 1 )
        {
            canmove = true;
            scenariotext1.gameObject.SetActive(false);
            textbackground.gameObject.SetActive(false);
            option1.gameObject.SetActive(false);
            option2.gameObject.SetActive(false);
            option3.gameObject.SetActive(false);
            option4.gameObject.SetActive(false);
            step = 0;
            scenario = 2;
        }
        if (option4choosen && scenario == 1 && !wrongpick4)
        {
            points += 10;
            option4.gameObject.SetActive(false);
            wrongpick4 = true;
        }
        if (option5choosen && scenario == 2 )
        {
            scenariotext2.gameObject.SetActive(false);
            textbackground.gameObject.SetActive(false);
            option5.gameObject.SetActive(false);
            option6.gameObject.SetActive(false);
            option7.gameObject.SetActive(false);
            option8.gameObject.SetActive(false);
            step = 0;
            canmove = true;
            scenario = 3;
        }
        if (option6choosen && scenario == 2 && !wrongpick6)
        {
            points += 10;
            option6.gameObject.SetActive(false);
            wrongpick6 = true;
        }
        if (option7choosen && scenario == 2 && !wrongpick7)
        {
            points += 10;
            option7.gameObject.SetActive(false);
            wrongpick7 = true;
        }
        if (option8choosen && scenario == 2 && !wrongpick8)
        {
            points += 10;
            option8.gameObject.SetActive(false);
            wrongpick8 = true;
        }
        if (option9choosen && scenario == 5 && !wrongpick9)
        {
            points += 10;
            option9.gameObject.SetActive(false);
            wrongpick9 = true;
        }
        if (option10choosen && scenario == 5 && !wrongpick10)
        {
            points += 10;
            option10.gameObject.SetActive(false);
            wrongpick10 = true;
        }
        if (option11choosen && scenario == 5 && !wrongpick11)
        {
            points += 10;
            option11.gameObject.SetActive(false);
            wrongpick11 = true;
        }
        if (option12choosen && scenario == 5)
        {
            scenariotext3.gameObject.SetActive(false);
            textbackground.gameObject.SetActive(false);
            option9.gameObject.SetActive(false);
            option10.gameObject.SetActive(false);
            option11.gameObject.SetActive(false);
            option12.gameObject.SetActive(false);
            pointcount.text = points.ToString();
            teacher.gameObject.SetActive(true);
            step = 0;
            scenario = 6;
        }
        if (option13choosen && scenario == 8 && !wrongpick13)
        {
            points += 10;
            option13.gameObject.SetActive(false);
            wrongpick13 = true;
        }
        if (option14choosen && scenario == 8)
        {
            scenariotext4.gameObject.SetActive(false);
            textbackground.gameObject.SetActive(false);
            option13.gameObject.SetActive(false);
            option14.gameObject.SetActive(false);
            option15.gameObject.SetActive(false);
            option16.gameObject.SetActive(false);
            pointsdisplay.gameObject.SetActive(true);
            pointsword.gameObject.SetActive(true);
            pointcount.text = points.ToString();
            step = 0;
            scenario = 0;
        }
        if (option15choosen && scenario == 8 && !wrongpick15)
        {
            points += 10;
            option15.gameObject.SetActive(false);
            wrongpick15 = true;
        }
        if (option16choosen && scenario == 8 && !wrongpick16)
        {
            points += 10;
            option16.gameObject.SetActive(false);
            wrongpick16 = true;
        }
    }
}