Singleton Pattern
=====

放了5種Singleton, 最後一種則是Unity的ThreadSafe寫法

### NonThreadSafe

最基本的Singleton概念, 就是用static和封裝把Class設定成最多只能有一個個體存在

### ThreadSafe DoubleCheck

用lock的語法來鎖定單一Thread, 確保一次只能有一條Thread去new出instance

### Eager Singleton

在Eager Singleton這個Class初始化時即new出instance, 所以不需要lock, 是非常簡潔的Singleton寫法

### Lazy Singleton

裡面包含了一個InnerClass, 在需要用到的時候InnerClass才會被呼叫, instance來會被new出來

### Singleton Use Gerneric

用Unity的寫法寫的, 概念跟ThreadSafe DoubleCheck差不多, 但是適從Hireachy抓帶有Singleton的類別物件
