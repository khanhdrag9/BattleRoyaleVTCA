using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    [Tooltip("CanvasGroup to fade the ammo UI")]
    public CanvasGroup canvasGroup;
    [Tooltip("Image for the weapon icon")]
    public Image weaponImage;
    [Tooltip("Text for image index")]
    public TMPro.TextMeshProUGUI weaponIndexText;
    public TMPro.TextMeshProUGUI countAmmoText;

    public int weaponCounterIndex { get; set; }

    PlayerWeaponsManager m_PlayerWeaponsManager;
    WeaponController m_Weapon;

    public void Initialize(WeaponController weapon, int weaponIndex)
    {
        m_Weapon = weapon;
        weaponCounterIndex = weaponIndex;
        weaponImage.sprite = weapon.weaponIcon;

        m_PlayerWeaponsManager = FindObjectOfType<PlayerWeaponsManager>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerWeaponsManager, AmmoCounter>(m_PlayerWeaponsManager, this);

        weaponIndexText.text = (weaponCounterIndex + 1).ToString();
        countAmmoText.text = m_Weapon.AmmoDisplay;
    }

    void Update()
    {
        bool isActiveWeapon = m_Weapon == m_PlayerWeaponsManager.GetActiveWeapon();
        if(isActiveWeapon)
            countAmmoText.text = m_Weapon.AmmoDisplay;
    }
}
