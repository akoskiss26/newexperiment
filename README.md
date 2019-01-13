# newexperiment
újabb kísérlet a szabadság nyilvántartó rep létrehozására
végre sikerült klónozni a gépemre a repository-t
# Első lépések
a github readme megismerése

## lista felállítása és kiírása
- generálunk egy új ActionControl fgv-t, benne a példányosított listával
- e lista tipusának megfelelő (a tipusnév azonos az osztálynévvel) osztályt generálunk a Models könyvtárban
- az osztályban meg kell csinálni a lista record adatainak a property-jeit (pl. a .add-al való feltöltésnél generáltathatjuk)
- az ActionResult fgv végén levő View() fgv-t megcsináljuk (jobbgomb-> add new view)
- view fgv-ben @model ......  sorba beírjuk a lista típusát, teljes elérési névvel
- foreach ciklussal kiolvassuk a lista elemeit

## saját controller készítése
- Controllers mappában új osztályt generálunk, neve xxxController (a név mindig Controllerrel végződjön)
- le kel származtatni a Controller osztályból (Controller névterét is be kell tölteni)
- a fent megcsinált osztályba tesszük az Action függvényt [ public ActionResult függvnév()  ]
- az ehhez tartozó View() fgv-t a Views/xxx mappában fogja keresni --> Views alatt kell csinálni egy xxx mappát, és oda kell tenni a View() fgv-t.


## CRUD alkalmazás készítése (Create, Read, Update, Delete)


## a feladat vázlata
+-----------------------------------------+
|                                         |
|   +-------------------------------+     |
|   | elem1          módosít  töröl |     |
|   |                               |     |
|   +-------------------------------+     |   műveletek kezdeményezésére
|   +-------------------------------+     |   szolgáló elemek
|   |                               |     |
|   | elem2         módosít  töröl  | <--------------+-----------+
|   +-------------------------------+     |          |
|   +-------------------------------+     |          |
|   | elem3         módosít  töröl  |     |          |
|   |                               |     |          |
|   +-------------------------------+     |          |
|                                         |          |
|                                         |          |
|                                         |          |
|                                         |          |
|                                         |          |
|                                         |          |
|  +----------------+  +--------------+   |          |
|  | beviteli mező  |  | rögzítés     | <------------+
|  +----------------+  +--------------+   |
|                                         |
+-----------------------------------------+

A Controller áttekintő nézetét szolgáltató kérés az index. Vagyis a mi kezdeti áttekintő nézetünk az Index action-ra kell hogy kerüljön. Ezért a jelenlegit átnevezzük Holiday-->Index

A routing alapbeállítások a Global.asax.cs könyvtár azonos nevű file-ban vannak


