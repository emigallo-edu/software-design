// See https://aka.ms/new-console-template for more information
using ZooPoo.Entidades;


List<Animal> animales = new List<Animal>();
Perro perr1 = new Perro("Lola", new DateTime(2020, 4, 2), "Mestiza");
perr1.SetearJugueteFavorito(new Juguete());
animales.Add(perr1);
animales.Add(new Perro("Coco", new DateTime(2010, 4, 2), "Callejero"));
animales.Add(new Perro("Cheddar", new DateTime(2010, 4, 2), "Caniche"));

animales.Add(new Gato("Pita", new DateTime(2018, 3, 9), "Mestiza", "Ratoncito"));

animales.Add(new Cotorra(new DateTime(2018, 3, 9), "Verde"));

foreach (Animal animal in animales)
{
    animal.Comunicarse();
}