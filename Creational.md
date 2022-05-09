# 创建型模式

### 总结
* Singleton解决的是实体对象个数的问题. 除了Singleton之外, 其他创建型模式都是解决new带来的耦合关系.
* Factory Method, Abstract Factory, Builder都需要一个额外的工厂类来负责实例化易变对象, 而Prototype则是通过原型(一个特殊的工厂类)来克隆易变对象.
* 如果遇到易变对象, 通常从Factory Method开始, 当遇到更多复杂的变化时, 再考虑重构为其他三种工厂模式. 