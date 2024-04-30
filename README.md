> [!CAUTION]
> **Važne stvari vezane za projekt**
>
> [GIT Cheatsheet](https://education.github.com/git-cheat-sheet-education.pdf)

# Requirements
### Generalno
- obavijest i prijenos materijala
> [!NOTE]
> Ja sam razumio da se ovo odnosi na to da app mora imati i obavijesti, a ne samo manipulaciju materijalima. However, nije velik problem to implementirat, treba nam samo forma i napravit dizajn za te obavijesti.
- login u sustav (student / nastavnik / admin)

### Student & Kolegij
- student moze biti upisan na vise kolegija
- kolegij mora biti definiran sljedecim varijablama: naziv, broj ECTS, smjer kolegija
- studenta definira: ime, prezime, jmbag, student moze biti samo na jednom smjeru
- student ima pristup kolegiju i materijalama (kategorije za materijale iste kao na nasoj IE)
- student mora imati mogucnost preuzimanja materijala (kao nasa IE)
- student i kolegij pripadaju smjeru

### Profesori
- profesor ima pristup materijalima za kolegije
- profesor moze materijale prenijet, izbrisat, izmijenit, itd.
- profesor unosi bodove i preko tablice unosi bodove (nema negativnih bodova) za svakog studenta

### Administracija
- administrator je treca osoba u sustavu - on moze vidjet smjerove, studente, nastavnike, predmete... On kaze da li taj student moze biti upisan na ponudjene kolegije.
> [!NOTE]
> uglavnom, CRUD operacije (on je specificno za admina govorio, mada svi entiteti imaju svoje CRUD operacije)

### Ostale funkcionalnosti
- potrebno omoguciti dodavanje jednog ili vise fajlova odjednom
- omoguciti odabir kategorija koje prof/admin moze dodat
- aplikacija bi trebala ispisati vrijeme kada je file uploadan i koji je prof. upload-ao to
- student i predmeti moraju pripadat smjeru, ne treba dodavat sve kolegije.

### Informacije o ocijenama
- ocjene su podijeljene u ishode (max 9)
- maksimalan broj bodova na svakom kolegiju je 100 (kriterije ocjenjivanja se moze uzet s nase IE)
- studentu se mora ispisati zakljucna ocjena ako ima dovoljno bodova za prolaz (ispisati i naziv ocjene uz to)

&nbsp;

> # Resources
> [C# General Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
>
> [ASP.NET Core & Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-8.0)
>
> [MongoDB API Documentation (C#)](https://www.mongodb.com/docs/drivers/csharp/current/)
