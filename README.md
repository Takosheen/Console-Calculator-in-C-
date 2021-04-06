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

# Other Design Patterns
1. Singleton
- As demonstrated below, a single instance of input history is created to preserve continuity of the history to keep adding to it.
- ![image](https://user-images.githubusercontent.com/60273779/113779841-4ea08600-96fc-11eb-9f28-135718237ebe.png)
2. Decorators 
- When a user inputs a number or operation, the event is raised through decorators to start calculating.
- ![image](https://user-images.githubusercontent.com/60273779/113780131-c2db2980-96fc-11eb-8adf-ed45c7554701.png)
3. Events
-  The publisher has a subscriber that is raised whenever there is an input. Each event determines what operation is going on and prompts a calculation object to be created.
- ![image](https://user-images.githubusercontent.com/60273779/113780588-6a585c00-96fd-11eb-9e94-950767c42f8b.png)
4. Facade
- Most of the code is separated and hidden behind method calls and object calls.
![image](https://user-images.githubusercontent.com/60273779/113783378-a8f01580-9701-11eb-91e6-2824f6240b4e.png)
5. Proxy
-  A separate calculation object is made to be modified with user input and modifications to history.
![image](https://user-images.githubusercontent.com/60273779/113783337-97a70900-9701-11eb-8127-1d859f3af0a2.png)



# References and external articles:
- https://refactoring.guru/design-patterns/singleton/csharp/example
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
- https://www.tutorialsteacher.com/csharp/csharp-list
- https://refactoring.guru/design-patterns/facade
- https://refactoring.guru/design-patterns/proxy
- https://refactoring.guru/design-patterns/decorator
- 
