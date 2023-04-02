using aula06;
using aula06.Character;
/* Animal section */

var cat = new Cat();
cat.Name = "Siames";
cat.Meow();

System.Console.WriteLine(cat.Name + '\n');

var dog = new Dog();
dog.Name = "Bidu";
dog.Bark();

System.Console.WriteLine(dog.Name + '\n');

/* var animal = new Animal; */

/* Vehicle section */

var car = new Car();
car.Model = "celta";
car.Accelerate();

System.Console.WriteLine(car.Model + '\n');

var moto = new Moto();
moto.Model = "yamaha";
moto.Accelerate();

System.Console.WriteLine(moto.Model + '\n');

/* Character's section */

/* var hero = new Character(); */

var hero = new Hero();
hero.Name = "Homem de ferro";
hero.Strength = "Força: média";
hero.Intelligence = "Inteligência: alta";
hero.Powers = "Poderes: voar, disparos de luz";
System.Console.WriteLine($"\n{hero.Name}, {hero.Strength}, {hero.Intelligence}, {hero.Powers}, Estilo de luta: {hero.FightStyle("calculada")}");

var villain = new Villain();
villain.Name = "Loki";
villain.Strength = "Força: baixa";
villain.Intelligence = "Inteligência: alta";
villain.Powers = "Poderes: Feitiços, magia";
System.Console.WriteLine($"\n{villain.Name}, {villain.Strength}, {villain.Intelligence}, {villain.Powers}, Estilo de luta: {villain.FightStyle("astuta")}");

var superhero = new SuperHero();
superhero.Name = "Thor";
superhero.Strength = "Força: alta";
superhero.Intelligence = "Inteligência: baixa";
superhero.Powers = "Poderes: controle de raios";
System.Console.WriteLine($"\n{superhero.Name}, {superhero.Strength}, {superhero.Intelligence}, {superhero.Powers}, Superpoder: {superhero.SuperPower("Descarga de raio")}");

var supervillain = new SuperVillain();
supervillain.Name = "Thanos";
supervillain.Strength = "Força: Alta";
supervillain.Intelligence = "Inteligência: média";
supervillain.Powers = "Poderes: Superforça, jóias do infinito";
System.Console.WriteLine($"\n{supervillain.Name}, {supervillain.Strength}, {supervillain.Intelligence}, {supervillain.Powers}, Superpoder: {supervillain.SuperPower("Desfoque de realidade com a joia da realidade")}");

