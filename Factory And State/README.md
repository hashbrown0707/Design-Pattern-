Factory Pattern and State Pattern
=====

這次直接把這2個模式寫在一起當成一個小練習

也順便學啥是Unit Test (其實寫的模式好像都是變體

主要是用工廠模式製造出了各種Product的State

然後再創造Product Model

再把Product的State套到Model裡

可以想成把狀態的邏輯實作丟到空的模型裡, 可是這跟Strategy Pattern很像, 所以放一篇比較文在最下面

## State

將行為用一個介面封裝起來，針對不同的狀態去改變其行為

重點偏向狀態會一直改變, 不同狀態也會有不同行為

State Pattern的UML : 

![image](https://www.dofactory.com/img/diagrams/net/state.gif)

## Factory

簡單說就是把生產的工作丟到一個Class啦

這樣就不會讓Client端一直需要生新物件

增加了可讀和可維護姓

並且用static可以讓它變成一個Utility

Factory Pattern的UML : 

![image](https://www.dofactory.com/img/diagrams/net/factory.gif)

關於State和Strategy的差異 : https://ccas.pixnet.net/blog/post/35771687
