
using System.Collections;
//Definición e inicioalización deln diccionario
Dictionary<string, int> dep = new Dictionary<string, int>()
{
    {"Boaco",185013},
    {"Carazo",197139},
    {"Chinandega",439906},
    {"Chontales",190863},
    {"Costa Caribe Norte",530586},
    {"Costa Caribe Sur",414543},
    {"Estelí",229866},
    {"Granada",214317},
    {"Jinotega",475630},
    {"León",421050},
    {"Madriz",174744},
    {"Managua",1575819},
    {"Masaya",391903},
    {"Matagalpa",593503},
    {"Nueva Segovia",271581},
    {"Río San Juan",135446},
    {"Rivas",182645}
};
//Ordenando de manera ascendente
var orderDepResult=dep.OrderBy(d=>d.Value);

//mostrar el diccionario
foreach (var item in dep)
    Console.WriteLine($"{item.Key,-20} ==> {item.Value,10:N0}");
//Suma de toda la población
Console.WriteLine($"Población General:{dep.Values.Sum():N0}");
//Mayor y menor población
Console.WriteLine($"Menor Población:{orderDepResult.First().key}");
Console.WriteLine($"Mayor Población:{orderDepResult.Last().key}");
