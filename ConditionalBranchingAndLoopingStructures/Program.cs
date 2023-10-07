string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

/*
    The total number of elements in this array can be calculated by multiplying the number of rows by the number of columns, which is 8 * 6 = 48.
    Therefore, there will be a total of 48 elements in the ourAnimals array. Each element can hold a string value.
*/
Console.WriteLine(ourAnimals.Length); // 48
Console.WriteLine(ourAnimals);