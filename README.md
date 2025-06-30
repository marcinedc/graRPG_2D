# RPG 2D - Królestwo Cieni

To jest gra RPG 2D, w której gracz wciela się w bohatera, który wyrusza na wyprawę, aby uratować swoje królestwo przed potworami. Gra zawiera eksplorację, walke oraz rozwój postaci.

### Funkcje:
- Eksploracja świata: Gracz przemierza różne lokacje, takie jak lasy, jaskinie i zamki.
![Świat Gry](Screenshots/ŚwiatGry.png)
- System walki z potworami.
  
![walka](Screenshots/Walka1.png)
![walka2](Screenshots/walka2.png)
- Historia: Interaktywna fabuła z dialogami.

## Technologie

### Silnik gry
- **Unity** - Silnik gier, który umożliwia tworzenie 2D i 3D gier. Używamy wersji Unity. Unity oferuje bogaty zestaw narzędzi, bibliotek i zasobów, umożliwiając szybkie prototypowanie oraz rozwój gier na wiele platform, takich jak PC, konsole, urządzenia mobilne czy przeglądarki internetowe. Dzięki intuicyjnemu edytorowi, obsłudze języka C#, wsparciu dla fizyki, animacji, systemów cząsteczkowych oraz integracji z popularnymi usługami (np. Ads, Analytics, multiplayer), Unity jest jedną z najczęściej wybieranych technologii do tworzenia zarówno gier niezależnych, jak i komercyjnych produkcji na dużą skalę. W naszym projekcie używamy aktualnej wersji Unity, aby zapewnić kompatybilność i wykorzystać najnowsze funkcje silnika.

### Język programowania
- **C#** - Język programowania używany do skryptów w grze. Unity używa C# do tworzenia logiki gry.

### Grafika
- **Adobe Photoshop / Aseprite** - Programy używane do tworzenia 2D sprite'ów, tekstur i tła w grze.

### Dźwięk
- **Audacity** - Program do edycji dźwięków.

### Zależności i narzędzia
- **Unity Asset Store** - Wykorzystane zasoby, takie jak pakiety dźwięków, grafik, czy animacji.
- **Cinemachine**  - Narzędzie Unity do tworzenia zaawansowanych kamer i śledzenia obiektów w grze.
- **TextMeshPro** - Narzędzie do wyświetlania zaawansowanego tekstu w Unity.
- **2D Sprite Renderer** - Używane do renderowania obrazów i animacji 2D w grze.
- **Box2D**  - Silnik fizyki 2D, który może być używany w grze do obsługi kolizji i fizyki obiektów.

### Inne technologie
- **GitHub** - Platforma do hostowania repozytorium i współpracy nad projektem.

### Platformy docelowe
- **Windows** - Gra stworzona z myślą o tej platformie.

## Paradygmat obiektowy

## Polimorfizm
```csharp
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int Health = 3;
    
    private int currentHealth;

    private void Start()
    {
        currentHealth = Health;
    }
```
## Hermetyzacja 
```csharp
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
```
#Dziedziczenie
```csharp
public class EnemyAi : MonoBehaviour
  {
      private enum State {
        Roaming
      }

      private State state;
      private EnemyFollowPath enemyPathfinding;

      private void Awake() {
          enemyPathfinding = GetComponent<EnemyFollowPath>();
          state = State.Roaming;
      }
```
## Instalacja

Aby zainstalować i uruchomić grę na swoim komputerze, wykonaj poniższe kroki:

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/twoje-repozytorium/rpg-2d.git
   cd rpg-2d

2. Pobierz i zainstaluj Unity Hub: https://unity.com/download.

3. W Unity Hub dodaj projekt klikając Add i wybierz folder, w którym pobrałeś projekt.

4. Jeśli projekt wymaga zainstalowania dodatkowych pakietów, Unity automatycznie poprosi Cię o ich pobranie.

5. Otwórz projekt w Unity i kliknij Play, aby uruchomić grę w edytorze.

6. Aby zbudować grę, wybierz File → Build Settings, wybierz platformę, kliknij Switch Platform, a następnie kliknij Build.

## License

[MIT](https://choosealicense.com/licenses/mit/)
