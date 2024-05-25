#include <iostream>
int f() {
    std::cout << "In f\n";
    return 3;
}

int g() {
    std::cout << "In g\n";
    return 4;
}

int sum(int i, int j) {
    return i + j;
}

int main() {
    return sum(f(), g());
}

@interface Pen : NSObject
@property(copy) NSColor* colour;	// The "copy" attribute causes the object's copy to be
// retained, instead of the original.
@end

@implementation Pen
@synthesize colour;			// Compiler directive to synthesise accessor methods.
// It can be left behind in Xcode 4.5 and later.
@end

function Pen() {
    this._color = 0;
}
// Add the property to the Pen type itself, can also
// be set on the instance individually
Object.defineProperties(Pen.prototype, {
    color: {
        get: function() {
            return this._color;
        },
        set : function(value) {
            this._color = value;
        }
    }
    });
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
mainHall.resources = { "Wood": 100, "Stone" : 50 };
bractal.areas.push(mainHall);
bractal.resources = { "Gold": 500, "Food" : 200 };
bractalia.towns.push(bractal);
bractalia.resources = { "Population": 52 }
thear.continent.countries.push(bractalia);