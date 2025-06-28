using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private Transform weaponColider;
    private PlayerMovement playerMovement;
    private ActiveWeapon activeWeapon;
    private PlayerMove playerMove; 
    private Animator animator;

    private void Awake()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();
        activeWeapon = GetComponentInParent<ActiveWeapon>();
        animator = GetComponent<Animator>();
        playerMove = new PlayerMove();
    }

    void OnEnable()
    {
        playerMove.Enable();
    }

    void Start()
    {
        playerMove.Combat.Smash.started += _ => Smash();
    }

    private void Update()
    {
        MouseFollow();
    }

    private void Smash()
    {
        animator.SetTrigger("Attack");
        weaponColider.gameObject.SetActive(true);
    }

    public void DoneSmash()
    {
        weaponColider.gameObject.SetActive(false);
    }

    private void MouseFollow()
    {
        Vector3 Pos= Input.mousePosition;
        Vector3 playerScreen = Camera.main.WorldToScreenPoint(playerMovement.transform.position);

        float angle = Mathf.Atan2(Pos.y, Pos.x) * Mathf.Rad2Deg;

        if(Pos.x < playerScreen.x)
        {
            activeWeapon.transform.rotation = Quaternion.Euler(0, -180, angle);
            weaponColider.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else
        {
            activeWeapon.transform.rotation = Quaternion.Euler(0, 0, angle);
            weaponColider.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
