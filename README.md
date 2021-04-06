- Terence Au
- Professor Williams
- IS 421
- April 3rd, 2021

# Features:
1. Calculations are stored in objects/models
2. Addition, Subtraction, Division, Multiplication, Square root, Square
3. History records previous calculations that are stored as objects in a list
4. History allows for selecting the first and last objects put into the list, and the next and previous objects in the list.
5. Calculations are handled by events that raise calculations with user input
![image](https://user-images.githubusercontent.com/60273779/113777196-bfde3a00-96f8-11eb-9d5f-616cdc26e850.png)

# Object Oriented Design
- The calculator uses a Calculator object that takes 3 doubles and a string. After that, each instance of the object is stored in a List of calculation objects that can be viewed in History. Within the history, each calculator object can be retrieved, scrolled through the list, and modified to be recalculated. 

# SOLID
- The calculator follows most of SOLID design principles by separating classes into their respective functions or responsibilities. In that sense, the calculator's operations only calculate what they are given and the Calculations were used twice, not only in the initial calculation, but also when the calculation is modified. 

# References and external articles:
- https://refactoring.guru/design-patterns/singleton/csharp/example
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
- https://www.tutorialsteacher.com/csharp/csharp-list
