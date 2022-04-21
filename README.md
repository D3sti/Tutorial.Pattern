# Builder Pattern
Shows the Builder Pattern in combination with vehicles. 

## Source of Knowledge
https://www.dofactory.com/net/builder-design-pattern


## UML
![BuilderPattern - UML](https://www.dofactory.com/img/diagrams/net/builder.png)


## When to use Builder Pattern

- Multiple constructor in your class and might expand
- Avoiding multiple constructor parameter
- Maintaining a given sequence when building an object

Source: https://www.youtube.com/watch?v=CDZniFqC4cI



## Side-Infos

Difference between **Factory** and **Builder** Pattern (Metapher)

### Factory:
Consider a restaurant. The creation of "today's meal" is a factory pattern, because you tell the kitchen "get me today's meal" 
and the kitchen (factory) decides what object to generate, based on hidden criteria.

### Builder: 
The builder appears if you order a custom pizza. 
In this case, the waiter tells the chef (builder) "I need a pizza; add cheese, onions and bacon to it!" 
Thus, the builder exposes the attributes the generated object should have, but hides how to set them.


Source: https://stackoverflow.com/questions/757743/what-is-the-difference-between-builder-design-pattern-and-factory-design-pattern
