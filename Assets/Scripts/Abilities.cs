using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    [Header("Ability 1")]
    public Image abilityImage1;
    public float cooldown1 = 5;
    public bool isCooldown = false;
    public KeyCode ability1;
    [SerializeField] GameObject prefabBall;

    [Header("Ability 2")]
    public Image abilityImage2;
    public float cooldown2 = 10;
    public bool isCooldown2 = false;
    public KeyCode ability2;
    [SerializeField] GameObject prefabBall2;

    [Header("Ability 3")]
    public Image abilityImage3;
    public float cooldown3 = 10;
    public bool isCooldown3 = false;
    public KeyCode ability3;
    [SerializeField] GameObject prefabBall3;

    GameObject castPrefabBall;
    // Start is called before the first frame update
    void Start()
    {
        abilityImage1.fillAmount = 0;
        abilityImage2.fillAmount = 0;
        abilityImage3.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
    }
    void Ability1()
    {
        if (Input.GetKey(ability1) && isCooldown == false)
        {
            isCooldown = true;
            abilityImage1.fillAmount = 1;
            castPrefabBall = prefabBall;
        }
        if (isCooldown)
        {
            abilityImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime;
            if (abilityImage1.fillAmount <= 0)
            {
                abilityImage1.fillAmount = 0;
                isCooldown = false;
            }
        }
    }
    void Ability2()
    {
        if (Input.GetKey(ability2) && isCooldown2 == false)
        {
            isCooldown2 = true;
            abilityImage2.fillAmount = 1;
            castPrefabBall = prefabBall2;

        }
        if (isCooldown2)
        {
            abilityImage2.fillAmount -= 1 / cooldown2 * Time.deltaTime;
            if (abilityImage2.fillAmount <= 0)
            {
                abilityImage2.fillAmount = 0;
                isCooldown2 = false;
            }
        }
    }

    void Ability3()
    {
        if (Input.GetKey(ability3) && isCooldown3 == false)
        {
            isCooldown3 = true;
            abilityImage3.fillAmount = 1;
            castPrefabBall = prefabBall3;

        }
        if (isCooldown3)
        {
            abilityImage3.fillAmount -= 1 / cooldown3 * Time.deltaTime;
            if (abilityImage3.fillAmount <= 0)
            {
                abilityImage3.fillAmount = 0;
                isCooldown3 = false;
            }
        }
    }
    public void Cast()
    {
        GameObject ball = Instantiate(castPrefabBall, new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z + 1), transform.rotation);
        Destroy(ball, 10f);
    }
}
