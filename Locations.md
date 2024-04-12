# Locations

## Bractalia Mercenary Camp:

Our very own base of operations, led by our fearless leader Ajax. It is here that we gather our forces, receive quests, and prepare for our perilous missions.

## Ye Olde Taverne:

A lively gathering place in Nexus where heroes and adventurers congregate. Here, we can meet potential allies, form parties, and gain new quests from Ralph.

## Underground Tunnels of Nexus:

A treacherous labyrinth where the Unholy Alliance resides. We have the opportunity to form an alliance with this dark power, but we must tread carefully.

## Bractus Royal Court:

The stronghold of the Unseen Hand, a faction immersed in political intrigue and intelligence gathering. Engaging with them may offer us quests and opportunities.

## Nexus Main Hall:

Located within Ye Olde Taverne, this bustling hall is teeming with adventurers, providing a colorful assortment of potential allies for our quests throughout Thear.

## Oracle Chamber:

A place of divination and knowledge, where we can seek guidance, access archives, and receive blessings to aid us on our journey.

## Armory:

Equip and upgrade armor.
Store or retrieve weapons.
Receive incoming deliveries.
Explore new armor options.

## Oracle Chamber:

Seek guidance or predictions.
Access knowledge archives.
Explore cosmic phenomena.
Receive divine protection or blessings.

## Inquiry Desk:

Gather information from local experts.
Consult on legal matters.
Receive protection from law enforcement.
Submit or review official documents.

## Marketplace:

Trade goods and services with other players or NPCs.

## Transportation Hub:

Access various transportation services.

## Library:

Research topics and learn new skills.

## Workshop:

Repair or upgrade equipment, and craft new items.

## Clinic:

Receive medical treatment and purchase medical supplies.

## Security Station:

Report crimes, seek protection, or access security services.

## Residential Quarters:

Rent or purchase a place to live, rest, and store items.

## Entertainment Center:

Enjoy recreational activities and socialize with others.

## Training Facility:

Develop combat skills and test new abilities.

## Communication Center:

Send and receive messages, or access news and information.

## Bank:

Store and manage in-game currency, and access investment services.

## Mutant Underground Network:

Provide sanctuary for mutants.
Organize resistance against persecution.
Recruit individuals with unique abilities.
Coordinate humanitarian aid efforts.

## University of Arcane Studies:

Delve into ancient texts and scrolls.
Attend lectures on magical theory.
Participate in experimental spellcasting.
Conduct research on mystical artifacts.

## Underground Resistance Hideout:

Join the fight against oppressive regimes.
Plan and execute covert operations.
Recruit allies for the resistance movement.
Obtain intelligence on enemy movements.

$Location.js=>

```
class Structure {
    constructor(name, quantity, size) {
        this.name = name;
        this.quantity = quantity;
        this.size = size;
    }
}

class Room {
    constructor(name, accessibility, size) {
        this.name = name;
        this.accessibility = accessibility;
        this.size = size;
    }
}

class Area {
    constructor(name) {
        this.name = name;
        this.structures = [];
        this.rooms = [];
        this.resources = {};
    }
}

class Village {
    constructor(name) {
        this.name = name;
        this.areas = [];
        this.resources = {};
        this.armies = [];
    }
}

class Town {
    constructor(name) {
        this.name = name;
        this.areas = [];
        this.resources = {};
        this.armies = [];
    }
}

class Country {
    constructor(name) {
        this.name = name;
        this.towns = [];
        this.resources = {};
    }
}

class Continent {
    constructor() {
        this.countries = [];
        this.resources = {};
    }
}

class Planet {
    constructor(name) {
        this.name = name;
        this.continent = new Continent();
        this.islands = [];
        this.otherside = [];
        this.resources = {};
    }
}

class Army {
    constructor(name) {
        this.name = name;
        this.size = 0;
        this.formations = [];
    }
}

class Formation {
    constructor(name) {
        this.name = name;
        this.units = [];
    }
}

class Unit {
    constructor(name, type) {
        this.name = name;
        this.type = type;
    }
}

// Instantiating objects
let thear = new Planet("Thear");
let bractalia = new Country("Bractalia");
let wolk = new Country("Wolk");
let kinderyarn = new Country("Kinderyarn");
let thipse = new Country("Thipse");
let nymenada = new Country("Nymenada");
let lochtou = new Country("Lochtou");
let varthek = new Country("Varthek");
let jight = new Country("Jight");
let slake = new Country("Slake");
let bractal = new Town("Bractal");
let bractus = new Castle("Bractus")
let nexus = new Village("Nexus");
let newtopia = new Village("Newtopia");
let flaxchop = new Town("Flaxchop");
let peachstraw = new Village("Peachstraw");
let cedalion = new Town("Cedalion");
let illgrada = new Town("Illgrada");
let leprhesion = new Town("Leprhesion");
let yeOldeTaverne = new Area("Ye Olde Taverne");
let yeOldeTaverne = new Structure("Ye Olde Taverne", 6, "Large");
let yeOldeTaverne0 = new Room("Main Hall", "Public", "Large");
let yeOldeTaverne1 = new Room("Back Room", "Private", "Medium");
let yeOldeTaverne2 = new Room("Training Room", "Restricted", "Medium");
let yeOldeTaverne3 = new Room("Storage", "Restricted", "Medium");
let yeOldeTaverne4 = new Room("Bedroom", "Private", "Medium");
let yeOldeTaverne5 = new Room("Office", "Restricted", "Large");

// Adding objects to each other
mainHall.structures.push(yeOldeTaverne);
mainHall.rooms.push(mainHallRoom1, mainHallRoom2, mainHallRoom3, mainHallRoom4, mainHallRoom5, mainHallRoom6);
mainHall.resources = { "Wood": 100, "Stone": 50 };
bractal.areas.push(mainHall);
bractal.resources = { "Gold": 500, "Food": 200 };
bractalia.towns.push(bractal);
bractalia.resources = { "Population": 52 }
thear.continent.countries.push(bractalia);
```
