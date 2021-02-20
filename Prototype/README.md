Prototype Pattern
=====

概念是使用**淺層複製**把需要消耗非常多資源或初始化需要很繁瑣的準備的物件用複製的方式製造

可省下一定程度的效能與時間

## 淺層複製 (Shallow Copy)

.NET裡面有內建一個MemberWiseClone()的方法

用它可以直接實作淺層複製

實際情況為

### value type : 完全複製的內容

### reference type : 複製的參考位置

所以修改複製品內的reference type物件時會把原始物件的reference type物件覆蓋掉 (範例在ConcretePrototypeTests.cs)

## 深層複製 (Deep Copy)

跟淺層複製不同

是另外抓出新的記憶體位置配給複製出來的物件

因此如果修改複製品也不會把原來的任何東西覆蓋掉 (範例在UtilityTests.cs)

## UML

Prototype Pattern的UML : 

![image](https://www.dofactory.com/img/diagrams/net/prototype.gif)

深淺複製參考資料 : https://dotblogs.com.tw/stanley14/2017/03/28/shallow_and_deep_copy
