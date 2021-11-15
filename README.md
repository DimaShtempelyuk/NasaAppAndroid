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
    - Taky tento program by mohl být určený sledování nebezpečí těles, které jsou blízko Země.
  - Uživatelské skupiny 
    - Studenti zajímající se o vesmír
  - Omezení návrhu a implementace
    - zádné znázornění těles
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
  - vstup: počet tělěs, které chceme zobrazit a časový interval ve kterém budeme tato tělesa hledat
- Nefunkční požadavky
  - Odezva
    - 1s, než se spustí zvukový signál
  - Spolehlivost
    - Jako švýcarské hodinky  	
  - Bezpečnost
    - Není nutné zadávat svoje osobní údaje
    - Všechno potřebné už budete mít v programu
  
