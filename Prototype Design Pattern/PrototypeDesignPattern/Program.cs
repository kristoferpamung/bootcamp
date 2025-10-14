
using PrototypeDesignPattern.Models;
using PrototypeDesignPattern.PrototypeRegistry;

PrototypeRegistry prototypeRegistry = new PrototypeRegistry();

var toyota = new Car("Toyota", "Avanza", "White", "1.3L", new List<string> { "AC", "Radio", "Airbag" });
var honda = new Car("Honda", "Brio", "Red", "1.2L", new List<string> { "AC", "Bluetooth", "Airbag" });

prototypeRegistry.Add("toyota", toyota);
prototypeRegistry.Add("honda", honda);

var avanza = prototypeRegistry.Create("toyota");
avanza.Color = "Black";
avanza.Features.Add("Spoiler");

var jazz = prototypeRegistry.Create("honda");
jazz.Model = "Jazz";

toyota.ShowInfo();
avanza.ShowInfo();
jazz.ShowInfo();