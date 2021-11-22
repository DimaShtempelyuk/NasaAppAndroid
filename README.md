# NasaAppAndroid
Mobile application for Android that will display information about celestial bodies near the Earth. An application is processing NASA data provided in the form of a JSON API.

Dmitro Romanovich Shtempelyuk

shtempelyuk.2018@skola.ssps.cz

15.11.2021
# Specifikace požadavků
- Úvod
  - Účel dokumentu
 	 - účelem tohoto sowftwaru je vytvořit mobilní aplikaci pro Android, která bude zobrazovat informace o tělesech v blízkosti Země.
  - Kontakty
    - Dmitro Romanovich Shtempelyuk e-mail: dimon.shtempelyuk@gmail.com soundcloud: nmbht44
  - Odkazy na ostatní dokumenty 
    - Odkaz na NASA API: https://api.nasa.gov/
 	  - Odkaz na Sink: http://ptsv2.com/t/cqzh9-1608204865

- Celkový popis
  - Funkce
    - Tento program má sloužit k sledování těles v blízkosti Země. 
    - Tento program by mohl být určený sledování nebezpečí těles, které jsou blízko Země.
  - Uživatelské skupiny 
    - Studenti zajímající se o vesmír
  - Omezení návrhu a implementace
    - žádné znázornění těles
- Požadavky na rozhraní
  - Uživatelská rozhraní
    - Android
  - Softwarová rozhraní
    - Xamarin
- Vlastnosti systému
  - i: funkce zadávání časového průseku, ve kterém nebeské těleso je blízko Země
  - i: funkce zadávání počtu nebeských těles
  - i: program využívá Nasa API k získání potřebných údajů
  - akce: program zjistí jaká nebeská tělesa se nacházeli v určitém časovém úseku blízko Země 
  - výstup: seznam s tělesy a jejich vzdáleností od Země
  - vstup: počet tělěs, které chceme zobrazit a čas ve kterém budeme tato tělesa hledat
- Nefunkční požadavky
  - Odezva
    - Pár sekund, než se zpracují data, zaleží taky na internetovým připojení
  - Spolehlivost
    - Jako švýcarské hodinky  	
  - Bezpečnost
    - Není nutné zadávat svoje osobní údaje
    - Všechno potřebné už budete mít v programu

 # Funkční specifikace
- Úvod
  - Účel dokumentu
 	 - účelem tohoto sowftwaru je vytvořit mobilní aplikaci pro Android, která bude zobrazovat informace o tělesech v blízkosti Země.
  - Kontakty
    - Dmitro Romanovich Shtempelyuk e-mail: dimon.shtempelyuk@gmail.com soundcloud: nmbht44
  - Odkazy na ostatní dokumenty 
    - Odkaz na NASA API: https://api.nasa.gov/   

-	Scénáře  
    -	Všechny reálné způsoby použití
        -	Použití pro lidi, které se chtěji dozvědět o nebekých tělesech v blízkostí Země
    -	Typy uživatelských rolí, „personas“
        -	Zájemce o vesmír - chce se dozvědět něco víc o vesmíru
    -	Detaily, motivace, „živé“ příklady
        - Na večerní procházce se určitá osobá zadívá na noční oblohu, a zamysli si nad vesmírem, vzhledem k aktuální situaci s covidem se zamysli, jestli se nechystá jeden z filmu o padu asteroidu na zem uskutečnít v blízké době, a tak se rozhodne najit na netu aplikaci, která mu poskytné jednoduché a snadno dohledatelné informamce o nebeských tělesách v okoli Země dneska, nebo i den kdy se chystá odjet na dovolenou, aby si mohl všechno naplánovat s ohledem na bližící se konec světa, právě pro tyto opatrné občany je tento program vytvořen
    -	Vymezení rozsahu – co v sw Nebude
        -	Sw bude určen jenom pro android, nebudou ani graficke prvky, které by znázorňobaly nebeská tělesa
    -	Na co se NEbude klást důraz (výkonnost)
        -	Bezpečnost se nebude brát v potaz, neplánuji klást důraz na designovou stránku aplikace, jednoduchost a funkčnost jsou našimi hlavními principy
-	Celková hrubá architektura
    -	Pracovní tok
        - Uživatel spustí aplikaci.
        - Dle defaultu bude mít nastavenou aplikaci na vypsání 5 nebeských těles v okolí Země na dnešek
        - Může si zvolit jiný datum pokud ho nezajímá aktuální situace nebeských těles v okolí Země
        - Uživatel si také může zvolit větší nebo menší počet nebeských těles, které se mu budou zobrazovat v aplikaci, v případe, že by měl více nebo méně času na analýzu vesmíru.
        - Zmačkně tlačítko "vyhledat"
        - Otevře se mu okno se seznamem nebeských těles v zadaném počtu a čase
    -	Hlavní moduly
        -	Modul "Asteroidy" 
    -	Všechny detaily: obrazovky, okna, tisky, chybové zprávy, logování
        -	 Aplikace bude ve fromě Hierarchical Navigation protože ostatní způsoby navigace by nevyhověly zadání
        -  Okno "Zadávání parametrů"
            - Vlevo nahoře nazev aplikace
            - Uprostřed zezhora updown určitý pro zadávaní počtu nebeských těles s popiskem zezhora
            - Uprotřed pole pro zadavání datu, pro který chceme vědět aktuální nebeská tělesa v okolí Země
        -  Okno "Výsledky hledání"
            - Vypíše se počet nebeských těles a datum ve kterém se hledaly uvedený v okně "Zadávání parametrů"
            - Vypíšou se s několika vlastnostmi a svým názvem
            - Stranku půjde opustit tlačítkem "zpátky" v levém horním rohu 
        -  Chybová hlášení
            - Pouze možnost "ok" pro odkliknití.
            - První chybové hlášení vyskočí při zadání 0 do "počtu". Druhé při zadání špatného formátu času do pole pro zadávání datu.
            - Chybová hlašení, poradí uživateli, jak má chybu spravit.
    -	Všechny dohodnuté principy
        -	Vyhledávání nebeských těles v okolí Země
    - Vzhled viz REPOSITORY
