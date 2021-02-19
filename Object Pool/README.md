Object Pool
=====

這次寫了遊戲很常用的Object Pool, 原理是用Dictionary把Pool存起來, 然後需要的時候再從pool.queue裡面抓出物件出來使用

## Flyweight Pattern 與 Object Pool

這2個東西其實概念上鰻相近的, 只是Flyweight的物件只有一個, 取用時是取用他的reference

而Object Pool則是存很多的物件在池子裡, 需要的時候直接取出來用, 最後放回去池子裡

Object Pool的UML : 

![image](https://media.geeksforgeeks.org/wp-content/uploads/uml-pool-design.jpg)

Flyweight Pattern的UML : 

![image](https://www.dofactory.com/img/diagrams/net/flyweight.gif)
